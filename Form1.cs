using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Configuration;

namespace NoteTakingAppFinal
{
    public partial class Form1 : Form
    {

        SQLHelper dbHelper = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertNoteTitleForm = Title.Text;
            string insertNoteBodyForm = Body.Text;

            try
            {

                dbHelper.InsertNoteTitleAndBody(insertNoteTitleForm, insertNoteBodyForm);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Note Added!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string noteTitle = NoteTitles.Text;

                string dataGridResult = dbHelper.ViewNotes(noteTitle);

                DataTable dt = new DataTable();
                dt.Columns.Add("Note");

                DataRow row = dt.NewRow();
                row["Note"] = dataGridResult;
                dt.Rows.Add(row);

                DisplaySQL.DataSource = dt;
                DisplaySQL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DisplaySQL.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> loadedNoteTitles = SQLHelper.ViewNoteTitles();
            NoteTitles.DataSource = loadedNoteTitles;
        }

        private void DisplaySQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string noteTitle = NoteTitles.Text;
                dbHelper.DeleteNote(noteTitle);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Note Deleted!");
            }
        }
    }
}