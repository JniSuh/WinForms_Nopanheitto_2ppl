namespace Nopanheitto_2ppl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxDice2 = new System.Windows.Forms.PictureBox();
            this.btnThrow = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.picBoxDice1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelaaja 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(460, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelaaja 2";
            // 
            // picBoxDice2
            // 
            this.picBoxDice2.Image = global::Nopanheitto_2ppl.DiceFaces.DiceFaces._1;
            this.picBoxDice2.Location = new System.Drawing.Point(239, 170);
            this.picBoxDice2.Name = "picBoxDice2";
            this.picBoxDice2.Size = new System.Drawing.Size(60, 60);
            this.picBoxDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDice2.TabIndex = 2;
            this.picBoxDice2.TabStop = false;
            this.picBoxDice2.Visible = false;
            // 
            // btnThrow
            // 
            this.btnThrow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThrow.Location = new System.Drawing.Point(221, 236);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(91, 48);
            this.btnThrow.TabIndex = 3;
            this.btnThrow.Text = "Heitä noppaa";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWinner.Location = new System.Drawing.Point(199, 12);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(157, 18);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "Voittaja: Pelaaja1";
            this.lblWinner.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(12, 257);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Nollaa";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picBoxDice1
            // 
            this.picBoxDice1.Image = global::Nopanheitto_2ppl.DiceFaces.DiceFaces._1;
            this.picBoxDice1.Location = new System.Drawing.Point(239, 170);
            this.picBoxDice1.Name = "picBoxDice1";
            this.picBoxDice1.Size = new System.Drawing.Size(60, 60);
            this.picBoxDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDice1.TabIndex = 6;
            this.picBoxDice1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 298);
            this.Controls.Add(this.picBoxDice1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.picBoxDice2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxDice2;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picBoxDice1;
    }
}
