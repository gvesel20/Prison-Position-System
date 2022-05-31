
namespace Prison_Position_System
{
    partial class Form2
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
            this.checkBoxAktivan = new System.Windows.Forms.CheckBox();
            this.buttonDodajTlocrt = new System.Windows.Forms.Button();
            this.textBoxIdTlocrta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDužina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxŠirina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxAktivan
            // 
            this.checkBoxAktivan.AutoSize = true;
            this.checkBoxAktivan.Location = new System.Drawing.Point(299, 329);
            this.checkBoxAktivan.Name = "checkBoxAktivan";
            this.checkBoxAktivan.Size = new System.Drawing.Size(187, 21);
            this.checkBoxAktivan.TabIndex = 19;
            this.checkBoxAktivan.Text = "Postavi tlocrt kao aktivan";
            this.checkBoxAktivan.UseVisualStyleBackColor = true;
            // 
            // buttonDodajTlocrt
            // 
            this.buttonDodajTlocrt.Location = new System.Drawing.Point(141, 329);
            this.buttonDodajTlocrt.Name = "buttonDodajTlocrt";
            this.buttonDodajTlocrt.Size = new System.Drawing.Size(124, 34);
            this.buttonDodajTlocrt.TabIndex = 18;
            this.buttonDodajTlocrt.Text = "Dodaj tlocrt";
            this.buttonDodajTlocrt.UseVisualStyleBackColor = true;
            this.buttonDodajTlocrt.Click += new System.EventHandler(this.buttonDodajTlocrt_Click);
            // 
            // textBoxIdTlocrta
            // 
            this.textBoxIdTlocrta.Location = new System.Drawing.Point(141, 109);
            this.textBoxIdTlocrta.Name = "textBoxIdTlocrta";
            this.textBoxIdTlocrta.Size = new System.Drawing.Size(92, 22);
            this.textBoxIdTlocrta.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "IdTlocrta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dodavanje tlocrta";
            // 
            // textBoxDužina
            // 
            this.textBoxDužina.Location = new System.Drawing.Point(141, 245);
            this.textBoxDužina.Name = "textBoxDužina";
            this.textBoxDužina.Size = new System.Drawing.Size(92, 22);
            this.textBoxDužina.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dužina tlocrta (m)";
            // 
            // textBoxŠirina
            // 
            this.textBoxŠirina.Location = new System.Drawing.Point(141, 179);
            this.textBoxŠirina.Name = "textBoxŠirina";
            this.textBoxŠirina.Size = new System.Drawing.Size(92, 22);
            this.textBoxŠirina.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Širina tlocrta (m)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 398);
            this.Controls.Add(this.checkBoxAktivan);
            this.Controls.Add(this.buttonDodajTlocrt);
            this.Controls.Add(this.textBoxIdTlocrta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDužina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxŠirina);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAktivan;
        private System.Windows.Forms.Button buttonDodajTlocrt;
        private System.Windows.Forms.TextBox textBoxIdTlocrta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDužina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxŠirina;
        private System.Windows.Forms.Label label1;
    }
}