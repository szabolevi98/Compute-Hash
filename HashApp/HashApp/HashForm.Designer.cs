namespace HashApp
{
    partial class HashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashForm));
            this.textBoxSzoveg = new System.Windows.Forms.TextBox();
            this.textBoxMD5 = new System.Windows.Forms.TextBox();
            this.textBoxSHA1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxKisbetu = new System.Windows.Forms.CheckBox();
            this.md5Masol = new System.Windows.Forms.Button();
            this.sha1Masol = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonMegnyit = new System.Windows.Forms.Button();
            this.buttonMent = new System.Windows.Forms.Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBoxSzoveg
            // 
            this.textBoxSzoveg.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzoveg.Location = new System.Drawing.Point(52, 12);
            this.textBoxSzoveg.Name = "textBoxSzoveg";
            this.textBoxSzoveg.Size = new System.Drawing.Size(247, 20);
            this.textBoxSzoveg.TabIndex = 0;
            this.textBoxSzoveg.TextChanged += new System.EventHandler(this.textBoxSzoveg_TextChanged);
            // 
            // textBoxMD5
            // 
            this.textBoxMD5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMD5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMD5.Location = new System.Drawing.Point(52, 38);
            this.textBoxMD5.Name = "textBoxMD5";
            this.textBoxMD5.ReadOnly = true;
            this.textBoxMD5.Size = new System.Drawing.Size(247, 20);
            this.textBoxMD5.TabIndex = 1;
            // 
            // textBoxSHA1
            // 
            this.textBoxSHA1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSHA1.Location = new System.Drawing.Point(52, 64);
            this.textBoxSHA1.Name = "textBoxSHA1";
            this.textBoxSHA1.ReadOnly = true;
            this.textBoxSHA1.Size = new System.Drawing.Size(247, 20);
            this.textBoxSHA1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Szöveg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MD5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SHA-1";
            // 
            // checkBoxKisbetu
            // 
            this.checkBoxKisbetu.AutoSize = true;
            this.checkBoxKisbetu.Location = new System.Drawing.Point(305, 14);
            this.checkBoxKisbetu.Name = "checkBoxKisbetu";
            this.checkBoxKisbetu.Size = new System.Drawing.Size(61, 17);
            this.checkBoxKisbetu.TabIndex = 7;
            this.checkBoxKisbetu.Text = "Kisbetű";
            this.checkBoxKisbetu.UseVisualStyleBackColor = true;
            this.checkBoxKisbetu.CheckedChanged += new System.EventHandler(this.checkBoxKisbetu_CheckedChanged);
            // 
            // md5Masol
            // 
            this.md5Masol.Location = new System.Drawing.Point(305, 38);
            this.md5Masol.Name = "md5Masol";
            this.md5Masol.Size = new System.Drawing.Size(56, 20);
            this.md5Masol.TabIndex = 8;
            this.md5Masol.Text = "Másol";
            this.md5Masol.UseVisualStyleBackColor = true;
            this.md5Masol.Click += new System.EventHandler(this.md5Masol_Click);
            // 
            // sha1Masol
            // 
            this.sha1Masol.Location = new System.Drawing.Point(305, 64);
            this.sha1Masol.Name = "sha1Masol";
            this.sha1Masol.Size = new System.Drawing.Size(56, 20);
            this.sha1Masol.TabIndex = 9;
            this.sha1Masol.Text = "Másol";
            this.sha1Masol.UseVisualStyleBackColor = true;
            this.sha1Masol.Click += new System.EventHandler(this.sha1Masol_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // buttonMegnyit
            // 
            this.buttonMegnyit.Location = new System.Drawing.Point(9, 90);
            this.buttonMegnyit.Name = "buttonMegnyit";
            this.buttonMegnyit.Size = new System.Drawing.Size(88, 23);
            this.buttonMegnyit.TabIndex = 10;
            this.buttonMegnyit.Text = "Fájl megnyitása";
            this.buttonMegnyit.UseVisualStyleBackColor = true;
            this.buttonMegnyit.Click += new System.EventHandler(this.buttonMegnyit_Click);
            // 
            // buttonMent
            // 
            this.buttonMent.Location = new System.Drawing.Point(103, 90);
            this.buttonMent.Name = "buttonMent";
            this.buttonMent.Size = new System.Drawing.Size(86, 23);
            this.buttonMent.TabIndex = 11;
            this.buttonMent.Text = "Mentés txt-be";
            this.buttonMent.UseVisualStyleBackColor = true;
            this.buttonMent.Click += new System.EventHandler(this.buttonMent_Click);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(264, 97);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(94, 13);
            this.labelCopyright.TabIndex = 12;
            this.labelCopyright.Text = "Copyright template";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "hash.txt";
            this.saveFileDialog.Filter = "Szöveges fájl .txt|*.txt";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // HashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 122);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.buttonMent);
            this.Controls.Add(this.buttonMegnyit);
            this.Controls.Add(this.sha1Masol);
            this.Controls.Add(this.md5Masol);
            this.Controls.Add(this.checkBoxKisbetu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSHA1);
            this.Controls.Add(this.textBoxMD5);
            this.Controls.Add(this.textBoxSzoveg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash számítás";
            this.Load += new System.EventHandler(this.HashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSzoveg;
        private System.Windows.Forms.TextBox textBoxMD5;
        private System.Windows.Forms.TextBox textBoxSHA1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxKisbetu;
        private System.Windows.Forms.Button md5Masol;
        private System.Windows.Forms.Button sha1Masol;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonMegnyit;
        private System.Windows.Forms.Button buttonMent;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

