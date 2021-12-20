
namespace BlackJack_SilasDannullis
{
    partial class AantalSpelers
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
            this.Punten = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Button();
            this.Stand = new System.Windows.Forms.Button();
            this.DealerPunten = new System.Windows.Forms.Label();
            this.ResultaatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Punten
            // 
            this.Punten.AutoSize = true;
            this.Punten.Location = new System.Drawing.Point(713, 482);
            this.Punten.Name = "Punten";
            this.Punten.Size = new System.Drawing.Size(0, 21);
            this.Punten.TabIndex = 1;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(88, 483);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 2;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Stand
            // 
            this.Stand.Location = new System.Drawing.Point(241, 482);
            this.Stand.Name = "Stand";
            this.Stand.Size = new System.Drawing.Size(75, 23);
            this.Stand.TabIndex = 3;
            this.Stand.Text = "Stand";
            this.Stand.UseVisualStyleBackColor = true;
            this.Stand.Click += new System.EventHandler(this.Stand_Click);
            // 
            // DealerPunten
            // 
            this.DealerPunten.AutoSize = true;
            this.DealerPunten.Location = new System.Drawing.Point(713, 165);
            this.DealerPunten.Name = "DealerPunten";
            this.DealerPunten.Size = new System.Drawing.Size(0, 17);
            this.DealerPunten.TabIndex = 4;
            // 
            // ResultaatLabel
            // 
            this.ResultaatLabel.AutoSize = true;
            this.ResultaatLabel.Location = new System.Drawing.Point(404, 282);
            this.ResultaatLabel.Name = "ResultaatLabel";
            this.ResultaatLabel.Size = new System.Drawing.Size(0, 21);
            this.ResultaatLabel.TabIndex = 5;
            // 
            // AantalSpelers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 747);
            this.Controls.Add(this.ResultaatLabel);
            this.Controls.Add(this.DealerPunten);
            this.Controls.Add(this.Stand);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.Punten);
            this.Name = "AantalSpelers";
            this.Text = "Aantal spelers";
            this.Load += new System.EventHandler(this.AantalSpelers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Punten;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Button Stand;
        private System.Windows.Forms.Label DealerPunten;
        private System.Windows.Forms.Label ResultaatLabel;
    }
}

