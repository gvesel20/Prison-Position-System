
namespace Prison_Position_System
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
            this.buttonDodavanjeTlocrta = new System.Windows.Forms.Button();
            this.buttonSimulacija = new System.Windows.Forms.Button();
            this.buttonPregledMobitela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodavanjeTlocrta
            // 
            this.buttonDodavanjeTlocrta.Location = new System.Drawing.Point(133, 59);
            this.buttonDodavanjeTlocrta.Name = "buttonDodavanjeTlocrta";
            this.buttonDodavanjeTlocrta.Size = new System.Drawing.Size(111, 44);
            this.buttonDodavanjeTlocrta.TabIndex = 1;
            this.buttonDodavanjeTlocrta.Text = "Dodavanje tlocrta";
            this.buttonDodavanjeTlocrta.UseVisualStyleBackColor = true;
            this.buttonDodavanjeTlocrta.Click += new System.EventHandler(this.buttonDodavanjeTlocrta_Click);
            // 
            // buttonSimulacija
            // 
            this.buttonSimulacija.Location = new System.Drawing.Point(133, 160);
            this.buttonSimulacija.Name = "buttonSimulacija";
            this.buttonSimulacija.Size = new System.Drawing.Size(111, 67);
            this.buttonSimulacija.TabIndex = 2;
            this.buttonSimulacija.Text = "Simulacija pojave mobitela";
            this.buttonSimulacija.UseVisualStyleBackColor = true;
            this.buttonSimulacija.Click += new System.EventHandler(this.buttonSimulacija_Click);
            // 
            // buttonPregledMobitela
            // 
            this.buttonPregledMobitela.Location = new System.Drawing.Point(133, 283);
            this.buttonPregledMobitela.Name = "buttonPregledMobitela";
            this.buttonPregledMobitela.Size = new System.Drawing.Size(111, 62);
            this.buttonPregledMobitela.TabIndex = 3;
            this.buttonPregledMobitela.Text = "Pregled mobilnih uređaja";
            this.buttonPregledMobitela.UseVisualStyleBackColor = true;
            this.buttonPregledMobitela.Click += new System.EventHandler(this.buttonPregledMobitela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.buttonPregledMobitela);
            this.Controls.Add(this.buttonSimulacija);
            this.Controls.Add(this.buttonDodavanjeTlocrta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDodavanjeTlocrta;
        private System.Windows.Forms.Button buttonSimulacija;
        private System.Windows.Forms.Button buttonPregledMobitela;
    }
}

