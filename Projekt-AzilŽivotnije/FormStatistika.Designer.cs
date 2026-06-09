namespace Projekt_AzilŽivotnije
{
    partial class FormStatistika
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
            this.listBoxStatistika = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lblTrenutno = new System.Windows.Forms.Label();
            this.lblUdomljeno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStatistika
            // 
            this.listBoxStatistika.FormattingEnabled = true;
            this.listBoxStatistika.ItemHeight = 16;
            this.listBoxStatistika.Location = new System.Drawing.Point(12, 12);
            this.listBoxStatistika.Name = "listBoxStatistika";
            this.listBoxStatistika.Size = new System.Drawing.Size(275, 212);
            this.listBoxStatistika.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProsjek.Location = new System.Drawing.Point(325, 13);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(95, 29);
            this.lblProsjek.TabIndex = 2;
            this.lblProsjek.Text = "Prosjek";
            this.lblProsjek.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupno.Location = new System.Drawing.Point(327, 52);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(96, 29);
            this.lblUkupno.TabIndex = 3;
            this.lblUkupno.Text = "Ukupno";
            // 
            // lblTrenutno
            // 
            this.lblTrenutno.AutoSize = true;
            this.lblTrenutno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutno.Location = new System.Drawing.Point(325, 91);
            this.lblTrenutno.Name = "lblTrenutno";
            this.lblTrenutno.Size = new System.Drawing.Size(110, 29);
            this.lblTrenutno.TabIndex = 4;
            this.lblTrenutno.Text = "Trenutno";
            // 
            // lblUdomljeno
            // 
            this.lblUdomljeno.AutoSize = true;
            this.lblUdomljeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUdomljeno.Location = new System.Drawing.Point(327, 133);
            this.lblUdomljeno.Name = "lblUdomljeno";
            this.lblUdomljeno.Size = new System.Drawing.Size(131, 29);
            this.lblUdomljeno.TabIndex = 5;
            this.lblUdomljeno.Text = "Udomljeno";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Izlaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Izvoz u Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUdomljeno);
            this.Controls.Add(this.lblTrenutno);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStatistika);
            this.Name = "FormStatistika";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormStatistika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStatistika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label lblTrenutno;
        private System.Windows.Forms.Label lblUdomljeno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}