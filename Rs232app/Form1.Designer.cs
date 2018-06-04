namespace Rs232app
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
            this.OutputGroup = new System.Windows.Forms.GroupBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.PortCombo = new System.Windows.Forms.ComboBox();
            this.BaudCombo = new System.Windows.Forms.ComboBox();
            this.DataCombo = new System.Windows.Forms.ComboBox();
            this.ParityCombo = new System.Windows.Forms.ComboBox();
            this.StopCombo = new System.Windows.Forms.ComboBox();
            this.FlowCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResetGroup = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ModemGroup = new System.Windows.Forms.GroupBox();
            this.PhyRadio = new System.Windows.Forms.RadioButton();
            this.DlRadio = new System.Windows.Forms.RadioButton();
            this.OutputGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ResetGroup.SuspendLayout();
            this.ModemGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputGroup
            // 
            this.OutputGroup.Controls.Add(this.OutputText);
            this.OutputGroup.Enabled = false;
            this.OutputGroup.Location = new System.Drawing.Point(287, 13);
            this.OutputGroup.Name = "OutputGroup";
            this.OutputGroup.Size = new System.Drawing.Size(259, 242);
            this.OutputGroup.TabIndex = 2;
            this.OutputGroup.TabStop = false;
            this.OutputGroup.Text = "Output";
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(7, 20);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.Size = new System.Drawing.Size(246, 216);
            this.OutputText.TabIndex = 0;
            // 
            // PortCombo
            // 
            this.PortCombo.FormattingEnabled = true;
            this.PortCombo.Location = new System.Drawing.Point(143, 33);
            this.PortCombo.Name = "PortCombo";
            this.PortCombo.Size = new System.Drawing.Size(121, 21);
            this.PortCombo.TabIndex = 0;
            // 
            // BaudCombo
            // 
            this.BaudCombo.FormattingEnabled = true;
            this.BaudCombo.Location = new System.Drawing.Point(143, 79);
            this.BaudCombo.Name = "BaudCombo";
            this.BaudCombo.Size = new System.Drawing.Size(121, 21);
            this.BaudCombo.TabIndex = 1;
            // 
            // DataCombo
            // 
            this.DataCombo.FormattingEnabled = true;
            this.DataCombo.Location = new System.Drawing.Point(143, 127);
            this.DataCombo.Name = "DataCombo";
            this.DataCombo.Size = new System.Drawing.Size(121, 21);
            this.DataCombo.TabIndex = 2;
            // 
            // ParityCombo
            // 
            this.ParityCombo.FormattingEnabled = true;
            this.ParityCombo.Location = new System.Drawing.Point(143, 177);
            this.ParityCombo.Name = "ParityCombo";
            this.ParityCombo.Size = new System.Drawing.Size(121, 21);
            this.ParityCombo.TabIndex = 3;
            // 
            // StopCombo
            // 
            this.StopCombo.FormattingEnabled = true;
            this.StopCombo.Location = new System.Drawing.Point(143, 227);
            this.StopCombo.Name = "StopCombo";
            this.StopCombo.Size = new System.Drawing.Size(121, 21);
            this.StopCombo.TabIndex = 4;
            // 
            // FlowCombo
            // 
            this.FlowCombo.FormattingEnabled = true;
            this.FlowCombo.Location = new System.Drawing.Point(143, 275);
            this.FlowCombo.Name = "FlowCombo";
            this.FlowCombo.Size = new System.Drawing.Size(121, 21);
            this.FlowCombo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Baudrate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Parity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stop bits:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Flow control:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(9, 330);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(255, 62);
            this.ConnectButton.TabIndex = 14;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.FlowCombo);
            this.groupBox1.Controls.Add(this.PortCombo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.StopCombo);
            this.groupBox1.Controls.Add(this.BaudCombo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ParityCombo);
            this.groupBox1.Controls.Add(this.DataCombo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 398);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port configuration";
            // 
            // ResetGroup
            // 
            this.ResetGroup.Controls.Add(this.ResetButton);
            this.ResetGroup.Enabled = false;
            this.ResetGroup.Location = new System.Drawing.Point(288, 323);
            this.ResetGroup.Name = "ResetGroup";
            this.ResetGroup.Size = new System.Drawing.Size(258, 88);
            this.ResetGroup.TabIndex = 4;
            this.ResetGroup.TabStop = false;
            this.ResetGroup.Text = "Reset";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(7, 20);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(245, 62);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ModemGroup
            // 
            this.ModemGroup.Controls.Add(this.PhyRadio);
            this.ModemGroup.Controls.Add(this.DlRadio);
            this.ModemGroup.Enabled = false;
            this.ModemGroup.Location = new System.Drawing.Point(288, 261);
            this.ModemGroup.Name = "ModemGroup";
            this.ModemGroup.Size = new System.Drawing.Size(252, 56);
            this.ModemGroup.TabIndex = 5;
            this.ModemGroup.TabStop = false;
            this.ModemGroup.Text = "Modem configuration";
            // 
            // PhyRadio
            // 
            this.PhyRadio.AutoSize = true;
            this.PhyRadio.Location = new System.Drawing.Point(64, 27);
            this.PhyRadio.Name = "PhyRadio";
            this.PhyRadio.Size = new System.Drawing.Size(47, 17);
            this.PhyRadio.TabIndex = 1;
            this.PhyRadio.Text = "PHY";
            this.PhyRadio.UseVisualStyleBackColor = true;
            this.PhyRadio.CheckedChanged += new System.EventHandler(this.PhyRadio_CheckedChanged);
            // 
            // DlRadio
            // 
            this.DlRadio.AutoSize = true;
            this.DlRadio.Location = new System.Drawing.Point(7, 27);
            this.DlRadio.Name = "DlRadio";
            this.DlRadio.Size = new System.Drawing.Size(39, 17);
            this.DlRadio.TabIndex = 0;
            this.DlRadio.Text = "DL";
            this.DlRadio.UseVisualStyleBackColor = true;
            this.DlRadio.CheckedChanged += new System.EventHandler(this.DlRadio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 419);
            this.Controls.Add(this.ModemGroup);
            this.Controls.Add(this.ResetGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OutputGroup);
            this.Name = "Form1";
            this.Text = "Rosoboto";
            this.OutputGroup.ResumeLayout(false);
            this.OutputGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResetGroup.ResumeLayout(false);
            this.ModemGroup.ResumeLayout(false);
            this.ModemGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox OutputGroup;
        private System.Windows.Forms.ComboBox PortCombo;
        private System.Windows.Forms.ComboBox BaudCombo;
        private System.Windows.Forms.ComboBox DataCombo;
        private System.Windows.Forms.ComboBox ParityCombo;
        private System.Windows.Forms.ComboBox StopCombo;
        private System.Windows.Forms.ComboBox FlowCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.GroupBox ResetGroup;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox ModemGroup;
        private System.Windows.Forms.RadioButton PhyRadio;
        private System.Windows.Forms.RadioButton DlRadio;
    }
}

