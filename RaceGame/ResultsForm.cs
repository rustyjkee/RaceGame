namespace Race
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            resultsDataGridView.DataSource = GameResultStorage.GetAll();
        }
    }
}
