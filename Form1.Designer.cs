namespace WindowsFormsApp1
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
            this.labelemptylist = new System.Windows.Forms.TextBox();
            this.button_add_defult = new System.Windows.Forms.Button();
            this.button_add_a_file = new System.Windows.Forms.Button();
            this.button_remove_file = new System.Windows.Forms.Button();
            this.button_print_all = new System.Windows.Forms.Button();
            this.press5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT = new System.Windows.Forms.Button();
            this.DOC = new System.Windows.Forms.Button();
            this.docx = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pptx = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.listoftable = new System.Windows.Forms.ListBox();
            this.PRINTBYTYPE = new System.Windows.Forms.Button();
            this.PPTX2 = new System.Windows.Forms.Button();
            this.PDF2 = new System.Windows.Forms.Button();
            this.DOCX2 = new System.Windows.Forms.Button();
            this.DOC2 = new System.Windows.Forms.Button();
            this.TXT2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelemptylist
            // 
            this.labelemptylist.BackColor = System.Drawing.Color.Red;
            this.labelemptylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemptylist.Location = new System.Drawing.Point(12, 23);
            this.labelemptylist.Name = "labelemptylist";
            this.labelemptylist.Size = new System.Drawing.Size(785, 30);
            this.labelemptylist.TabIndex = 0;
            this.labelemptylist.Text = "The list  is empty";
            this.labelemptylist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_add_defult
            // 
            this.button_add_defult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_add_defult.BackColor = System.Drawing.SystemColors.Info;
            this.button_add_defult.Location = new System.Drawing.Point(12, 59);
            this.button_add_defult.Name = "button_add_defult";
            this.button_add_defult.Size = new System.Drawing.Size(99, 62);
            this.button_add_defult.TabIndex = 1;
            this.button_add_defult.Text = "Add defult  file";
            this.button_add_defult.UseVisualStyleBackColor = false;
            this.button_add_defult.Click += new System.EventHandler(this.add_defult_file_press1);
            // 
            // button_add_a_file
            // 
            this.button_add_a_file.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_add_a_file.BackColor = System.Drawing.SystemColors.Info;
            this.button_add_a_file.Location = new System.Drawing.Point(12, 118);
            this.button_add_a_file.Name = "button_add_a_file";
            this.button_add_a_file.Size = new System.Drawing.Size(99, 62);
            this.button_add_a_file.TabIndex = 2;
            this.button_add_a_file.Text = "Add file";
            this.button_add_a_file.UseVisualStyleBackColor = false;
            this.button_add_a_file.Click += new System.EventHandler(this.visible_add_file_buttton);
            // 
            // button_remove_file
            // 
            this.button_remove_file.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_remove_file.BackColor = System.Drawing.SystemColors.Info;
            this.button_remove_file.Location = new System.Drawing.Point(12, 177);
            this.button_remove_file.Name = "button_remove_file";
            this.button_remove_file.Size = new System.Drawing.Size(99, 62);
            this.button_remove_file.TabIndex = 3;
            this.button_remove_file.Text = "Remove file";
            this.button_remove_file.UseVisualStyleBackColor = false;
            this.button_remove_file.Click += new System.EventHandler(this.remove_a_file_press3);
            // 
            // button_print_all
            // 
            this.button_print_all.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_print_all.BackColor = System.Drawing.SystemColors.Info;
            this.button_print_all.Location = new System.Drawing.Point(12, 236);
            this.button_print_all.Name = "button_print_all";
            this.button_print_all.Size = new System.Drawing.Size(99, 62);
            this.button_print_all.TabIndex = 4;
            this.button_print_all.Text = "Print all files";
            this.button_print_all.UseVisualStyleBackColor = false;
            this.button_print_all.Click += new System.EventHandler(this.print_all_files_press4);
            // 
            // press5
            // 
            this.press5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.press5.BackColor = System.Drawing.SystemColors.Info;
            this.press5.Location = new System.Drawing.Point(12, 361);
            this.press5.Name = "press5";
            this.press5.Size = new System.Drawing.Size(99, 62);
            this.press5.TabIndex = 5;
            this.press5.Text = "Print the largest File";
            this.press5.UseVisualStyleBackColor = false;
            this.press5.Click += new System.EventHandler(this.print_the_largest_file_press6);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "file data :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "file data :";
            // 
            // TXT
            // 
            this.TXT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TXT.BackColor = System.Drawing.SystemColors.Info;
            this.TXT.Location = new System.Drawing.Point(173, 161);
            this.TXT.Name = "TXT";
            this.TXT.Size = new System.Drawing.Size(37, 19);
            this.TXT.TabIndex = 13;
            this.TXT.Text = "TXT";
            this.TXT.UseVisualStyleBackColor = false;
            this.TXT.Click += new System.EventHandler(this.TXT_Click);
            // 
            // DOC
            // 
            this.DOC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DOC.BackColor = System.Drawing.SystemColors.Info;
            this.DOC.Location = new System.Drawing.Point(216, 161);
            this.DOC.Name = "DOC";
            this.DOC.Size = new System.Drawing.Size(45, 19);
            this.DOC.TabIndex = 14;
            this.DOC.Text = "DOC";
            this.DOC.UseVisualStyleBackColor = false;
            this.DOC.Click += new System.EventHandler(this.DOC_Click);
            // 
            // docx
            // 
            this.docx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.docx.BackColor = System.Drawing.SystemColors.Info;
            this.docx.Location = new System.Drawing.Point(267, 161);
            this.docx.Name = "docx";
            this.docx.Size = new System.Drawing.Size(45, 19);
            this.docx.TabIndex = 15;
            this.docx.Text = "DOCX";
            this.docx.UseVisualStyleBackColor = false;
            this.docx.Click += new System.EventHandler(this.docx_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(316, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 19);
            this.button2.TabIndex = 16;
            this.button2.Text = "PDF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pptx
            // 
            this.pptx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pptx.BackColor = System.Drawing.SystemColors.Info;
            this.pptx.Location = new System.Drawing.Point(367, 161);
            this.pptx.Name = "pptx";
            this.pptx.Size = new System.Drawing.Size(45, 19);
            this.pptx.TabIndex = 17;
            this.pptx.Text = "PPTX";
            this.pptx.UseVisualStyleBackColor = false;
            this.pptx.Click += new System.EventHandler(this.pptx_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(443, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.add_a_file_press2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "file name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(116, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 62);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // listoftable
            // 
            this.listoftable.FormattingEnabled = true;
            this.listoftable.Location = new System.Drawing.Point(487, 59);
            this.listoftable.Margin = new System.Windows.Forms.Padding(2);
            this.listoftable.Name = "listoftable";
            this.listoftable.Size = new System.Drawing.Size(293, 342);
            this.listoftable.TabIndex = 20;
            // 
            // PRINTBYTYPE
            // 
            this.PRINTBYTYPE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PRINTBYTYPE.BackColor = System.Drawing.SystemColors.Info;
            this.PRINTBYTYPE.Location = new System.Drawing.Point(179, 311);
            this.PRINTBYTYPE.Name = "PRINTBYTYPE";
            this.PRINTBYTYPE.Size = new System.Drawing.Size(99, 44);
            this.PRINTBYTYPE.TabIndex = 21;
            this.PRINTBYTYPE.Text = "print files by type";
            this.PRINTBYTYPE.UseVisualStyleBackColor = false;
            this.PRINTBYTYPE.Click += new System.EventHandler(this.print_a_spec_type_of_filepress5);
            // 
            // PPTX2
            // 
            this.PPTX2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PPTX2.BackColor = System.Drawing.SystemColors.Info;
            this.PPTX2.Location = new System.Drawing.Point(128, 311);
            this.PPTX2.Name = "PPTX2";
            this.PPTX2.Size = new System.Drawing.Size(45, 19);
            this.PPTX2.TabIndex = 26;
            this.PPTX2.Text = "PPTX";
            this.PPTX2.UseVisualStyleBackColor = false;
            this.PPTX2.Click += new System.EventHandler(this.PPTX2_Click_1);
            // 
            // PDF2
            // 
            this.PDF2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PDF2.BackColor = System.Drawing.SystemColors.Info;
            this.PDF2.Location = new System.Drawing.Point(77, 336);
            this.PDF2.Name = "PDF2";
            this.PDF2.Size = new System.Drawing.Size(45, 19);
            this.PDF2.TabIndex = 25;
            this.PDF2.Text = "PDF";
            this.PDF2.UseVisualStyleBackColor = false;
            this.PDF2.Click += new System.EventHandler(this.PDF2_Click_1);
            // 
            // DOCX2
            // 
            this.DOCX2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DOCX2.BackColor = System.Drawing.SystemColors.Info;
            this.DOCX2.Location = new System.Drawing.Point(77, 311);
            this.DOCX2.Name = "DOCX2";
            this.DOCX2.Size = new System.Drawing.Size(45, 19);
            this.DOCX2.TabIndex = 24;
            this.DOCX2.Text = "DOCX";
            this.DOCX2.UseVisualStyleBackColor = false;
            this.DOCX2.Click += new System.EventHandler(this.DOCX2_Click_1);
            // 
            // DOC2
            // 
            this.DOC2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DOC2.BackColor = System.Drawing.SystemColors.Info;
            this.DOC2.Location = new System.Drawing.Point(128, 336);
            this.DOC2.Name = "DOC2";
            this.DOC2.Size = new System.Drawing.Size(45, 19);
            this.DOC2.TabIndex = 23;
            this.DOC2.Text = "DOC";
            this.DOC2.UseVisualStyleBackColor = false;
            this.DOC2.Click += new System.EventHandler(this.DOC2_Click_1);
            // 
            // TXT2
            // 
            this.TXT2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TXT2.BackColor = System.Drawing.SystemColors.Info;
            this.TXT2.Location = new System.Drawing.Point(26, 336);
            this.TXT2.Name = "TXT2";
            this.TXT2.Size = new System.Drawing.Size(45, 19);
            this.TXT2.TabIndex = 22;
            this.TXT2.Text = "TXT";
            this.TXT2.UseVisualStyleBackColor = false;
            this.TXT2.Click += new System.EventHandler(this.TXT2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Choose type :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PPTX2);
            this.Controls.Add(this.PDF2);
            this.Controls.Add(this.DOCX2);
            this.Controls.Add(this.DOC2);
            this.Controls.Add(this.TXT2);
            this.Controls.Add(this.PRINTBYTYPE);
            this.Controls.Add(this.listoftable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pptx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.docx);
            this.Controls.Add(this.DOC);
            this.Controls.Add(this.TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.press5);
            this.Controls.Add(this.button_print_all);
            this.Controls.Add(this.button_remove_file);
            this.Controls.Add(this.button_add_a_file);
            this.Controls.Add(this.button_add_defult);
            this.Controls.Add(this.labelemptylist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox labelemptylist;
        private System.Windows.Forms.Button button_add_defult;
        private System.Windows.Forms.Button button_add_a_file;
        private System.Windows.Forms.Button button_remove_file;
        private System.Windows.Forms.Button button_print_all;
        private System.Windows.Forms.Button press5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TXT;
        private System.Windows.Forms.Button DOC;
        private System.Windows.Forms.Button docx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button pptx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ListBox listoftable;
        private System.Windows.Forms.Button PRINTBYTYPE;
        private System.Windows.Forms.Button PPTX2;
        private System.Windows.Forms.Button PDF2;
        private System.Windows.Forms.Button DOCX2;
        private System.Windows.Forms.Button DOC2;
        private System.Windows.Forms.Button TXT2;
        private System.Windows.Forms.Label label4;
    }
}

