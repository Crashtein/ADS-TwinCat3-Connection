
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
            this.label1 = new System.Windows.Forms.Label();
            this.NBytesBox = new System.Windows.Forms.NumericUpDown();
            this.AreaBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ReadByNameButton = new System.Windows.Forms.Button();
            this.VarNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NBytesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectBox
            // 
            this.ConnectBox.Location = new System.Drawing.Point(655, 14);
            this.ConnectBox.Name = "ConnectBox";
            this.ConnectBox.ReadOnly = true;
            this.ConnectBox.Size = new System.Drawing.Size(133, 20);
            this.ConnectBox.TabIndex = 0;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(12, 12);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(71, 41);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(581, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(68, 41);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ReadBox
            // 
            this.ReadBox.Location = new System.Drawing.Point(14, 59);
            this.ReadBox.Multiline = true;
            this.ReadBox.Name = "ReadBox";
            this.ReadBox.ReadOnly = true;
            this.ReadBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReadBox.Size = new System.Drawing.Size(774, 379);
            this.ReadBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NBytes";
            // 
            // NBytesBox
            // 
            this.NBytesBox.Location = new System.Drawing.Point(93, 32);
            this.NBytesBox.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.NBytesBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NBytesBox.Name = "NBytesBox";
            this.NBytesBox.Size = new System.Drawing.Size(79, 20);
            this.NBytesBox.TabIndex = 5;
            this.NBytesBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // AreaBox
            // 
            this.AreaBox.Location = new System.Drawing.Point(182, 33);
            this.AreaBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.AreaBox.Name = "AreaBox";
            this.AreaBox.Size = new System.Drawing.Size(79, 20);
            this.AreaBox.TabIndex = 7;
            this.AreaBox.Value = new decimal(new int[] {
            16416,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Area";
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(267, 33);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(79, 20);
            this.TypeBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type";
            // 
            // ReadByNameButton
            // 
            this.ReadByNameButton.Location = new System.Drawing.Point(352, 11);
            this.ReadByNameButton.Name = "ReadByNameButton";
            this.ReadByNameButton.Size = new System.Drawing.Size(71, 41);
            this.ReadByNameButton.TabIndex = 10;
            this.ReadByNameButton.Text = "Read by Name";
            this.ReadByNameButton.UseVisualStyleBackColor = true;
            this.ReadByNameButton.Click += new System.EventHandler(this.ReadByNameButton_Click);
            // 
            // VarNameBox
            // 
            this.VarNameBox.Location = new System.Drawing.Point(429, 33);
            this.VarNameBox.Name = "VarNameBox";
            this.VarNameBox.Size = new System.Drawing.Size(146, 20);
            this.VarNameBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Var Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VarNameBox);
            this.Controls.Add(this.ReadByNameButton);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AreaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NBytesBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.ConnectBox);
            this.Name = "Form1";
            this.Text = "ADS Connect TwinCat 3";
            ((System.ComponentModel.ISupportInitialize)(this.NBytesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConnectBox;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ReadBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NBytesBox;
        private System.Windows.Forms.NumericUpDown AreaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReadByNameButton;
        private System.Windows.Forms.TextBox VarNameBox;
        private System.Windows.Forms.Label label4;
    }
}

