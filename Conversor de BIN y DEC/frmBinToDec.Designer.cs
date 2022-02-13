namespace Conversor_de_BIN_y_DEC
{
    partial class frmBinToDec
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvertBaD = new System.Windows.Forms.Button();
            this.btnVolverDashboard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(202, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decimal - Resultado";
            // 
            // txtBinario
            // 
            this.txtBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtBinario.Location = new System.Drawing.Point(205, 79);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(150, 38);
            this.txtBinario.TabIndex = 1;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtDecimal.Location = new System.Drawing.Point(205, 146);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(150, 38);
            this.txtDecimal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(202, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Binario - A Convertir";
            // 
            // btnConvertBaD
            // 
            this.btnConvertBaD.BackColor = System.Drawing.Color.Transparent;
            this.btnConvertBaD.BackgroundImage = global::Conversor_de_BIN_y_DEC.Properties.Resources.logo;
            this.btnConvertBaD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConvertBaD.FlatAppearance.BorderSize = 0;
            this.btnConvertBaD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertBaD.Location = new System.Drawing.Point(33, 163);
            this.btnConvertBaD.Name = "btnConvertBaD";
            this.btnConvertBaD.Size = new System.Drawing.Size(96, 96);
            this.btnConvertBaD.TabIndex = 4;
            this.btnConvertBaD.UseVisualStyleBackColor = false;
            this.btnConvertBaD.Click += new System.EventHandler(this.btnConvertBaD_Click);
            // 
            // btnVolverDashboard
            // 
            this.btnVolverDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverDashboard.BackgroundImage = global::Conversor_de_BIN_y_DEC.Properties.Resources._61449;
            this.btnVolverDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverDashboard.FlatAppearance.BorderSize = 0;
            this.btnVolverDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverDashboard.Location = new System.Drawing.Point(432, 163);
            this.btnVolverDashboard.Name = "btnVolverDashboard";
            this.btnVolverDashboard.Size = new System.Drawing.Size(96, 96);
            this.btnVolverDashboard.TabIndex = 5;
            this.btnVolverDashboard.UseVisualStyleBackColor = false;
            this.btnVolverDashboard.Click += new System.EventHandler(this.btnVolverDashboard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Convertir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Volver";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(105, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Conversor de Binario a Decimal";
            // 
            // frmBinToDec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Conversor_de_BIN_y_DEC.Properties.Resources.bintodec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 284);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolverDashboard);
            this.Controls.Add(this.btnConvertBaD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBinToDec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binario a Decimal";
            this.Load += new System.EventHandler(this.frmBinToDec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvertBaD;
        private System.Windows.Forms.Button btnVolverDashboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}