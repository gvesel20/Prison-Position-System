
namespace Prison_Position_System
{
    partial class Form4
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPretraživanje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrisanjePojave = new System.Windows.Forms.Button();
            this.buttonPromjenaDopuštenosti = new System.Windows.Forms.Button();
            this.dataGridViewPojave = new System.Windows.Forms.DataGridView();
            this.dataGridViewMobiteli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPojave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMobiteli)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(803, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 57);
            this.button2.TabIndex = 15;
            this.button2.Text = "Ponovno prikaži sve pojave";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPretraživanje
            // 
            this.textBoxPretraživanje.Location = new System.Drawing.Point(556, 347);
            this.textBoxPretraživanje.Name = "textBoxPretraživanje";
            this.textBoxPretraživanje.Size = new System.Drawing.Size(138, 22);
            this.textBoxPretraživanje.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pretraživanje po ID-u mobitela";
            // 
            // buttonBrisanjePojave
            // 
            this.buttonBrisanjePojave.Location = new System.Drawing.Point(420, 313);
            this.buttonBrisanjePojave.Name = "buttonBrisanjePojave";
            this.buttonBrisanjePojave.Size = new System.Drawing.Size(100, 56);
            this.buttonBrisanjePojave.TabIndex = 11;
            this.buttonBrisanjePojave.Text = "Brisanje pojave";
            this.buttonBrisanjePojave.UseVisualStyleBackColor = true;
            this.buttonBrisanjePojave.Click += new System.EventHandler(this.buttonBrisanjePojave_Click);
            // 
            // buttonPromjenaDopuštenosti
            // 
            this.buttonPromjenaDopuštenosti.Location = new System.Drawing.Point(12, 313);
            this.buttonPromjenaDopuštenosti.Name = "buttonPromjenaDopuštenosti";
            this.buttonPromjenaDopuštenosti.Size = new System.Drawing.Size(100, 56);
            this.buttonPromjenaDopuštenosti.TabIndex = 10;
            this.buttonPromjenaDopuštenosti.Text = "Promjena dopuštenosti";
            this.buttonPromjenaDopuštenosti.UseVisualStyleBackColor = true;
            this.buttonPromjenaDopuštenosti.Click += new System.EventHandler(this.buttonPromjenaDopuštenosti_Click);
            // 
            // dataGridViewPojave
            // 
            this.dataGridViewPojave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPojave.Location = new System.Drawing.Point(420, 12);
            this.dataGridViewPojave.Name = "dataGridViewPojave";
            this.dataGridViewPojave.RowHeadersWidth = 51;
            this.dataGridViewPojave.RowTemplate.Height = 24;
            this.dataGridViewPojave.Size = new System.Drawing.Size(843, 273);
            this.dataGridViewPojave.TabIndex = 9;
            // 
            // dataGridViewMobiteli
            // 
            this.dataGridViewMobiteli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMobiteli.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMobiteli.Name = "dataGridViewMobiteli";
            this.dataGridViewMobiteli.RowHeadersWidth = 51;
            this.dataGridViewMobiteli.RowTemplate.Height = 24;
            this.dataGridViewMobiteli.Size = new System.Drawing.Size(373, 273);
            this.dataGridViewMobiteli.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPretraživanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrisanjePojave);
            this.Controls.Add(this.buttonPromjenaDopuštenosti);
            this.Controls.Add(this.dataGridViewPojave);
            this.Controls.Add(this.dataGridViewMobiteli);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPojave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMobiteli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPretraživanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrisanjePojave;
        private System.Windows.Forms.Button buttonPromjenaDopuštenosti;
        private System.Windows.Forms.DataGridView dataGridViewPojave;
        private System.Windows.Forms.DataGridView dataGridViewMobiteli;
    }
}