namespace Encoder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputText = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.outputText = new System.Windows.Forms.TextBox();
            this.setKey = new System.Windows.Forms.Button();
            this.keyPath = new System.Windows.Forms.TextBox();
            this.keyString = new System.Windows.Forms.TextBox();
            this.setVector = new System.Windows.Forms.Button();
            this.vectorPath = new System.Windows.Forms.TextBox();
            this.vectorString = new System.Windows.Forms.TextBox();
            this.hexText = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.encrypting = new System.Windows.Forms.Button();
            this.decrypting = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Base64_box = new System.Windows.Forms.CheckBox();
            this.Hex = new System.Windows.Forms.CheckBox();
            this.hexCloseText = new System.Windows.Forms.TextBox();
            this.keyHex = new System.Windows.Forms.TextBox();
            this.vectorHex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText.Location = new System.Drawing.Point(12, 21);
            this.inputText.MaximumSize = new System.Drawing.Size(500, 500);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(332, 221);
            this.inputText.TabIndex = 0;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.Location = new System.Drawing.Point(358, 21);
            this.outputText.MaximumSize = new System.Drawing.Size(500, 500);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(332, 221);
            this.outputText.TabIndex = 1;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // setKey
            // 
            this.setKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setKey.Location = new System.Drawing.Point(615, 388);
            this.setKey.Name = "setKey";
            this.setKey.Size = new System.Drawing.Size(75, 23);
            this.setKey.TabIndex = 2;
            this.setKey.Text = "Set key";
            this.setKey.UseVisualStyleBackColor = true;
            this.setKey.Click += new System.EventHandler(this.setKey_Click);
            // 
            // keyPath
            // 
            this.keyPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.keyPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.keyPath.Location = new System.Drawing.Point(12, 390);
            this.keyPath.Name = "keyPath";
            this.keyPath.ReadOnly = true;
            this.keyPath.Size = new System.Drawing.Size(261, 20);
            this.keyPath.TabIndex = 4;
            this.keyPath.TabStop = false;
            // 
            // keyString
            // 
            this.keyString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.keyString.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.keyString.Location = new System.Drawing.Point(276, 390);
            this.keyString.Name = "keyString";
            this.keyString.ReadOnly = true;
            this.keyString.Size = new System.Drawing.Size(129, 20);
            this.keyString.TabIndex = 5;
            this.keyString.TabStop = false;
            // 
            // setVector
            // 
            this.setVector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setVector.Location = new System.Drawing.Point(615, 414);
            this.setVector.Name = "setVector";
            this.setVector.Size = new System.Drawing.Size(75, 23);
            this.setVector.TabIndex = 6;
            this.setVector.Text = "Set vector";
            this.setVector.UseVisualStyleBackColor = true;
            this.setVector.Click += new System.EventHandler(this.setVector_Click);
            // 
            // vectorPath
            // 
            this.vectorPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vectorPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vectorPath.Location = new System.Drawing.Point(12, 416);
            this.vectorPath.Name = "vectorPath";
            this.vectorPath.ReadOnly = true;
            this.vectorPath.Size = new System.Drawing.Size(261, 20);
            this.vectorPath.TabIndex = 7;
            this.vectorPath.TabStop = false;
            // 
            // vectorString
            // 
            this.vectorString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vectorString.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vectorString.Location = new System.Drawing.Point(276, 416);
            this.vectorString.Name = "vectorString";
            this.vectorString.ReadOnly = true;
            this.vectorString.Size = new System.Drawing.Size(129, 20);
            this.vectorString.TabIndex = 8;
            this.vectorString.TabStop = false;
            // 
            // hexText
            // 
            this.hexText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hexText.Location = new System.Drawing.Point(12, 243);
            this.hexText.Multiline = true;
            this.hexText.Name = "hexText";
            this.hexText.ReadOnly = true;
            this.hexText.Size = new System.Drawing.Size(332, 113);
            this.hexText.TabIndex = 9;
            // 
            // openFile
            // 
            this.openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openFile.Location = new System.Drawing.Point(269, 362);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 10;
            this.openFile.Text = "Open";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFile.Location = new System.Drawing.Point(615, 362);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 11;
            this.saveFile.Text = "Save";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // encrypting
            // 
            this.encrypting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.encrypting.Location = new System.Drawing.Point(408, 446);
            this.encrypting.Name = "encrypting";
            this.encrypting.Size = new System.Drawing.Size(132, 36);
            this.encrypting.TabIndex = 12;
            this.encrypting.Text = "Encrypt";
            this.encrypting.UseVisualStyleBackColor = true;
            this.encrypting.Click += new System.EventHandler(this.encrypting_Click);
            // 
            // decrypting
            // 
            this.decrypting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.decrypting.Location = new System.Drawing.Point(558, 446);
            this.decrypting.Name = "decrypting";
            this.decrypting.Size = new System.Drawing.Size(132, 36);
            this.decrypting.TabIndex = 13;
            this.decrypting.Text = "Decrypt";
            this.decrypting.UseVisualStyleBackColor = true;
            this.decrypting.Click += new System.EventHandler(this.decrypting_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Base64_box
            // 
            this.Base64_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Base64_box.AutoSize = true;
            this.Base64_box.Location = new System.Drawing.Point(408, 365);
            this.Base64_box.Name = "Base64_box";
            this.Base64_box.Size = new System.Drawing.Size(62, 17);
            this.Base64_box.TabIndex = 14;
            this.Base64_box.Text = "Base64";
            this.Base64_box.UseVisualStyleBackColor = true;
            // 
            // Hex
            // 
            this.Hex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Hex.AutoSize = true;
            this.Hex.Location = new System.Drawing.Point(510, 365);
            this.Hex.Name = "Hex";
            this.Hex.Size = new System.Drawing.Size(45, 17);
            this.Hex.TabIndex = 15;
            this.Hex.Text = "Hex";
            this.Hex.UseVisualStyleBackColor = true;
            // 
            // hexCloseText
            // 
            this.hexCloseText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexCloseText.Location = new System.Drawing.Point(358, 243);
            this.hexCloseText.Multiline = true;
            this.hexCloseText.Name = "hexCloseText";
            this.hexCloseText.ReadOnly = true;
            this.hexCloseText.Size = new System.Drawing.Size(332, 113);
            this.hexCloseText.TabIndex = 16;
            // 
            // keyHex
            // 
            this.keyHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyHex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.keyHex.Location = new System.Drawing.Point(408, 389);
            this.keyHex.Name = "keyHex";
            this.keyHex.ReadOnly = true;
            this.keyHex.Size = new System.Drawing.Size(204, 20);
            this.keyHex.TabIndex = 17;
            this.keyHex.TabStop = false;
            // 
            // vectorHex
            // 
            this.vectorHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vectorHex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vectorHex.Location = new System.Drawing.Point(408, 416);
            this.vectorHex.Name = "vectorHex";
            this.vectorHex.ReadOnly = true;
            this.vectorHex.Size = new System.Drawing.Size(204, 20);
            this.vectorHex.TabIndex = 18;
            this.vectorHex.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(702, 491);
            this.Controls.Add(this.vectorHex);
            this.Controls.Add(this.keyHex);
            this.Controls.Add(this.hexCloseText);
            this.Controls.Add(this.Hex);
            this.Controls.Add(this.Base64_box);
            this.Controls.Add(this.decrypting);
            this.Controls.Add(this.encrypting);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.hexText);
            this.Controls.Add(this.vectorString);
            this.Controls.Add(this.vectorPath);
            this.Controls.Add(this.setVector);
            this.Controls.Add(this.keyString);
            this.Controls.Add(this.keyPath);
            this.Controls.Add(this.setKey);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(718, 530);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Encoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button setKey;
        private System.Windows.Forms.TextBox keyPath;
        private System.Windows.Forms.TextBox keyString;
        private System.Windows.Forms.Button setVector;
        private System.Windows.Forms.TextBox vectorPath;
        private System.Windows.Forms.TextBox vectorString;
        private System.Windows.Forms.TextBox hexText;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button encrypting;
        private System.Windows.Forms.Button decrypting;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.CheckBox Base64_box;
        private System.Windows.Forms.CheckBox Hex;
        private System.Windows.Forms.TextBox hexCloseText;
        private System.Windows.Forms.TextBox keyHex;
        private System.Windows.Forms.TextBox vectorHex;
    }
}

