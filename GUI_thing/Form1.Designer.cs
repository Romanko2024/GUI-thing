﻿namespace GUI_thing
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
            buttonTransparency = new Button();
            buttonBackgroundColor = new Button();
            buttonHelloWorld = new Button();
            buttonTHEBUTTON = new Button();
            checkTransparency = new CheckBox();
            checkBackgroundColor = new CheckBox();
            checkMessage = new CheckBox();
            SuspendLayout();
            // 
            // buttonTransparency
            // 
            buttonTransparency.Location = new Point(14, 13);
            buttonTransparency.Name = "buttonTransparency";
            buttonTransparency.Size = new Size(132, 40);
            buttonTransparency.TabIndex = 0;
            buttonTransparency.Text = "Прозорість";
            buttonTransparency.UseVisualStyleBackColor = true;
            buttonTransparency.Click += buttonTransparency_Click;
            // 
            // buttonBackgroundColor
            // 
            buttonBackgroundColor.Location = new Point(152, 13);
            buttonBackgroundColor.Name = "buttonBackgroundColor";
            buttonBackgroundColor.Size = new Size(132, 40);
            buttonBackgroundColor.TabIndex = 1;
            buttonBackgroundColor.Text = "Колір тла";
            buttonBackgroundColor.UseVisualStyleBackColor = true;
            buttonBackgroundColor.Click += buttonBackgroundColor_Click;
            // 
            // buttonHelloWorld
            // 
            buttonHelloWorld.Location = new Point(290, 13);
            buttonHelloWorld.Name = "buttonHelloWorld";
            buttonHelloWorld.Size = new Size(132, 40);
            buttonHelloWorld.TabIndex = 2;
            buttonHelloWorld.Text = "hello World";
            buttonHelloWorld.UseVisualStyleBackColor = true;
            buttonHelloWorld.Click += buttonHelloWorld_Click;
            // 
            // buttonTHEBUTTON
            // 
            buttonTHEBUTTON.Location = new Point(14, 59);
            buttonTHEBUTTON.Name = "buttonTHEBUTTON";
            buttonTHEBUTTON.Size = new Size(408, 40);
            buttonTHEBUTTON.TabIndex = 3;
            buttonTHEBUTTON.Text = "супермегакнопка";
            buttonTHEBUTTON.UseVisualStyleBackColor = true;
            buttonTHEBUTTON.Click += buttonTHEBUTTON_Click;
            // 
            // checkTransparency
            // 
            checkTransparency.AutoSize = true;
            checkTransparency.Location = new Point(14, 105);
            checkTransparency.Name = "checkTransparency";
            checkTransparency.Size = new Size(258, 34);
            checkTransparency.TabIndex = 4;
            checkTransparency.Text = "\"супермегакнопка\" поглинає \"Прозорість\r\n\"";
            checkTransparency.UseVisualStyleBackColor = true;
            checkTransparency.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBackgroundColor
            // 
            checkBackgroundColor.AutoSize = true;
            checkBackgroundColor.Location = new Point(14, 145);
            checkBackgroundColor.Name = "checkBackgroundColor";
            checkBackgroundColor.Size = new Size(253, 19);
            checkBackgroundColor.TabIndex = 5;
            checkBackgroundColor.Text = "\"супермегакнопка\" поглинає \"Колір тла\"";
            checkBackgroundColor.UseVisualStyleBackColor = true;
            checkBackgroundColor.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkMessage
            // 
            checkMessage.AutoSize = true;
            checkMessage.Location = new Point(14, 170);
            checkMessage.Name = "checkMessage";
            checkMessage.Size = new Size(262, 19);
            checkMessage.TabIndex = 6;
            checkMessage.Text = "\"супермегакнопка\" поглинає \"hello World\"";
            checkMessage.UseVisualStyleBackColor = true;
            checkMessage.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 197);
            Controls.Add(checkMessage);
            Controls.Add(checkBackgroundColor);
            Controls.Add(checkTransparency);
            Controls.Add(buttonTHEBUTTON);
            Controls.Add(buttonHelloWorld);
            Controls.Add(buttonBackgroundColor);
            Controls.Add(buttonTransparency);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTransparency;
        private Button buttonBackgroundColor;
        private Button buttonHelloWorld;
        private Button buttonTHEBUTTON;
        private CheckBox checkTransparency;
        private CheckBox checkBackgroundColor;
        private CheckBox checkMessage;
    }
}