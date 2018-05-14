namespace HTMLSteganographyWinFormV2
{
    partial class Form1
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
            this.openHTMLFile = new System.Windows.Forms.Button();
            this.containerCapacityLabelReadOnly = new System.Windows.Forms.Label();
            this.containerCapacity = new System.Windows.Forms.Label();
            this.embeddingMessageLabelReadOnly = new System.Windows.Forms.Label();
            this.embedMessage = new System.Windows.Forms.TextBox();
            this.embedMessageButton = new System.Windows.Forms.Button();
            this.extractMessageFromHTMLButton = new System.Windows.Forms.Button();
            this.extractedMessaageTextBox = new System.Windows.Forms.TextBox();
            this.ContainerLabel = new System.Windows.Forms.Label();
            this.openedContainerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.messageHashTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openHTMLFile
            // 
            this.openHTMLFile.Location = new System.Drawing.Point(15, 121);
            this.openHTMLFile.Name = "openHTMLFile";
            this.openHTMLFile.Size = new System.Drawing.Size(203, 23);
            this.openHTMLFile.TabIndex = 0;
            this.openHTMLFile.Text = "Открыть файл";
            this.openHTMLFile.UseVisualStyleBackColor = true;
            this.openHTMLFile.Click += new System.EventHandler(this.openHTMLFile_Click);
            // 
            // containerCapacityLabelReadOnly
            // 
            this.containerCapacityLabelReadOnly.AutoSize = true;
            this.containerCapacityLabelReadOnly.Location = new System.Drawing.Point(12, 33);
            this.containerCapacityLabelReadOnly.Name = "containerCapacityLabelReadOnly";
            this.containerCapacityLabelReadOnly.Size = new System.Drawing.Size(111, 13);
            this.containerCapacityLabelReadOnly.TabIndex = 1;
            this.containerCapacityLabelReadOnly.Text = "Размер контейнера:";
            // 
            // containerCapacity
            // 
            this.containerCapacity.AutoSize = true;
            this.containerCapacity.Location = new System.Drawing.Point(159, 33);
            this.containerCapacity.Name = "containerCapacity";
            this.containerCapacity.Size = new System.Drawing.Size(13, 13);
            this.containerCapacity.TabIndex = 2;
            this.containerCapacity.Text = "0";
            // 
            // embeddingMessageLabelReadOnly
            // 
            this.embeddingMessageLabelReadOnly.AutoSize = true;
            this.embeddingMessageLabelReadOnly.Location = new System.Drawing.Point(12, 86);
            this.embeddingMessageLabelReadOnly.Name = "embeddingMessageLabelReadOnly";
            this.embeddingMessageLabelReadOnly.Size = new System.Drawing.Size(144, 13);
            this.embeddingMessageLabelReadOnly.TabIndex = 3;
            this.embeddingMessageLabelReadOnly.Text = "Встраивоемое сообщение:";
            // 
            // embedMessage
            // 
            this.embedMessage.Location = new System.Drawing.Point(162, 83);
            this.embedMessage.Name = "embedMessage";
            this.embedMessage.Size = new System.Drawing.Size(162, 20);
            this.embedMessage.TabIndex = 4;
            this.embedMessage.TextChanged += new System.EventHandler(this.embedMessage_TextChanged);
            // 
            // embedMessageButton
            // 
            this.embedMessageButton.Location = new System.Drawing.Point(224, 121);
            this.embedMessageButton.Name = "embedMessageButton";
            this.embedMessageButton.Size = new System.Drawing.Size(100, 23);
            this.embedMessageButton.TabIndex = 5;
            this.embedMessageButton.Text = "Встроить";
            this.embedMessageButton.UseVisualStyleBackColor = true;
            this.embedMessageButton.Click += new System.EventHandler(this.embedMessageButton_Click);
            // 
            // extractMessageFromHTMLButton
            // 
            this.extractMessageFromHTMLButton.Location = new System.Drawing.Point(12, 183);
            this.extractMessageFromHTMLButton.Name = "extractMessageFromHTMLButton";
            this.extractMessageFromHTMLButton.Size = new System.Drawing.Size(312, 23);
            this.extractMessageFromHTMLButton.TabIndex = 6;
            this.extractMessageFromHTMLButton.Text = "Извлечь сообщение";
            this.extractMessageFromHTMLButton.UseVisualStyleBackColor = true;
            this.extractMessageFromHTMLButton.Click += new System.EventHandler(this.extractMessageFromHTMLButton_Click);
            // 
            // extractedMessaageTextBox
            // 
            this.extractedMessaageTextBox.Location = new System.Drawing.Point(12, 212);
            this.extractedMessaageTextBox.Name = "extractedMessaageTextBox";
            this.extractedMessaageTextBox.Size = new System.Drawing.Size(312, 20);
            this.extractedMessaageTextBox.TabIndex = 7;
            // 
            // ContainerLabel
            // 
            this.ContainerLabel.AutoSize = true;
            this.ContainerLabel.Location = new System.Drawing.Point(12, 9);
            this.ContainerLabel.Name = "ContainerLabel";
            this.ContainerLabel.Size = new System.Drawing.Size(64, 13);
            this.ContainerLabel.TabIndex = 10;
            this.ContainerLabel.Text = "Контейнер:";
            // 
            // openedContainerLabel
            // 
            this.openedContainerLabel.AutoSize = true;
            this.openedContainerLabel.Location = new System.Drawing.Point(82, 9);
            this.openedContainerLabel.Name = "openedContainerLabel";
            this.openedContainerLabel.Size = new System.Drawing.Size(36, 13);
            this.openedContainerLabel.TabIndex = 11;
            this.openedContainerLabel.Text = "Empty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Хэш сообщения:";
            // 
            // messageHashTextBox
            // 
            this.messageHashTextBox.Location = new System.Drawing.Point(109, 55);
            this.messageHashTextBox.Name = "messageHashTextBox";
            this.messageHashTextBox.Size = new System.Drawing.Size(215, 20);
            this.messageHashTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 289);
            this.Controls.Add(this.messageHashTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openedContainerLabel);
            this.Controls.Add(this.ContainerLabel);
            this.Controls.Add(this.extractedMessaageTextBox);
            this.Controls.Add(this.extractMessageFromHTMLButton);
            this.Controls.Add(this.embedMessageButton);
            this.Controls.Add(this.embedMessage);
            this.Controls.Add(this.embeddingMessageLabelReadOnly);
            this.Controls.Add(this.containerCapacity);
            this.Controls.Add(this.containerCapacityLabelReadOnly);
            this.Controls.Add(this.openHTMLFile);
            this.Name = "Form1";
            this.Text = "MarkupStego";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openHTMLFile;
        private System.Windows.Forms.Label containerCapacityLabelReadOnly;
        private System.Windows.Forms.Label containerCapacity;
        private System.Windows.Forms.Label embeddingMessageLabelReadOnly;
        private System.Windows.Forms.TextBox embedMessage;
        private System.Windows.Forms.Button embedMessageButton;
        private System.Windows.Forms.Button extractMessageFromHTMLButton;
        private System.Windows.Forms.TextBox extractedMessaageTextBox;
        private System.Windows.Forms.Label ContainerLabel;
        private System.Windows.Forms.Label openedContainerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messageHashTextBox;
    }
}

