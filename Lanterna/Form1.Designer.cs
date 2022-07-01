namespace Lanterna
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBateria = new System.Windows.Forms.Label();
            this.btnLigaDesliga = new System.Windows.Forms.Button();
            this.btnTrocarBateria = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(71, 44);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(19, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bateria:";
            // 
            // lblBateria
            // 
            this.lblBateria.AutoSize = true;
            this.lblBateria.Location = new System.Drawing.Point(74, 71);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(19, 13);
            this.lblBateria.TabIndex = 3;
            this.lblBateria.Text = "....";
            // 
            // btnLigaDesliga
            // 
            this.btnLigaDesliga.Location = new System.Drawing.Point(27, 147);
            this.btnLigaDesliga.Name = "btnLigaDesliga";
            this.btnLigaDesliga.Size = new System.Drawing.Size(133, 23);
            this.btnLigaDesliga.TabIndex = 4;
            this.btnLigaDesliga.Text = "Liga/Desliga";
            this.btnLigaDesliga.UseVisualStyleBackColor = true;
            this.btnLigaDesliga.Click += new System.EventHandler(this.btnLigaDesliga_Click);
            // 
            // btnTrocarBateria
            // 
            this.btnTrocarBateria.Location = new System.Drawing.Point(185, 147);
            this.btnTrocarBateria.Name = "btnTrocarBateria";
            this.btnTrocarBateria.Size = new System.Drawing.Size(137, 23);
            this.btnTrocarBateria.TabIndex = 5;
            this.btnTrocarBateria.Text = "Trocar Bateria";
            this.btnTrocarBateria.UseVisualStyleBackColor = true;
            this.btnTrocarBateria.Click += new System.EventHandler(this.btnTrocarBateria_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrocarBateria);
            this.Controls.Add(this.btnLigaDesliga);
            this.Controls.Add(this.lblBateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lanterna";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.Button btnLigaDesliga;
        private System.Windows.Forms.Button btnTrocarBateria;
        private System.Windows.Forms.Timer timer1;
    }
}

