
namespace Serialization
{
    partial class Form1
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
            this.serializeBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.deserializeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xMLToJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.xmlBtn = new System.Windows.Forms.RadioButton();
            this.binBtn = new System.Windows.Forms.RadioButton();
            this.jsonBtn = new System.Windows.Forms.RadioButton();
            this.newPlaneType = new System.Windows.Forms.Label();
            this.fieldsHolder = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serializeBtn
            // 
            this.serializeBtn.Location = new System.Drawing.Point(515, 340);
            this.serializeBtn.Name = "serializeBtn";
            this.serializeBtn.Size = new System.Drawing.Size(135, 26);
            this.serializeBtn.TabIndex = 1;
            this.serializeBtn.Text = "Serialize";
            this.serializeBtn.UseVisualStyleBackColor = true;
            this.serializeBtn.Click += new System.EventHandler(this.serializationBtn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(245, 262);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // deserializeBtn
            // 
            this.deserializeBtn.Location = new System.Drawing.Point(374, 340);
            this.deserializeBtn.Name = "deserializeBtn";
            this.deserializeBtn.Size = new System.Drawing.Size(135, 26);
            this.deserializeBtn.TabIndex = 4;
            this.deserializeBtn.Text = "Deserialize";
            this.deserializeBtn.UseVisualStyleBackColor = true;
            this.deserializeBtn.Click += new System.EventHandler(this.serializationBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(515, 295);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(135, 26);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(515, 34);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(135, 26);
            this.newBtn.TabIndex = 15;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(12, 295);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(135, 26);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete Selected";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToJSONToolStripMenuItem,
            this.transformXMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xMLToJSONToolStripMenuItem
            // 
            this.xMLToJSONToolStripMenuItem.Name = "xMLToJSONToolStripMenuItem";
            this.xMLToJSONToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.xMLToJSONToolStripMenuItem.Text = "Plugin1";
            this.xMLToJSONToolStripMenuItem.Visible = false;
            this.xMLToJSONToolStripMenuItem.Click += new System.EventHandler(this.xMLToJSONToolStripMenuItem_Click);
            // 
            // transformXMLToolStripMenuItem
            // 
            this.transformXMLToolStripMenuItem.Name = "transformXMLToolStripMenuItem";
            this.transformXMLToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.transformXMLToolStripMenuItem.Text = "Plugin2";
            this.transformXMLToolStripMenuItem.Visible = false;
            this.transformXMLToolStripMenuItem.Click += new System.EventHandler(this.transformXMLToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // xmlBtn
            // 
            this.xmlBtn.AutoSize = true;
            this.xmlBtn.Checked = true;
            this.xmlBtn.Location = new System.Drawing.Point(12, 345);
            this.xmlBtn.Name = "xmlBtn";
            this.xmlBtn.Size = new System.Drawing.Size(106, 17);
            this.xmlBtn.TabIndex = 18;
            this.xmlBtn.TabStop = true;
            this.xmlBtn.Text = "XML Serialization";
            this.xmlBtn.UseVisualStyleBackColor = true;
            this.xmlBtn.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // binBtn
            // 
            this.binBtn.AutoSize = true;
            this.binBtn.Location = new System.Drawing.Point(124, 345);
            this.binBtn.Name = "binBtn";
            this.binBtn.Size = new System.Drawing.Size(113, 17);
            this.binBtn.TabIndex = 19;
            this.binBtn.TabStop = true;
            this.binBtn.Text = "Binary Serialization";
            this.binBtn.UseVisualStyleBackColor = true;
            this.binBtn.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // jsonBtn
            // 
            this.jsonBtn.AutoSize = true;
            this.jsonBtn.Location = new System.Drawing.Point(242, 345);
            this.jsonBtn.Name = "jsonBtn";
            this.jsonBtn.Size = new System.Drawing.Size(112, 17);
            this.jsonBtn.TabIndex = 20;
            this.jsonBtn.TabStop = true;
            this.jsonBtn.Text = "JSON Serialization";
            this.jsonBtn.UseVisualStyleBackColor = true;
            this.jsonBtn.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // newPlaneType
            // 
            this.newPlaneType.AutoSize = true;
            this.newPlaneType.Location = new System.Drawing.Point(263, 34);
            this.newPlaneType.Name = "newPlaneType";
            this.newPlaneType.Size = new System.Drawing.Size(0, 13);
            this.newPlaneType.TabIndex = 21;
            // 
            // fieldsHolder
            // 
            this.fieldsHolder.Location = new System.Drawing.Point(266, 59);
            this.fieldsHolder.Name = "fieldsHolder";
            this.fieldsHolder.Size = new System.Drawing.Size(384, 230);
            this.fieldsHolder.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 378);
            this.Controls.Add(this.newPlaneType);
            this.Controls.Add(this.jsonBtn);
            this.Controls.Add(this.binBtn);
            this.Controls.Add(this.xmlBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deserializeBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.serializeBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.fieldsHolder);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button serializeBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button deserializeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xMLToJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformXMLToolStripMenuItem;
        private System.Windows.Forms.RadioButton xmlBtn;
        private System.Windows.Forms.RadioButton binBtn;
        private System.Windows.Forms.RadioButton jsonBtn;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label newPlaneType;
        private System.Windows.Forms.Panel fieldsHolder;
    }
}

