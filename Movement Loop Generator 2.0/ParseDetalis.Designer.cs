namespace Movement_Loop_Generator_2._0
{
    partial class ParseDetalis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpawnName = new System.Windows.Forms.TextBox();
            this.tbAuthorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFunction = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spawn Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // tbSpawnName
            // 
            this.tbSpawnName.Location = new System.Drawing.Point(12, 38);
            this.tbSpawnName.Name = "tbSpawnName";
            this.tbSpawnName.Size = new System.Drawing.Size(138, 20);
            this.tbSpawnName.TabIndex = 2;
            // 
            // tbAuthorName
            // 
            this.tbAuthorName.Location = new System.Drawing.Point(186, 38);
            this.tbAuthorName.Name = "tbAuthorName";
            this.tbAuthorName.Size = new System.Drawing.Size(138, 20);
            this.tbAuthorName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Delay";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(50, 90);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbSpeed.TabIndex = 13;
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(186, 90);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(100, 20);
            this.tbDelay.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Function";
            // 
            // tbFunction
            // 
            this.tbFunction.Location = new System.Drawing.Point(50, 142);
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.Size = new System.Drawing.Size(236, 20);
            this.tbFunction.TabIndex = 16;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(120, 187);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(100, 31);
            this.btnParse.TabIndex = 17;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // ParseDetalis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 230);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.tbFunction);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDelay);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAuthorName);
            this.Controls.Add(this.tbSpawnName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ParseDetalis";
            this.Text = "ParseDetalis";
            this.Load += new System.EventHandler(this.ParseDetalis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSpawnName;
        private System.Windows.Forms.TextBox tbAuthorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.TextBox tbDelay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFunction;
        private System.Windows.Forms.Button btnParse;
    }
}