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
            this.bitsInOneCharacter = new System.Windows.Forms.Label();
            this.ContainerLabel = new System.Windows.Forms.Label();
            this.openedContainerLabel = new System.Windows.Forms.Label();
            this.bitsInOneSymbolTextBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfUsedQuates = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bitsInOneSymbolTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openHTMLFile
            // 
            this.openHTMLFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.openHTMLFile.Location = new System.Drawing.Point(12, 18);
            this.openHTMLFile.Name = "openHTMLFile";
            this.openHTMLFile.Size = new System.Drawing.Size(309, 34);
            this.openHTMLFile.TabIndex = 0;
            this.openHTMLFile.Text = "Выбрать контейнер";
            this.openHTMLFile.UseVisualStyleBackColor = false;
            this.openHTMLFile.Click += new System.EventHandler(this.openHTMLFile_Click);
            // 
            // containerCapacityLabelReadOnly
            // 
            this.containerCapacityLabelReadOnly.AutoSize = true;
            this.containerCapacityLabelReadOnly.Location = new System.Drawing.Point(9, 112);
            this.containerCapacityLabelReadOnly.Name = "containerCapacityLabelReadOnly";
            this.containerCapacityLabelReadOnly.Size = new System.Drawing.Size(111, 13);
            this.containerCapacityLabelReadOnly.TabIndex = 1;
            this.containerCapacityLabelReadOnly.Text = "Размер контейнера:";
            // 
            // containerCapacity
            // 
            this.containerCapacity.AutoSize = true;
            this.containerCapacity.Location = new System.Drawing.Point(156, 112);
            this.containerCapacity.Name = "containerCapacity";
            this.containerCapacity.Size = new System.Drawing.Size(13, 13);
            this.containerCapacity.TabIndex = 2;
            this.containerCapacity.Text = "0";
            // 
            // embeddingMessageLabelReadOnly
            // 
            this.embeddingMessageLabelReadOnly.AutoSize = true;
            this.embeddingMessageLabelReadOnly.Location = new System.Drawing.Point(9, 179);
            this.embeddingMessageLabelReadOnly.Name = "embeddingMessageLabelReadOnly";
            this.embeddingMessageLabelReadOnly.Size = new System.Drawing.Size(151, 13);
            this.embeddingMessageLabelReadOnly.TabIndex = 3;
            this.embeddingMessageLabelReadOnly.Text = "Сообщение для осаждения :";
            // 
            // embedMessage
            // 
            this.embedMessage.Location = new System.Drawing.Point(159, 176);
            this.embedMessage.Name = "embedMessage";
            this.embedMessage.Size = new System.Drawing.Size(162, 20);
            this.embedMessage.TabIndex = 4;
            this.embedMessage.TextChanged += new System.EventHandler(this.embedMessage_TextChanged);
            // 
            // embedMessageButton
            // 
            this.embedMessageButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.embedMessageButton.Location = new System.Drawing.Point(12, 215);
            this.embedMessageButton.Name = "embedMessageButton";
            this.embedMessageButton.Size = new System.Drawing.Size(309, 30);
            this.embedMessageButton.TabIndex = 5;
            this.embedMessageButton.Text = "Осадить сообщение";
            this.embedMessageButton.UseVisualStyleBackColor = false;
            this.embedMessageButton.Click += new System.EventHandler(this.embedMessageButton_Click);
            // 
            // extractMessageFromHTMLButton
            // 
            this.extractMessageFromHTMLButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.extractMessageFromHTMLButton.Location = new System.Drawing.Point(12, 292);
            this.extractMessageFromHTMLButton.Name = "extractMessageFromHTMLButton";
            this.extractMessageFromHTMLButton.Size = new System.Drawing.Size(312, 30);
            this.extractMessageFromHTMLButton.TabIndex = 6;
            this.extractMessageFromHTMLButton.Text = "Извлечь сообщение";
            this.extractMessageFromHTMLButton.UseVisualStyleBackColor = false;
            this.extractMessageFromHTMLButton.Click += new System.EventHandler(this.extractMessageFromHTMLButton_Click);
            // 
            // extractedMessaageTextBox
            // 
            this.extractedMessaageTextBox.Location = new System.Drawing.Point(159, 339);
            this.extractedMessaageTextBox.Name = "extractedMessaageTextBox";
            this.extractedMessaageTextBox.Size = new System.Drawing.Size(165, 20);
            this.extractedMessaageTextBox.TabIndex = 7;
            // 
            // bitsInOneCharacter
            // 
            this.bitsInOneCharacter.AutoSize = true;
            this.bitsInOneCharacter.Location = new System.Drawing.Point(9, 143);
            this.bitsInOneCharacter.Name = "bitsInOneCharacter";
            this.bitsInOneCharacter.Size = new System.Drawing.Size(120, 13);
            this.bitsInOneCharacter.TabIndex = 8;
            this.bitsInOneCharacter.Text = "Кол-во бит на символ:";
            // 
            // ContainerLabel
            // 
            this.ContainerLabel.AutoSize = true;
            this.ContainerLabel.Location = new System.Drawing.Point(114, 55);
            this.ContainerLabel.Name = "ContainerLabel";
            this.ContainerLabel.Size = new System.Drawing.Size(101, 13);
            this.ContainerLabel.TabIndex = 10;
            this.ContainerLabel.Text = "Путь к контейнеру";
            // 
            // openedContainerLabel
            // 
            this.openedContainerLabel.AutoSize = true;
            this.openedContainerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.openedContainerLabel.Location = new System.Drawing.Point(12, 83);
            this.openedContainerLabel.Name = "openedContainerLabel";
            this.openedContainerLabel.Size = new System.Drawing.Size(0, 13);
            this.openedContainerLabel.TabIndex = 11;
            // 
            // bitsInOneSymbolTextBox
            // 
            this.bitsInOneSymbolTextBox.Location = new System.Drawing.Point(159, 141);
            this.bitsInOneSymbolTextBox.Name = "bitsInOneSymbolTextBox";
            this.bitsInOneSymbolTextBox.Size = new System.Drawing.Size(162, 20);
            this.bitsInOneSymbolTextBox.TabIndex = 12;
            this.bitsInOneSymbolTextBox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Количество использованных кавычек:";
            // 
            // numberOfUsedQuates
            // 
            this.numberOfUsedQuates.AutoSize = true;
            this.numberOfUsedQuates.Location = new System.Drawing.Point(221, 261);
            this.numberOfUsedQuates.Name = "numberOfUsedQuates";
            this.numberOfUsedQuates.Size = new System.Drawing.Size(0, 13);
            this.numberOfUsedQuates.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Извлеченное сообщение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(346, 382);
            this.Controls.Add(this.ContainerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberOfUsedQuates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitsInOneSymbolTextBox);
            this.Controls.Add(this.openedContainerLabel);
            this.Controls.Add(this.bitsInOneCharacter);
            this.Controls.Add(this.extractedMessaageTextBox);
            this.Controls.Add(this.extractMessageFromHTMLButton);
            this.Controls.Add(this.embedMessageButton);
            this.Controls.Add(this.embedMessage);
            this.Controls.Add(this.embeddingMessageLabelReadOnly);
            this.Controls.Add(this.containerCapacity);
            this.Controls.Add(this.containerCapacityLabelReadOnly);
            this.Controls.Add(this.openHTMLFile);
            this.Name = "Form1";
            this.Text = "QuatesEmbed";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bitsInOneSymbolTextBox)).EndInit();
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
        private System.Windows.Forms.Label bitsInOneCharacter;
        private System.Windows.Forms.Label ContainerLabel;
        private System.Windows.Forms.Label openedContainerLabel;
        private System.Windows.Forms.NumericUpDown bitsInOneSymbolTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfUsedQuates;
        private System.Windows.Forms.Label label2;
    }
}

