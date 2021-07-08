
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
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ReadBox = new System.Windows.Forms.TextBox();
            this.StartReadingButton = new System.Windows.Forms.Button();
            this.VarNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReadAsInt32RadioButton = new System.Windows.Forms.RadioButton();
            this.ReadAsBooleanRadioButton = new System.Windows.Forms.RadioButton();
            this.StopReadingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.PortNBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerNBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PortNBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerNBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectBox
            // 
            this.ConnectBox.Location = new System.Drawing.Point(720, 30);
            this.ConnectBox.Name = "ConnectBox";
            this.ConnectBox.ReadOnly = true;
            this.ConnectBox.Size = new System.Drawing.Size(133, 20);
            this.ConnectBox.TabIndex = 0;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(649, 10);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(68, 41);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ReadBox
            // 
            this.ReadBox.Location = new System.Drawing.Point(12, 56);
            this.ReadBox.Multiline = true;
            this.ReadBox.Name = "ReadBox";
            this.ReadBox.ReadOnly = true;
            this.ReadBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReadBox.Size = new System.Drawing.Size(841, 508);
            this.ReadBox.TabIndex = 3;
            // 
            // StartReadingButton
            // 
            this.StartReadingButton.Location = new System.Drawing.Point(127, 11);
            this.StartReadingButton.Name = "StartReadingButton";
            this.StartReadingButton.Size = new System.Drawing.Size(71, 39);
            this.StartReadingButton.TabIndex = 10;
            this.StartReadingButton.Text = "Start";
            this.StartReadingButton.UseVisualStyleBackColor = true;
            this.StartReadingButton.Click += new System.EventHandler(this.StartReadingButton_Click);
            // 
            // VarNameBox
            // 
            this.VarNameBox.Location = new System.Drawing.Point(349, 27);
            this.VarNameBox.Name = "VarNameBox";
            this.VarNameBox.Size = new System.Drawing.Size(113, 20);
            this.VarNameBox.TabIndex = 11;
            this.VarNameBox.Text = "X1;X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Variable Names";
            // 
            // ReadAsInt32RadioButton
            // 
            this.ReadAsInt32RadioButton.AutoSize = true;
            this.ReadAsInt32RadioButton.Checked = true;
            this.ReadAsInt32RadioButton.Location = new System.Drawing.Point(14, 11);
            this.ReadAsInt32RadioButton.Name = "ReadAsInt32RadioButton";
            this.ReadAsInt32RadioButton.Size = new System.Drawing.Size(92, 17);
            this.ReadAsInt32RadioButton.TabIndex = 13;
            this.ReadAsInt32RadioButton.TabStop = true;
            this.ReadAsInt32RadioButton.Text = "Read as Int32";
            this.ReadAsInt32RadioButton.UseVisualStyleBackColor = true;
            // 
            // ReadAsBooleanRadioButton
            // 
            this.ReadAsBooleanRadioButton.AutoSize = true;
            this.ReadAsBooleanRadioButton.Location = new System.Drawing.Point(14, 33);
            this.ReadAsBooleanRadioButton.Name = "ReadAsBooleanRadioButton";
            this.ReadAsBooleanRadioButton.Size = new System.Drawing.Size(107, 17);
            this.ReadAsBooleanRadioButton.TabIndex = 14;
            this.ReadAsBooleanRadioButton.Text = "Read as Boolean";
            this.ReadAsBooleanRadioButton.UseVisualStyleBackColor = true;
            // 
            // StopReadingButton
            // 
            this.StopReadingButton.Location = new System.Drawing.Point(204, 11);
            this.StopReadingButton.Name = "StopReadingButton";
            this.StopReadingButton.Size = new System.Drawing.Size(71, 39);
            this.StopReadingButton.TabIndex = 15;
            this.StopReadingButton.Text = "Stop";
            this.StopReadingButton.UseVisualStyleBackColor = true;
            this.StopReadingButton.Click += new System.EventHandler(this.StopReadingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Status";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(544, 10);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(99, 20);
            this.addressBox.TabIndex = 17;
            this.addressBox.Text = "5.43.145.72.1.1";
            // 
            // PortNBox
            // 
            this.PortNBox.Location = new System.Drawing.Point(544, 31);
            this.PortNBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.PortNBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PortNBox.Name = "PortNBox";
            this.PortNBox.Size = new System.Drawing.Size(99, 20);
            this.PortNBox.TabIndex = 18;
            this.PortNBox.Value = new decimal(new int[] {
            851,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "AMS address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Timer [ms]";
            // 
            // timerNBox
            // 
            this.timerNBox.Location = new System.Drawing.Point(284, 28);
            this.timerNBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.timerNBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timerNBox.Name = "timerNBox";
            this.timerNBox.Size = new System.Drawing.Size(59, 20);
            this.timerNBox.TabIndex = 22;
            this.timerNBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 576);
            this.Controls.Add(this.timerNBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortNBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopReadingButton);
            this.Controls.Add(this.ReadAsBooleanRadioButton);
            this.Controls.Add(this.ReadAsInt32RadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VarNameBox);
            this.Controls.Add(this.StartReadingButton);
            this.Controls.Add(this.ReadBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ConnectBox);
            this.MaximumSize = new System.Drawing.Size(880, 615);
            this.MinimumSize = new System.Drawing.Size(880, 615);
            this.Name = "Form1";
            this.Text = "TwinCat Reader";
            ((System.ComponentModel.ISupportInitialize)(this.PortNBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerNBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConnectBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ReadBox;
        private System.Windows.Forms.Button StartReadingButton;
        private System.Windows.Forms.TextBox VarNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton ReadAsInt32RadioButton;
        private System.Windows.Forms.RadioButton ReadAsBooleanRadioButton;
        private System.Windows.Forms.Button StopReadingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.NumericUpDown PortNBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown timerNBox;
    }
}

