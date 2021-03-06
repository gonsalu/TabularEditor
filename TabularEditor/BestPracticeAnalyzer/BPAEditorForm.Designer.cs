﻿namespace TabularEditor.UI.Dialogs
{
    partial class BPAEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.numSeverity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuConditions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCriteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCriteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtExpression = new System.Windows.Forms.RichTextBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customComboBox1 = new CustomComboBox.CustomComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSeverity)).BeginInit();
            this.menuConditions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Applies to";
            // 
            // numSeverity
            // 
            this.numSeverity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSeverity.Location = new System.Drawing.Point(588, 38);
            this.numSeverity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSeverity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeverity.Name = "numSeverity";
            this.numSeverity.Size = new System.Drawing.Size(59, 20);
            this.numSeverity.TabIndex = 20;
            this.numSeverity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSeverity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Severity";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(78, 64);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(569, 59);
            this.txtDescription.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(78, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(569, 20);
            this.txtName.TabIndex = 15;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // menuConditions
            // 
            this.menuConditions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCriteriaToolStripMenuItem,
            this.deleteCriteriaToolStripMenuItem});
            this.menuConditions.Name = "menuConditions";
            this.menuConditions.Size = new System.Drawing.Size(147, 48);
            this.menuConditions.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.menuConditions_Closing);
            this.menuConditions.Opening += new System.ComponentModel.CancelEventHandler(this.menuConditions_Opening);
            // 
            // addCriteriaToolStripMenuItem
            // 
            this.addCriteriaToolStripMenuItem.Name = "addCriteriaToolStripMenuItem";
            this.addCriteriaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addCriteriaToolStripMenuItem.Text = "Add criteria";
            this.addCriteriaToolStripMenuItem.Click += new System.EventHandler(this.addCriteriaToolStripMenuItem_Click);
            // 
            // deleteCriteriaToolStripMenuItem
            // 
            this.deleteCriteriaToolStripMenuItem.Name = "deleteCriteriaToolStripMenuItem";
            this.deleteCriteriaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.deleteCriteriaToolStripMenuItem.Text = "Delete criteria";
            this.deleteCriteriaToolStripMenuItem.Click += new System.EventHandler(this.deleteCriteriaToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 154);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 215);
            this.tabControl1.TabIndex = 27;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtExpression);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rule Expression Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtExpression
            // 
            this.txtExpression.AcceptsTab = true;
            this.txtExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpression.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpression.Location = new System.Drawing.Point(3, 3);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(621, 183);
            this.txtExpression.TabIndex = 0;
            this.txtExpression.Text = "";
            this.txtExpression.TextChanged += new System.EventHandler(this.txtExpression_TextChanged);
            this.txtExpression.Leave += new System.EventHandler(this.txtExpression_Leave);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Info;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(659, 25);
            this.pnlInfo.TabIndex = 28;
            this.pnlInfo.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(4, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(44, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Error: ...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customComboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numSeverity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 410);
            this.panel1.TabIndex = 29;
            // 
            // customComboBox1
            // 
            this.customComboBox1.AllowResizeDropDown = true;
            this.customComboBox1.ControlSize = new System.Drawing.Size(1, 1);
            this.customComboBox1.DropDownControl = null;
            this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customComboBox1.DropSize = new System.Drawing.Size(121, 150);
            this.customComboBox1.Location = new System.Drawing.Point(78, 129);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Size = new System.Drawing.Size(253, 21);
            this.customComboBox1.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(78, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(453, 20);
            this.txtID.TabIndex = 31;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "satisfying the following criteria:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(558, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(463, 375);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 23);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // BPAEditorForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(659, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 230);
            this.Name = "BPAEditorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edit Best Practice Rule";
            ((System.ComponentModel.ISupportInitialize)(this.numSeverity)).EndInit();
            this.menuConditions.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSeverity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip menuConditions;
        private System.Windows.Forms.ToolStripMenuItem addCriteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCriteriaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txtExpression;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private CustomComboBox.CustomComboBox customComboBox1;
    }
}