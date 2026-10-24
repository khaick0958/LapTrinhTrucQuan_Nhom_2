namespace TiviManagementApp.AppForms
{
    partial class FormTest
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

        private void InitializeComponent()
        {
            addBtn = new Button();
            viewBtn = new Button();
            dataListBox = new ListBox();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(119, 348);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(157, 63);
            addBtn.TabIndex = 0;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // viewBtn
            // 
            viewBtn.Location = new Point(509, 348);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(157, 63);
            viewBtn.TabIndex = 2;
            viewBtn.Text = "Xem sản phẩm";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // dataListBox
            // 
            dataListBox.FormattingEnabled = true;
            dataListBox.Location = new Point(12, 12);
            dataListBox.Name = "dataListBox";
            dataListBox.Size = new Size(765, 284);
            dataListBox.TabIndex = 3;
            // 
            // FormTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataListBox);
            Controls.Add(viewBtn);
            Controls.Add(addBtn);
            Name = "FormTest";
            Text = "FormTest";
            ResumeLayout(false);
        }

        private Button addBtn;
        private Button viewBtn;
        private ListBox dataListBox;
    }
}