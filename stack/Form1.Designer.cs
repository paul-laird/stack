namespace stack
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
            this.Push = new System.Windows.Forms.Button();
            this.Pop = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Push
            // 
            this.Push.Location = new System.Drawing.Point(229, 78);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(75, 23);
            this.Push.TabIndex = 0;
            this.Push.Text = "Push";
            this.Push.UseVisualStyleBackColor = true;
            this.Push.Click += new System.EventHandler(this.Push_Click);
            // 
            // Pop
            // 
            this.Pop.Location = new System.Drawing.Point(229, 124);
            this.Pop.Name = "Pop";
            this.Pop.Size = new System.Drawing.Size(75, 23);
            this.Pop.TabIndex = 1;
            this.Pop.Text = "Pop";
            this.Pop.UseVisualStyleBackColor = true;
            this.Pop.Click += new System.EventHandler(this.Pop_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(229, 175);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(35, 13);
            this.Output.TabIndex = 2;
            this.Output.Text = "label1";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(229, 33);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(100, 20);
            this.Input.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 408);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Pop);
            this.Controls.Add(this.Push);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Push;
        private System.Windows.Forms.Button Pop;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.TextBox Input;
    }
}

