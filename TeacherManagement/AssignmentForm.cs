using System.Windows.Forms;
using TeacherManagement.Models;

namespace TeacherManagement
{
    public partial class AssignmentForm : Form
    {
        public AssignmentForm()
        {
            InitializeComponent();

            // Set properties of the FlowLayoutPanel
            QuestionList.AutoScroll = true;
            QuestionList.Dock = DockStyle.Fill;
            QuestionList.FlowDirection = FlowDirection.TopDown;
            QuestionList.WrapContents = false;

            QuestionList.VerticalScroll.Visible = true;
            QuestionList.VerticalScroll.Enabled = true;
        }

        private void AddItemWithTextBox(string text)
        {
            TextBox questiontextBox = new()
            {
                Text = text,
                Multiline = true,
                Width = QuestionList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 5,
                Height = 100,
                ScrollBars = ScrollBars.Vertical,
                Name = $"QuestiontextBox-{QuestionList.Controls.Count + 1}",
            };

            TextBox correctAnswerTextBox = new()
            {
                PlaceholderText = "Correct Answer Letter A,B,C ...",
                Name = $"CorrectAnswerTextBox-{QuestionList.Controls.Count + 1}",
            };

            Button deleteButton = new()
            {
                Text = "Delete",
                BackColor = Color.Red,
            };
            NumericUpDown mark = new()
            {
                Name = $"MarkNumericUpDown-{QuestionList.Controls.Count + 1}",
            };
            deleteButton.Click += (sender, e) =>
            {
                // Remove the panel containing the controls when the delete button is clicked
                if (deleteButton.Parent is FlowLayoutPanel panel)
                {
                    QuestionList.Controls.Remove(panel);
                    panel.Dispose(); // Dispose the panel to release its resources
                }
            };

            FlowLayoutPanel panel = new()
            {
                AutoSize = true,
                Controls = { questiontextBox, correctAnswerTextBox, mark, deleteButton },
            };

            QuestionList.Controls.Add(panel);

            QuestionList.ScrollControlIntoView(panel);
        }



        private void AddNewQuestion_Click(object sender, EventArgs e)
        {
            AddItemWithTextBox($"Question {QuestionList.Controls.Count + 1}: ");

        }

        private void SubmitAssignment(object sender, EventArgs e)
        {
            List<Question> questionList = new();
            var questionListControls = QuestionList.Controls;
            for (int i = 0; i < questionListControls.Count; i++)
            {
                var control = questionListControls[i];
                if (control is FlowLayoutPanel flowLayoutPanelPanel)
                {
                    questionList.Add(new());
                    foreach (var controlPanel in flowLayoutPanelPanel.Controls)
                    {


                        if (controlPanel is TextBox queestionPanel && queestionPanel.Name == $"QuestiontextBox-{i + 1}")
                            questionList[^1].Questions = queestionPanel.Text;

                        else if (controlPanel is TextBox correctAnswerPanel && correctAnswerPanel.Name == $"CorrectAnswerTextBox-{i + 1}")
                            questionList[^1].CorrectAnwser = correctAnswerPanel.Text;

                        else if (controlPanel is NumericUpDown markPanel && markPanel.Name  == $"MarkNumericUpDown-{i + 1}")
                            questionList[^1].Mark = Convert.ToDouble(markPanel.Value );

                    }


                }
            }
        }
    }
}
