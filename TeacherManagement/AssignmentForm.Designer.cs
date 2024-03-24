namespace TeacherManagement
{
    partial class AssignmentForm
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
            QuestionList = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            addNewQuestionToolStripMenuItem = new ToolStripMenuItem();
            submitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // QuestionList
            // 
            QuestionList.BackColor = SystemColors.ActiveCaption;
            QuestionList.Dock = DockStyle.Fill;
            QuestionList.Location = new Point(0, 24);
            QuestionList.Name = "QuestionList";
            QuestionList.Size = new Size(800, 426);
            QuestionList.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addNewQuestionToolStripMenuItem, submitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // addNewQuestionToolStripMenuItem
            // 
            addNewQuestionToolStripMenuItem.Name = "addNewQuestionToolStripMenuItem";
            addNewQuestionToolStripMenuItem.Size = new Size(119, 20);
            addNewQuestionToolStripMenuItem.Text = "Add New Question";
            addNewQuestionToolStripMenuItem.Click += AddNewQuestion_Click;
            // 
            // submitToolStripMenuItem
            // 
            submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            submitToolStripMenuItem.Size = new Size(57, 20);
            submitToolStripMenuItem.Text = "Submit";
            submitToolStripMenuItem.Click += SubmitAssignment;
            // 
            // AssignmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(QuestionList);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AssignmentForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel QuestionList;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addNewQuestionToolStripMenuItem;
        private ToolStripMenuItem submitToolStripMenuItem;
    }
}
