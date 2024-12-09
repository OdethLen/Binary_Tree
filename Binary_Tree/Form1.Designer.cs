namespace Binary_Tree
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
            label1 = new Label();
            txtNumbers = new TextBox();
            btnInsertion = new Button();
            btnDeletion = new Button();
            btnSearch = new Button();
            dgvTree = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTree).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 123);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // txtNumbers
            // 
            txtNumbers.Location = new Point(124, 120);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(100, 23);
            txtNumbers.TabIndex = 1;
            // 
            // btnInsertion
            // 
            btnInsertion.Location = new Point(67, 162);
            btnInsertion.Name = "btnInsertion";
            btnInsertion.Size = new Size(75, 23);
            btnInsertion.TabIndex = 2;
            btnInsertion.Text = "Insertion";
            btnInsertion.UseVisualStyleBackColor = true;
            btnInsertion.Click += btnInsertion_Click;
            // 
            // btnDeletion
            // 
            btnDeletion.Location = new Point(67, 204);
            btnDeletion.Name = "btnDeletion";
            btnDeletion.Size = new Size(75, 23);
            btnDeletion.TabIndex = 3;
            btnDeletion.Text = "Deletion ";
            btnDeletion.UseVisualStyleBackColor = true;
            btnDeletion.Click += btnDeletion_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(67, 245);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvTree
            // 
            dgvTree.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTree.Location = new Point(242, 67);
            dgvTree.Name = "dgvTree";
            dgvTree.Size = new Size(533, 215);
            dgvTree.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 349);
            Controls.Add(dgvTree);
            Controls.Add(btnSearch);
            Controls.Add(btnDeletion);
            Controls.Add(btnInsertion);
            Controls.Add(txtNumbers);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvTree).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumbers;
        private Button btnInsertion;
        private Button btnDeletion;
        private Button btnSearch;
        private DataGridView dgvTree;
    }
}
