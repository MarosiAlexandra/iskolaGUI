
namespace iskola_2022_02_11
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTörlés = new System.Windows.Forms.Button();
            this.btnMentés = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(76, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 264);
            this.listBox1.TabIndex = 0;
            // 
            // btnTörlés
            // 
            this.btnTörlés.Location = new System.Drawing.Point(76, 319);
            this.btnTörlés.Name = "btnTörlés";
            this.btnTörlés.Size = new System.Drawing.Size(102, 29);
            this.btnTörlés.TabIndex = 1;
            this.btnTörlés.Text = "törlés";
            this.btnTörlés.UseVisualStyleBackColor = true;
            // 
            // btnMentés
            // 
            this.btnMentés.Location = new System.Drawing.Point(188, 319);
            this.btnMentés.Name = "btnMentés";
            this.btnMentés.Size = new System.Drawing.Size(106, 29);
            this.btnMentés.TabIndex = 2;
            this.btnMentés.Text = "mentés";
            this.btnMentés.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 391);
            this.Controls.Add(this.btnMentés);
            this.Controls.Add(this.btnTörlés);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "iskolaGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTörlés;
        private System.Windows.Forms.Button btnMentés;
    }
}

