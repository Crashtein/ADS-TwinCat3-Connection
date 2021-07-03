
namespace ADSTwinCat3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectBox = new System.Windows.Forms.TextBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ReadBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConnectBox
            // 
            this.ConnectBox.Location = new System.Drawing.Point(14, 14);
            this.ConnectBox.Name = "ConnectBox";
            this.ConnectBox.ReadOnly = true;
            this.ConnectBox.Size = new System.Drawing.Size(774, 20);
            this.ConnectBox.TabIndex = 0;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(14, 113);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(156, 41);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(13, 40);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(157, 41);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ReadBox
            // 
            this.ReadBox.Enabled = false;
            this.ReadBox.Location = new System.Drawing.Point(14, 87);
            this.ReadBox.Name = "ReadBox";
            this.ReadBox.ReadOnly = true;
            this.ReadBox.Size = new System.Drawing.Size(774, 20);
            this.ReadBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReadBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.ConnectBox);
            this.Name = "Form1";
            this.Text = "ADS Connect TwinCat 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConnectBox;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ReadBox;
    }
}

