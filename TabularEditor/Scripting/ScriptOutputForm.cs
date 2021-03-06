﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabularEditor.TOMWrapper;

namespace TabularEditor.Scripting
{
    public partial class ScriptOutputForm : Form
    {
        public static void Reset(bool canShowOutputForm = true)
        {
            DontShow = !canShowOutputForm;
        }
        private static ScriptOutputForm DormantForm = new ScriptOutputForm();
        public static bool DontShow { get; set; }

        public ScriptOutputForm()
        {
            InitializeComponent();
        }

        public static void ShowObject(object value, string caption)
        {
            DormantForm.Text = caption;

            var testTabularObject = value as TabularObject;
            var testTabularCollection = value as IEnumerable<ITabularNamedObject>;
            var testDictionary = value as IDictionary;
            var testList = value as IEnumerable<object>;

            if (value == null) ShowString("(Null)");
            else if (testTabularObject != null) ShowTabularObject(testTabularObject);
            else if (testTabularCollection != null) ShowTabularObjectCollection(testTabularCollection);
            else if (testDictionary != null) ShowObjectDictionary(testDictionary);
            else if (testList != null) ShowObjectCollection(testList);
            else ShowString(value.ToString());

            DormantForm.ShowDialog();
            DontShow = DormantForm.chkDontShow.Checked;
        }

        private static void ShowTabularObject(TabularObject obj)
        {
            DormantForm.DataProperties.Visible = true;
            DormantForm.DataListView.Visible = false;
            DormantForm.DataListView.VirtualListSize = 0;
            DormantForm.DataSplitter.Visible = false;
            DormantForm.DataTextBox.Visible = false;
            DormantForm.DataTextBox.Text = "";

            DormantForm.DataPropertyGrid.SelectedObject = obj;
        }

        private enum ListMode
        {
            TabularObjects,
            KeyValuePair,
            Others
        }

        private List<object> objList;
        private ListMode Mode;

        private static void ShowCollection()
        {
            DormantForm.DataProperties.Visible = true;
            DormantForm.DataListView.Visible = true;
            DormantForm.DataListView.VirtualListSize = DormantForm.objList.Count;
            DormantForm.DataTextBox.Visible = false;
            DormantForm.DataTextBox.Text = "";

            DormantForm.DataPropertyGrid.SelectedObject = null;
        }

        private static void ShowTabularObjectCollection(IEnumerable<ITabularNamedObject> obj)
        {
            DormantForm.Mode = ListMode.TabularObjects;
            DormantForm.objList = obj.ToList<object>();
            DormantForm.DataSplitter.Visible = true;
            DormantForm.DataPropertyGrid.Visible = true;
            DormantForm.DataListView.Dock = DockStyle.Left;
            DormantForm.DataListView.Columns[0].Text = "Name";

            ShowCollection();
        }

        private static void ShowObjectCollection(IEnumerable<object> obj)
        {
            DormantForm.Mode = ListMode.Others;
            DormantForm.objList = obj.ToList<object>();
            DormantForm.DataSplitter.Visible = false;
            DormantForm.DataPropertyGrid.Visible = false;
            DormantForm.DataListView.Dock = DockStyle.Fill;
            DormantForm.DataListView.Columns[0].Text = "Value";

            ShowCollection();
        }

        private static void ShowObjectDictionary(IDictionary obj)
        {
            DormantForm.Mode = ListMode.KeyValuePair;
            DormantForm.objList = obj.Keys.Cast<object>().Select(key => (object)new KeyValuePair<object, object>(key, obj[key])).ToList();
            DormantForm.DataSplitter.Visible = true;
            DormantForm.DataPropertyGrid.Visible = true;
            DormantForm.DataListView.Dock = DockStyle.Left;
            DormantForm.DataListView.Columns[0].Text = "Key";

            ShowCollection();
        }

        private static void ShowString(string value)
        {
            DormantForm.DataProperties.Visible = false;
            DormantForm.DataListView.VirtualListSize = 0;
            DormantForm.DataTextBox.Visible = true;
            DormantForm.DataTextBox.Text = value;

            DormantForm.DataPropertyGrid.SelectedObject = null;
        }

        private void DataListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (Mode == ListMode.TabularObjects)
            {
                var obj = objList[e.ItemIndex] as ITabularNamedObject;
                e.Item = new ListViewItem(new[] { obj.Name, obj.GetTypeName() }, 15);
            } else if (Mode == ListMode.KeyValuePair) {
                var obj = (KeyValuePair < object, object> )objList[e.ItemIndex];
                e.Item = new ListViewItem(new[] { obj.Key.ToString(), obj.Value?.GetType()?.Name });
            }
            else if (Mode == ListMode.Others)
            {
                var obj = objList[e.ItemIndex];
                e.Item = new ListViewItem(new[] { obj?.ToString(), obj?.GetType()?.Name }, 15);
            }
        }

        private void DataListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataListView.SelectedIndices.Count == 1 && Mode == ListMode.TabularObjects)
                DataPropertyGrid.SelectedObject = objList[DataListView.SelectedIndices[0]];
            else if (DataListView.SelectedIndices.Count == 1 && Mode == ListMode.KeyValuePair)
            {
                var obj = (KeyValuePair<object, object>)objList[DataListView.SelectedIndices[0]];
                if (obj.Value != null && obj.Value.GetType().IsPrimitive)
                    DataPropertyGrid.SelectedObject = obj;
                else
                    DataPropertyGrid.SelectedObject = obj.Value;
            }
            else
                DataPropertyGrid.SelectedObject = null;
        }
    }
}
