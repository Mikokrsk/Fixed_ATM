namespace Fixed_ATM
{
    partial class CheckForm
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
            this.checkListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // checkListBox
            // 
            this.checkListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkListBox.FormattingEnabled = true;
            this.checkListBox.ItemHeight = 20;
            this.checkListBox.Location = new System.Drawing.Point(13, 13);
            this.checkListBox.Name = "checkListBox";
            this.checkListBox.Size = new System.Drawing.Size(348, 404);
            this.checkListBox.TabIndex = 0;
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 422);
            this.Controls.Add(this.checkListBox);
            this.Name = "CheckForm";
            this.Text = "CheckForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox checkListBox;
    }
}