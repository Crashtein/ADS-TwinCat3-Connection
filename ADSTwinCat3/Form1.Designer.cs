
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
            this.StopReadingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.PortNBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerNBox = new System.Windows.Forms.NumericUpDown();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.ShowLogsBox = new System.Windows.Forms.CheckBox();
            this.SaveToFileBox = new System.Windows.Forms.CheckBox();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numberOfStates = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PortNBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerNBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectBox
            // 
            this.ConnectBox.Location = new System.Drawing.Point(649, 38);
            this.ConnectBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectBox.Name = "ConnectBox";
            this.ConnectBox.ReadOnly = true;
            this.ConnectBox.Size = new System.Drawing.Size(124, 22);
            this.ConnectBox.TabIndex = 0;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(554, 13);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(91, 50);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ReadBox
            // 
            this.ReadBox.Location = new System.Drawing.Point(16, 69);
            this.ReadBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReadBox.Multiline = true;
            this.ReadBox.Name = "ReadBox";
            this.ReadBox.ReadOnly = true;
            this.ReadBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReadBox.Size = new System.Drawing.Size(1311, 655);
            this.ReadBox.TabIndex = 3;
            // 
            // StartReadingButton
            // 
            this.StartReadingButton.Location = new System.Drawing.Point(16, 15);
            this.StartReadingButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartReadingButton.Name = "StartReadingButton";
            this.StartReadingButton.Size = new System.Drawing.Size(95, 48);
            this.StartReadingButton.TabIndex = 10;
            this.StartReadingButton.Text = "Start";
            this.StartReadingButton.UseVisualStyleBackColor = true;
            this.StartReadingButton.Click += new System.EventHandler(this.StartReadingButton_Click);
            // 
            // StopReadingButton
            // 
            this.StopReadingButton.Location = new System.Drawing.Point(119, 16);
            this.StopReadingButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopReadingButton.Name = "StopReadingButton";
            this.StopReadingButton.Size = new System.Drawing.Size(95, 48);
            this.StopReadingButton.TabIndex = 15;
            this.StopReadingButton.Text = "Stop";
            this.StopReadingButton.UseVisualStyleBackColor = true;
            this.StopReadingButton.Click += new System.EventHandler(this.StopReadingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Status";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(414, 13);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(131, 22);
            this.addressBox.TabIndex = 17;
            this.addressBox.Text = "5.43.145.72.1.1";
            // 
            // PortNBox
            // 
            this.PortNBox.Location = new System.Drawing.Point(414, 39);
            this.PortNBox.Margin = new System.Windows.Forms.Padding(4);
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
            this.PortNBox.Size = new System.Drawing.Size(132, 22);
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
            this.label2.Location = new System.Drawing.Point(313, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "AMS address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Timer [ms]";
            // 
            // timerNBox
            // 
            this.timerNBox.Location = new System.Drawing.Point(221, 40);
            this.timerNBox.Margin = new System.Windows.Forms.Padding(4);
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
            this.timerNBox.Size = new System.Drawing.Size(79, 22);
            this.timerNBox.TabIndex = 22;
            this.timerNBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(884, 38);
            this.FileNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(116, 22);
            this.FileNameBox.TabIndex = 23;
            this.FileNameBox.Text = "log.txt";
            // 
            // ShowLogsBox
            // 
            this.ShowLogsBox.AutoSize = true;
            this.ShowLogsBox.Checked = true;
            this.ShowLogsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowLogsBox.Location = new System.Drawing.Point(782, 16);
            this.ShowLogsBox.Margin = new System.Windows.Forms.Padding(4);
            this.ShowLogsBox.Name = "ShowLogsBox";
            this.ShowLogsBox.Size = new System.Drawing.Size(94, 21);
            this.ShowLogsBox.TabIndex = 24;
            this.ShowLogsBox.Text = "Show logs";
            this.ShowLogsBox.UseVisualStyleBackColor = true;
            // 
            // SaveToFileBox
            // 
            this.SaveToFileBox.AutoSize = true;
            this.SaveToFileBox.Checked = true;
            this.SaveToFileBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveToFileBox.Location = new System.Drawing.Point(782, 40);
            this.SaveToFileBox.Margin = new System.Windows.Forms.Padding(4);
            this.SaveToFileBox.Name = "SaveToFileBox";
            this.SaveToFileBox.Size = new System.Drawing.Size(104, 21);
            this.SaveToFileBox.TabIndex = 25;
            this.SaveToFileBox.Text = "Save to File";
            this.SaveToFileBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1005, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Description file";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1008, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "F:/studia/Artykuł-Cyber/inżynierka_program (1)/c++/TwincatAttempt2/ADS-TwinCat3-C" +
    "onnection/excel1.csv";
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(1132, 11);
            this.LoadDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(91, 50);
            this.LoadDataButton.TabIndex = 28;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1231, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Number of states";
            // 
            // numberOfStates
            // 
            this.numberOfStates.Location = new System.Drawing.Point(1231, 36);
            this.numberOfStates.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfStates.Name = "numberOfStates";
            this.numberOfStates.Size = new System.Drawing.Size(86, 22);
            this.numberOfStates.TabIndex = 30;
            this.numberOfStates.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 730);
            this.Controls.Add(this.numberOfStates);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveToFileBox);
            this.Controls.Add(this.ShowLogsBox);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.timerNBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortNBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopReadingButton);
            this.Controls.Add(this.StartReadingButton);
            this.Controls.Add(this.ReadBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ConnectBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1359, 777);
            this.MinimumSize = new System.Drawing.Size(1359, 777);
            this.Name = "Form1";
            this.Text = "TwinCat Reader";
            ((System.ComponentModel.ISupportInitialize)(this.PortNBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerNBox)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConnectBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ReadBox;
        private System.Windows.Forms.Button StartReadingButton;
        private System.Windows.Forms.Button StopReadingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.NumericUpDown PortNBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown timerNBox;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.CheckBox ShowLogsBox;
        private System.Windows.Forms.CheckBox SaveToFileBox;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numberOfStates;
    }
}

