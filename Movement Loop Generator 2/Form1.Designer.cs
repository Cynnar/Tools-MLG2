namespace Movement_Loop_Generator_2._0
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_Author = new System.Windows.Forms.ToolStripTextBox();
            this.reversePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectWaypointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadingLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_LogFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.listView_Loaded = new System.Windows.Forms.ListView();
            this.column_blank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_SpawnX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_SpawnY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_SpawnZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_SpawnSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_SpawnDelay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_SpawnFunction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox_OutputView = new System.Windows.Forms.RichTextBox();
            this.groupBox_Edit = new System.Windows.Forms.GroupBox();
            this.checkBox_ReversePath = new System.Windows.Forms.CheckBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_InsertBelow = new System.Windows.Forms.Button();
            this.textBox_Function = new System.Windows.Forms.TextBox();
            this.textBox_Delay = new System.Windows.Forms.TextBox();
            this.textBox_Speed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ZLOC = new System.Windows.Forms.TextBox();
            this.textBox_YLOC = new System.Windows.Forms.TextBox();
            this.textBox_XLOC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_ParseDetalis = new System.Windows.Forms.Button();
            this.listBox_NPCs = new System.Windows.Forms.ListBox();
            this.button_InsertAbove = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.howToUseToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.userToolStripMenuItem,
            this.authorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem1,
            this.reversePathToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // authorToolStripMenuItem1
            // 
            this.authorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_Author});
            this.authorToolStripMenuItem1.Name = "authorToolStripMenuItem1";
            this.authorToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.authorToolStripMenuItem1.Text = "Author";
            this.authorToolStripMenuItem1.MouseEnter += new System.EventHandler(this.authorToolStripMenuItem_MouseEnter);
            // 
            // toolStripTextBox_Author
            // 
            this.toolStripTextBox_Author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_Author.Name = "toolStripTextBox_Author";
            this.toolStripTextBox_Author.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_Author.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxAuthor_KeyDown);
            // 
            // reversePathToolStripMenuItem
            // 
            this.reversePathToolStripMenuItem.Name = "reversePathToolStripMenuItem";
            this.reversePathToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.reversePathToolStripMenuItem.Text = "Reverse Path";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectWaypointsToolStripMenuItem,
            this.loadingLogsToolStripMenuItem,
            this.useGeneratorToolStripMenuItem});
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.howToUseToolStripMenuItem.Text = "How To";
            // 
            // collectWaypointsToolStripMenuItem
            // 
            this.collectWaypointsToolStripMenuItem.Name = "collectWaypointsToolStripMenuItem";
            this.collectWaypointsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.collectWaypointsToolStripMenuItem.Text = "Collecting locations";
            this.collectWaypointsToolStripMenuItem.Click += new System.EventHandler(this.collectWaypointsToolStripMenuItem_Click);
            // 
            // loadingLogsToolStripMenuItem
            // 
            this.loadingLogsToolStripMenuItem.Name = "loadingLogsToolStripMenuItem";
            this.loadingLogsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadingLogsToolStripMenuItem.Text = "Loading logs";
            this.loadingLogsToolStripMenuItem.Click += new System.EventHandler(this.loadingLogsToolStripMenuItem_Click);
            // 
            // useGeneratorToolStripMenuItem
            // 
            this.useGeneratorToolStripMenuItem.Name = "useGeneratorToolStripMenuItem";
            this.useGeneratorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.useGeneratorToolStripMenuItem.Text = "Editing locations";
            this.useGeneratorToolStripMenuItem.Click += new System.EventHandler(this.editinglogsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.userToolStripMenuItem.Text = "user";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.authorToolStripMenuItem.Text = "Author :";
            // 
            // textBox_LogFile
            // 
            this.textBox_LogFile.AllowDrop = true;
            this.textBox_LogFile.Location = new System.Drawing.Point(92, 29);
            this.textBox_LogFile.Name = "textBox_LogFile";
            this.textBox_LogFile.Size = new System.Drawing.Size(348, 20);
            this.textBox_LogFile.TabIndex = 1;
            this.textBox_LogFile.DoubleClick += new System.EventHandler(this.textBox_LogFile_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Load Log File:";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(446, 27);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // listView_Loaded
            // 
            this.listView_Loaded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_blank,
            this.column_SpawnX,
            this.column_SpawnY,
            this.column_SpawnZ,
            this.column_SpawnSpeed,
            this.column_SpawnDelay,
            this.column_SpawnFunction});
            this.listView_Loaded.FullRowSelect = true;
            this.listView_Loaded.GridLines = true;
            this.listView_Loaded.HideSelection = false;
            this.listView_Loaded.Location = new System.Drawing.Point(141, 55);
            this.listView_Loaded.MultiSelect = false;
            this.listView_Loaded.Name = "listView_Loaded";
            this.listView_Loaded.Size = new System.Drawing.Size(509, 374);
            this.listView_Loaded.TabIndex = 1;
            this.listView_Loaded.TabStop = false;
            this.listView_Loaded.UseCompatibleStateImageBehavior = false;
            this.listView_Loaded.View = System.Windows.Forms.View.Details;
            this.listView_Loaded.SelectedIndexChanged += new System.EventHandler(this.listView_Loaded_SelectedIndexChanged);
            // 
            // column_blank
            // 
            this.column_blank.Text = "";
            this.column_blank.Width = 0;
            // 
            // column_SpawnX
            // 
            this.column_SpawnX.Text = "X";
            this.column_SpawnX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_SpawnX.Width = 70;
            // 
            // column_SpawnY
            // 
            this.column_SpawnY.Text = "Y";
            this.column_SpawnY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_SpawnY.Width = 70;
            // 
            // column_SpawnZ
            // 
            this.column_SpawnZ.Text = "Z";
            this.column_SpawnZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_SpawnZ.Width = 70;
            // 
            // column_SpawnSpeed
            // 
            this.column_SpawnSpeed.Text = "Speed";
            this.column_SpawnSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_SpawnSpeed.Width = 70;
            // 
            // column_SpawnDelay
            // 
            this.column_SpawnDelay.Text = "Delay";
            this.column_SpawnDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_SpawnDelay.Width = 70;
            // 
            // column_SpawnFunction
            // 
            this.column_SpawnFunction.Text = "Function";
            this.column_SpawnFunction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_SpawnFunction.Width = 150;
            // 
            // richTextBox_OutputView
            // 
            this.richTextBox_OutputView.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox_OutputView.Enabled = false;
            this.richTextBox_OutputView.Location = new System.Drawing.Point(656, 353);
            this.richTextBox_OutputView.Name = "richTextBox_OutputView";
            this.richTextBox_OutputView.Size = new System.Drawing.Size(277, 174);
            this.richTextBox_OutputView.TabIndex = 0;
            this.richTextBox_OutputView.Text = "";
            // 
            // groupBox_Edit
            // 
            this.groupBox_Edit.Location = new System.Drawing.Point(656, 55);
            this.groupBox_Edit.Name = "groupBox_Edit";
            this.groupBox_Edit.Size = new System.Drawing.Size(277, 292);
            this.groupBox_Edit.TabIndex = 4;
            this.groupBox_Edit.TabStop = false;
            // 
            // checkBox_ReversePath
            // 
            this.checkBox_ReversePath.AutoSize = true;
            this.checkBox_ReversePath.Location = new System.Drawing.Point(569, 463);
            this.checkBox_ReversePath.Name = "checkBox_ReversePath";
            this.checkBox_ReversePath.Size = new System.Drawing.Size(75, 17);
            this.checkBox_ReversePath.TabIndex = 16;
            this.checkBox_ReversePath.Text = "Loop Path";
            this.checkBox_ReversePath.UseVisualStyleBackColor = true;
            this.checkBox_ReversePath.Visible = false;
            this.checkBox_ReversePath.CheckedChanged += new System.EventHandler(this.checkBox_ReversePath_CheckedChanged);
            // 
            // button_Remove
            // 
            this.button_Remove.Enabled = false;
            this.button_Remove.Location = new System.Drawing.Point(405, 487);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 5;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Update
            // 
            this.button_Update.Enabled = false;
            this.button_Update.Location = new System.Drawing.Point(324, 487);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Enabled = false;
            this.button_Reset.Location = new System.Drawing.Point(486, 487);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 5;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_InsertBelow
            // 
            this.button_InsertBelow.Enabled = false;
            this.button_InsertBelow.Location = new System.Drawing.Point(243, 487);
            this.button_InsertBelow.Name = "button_InsertBelow";
            this.button_InsertBelow.Size = new System.Drawing.Size(75, 23);
            this.button_InsertBelow.TabIndex = 8;
            this.button_InsertBelow.Text = "Insert Below";
            this.button_InsertBelow.UseVisualStyleBackColor = true;
            this.button_InsertBelow.Click += new System.EventHandler(this.button_InsertBelow_Click);
            // 
            // textBox_Function
            // 
            this.textBox_Function.Location = new System.Drawing.Point(525, 435);
            this.textBox_Function.Name = "textBox_Function";
            this.textBox_Function.Size = new System.Drawing.Size(117, 20);
            this.textBox_Function.TabIndex = 15;
            // 
            // textBox_Delay
            // 
            this.textBox_Delay.Location = new System.Drawing.Point(348, 435);
            this.textBox_Delay.Name = "textBox_Delay";
            this.textBox_Delay.Size = new System.Drawing.Size(117, 20);
            this.textBox_Delay.TabIndex = 14;
            // 
            // textBox_Speed
            // 
            this.textBox_Speed.Location = new System.Drawing.Point(185, 435);
            this.textBox_Speed.Name = "textBox_Speed";
            this.textBox_Speed.Size = new System.Drawing.Size(117, 20);
            this.textBox_Speed.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Function";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Delay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Z";
            // 
            // textBox_ZLOC
            // 
            this.textBox_ZLOC.Location = new System.Drawing.Point(446, 461);
            this.textBox_ZLOC.Name = "textBox_ZLOC";
            this.textBox_ZLOC.Size = new System.Drawing.Size(117, 20);
            this.textBox_ZLOC.TabIndex = 8;
            // 
            // textBox_YLOC
            // 
            this.textBox_YLOC.Location = new System.Drawing.Point(306, 461);
            this.textBox_YLOC.Name = "textBox_YLOC";
            this.textBox_YLOC.Size = new System.Drawing.Size(117, 20);
            this.textBox_YLOC.TabIndex = 7;
            // 
            // textBox_XLOC
            // 
            this.textBox_XLOC.Location = new System.Drawing.Point(162, 461);
            this.textBox_XLOC.Name = "textBox_XLOC";
            this.textBox_XLOC.Size = new System.Drawing.Size(117, 20);
            this.textBox_XLOC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(679, 26);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_ParseDetalis
            // 
            this.button_ParseDetalis.Location = new System.Drawing.Point(575, 26);
            this.button_ParseDetalis.Name = "button_ParseDetalis";
            this.button_ParseDetalis.Size = new System.Drawing.Size(75, 23);
            this.button_ParseDetalis.TabIndex = 6;
            this.button_ParseDetalis.Text = "Parse";
            this.button_ParseDetalis.UseVisualStyleBackColor = true;
            this.button_ParseDetalis.Click += new System.EventHandler(this.button_ParseDetalis_Click);
            // 
            // listBox_NPCs
            // 
            this.listBox_NPCs.FormattingEnabled = true;
            this.listBox_NPCs.Location = new System.Drawing.Point(9, 55);
            this.listBox_NPCs.Name = "listBox_NPCs";
            this.listBox_NPCs.Size = new System.Drawing.Size(126, 472);
            this.listBox_NPCs.TabIndex = 7;
            this.listBox_NPCs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_NPCs_MouseDoubleClick);
            // 
            // button_InsertAbove
            // 
            this.button_InsertAbove.Enabled = false;
            this.button_InsertAbove.Location = new System.Drawing.Point(162, 487);
            this.button_InsertAbove.Name = "button_InsertAbove";
            this.button_InsertAbove.Size = new System.Drawing.Size(75, 23);
            this.button_InsertAbove.TabIndex = 16;
            this.button_InsertAbove.Text = "Insert Above";
            this.button_InsertAbove.UseVisualStyleBackColor = true;
            this.button_InsertAbove.Click += new System.EventHandler(this.button_InsertAbove_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 537);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.checkBox_ReversePath);
            this.Controls.Add(this.button_InsertAbove);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.listBox_NPCs);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.richTextBox_OutputView);
            this.Controls.Add(this.listView_Loaded);
            this.Controls.Add(this.button_ParseDetalis);
            this.Controls.Add(this.textBox_Function);
            this.Controls.Add(this.button_InsertBelow);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Delay);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Speed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox_Edit);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_LogFile);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox_XLOC);
            this.Controls.Add(this.textBox_ZLOC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_YLOC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_LogFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.ListView listView_Loaded;
        private System.Windows.Forms.ColumnHeader column_SpawnX;
        private System.Windows.Forms.ColumnHeader column_SpawnY;
        private System.Windows.Forms.ColumnHeader column_SpawnZ;
        private System.Windows.Forms.ColumnHeader column_SpawnSpeed;
        private System.Windows.Forms.ColumnHeader column_SpawnDelay;
        private System.Windows.Forms.ColumnHeader column_SpawnFunction;
        private System.Windows.Forms.ColumnHeader column_blank;
        private System.Windows.Forms.RichTextBox richTextBox_OutputView;
        private System.Windows.Forms.GroupBox groupBox_Edit;
        private System.Windows.Forms.TextBox textBox_Function;
        private System.Windows.Forms.TextBox textBox_Delay;
        private System.Windows.Forms.TextBox textBox_Speed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ZLOC;
        private System.Windows.Forms.TextBox textBox_YLOC;
        private System.Windows.Forms.TextBox textBox_XLOC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_InsertBelow;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_ParseDetalis;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectWaypointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadingLogsToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_ReversePath;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Author;
        private System.Windows.Forms.ToolStripMenuItem reversePathToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_NPCs;
        private System.Windows.Forms.Button button_InsertAbove;
    }
}

