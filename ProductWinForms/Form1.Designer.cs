namespace ProductWinForms
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
            btnView = new Button();
            btnViewCatory = new Button();
            dvgData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgData).BeginInit();
            SuspendLayout();
            // 
            // btnView
            // 
            btnView.Location = new Point(116, 76);
            btnView.Name = "btnView";
            btnView.Size = new Size(180, 34);
            btnView.TabIndex = 0;
            btnView.Text = "View Product";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnViewCatory
            // 
            btnViewCatory.Location = new Point(479, 76);
            btnViewCatory.Name = "btnViewCatory";
            btnViewCatory.Size = new Size(180, 34);
            btnViewCatory.TabIndex = 1;
            btnViewCatory.Text = "View Caretories";
            btnViewCatory.UseVisualStyleBackColor = true;
            btnViewCatory.Click += btnViewCatory_Click;
            // 
            // dvgData
            // 
            dvgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgData.Location = new Point(52, 145);
            dvgData.Name = "dvgData";
            dvgData.RowHeadersWidth = 62;
            dvgData.RowTemplate.Height = 33;
            dvgData.Size = new Size(703, 225);
            dvgData.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dvgData);
            Controls.Add(btnViewCatory);
            Controls.Add(btnView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnView;
        private Button btnViewCatory;
        private DataGridView dvgData;
    }
}