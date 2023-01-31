namespace Examen2_121944_Asig7
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
            this.IntputTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.ToKelvinRadioButton = new System.Windows.Forms.RadioButton();
            this.ToCelciusRadioButton = new System.Windows.Forms.RadioButton();
            this.ShowResultButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AnimalComboBox = new System.Windows.Forms.ComboBox();
            this.AnimalPictureBox = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature:";
            // 
            // IntputTemperatureTextBox
            // 
            this.IntputTemperatureTextBox.Location = new System.Drawing.Point(125, 85);
            this.IntputTemperatureTextBox.Name = "IntputTemperatureTextBox";
            this.IntputTemperatureTextBox.Size = new System.Drawing.Size(234, 27);
            this.IntputTemperatureTextBox.TabIndex = 1;
            this.IntputTemperatureTextBox.TextChanged += new System.EventHandler(this.IntputTemperatureTextBox_TextChanged);
            this.IntputTemperatureTextBox.Leave += new System.EventHandler(this.Exception);
            // 
            // ToKelvinRadioButton
            // 
            this.ToKelvinRadioButton.AutoSize = true;
            this.ToKelvinRadioButton.Location = new System.Drawing.Point(378, 88);
            this.ToKelvinRadioButton.Name = "ToKelvinRadioButton";
            this.ToKelvinRadioButton.Size = new System.Drawing.Size(88, 24);
            this.ToKelvinRadioButton.TabIndex = 2;
            this.ToKelvinRadioButton.TabStop = true;
            this.ToKelvinRadioButton.Text = "to Kelvin";
            this.ToKelvinRadioButton.UseVisualStyleBackColor = true;
            this.ToKelvinRadioButton.CheckedChanged += new System.EventHandler(this.ToKelvinRadioButton_CheckedChanged);
            // 
            // ToCelciusRadioButton
            // 
            this.ToCelciusRadioButton.AutoSize = true;
            this.ToCelciusRadioButton.Location = new System.Drawing.Point(490, 88);
            this.ToCelciusRadioButton.Name = "ToCelciusRadioButton";
            this.ToCelciusRadioButton.Size = new System.Drawing.Size(94, 24);
            this.ToCelciusRadioButton.TabIndex = 3;
            this.ToCelciusRadioButton.TabStop = true;
            this.ToCelciusRadioButton.Text = "to Celcius";
            this.ToCelciusRadioButton.UseVisualStyleBackColor = true;
            this.ToCelciusRadioButton.CheckedChanged += new System.EventHandler(this.ToCelciusRadioButton_CheckedChanged);
            // 
            // ShowResultButton
            // 
            this.ShowResultButton.Location = new System.Drawing.Point(641, 88);
            this.ShowResultButton.Name = "ShowResultButton";
            this.ShowResultButton.Size = new System.Drawing.Size(115, 24);
            this.ShowResultButton.TabIndex = 4;
            this.ShowResultButton.Text = "ShowResult";
            this.ShowResultButton.UseVisualStyleBackColor = true;
            this.ShowResultButton.Click += new System.EventHandler(this.ShowResultButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(326, 139);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(52, 20);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose:";
            // 
            // AnimalComboBox
            // 
            this.AnimalComboBox.FormattingEnabled = true;
            this.AnimalComboBox.Items.AddRange(new object[] {
            "",
            "Pig",
            "Bird",
            "HedgeHog",
            "Crocodile",
            "Dog",
            "Cat"});
            this.AnimalComboBox.Location = new System.Drawing.Point(125, 322);
            this.AnimalComboBox.Name = "AnimalComboBox";
            this.AnimalComboBox.Size = new System.Drawing.Size(200, 28);
            this.AnimalComboBox.TabIndex = 7;
            this.AnimalComboBox.SelectedIndexChanged += new System.EventHandler(this.AnimalComboBox_SelectedIndexChanged);
            // 
            // AnimalPictureBox
            // 
            this.AnimalPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.AnimalPictureBox.Location = new System.Drawing.Point(405, 221);
            this.AnimalPictureBox.Name = "AnimalPictureBox";
            this.AnimalPictureBox.Size = new System.Drawing.Size(396, 238);
            this.AnimalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnimalPictureBox.TabIndex = 8;
            this.AnimalPictureBox.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(140, 367);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Do not change image";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(303, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Temperature Converion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AnimalPictureBox);
            this.Controls.Add(this.AnimalComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ShowResultButton);
            this.Controls.Add(this.ToCelciusRadioButton);
            this.Controls.Add(this.ToKelvinRadioButton);
            this.Controls.Add(this.IntputTemperatureTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Exam2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox IntputTemperatureTextBox;
        private RadioButton ToKelvinRadioButton;
        private RadioButton ToCelciusRadioButton;
        private Button ShowResultButton;
        private Label ResultLabel;
        private Label label2;
        private ComboBox AnimalComboBox;
        private PictureBox AnimalPictureBox;
        private CheckBox checkBox1;
        private Label label3;
    }
}