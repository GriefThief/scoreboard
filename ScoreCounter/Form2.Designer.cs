
namespace ScoreCounter
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
            this.bank = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.winBtn = new System.Windows.Forms.Button();
            this.bankBtn = new System.Windows.Forms.Button();
            this.loseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bank
            // 
            this.bank.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank.Location = new System.Drawing.Point(124, 163);
            this.bank.Name = "bank";
            this.bank.ReadOnly = true;
            this.bank.Size = new System.Drawing.Size(100, 27);
            this.bank.TabIndex = 0;
            this.bank.TabStop = false;
            this.bank.Text = "£0";
            this.bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Winnings:";
            // 
            // pot
            // 
            this.pot.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pot.Location = new System.Drawing.Point(112, 53);
            this.pot.Name = "pot";
            this.pot.ReadOnly = true;
            this.pot.Size = new System.Drawing.Size(112, 27);
            this.pot.TabIndex = 2;
            this.pot.TabStop = false;
            this.pot.Text = "£0";
            this.pot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "TEAM 1";
            // 
            // winBtn
            // 
            this.winBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winBtn.Location = new System.Drawing.Point(12, 86);
            this.winBtn.Name = "winBtn";
            this.winBtn.Size = new System.Drawing.Size(100, 40);
            this.winBtn.TabIndex = 1;
            this.winBtn.Text = "Win";
            this.winBtn.UseVisualStyleBackColor = true;
            this.winBtn.Click += new System.EventHandler(this.submitPnts_Click);
            // 
            // bankBtn
            // 
            this.bankBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankBtn.Location = new System.Drawing.Point(12, 150);
            this.bankBtn.Name = "bankBtn";
            this.bankBtn.Size = new System.Drawing.Size(100, 40);
            this.bankBtn.TabIndex = 2;
            this.bankBtn.Text = "Bank";
            this.bankBtn.UseVisualStyleBackColor = true;
            this.bankBtn.Click += new System.EventHandler(this.bankBtn_Click);
            // 
            // loseBtn
            // 
            this.loseBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseBtn.Location = new System.Drawing.Point(124, 86);
            this.loseBtn.Name = "loseBtn";
            this.loseBtn.Size = new System.Drawing.Size(100, 40);
            this.loseBtn.TabIndex = 5;
            this.loseBtn.Text = "Lose";
            this.loseBtn.UseVisualStyleBackColor = true;
            this.loseBtn.Click += new System.EventHandler(this.loseBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 217);
            this.Controls.Add(this.loseBtn);
            this.Controls.Add(this.bankBtn);
            this.Controls.Add(this.winBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bank);
            this.MinimumSize = new System.Drawing.Size(264, 256);
            this.Name = "Form2";
            this.Text = "TEAM NAME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button winBtn;
        private System.Windows.Forms.Button bankBtn;
        private System.Windows.Forms.Button loseBtn;
    }
}