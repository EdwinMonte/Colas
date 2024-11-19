namespace Colas
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
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnPeek = new Button();
            lstQueue = new ListBox();
            txtValue = new TextBox();
            SuspendLayout();
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(41, 55);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(139, 41);
            btnEnqueue.TabIndex = 0;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(41, 115);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(139, 46);
            btnDequeue.TabIndex = 1;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(41, 181);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(139, 40);
            btnPeek.TabIndex = 2;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            // 
            // lstQueue
            // 
            lstQueue.FormattingEnabled = true;
            lstQueue.Location = new Point(202, 23);
            lstQueue.Name = "lstQueue";
            lstQueue.Size = new Size(726, 404);
            lstQueue.TabIndex = 3;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(21, 455);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(374, 69);
            txtValue.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 613);
            Controls.Add(txtValue);
            Controls.Add(lstQueue);
            Controls.Add(btnPeek);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnPeek;
        private ListBox lstQueue;
        private TextBox txtValue;
    }
}
