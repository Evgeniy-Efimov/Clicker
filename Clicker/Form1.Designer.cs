namespace Clicker
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
            ScriptTextBox = new TextBox();
            StartButton = new Button();
            XLable = new Label();
            YLabel = new Label();
            XValueLabel = new Label();
            YValueLabel = new Label();
            OutputTextBox = new TextBox();
            StopButton = new Button();
            SuspendLayout();
            // 
            // ScriptTextBox
            // 
            ScriptTextBox.Location = new Point(12, 38);
            ScriptTextBox.Multiline = true;
            ScriptTextBox.Name = "ScriptTextBox";
            ScriptTextBox.ScrollBars = ScrollBars.Both;
            ScriptTextBox.Size = new Size(363, 357);
            ScriptTextBox.TabIndex = 1;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(12, 401);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(180, 23);
            StartButton.TabIndex = 2;
            StartButton.Text = "START";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // XLable
            // 
            XLable.AutoSize = true;
            XLable.Location = new Point(13, 11);
            XLable.Name = "XLable";
            XLable.Size = new Size(17, 15);
            XLable.TabIndex = 4;
            XLable.Text = "X:";
            // 
            // YLabel
            // 
            YLabel.AutoSize = true;
            YLabel.Location = new Point(78, 11);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(17, 15);
            YLabel.TabIndex = 5;
            YLabel.Text = "Y:";
            // 
            // XValueLabel
            // 
            XValueLabel.AutoSize = true;
            XValueLabel.Location = new Point(33, 11);
            XValueLabel.Name = "XValueLabel";
            XValueLabel.Size = new Size(13, 15);
            XValueLabel.TabIndex = 6;
            XValueLabel.Text = "0";
            // 
            // YValueLabel
            // 
            YValueLabel.AutoSize = true;
            YValueLabel.Location = new Point(98, 11);
            YValueLabel.Name = "YValueLabel";
            YValueLabel.Size = new Size(13, 15);
            YValueLabel.TabIndex = 7;
            YValueLabel.Text = "0";
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new Point(12, 430);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.ScrollBars = ScrollBars.Both;
            OutputTextBox.Size = new Size(360, 69);
            OutputTextBox.TabIndex = 8;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(195, 401);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(180, 23);
            StopButton.TabIndex = 9;
            StopButton.Text = "STOP";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 511);
            Controls.Add(StopButton);
            Controls.Add(OutputTextBox);
            Controls.Add(YValueLabel);
            Controls.Add(XValueLabel);
            Controls.Add(YLabel);
            Controls.Add(XLable);
            Controls.Add(StartButton);
            Controls.Add(ScriptTextBox);
            MaximumSize = new Size(400, 550);
            MinimumSize = new Size(400, 550);
            Name = "Form1";
            Text = "Clicker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ScriptTextBox;
        private Button StartButton;
        private Label XLable;
        private Label YLabel;
        private Label XValueLabel;
        private Label YValueLabel;
        private TextBox OutputTextBox;
        private Button StopButton;
    }
}
