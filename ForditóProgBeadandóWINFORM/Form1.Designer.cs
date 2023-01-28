namespace ForditóProgBeadandóWINFORM
{
    partial class Assignment
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
            this.label3 = new System.Windows.Forms.Label();
            this.resultTitle = new System.Windows.Forms.Label();
            this.Input_BTN = new System.Windows.Forms.Button();
            this.convertedInput_BTN = new System.Windows.Forms.Button();
            this.InputPath_BTN = new System.Windows.Forms.Button();
            this.ruleGrid = new System.Windows.Forms.DataGridView();
            this.Input_TB = new System.Windows.Forms.TextBox();
            this.ConvertedInput_TB = new System.Windows.Forms.TextBox();
            this.inputPath_TB = new System.Windows.Forms.TextBox();
            this.solver_BTN = new System.Windows.Forms.Button();
            this.stepByStep_LB = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ruleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Converted Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input Path";
            // 
            // resultTitle
            // 
            this.resultTitle.AutoSize = true;
            this.resultTitle.Location = new System.Drawing.Point(353, 17);
            this.resultTitle.Name = "resultTitle";
            this.resultTitle.Size = new System.Drawing.Size(19, 13);
            this.resultTitle.TabIndex = 3;
            this.resultTitle.Text = "----";
            // 
            // Input_BTN
            // 
            this.Input_BTN.Location = new System.Drawing.Point(573, 65);
            this.Input_BTN.Name = "Input_BTN";
            this.Input_BTN.Size = new System.Drawing.Size(75, 23);
            this.Input_BTN.TabIndex = 4;
            this.Input_BTN.Text = "OK";
            this.Input_BTN.UseVisualStyleBackColor = true;
            this.Input_BTN.Click += new System.EventHandler(this.Input_BTN_Click);
            // 
            // convertedInput_BTN
            // 
            this.convertedInput_BTN.Enabled = false;
            this.convertedInput_BTN.Location = new System.Drawing.Point(573, 118);
            this.convertedInput_BTN.Name = "convertedInput_BTN";
            this.convertedInput_BTN.Size = new System.Drawing.Size(75, 23);
            this.convertedInput_BTN.TabIndex = 5;
            this.convertedInput_BTN.Text = "OK";
            this.convertedInput_BTN.UseVisualStyleBackColor = true;
            this.convertedInput_BTN.Click += new System.EventHandler(this.ConvertedInput_BTN_Click);
            // 
            // InputPath_BTN
            // 
            this.InputPath_BTN.Location = new System.Drawing.Point(573, 172);
            this.InputPath_BTN.Name = "InputPath_BTN";
            this.InputPath_BTN.Size = new System.Drawing.Size(75, 23);
            this.InputPath_BTN.TabIndex = 6;
            this.InputPath_BTN.Text = "Browse";
            this.InputPath_BTN.UseVisualStyleBackColor = true;
            this.InputPath_BTN.Click += new System.EventHandler(this.InputPath_BTN_Click);
            // 
            // ruleGrid
            // 
            this.ruleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ruleGrid.Location = new System.Drawing.Point(98, 224);
            this.ruleGrid.Name = "ruleGrid";
            this.ruleGrid.Size = new System.Drawing.Size(550, 388);
            this.ruleGrid.TabIndex = 9;
            // 
            // Input_TB
            // 
            this.Input_TB.Location = new System.Drawing.Point(198, 67);
            this.Input_TB.Name = "Input_TB";
            this.Input_TB.Size = new System.Drawing.Size(358, 20);
            this.Input_TB.TabIndex = 10;
            // 
            // ConvertedInput_TB
            // 
            this.ConvertedInput_TB.Location = new System.Drawing.Point(198, 121);
            this.ConvertedInput_TB.Name = "ConvertedInput_TB";
            this.ConvertedInput_TB.Size = new System.Drawing.Size(358, 20);
            this.ConvertedInput_TB.TabIndex = 11;
            // 
            // inputPath_TB
            // 
            this.inputPath_TB.Location = new System.Drawing.Point(198, 174);
            this.inputPath_TB.Name = "inputPath_TB";
            this.inputPath_TB.ReadOnly = true;
            this.inputPath_TB.Size = new System.Drawing.Size(358, 20);
            this.inputPath_TB.TabIndex = 12;
            // 
            // solver_BTN
            // 
            this.solver_BTN.Location = new System.Drawing.Point(680, 38);
            this.solver_BTN.Name = "solver_BTN";
            this.solver_BTN.Size = new System.Drawing.Size(324, 35);
            this.solver_BTN.TabIndex = 14;
            this.solver_BTN.Text = "Solve Step By Step";
            this.solver_BTN.UseVisualStyleBackColor = true;
            this.solver_BTN.Click += new System.EventHandler(this.solver_BTN_Click);
            // 
            // stepByStep_LB
            // 
            this.stepByStep_LB.FormattingEnabled = true;
            this.stepByStep_LB.HorizontalScrollbar = true;
            this.stepByStep_LB.Location = new System.Drawing.Point(680, 88);
            this.stepByStep_LB.Name = "stepByStep_LB";
            this.stepByStep_LB.Size = new System.Drawing.Size(324, 524);
            this.stepByStep_LB.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 624);
            this.Controls.Add(this.stepByStep_LB);
            this.Controls.Add(this.solver_BTN);
            this.Controls.Add(this.inputPath_TB);
            this.Controls.Add(this.ConvertedInput_TB);
            this.Controls.Add(this.Input_TB);
            this.Controls.Add(this.ruleGrid);
            this.Controls.Add(this.InputPath_BTN);
            this.Controls.Add(this.convertedInput_BTN);
            this.Controls.Add(this.Input_BTN);
            this.Controls.Add(this.resultTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Assignment";
            this.Text = "Comp. Assignment";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultTitle;
        private System.Windows.Forms.Button Input_BTN;
        private System.Windows.Forms.Button convertedInput_BTN;
        private System.Windows.Forms.Button InputPath_BTN;
        private System.Windows.Forms.DataGridView ruleGrid;
        private System.Windows.Forms.TextBox Input_TB;
        private System.Windows.Forms.TextBox ConvertedInput_TB;
        private System.Windows.Forms.TextBox inputPath_TB;
        private System.Windows.Forms.Button solver_BTN;
        private System.Windows.Forms.ListBox stepByStep_LB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

