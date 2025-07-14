namespace WindowsRepresentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.backtrackButton = new System.Windows.Forms.RadioButton();
            this.depthFirstButton = new System.Windows.Forms.RadioButton();
            this.breathFirstButton = new System.Windows.Forms.RadioButton();
            this.optimalButton = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(48, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "9";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "10";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Table Data";
            // 
            // backtrackButton
            // 
            this.backtrackButton.AutoSize = true;
            this.backtrackButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backtrackButton.Location = new System.Drawing.Point(57, 12);
            this.backtrackButton.Name = "backtrackButton";
            this.backtrackButton.Size = new System.Drawing.Size(110, 27);
            this.backtrackButton.TabIndex = 4;
            this.backtrackButton.TabStop = true;
            this.backtrackButton.Text = "Backtrack";
            this.backtrackButton.UseVisualStyleBackColor = true;
            this.backtrackButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // depthFirstButton
            // 
            this.depthFirstButton.AutoSize = true;
            this.depthFirstButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depthFirstButton.Location = new System.Drawing.Point(265, 12);
            this.depthFirstButton.Name = "depthFirstButton";
            this.depthFirstButton.Size = new System.Drawing.Size(116, 27);
            this.depthFirstButton.TabIndex = 5;
            this.depthFirstButton.TabStop = true;
            this.depthFirstButton.Text = "DepthFirst";
            this.depthFirstButton.UseVisualStyleBackColor = true;
            this.depthFirstButton.CheckedChanged += new System.EventHandler(this.depthFirstButton_CheckedChanged);
            // 
            // breathFirstButton
            // 
            this.breathFirstButton.AutoSize = true;
            this.breathFirstButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.breathFirstButton.Location = new System.Drawing.Point(445, 12);
            this.breathFirstButton.Name = "breathFirstButton";
            this.breathFirstButton.Size = new System.Drawing.Size(119, 27);
            this.breathFirstButton.TabIndex = 6;
            this.breathFirstButton.TabStop = true;
            this.breathFirstButton.Text = "BreathFirst";
            this.breathFirstButton.UseVisualStyleBackColor = true;
            this.breathFirstButton.CheckedChanged += new System.EventHandler(this.breathFirstButton_CheckedChanged);
            // 
            // optimalButton
            // 
            this.optimalButton.AutoSize = true;
            this.optimalButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optimalButton.Location = new System.Drawing.Point(702, 12);
            this.optimalButton.Name = "optimalButton";
            this.optimalButton.Size = new System.Drawing.Size(97, 27);
            this.optimalButton.TabIndex = 7;
            this.optimalButton.TabStop = true;
            this.optimalButton.Text = "Optimal";
            this.optimalButton.UseVisualStyleBackColor = true;
            this.optimalButton.CheckedChanged += new System.EventHandler(this.optimalButton_CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13});
            this.dataGridView2.Location = new System.Drawing.Point(57, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(427, 253);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Cost";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "action";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "position";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 718);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.optimalButton);
            this.Controls.Add(this.breathFirstButton);
            this.Controls.Add(this.depthFirstButton);
            this.Controls.Add(this.backtrackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Object Movement ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label label1;
        private RadioButton backtrackButton;
        private RadioButton depthFirstButton;
        private RadioButton breathFirstButton;
        private RadioButton optimalButton;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
    }
}