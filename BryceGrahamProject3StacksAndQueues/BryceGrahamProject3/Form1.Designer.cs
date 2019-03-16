namespace BryceGrahamProject3
{
    partial class stackTester
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
            this.stackPushButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.stackTextBox = new System.Windows.Forms.TextBox();
            this.stackPopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stackPeekButton = new System.Windows.Forms.Button();
            this.queuePopButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.queueTextBox = new System.Windows.Forms.TextBox();
            this.queuePeekButton = new System.Windows.Forms.Button();
            this.queuePushButton = new System.Windows.Forms.Button();
            this.displayList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expressionText = new System.Windows.Forms.TextBox();
            this.evaluateButton = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stackPushButton
            // 
            this.stackPushButton.Location = new System.Drawing.Point(76, 140);
            this.stackPushButton.Name = "stackPushButton";
            this.stackPushButton.Size = new System.Drawing.Size(75, 23);
            this.stackPushButton.TabIndex = 0;
            this.stackPushButton.Text = "Push";
            this.stackPushButton.UseVisualStyleBackColor = true;
            this.stackPushButton.Click += new System.EventHandler(this.stackPushButton_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(63, 245);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(469, 96);
            this.displayBox.TabIndex = 1;
            this.displayBox.Text = "";
            // 
            // stackTextBox
            // 
            this.stackTextBox.Location = new System.Drawing.Point(76, 114);
            this.stackTextBox.Name = "stackTextBox";
            this.stackTextBox.Size = new System.Drawing.Size(100, 20);
            this.stackTextBox.TabIndex = 2;
            // 
            // stackPopButton
            // 
            this.stackPopButton.Location = new System.Drawing.Point(76, 169);
            this.stackPopButton.Name = "stackPopButton";
            this.stackPopButton.Size = new System.Drawing.Size(75, 23);
            this.stackPopButton.TabIndex = 3;
            this.stackPopButton.Text = "Pop";
            this.stackPopButton.UseVisualStyleBackColor = true;
            this.stackPopButton.Click += new System.EventHandler(this.stackPopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stack";
            // 
            // stackPeekButton
            // 
            this.stackPeekButton.Location = new System.Drawing.Point(77, 198);
            this.stackPeekButton.Name = "stackPeekButton";
            this.stackPeekButton.Size = new System.Drawing.Size(75, 23);
            this.stackPeekButton.TabIndex = 5;
            this.stackPeekButton.Text = "Peek";
            this.stackPeekButton.UseVisualStyleBackColor = true;
            this.stackPeekButton.Click += new System.EventHandler(this.stackPeekButton_Click);
            // 
            // queuePopButton
            // 
            this.queuePopButton.Location = new System.Drawing.Point(276, 169);
            this.queuePopButton.Name = "queuePopButton";
            this.queuePopButton.Size = new System.Drawing.Size(75, 23);
            this.queuePopButton.TabIndex = 6;
            this.queuePopButton.Text = "Pop";
            this.queuePopButton.UseVisualStyleBackColor = true;
            this.queuePopButton.Click += new System.EventHandler(this.queuePopButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Queue";
            // 
            // queueTextBox
            // 
            this.queueTextBox.Location = new System.Drawing.Point(276, 114);
            this.queueTextBox.Name = "queueTextBox";
            this.queueTextBox.Size = new System.Drawing.Size(100, 20);
            this.queueTextBox.TabIndex = 8;
            // 
            // queuePeekButton
            // 
            this.queuePeekButton.Location = new System.Drawing.Point(277, 198);
            this.queuePeekButton.Name = "queuePeekButton";
            this.queuePeekButton.Size = new System.Drawing.Size(75, 23);
            this.queuePeekButton.TabIndex = 9;
            this.queuePeekButton.Text = "Peek";
            this.queuePeekButton.UseVisualStyleBackColor = true;
            this.queuePeekButton.Click += new System.EventHandler(this.queuePeekButton_Click);
            // 
            // queuePushButton
            // 
            this.queuePushButton.Location = new System.Drawing.Point(277, 140);
            this.queuePushButton.Name = "queuePushButton";
            this.queuePushButton.Size = new System.Drawing.Size(75, 23);
            this.queuePushButton.TabIndex = 10;
            this.queuePushButton.Text = "Push";
            this.queuePushButton.UseVisualStyleBackColor = true;
            this.queuePushButton.Click += new System.EventHandler(this.queuePushButton_Click);
            // 
            // displayList
            // 
            this.displayList.FormattingEnabled = true;
            this.displayList.Location = new System.Drawing.Point(412, 114);
            this.displayList.Name = "displayList";
            this.displayList.Size = new System.Drawing.Size(120, 95);
            this.displayList.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(576, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 334);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Expression";
            // 
            // expressionText
            // 
            this.expressionText.Location = new System.Drawing.Point(654, 102);
            this.expressionText.Name = "expressionText";
            this.expressionText.Size = new System.Drawing.Size(100, 20);
            this.expressionText.TabIndex = 14;
            // 
            // evaluateButton
            // 
            this.evaluateButton.Location = new System.Drawing.Point(654, 140);
            this.evaluateButton.Name = "evaluateButton";
            this.evaluateButton.Size = new System.Drawing.Size(75, 23);
            this.evaluateButton.TabIndex = 15;
            this.evaluateButton.Text = "Evaluate";
            this.evaluateButton.UseVisualStyleBackColor = true;
            this.evaluateButton.Click += new System.EventHandler(this.evaluateButton_Click);
            // 
            // Convert
            // 
            this.Convert.AutoSize = true;
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(651, 196);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 24);
            this.Convert.TabIndex = 16;
            this.Convert.Text = "Convert";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(654, 243);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(101, 23);
            this.convertButton.TabIndex = 17;
            this.convertButton.Text = "Convert to postfix";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // stackTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 359);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.evaluateButton);
            this.Controls.Add(this.expressionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.displayList);
            this.Controls.Add(this.queuePushButton);
            this.Controls.Add(this.queuePeekButton);
            this.Controls.Add(this.queueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.queuePopButton);
            this.Controls.Add(this.stackPeekButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stackPopButton);
            this.Controls.Add(this.stackTextBox);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.stackPushButton);
            this.Name = "stackTester";
            this.Text = "Stack Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stackPushButton;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.TextBox stackTextBox;
        private System.Windows.Forms.Button stackPopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stackPeekButton;
        private System.Windows.Forms.Button queuePopButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox queueTextBox;
        private System.Windows.Forms.Button queuePeekButton;
        private System.Windows.Forms.Button queuePushButton;
        private System.Windows.Forms.ListBox displayList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expressionText;
        private System.Windows.Forms.Button evaluateButton;
        private System.Windows.Forms.Label Convert;
        private System.Windows.Forms.Button convertButton;
    }
}

