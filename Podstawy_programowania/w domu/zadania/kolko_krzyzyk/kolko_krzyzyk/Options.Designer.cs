namespace kolko_krzyzyk
{
    partial class Options
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
            this.lblColorO = new System.Windows.Forms.Label();
            this.lblColorX = new System.Windows.Forms.Label();
            this.btnColorO = new System.Windows.Forms.Button();
            this.btnColorX = new System.Windows.Forms.Button();
            this.lblO1 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblResultO = new System.Windows.Forms.Label();
            this.lblResultX = new System.Windows.Forms.Label();
            this.btnResultPlusO = new System.Windows.Forms.Button();
            this.btnResultMinusO = new System.Windows.Forms.Button();
            this.btnResultMinusX = new System.Windows.Forms.Button();
            this.btnResultPlusX = new System.Windows.Forms.Button();
            this.btnOptionsOK = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnOptionsAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblColorO
            // 
            this.lblColorO.AutoSize = true;
            this.lblColorO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblColorO.Location = new System.Drawing.Point(12, 23);
            this.lblColorO.Name = "lblColorO";
            this.lblColorO.Size = new System.Drawing.Size(163, 20);
            this.lblColorO.TabIndex = 0;
            this.lblColorO.Text = "Zmień kolor gracza O:";
            // 
            // lblColorX
            // 
            this.lblColorX.AutoSize = true;
            this.lblColorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblColorX.Location = new System.Drawing.Point(12, 79);
            this.lblColorX.Name = "lblColorX";
            this.lblColorX.Size = new System.Drawing.Size(162, 20);
            this.lblColorX.TabIndex = 1;
            this.lblColorX.Text = "Zmień kolor gracza X:";
            // 
            // btnColorO
            // 
            this.btnColorO.Location = new System.Drawing.Point(181, 9);
            this.btnColorO.Name = "btnColorO";
            this.btnColorO.Size = new System.Drawing.Size(50, 50);
            this.btnColorO.TabIndex = 2;
            this.btnColorO.Text = "O";
            this.btnColorO.UseVisualStyleBackColor = true;
            this.btnColorO.Click += new System.EventHandler(this.btnColorO_Click);
            // 
            // btnColorX
            // 
            this.btnColorX.Location = new System.Drawing.Point(181, 65);
            this.btnColorX.Name = "btnColorX";
            this.btnColorX.Size = new System.Drawing.Size(50, 50);
            this.btnColorX.TabIndex = 3;
            this.btnColorX.Text = "X";
            this.btnColorX.UseVisualStyleBackColor = true;
            this.btnColorX.Click += new System.EventHandler(this.btnColorX_Click);
            // 
            // lblO1
            // 
            this.lblO1.AutoSize = true;
            this.lblO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblO1.Location = new System.Drawing.Point(12, 137);
            this.lblO1.Name = "lblO1";
            this.lblO1.Size = new System.Drawing.Size(167, 20);
            this.lblO1.TabIndex = 4;
            this.lblO1.Text = "Zmień wynik gracza O:";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX1.Location = new System.Drawing.Point(12, 184);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(166, 20);
            this.lblX1.TabIndex = 5;
            this.lblX1.Text = "Zmień wynik gracza X:";
            // 
            // lblResultO
            // 
            this.lblResultO.AutoSize = true;
            this.lblResultO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResultO.Location = new System.Drawing.Point(175, 137);
            this.lblResultO.Name = "lblResultO";
            this.lblResultO.Size = new System.Drawing.Size(18, 20);
            this.lblResultO.TabIndex = 6;
            this.lblResultO.Text = "0";
            // 
            // lblResultX
            // 
            this.lblResultX.AutoSize = true;
            this.lblResultX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResultX.Location = new System.Drawing.Point(175, 184);
            this.lblResultX.Name = "lblResultX";
            this.lblResultX.Size = new System.Drawing.Size(18, 20);
            this.lblResultX.TabIndex = 7;
            this.lblResultX.Text = "0";
            // 
            // btnResultPlusO
            // 
            this.btnResultPlusO.Location = new System.Drawing.Point(191, 138);
            this.btnResultPlusO.Name = "btnResultPlusO";
            this.btnResultPlusO.Size = new System.Drawing.Size(20, 20);
            this.btnResultPlusO.TabIndex = 8;
            this.btnResultPlusO.Text = "+";
            this.btnResultPlusO.UseVisualStyleBackColor = true;
            this.btnResultPlusO.Click += new System.EventHandler(this.btnResultPlusO_Click);
            // 
            // btnResultMinusO
            // 
            this.btnResultMinusO.Location = new System.Drawing.Point(211, 138);
            this.btnResultMinusO.Name = "btnResultMinusO";
            this.btnResultMinusO.Size = new System.Drawing.Size(20, 20);
            this.btnResultMinusO.TabIndex = 9;
            this.btnResultMinusO.Text = "-";
            this.btnResultMinusO.UseVisualStyleBackColor = true;
            this.btnResultMinusO.Click += new System.EventHandler(this.btnResultMinusO_Click);
            // 
            // btnResultMinusX
            // 
            this.btnResultMinusX.Location = new System.Drawing.Point(211, 184);
            this.btnResultMinusX.Name = "btnResultMinusX";
            this.btnResultMinusX.Size = new System.Drawing.Size(20, 20);
            this.btnResultMinusX.TabIndex = 11;
            this.btnResultMinusX.Text = "-";
            this.btnResultMinusX.UseVisualStyleBackColor = true;
            this.btnResultMinusX.Click += new System.EventHandler(this.btnResultMinusX_Click);
            // 
            // btnResultPlusX
            // 
            this.btnResultPlusX.Location = new System.Drawing.Point(191, 184);
            this.btnResultPlusX.Name = "btnResultPlusX";
            this.btnResultPlusX.Size = new System.Drawing.Size(20, 20);
            this.btnResultPlusX.TabIndex = 10;
            this.btnResultPlusX.Text = "+";
            this.btnResultPlusX.UseVisualStyleBackColor = true;
            this.btnResultPlusX.Click += new System.EventHandler(this.btnResultPlusX_Click);
            // 
            // btnOptionsOK
            // 
            this.btnOptionsOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOptionsOK.Location = new System.Drawing.Point(26, 225);
            this.btnOptionsOK.Name = "btnOptionsOK";
            this.btnOptionsOK.Size = new System.Drawing.Size(87, 38);
            this.btnOptionsOK.TabIndex = 12;
            this.btnOptionsOK.Text = "OK";
            this.btnOptionsOK.UseVisualStyleBackColor = true;
            this.btnOptionsOK.Click += new System.EventHandler(this.btnOptionsOK_Click);
            // 
            // btnOptionsAnuluj
            // 
            this.btnOptionsAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOptionsAnuluj.Location = new System.Drawing.Point(134, 225);
            this.btnOptionsAnuluj.Name = "btnOptionsAnuluj";
            this.btnOptionsAnuluj.Size = new System.Drawing.Size(87, 38);
            this.btnOptionsAnuluj.TabIndex = 13;
            this.btnOptionsAnuluj.Text = "Anuluj";
            this.btnOptionsAnuluj.UseVisualStyleBackColor = true;
            this.btnOptionsAnuluj.Click += new System.EventHandler(this.btnOptionsAnuluj_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.btnOptionsOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 279);
            this.Controls.Add(this.btnOptionsAnuluj);
            this.Controls.Add(this.btnOptionsOK);
            this.Controls.Add(this.btnResultMinusX);
            this.Controls.Add(this.btnResultPlusX);
            this.Controls.Add(this.btnResultMinusO);
            this.Controls.Add(this.btnResultPlusO);
            this.Controls.Add(this.lblResultX);
            this.Controls.Add(this.lblResultO);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.lblO1);
            this.Controls.Add(this.btnColorX);
            this.Controls.Add(this.btnColorO);
            this.Controls.Add(this.lblColorX);
            this.Controls.Add(this.lblColorO);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(266, 318);
            this.MinimumSize = new System.Drawing.Size(266, 318);
            this.Name = "Options";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblColorX;
        private System.Windows.Forms.Label lblO1;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblResultO;
        private System.Windows.Forms.Label lblResultX;
        private System.Windows.Forms.Button btnResultPlusO;
        private System.Windows.Forms.Button btnResultMinusO;
        private System.Windows.Forms.Button btnResultMinusX;
        private System.Windows.Forms.Button btnResultPlusX;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Button btnOptionsOK;
        public System.Windows.Forms.Button btnColorO;
        public System.Windows.Forms.Button btnColorX;
        public System.Windows.Forms.Button btnOptionsAnuluj;
        public System.Windows.Forms.Label lblColorO;
    }
}