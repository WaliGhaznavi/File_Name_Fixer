namespace File_Name_Fixer
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
            this.btn_selectFiles = new System.Windows.Forms.Button();
            this.lbl_Directory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fix = new System.Windows.Forms.Button();
            this.txt_Files = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_selectFiles
            // 
            this.btn_selectFiles.Location = new System.Drawing.Point(68, 52);
            this.btn_selectFiles.Name = "btn_selectFiles";
            this.btn_selectFiles.Size = new System.Drawing.Size(155, 23);
            this.btn_selectFiles.TabIndex = 0;
            this.btn_selectFiles.Text = "Select Files Directory";
            this.btn_selectFiles.UseVisualStyleBackColor = true;
            this.btn_selectFiles.Click += new System.EventHandler(this.btn_selectFiles_Click);
            // 
            // lbl_Directory
            // 
            this.lbl_Directory.AutoSize = true;
            this.lbl_Directory.Location = new System.Drawing.Point(229, 56);
            this.lbl_Directory.Name = "lbl_Directory";
            this.lbl_Directory.Size = new System.Drawing.Size(10, 13);
            this.lbl_Directory.TabIndex = 1;
            this.lbl_Directory.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Files Names Fixed";
            // 
            // btn_fix
            // 
            this.btn_fix.Location = new System.Drawing.Point(68, 101);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(152, 23);
            this.btn_fix.TabIndex = 3;
            this.btn_fix.Text = "Fix Names";
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // txt_Files
            // 
            this.txt_Files.Location = new System.Drawing.Point(71, 159);
            this.txt_Files.Multiline = true;
            this.txt_Files.Name = "txt_Files";
            this.txt_Files.Size = new System.Drawing.Size(1051, 458);
            this.txt_Files.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 642);
            this.Controls.Add(this.txt_Files);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Directory);
            this.Controls.Add(this.btn_selectFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_selectFiles;
        private System.Windows.Forms.Label lbl_Directory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.TextBox txt_Files;
    }
}

