using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingAppFinal
{
    public class SQLHelper
    {

        public void InsertNoteTitleAndBody(string insertNoteTitle, string insertNoteBody)
        {
            string connectionString = GetConnectionString();

                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand("InsertNote", cnn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@NoteTitleDescription", insertNoteTitle));
                        command.Parameters.Add(new SqlParameter("@NoteBodyDescription", insertNoteBody));

                        command.ExecuteNonQuery();
                    }

                    cnn.Close();
                }
        }


        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }


        public string ViewNotes(string noteTitle)
        {
            string connectionString = GetConnectionString();
            string result = "";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand("ViewNotes",cnn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@NoteTitle", noteTitle));
                    command.ExecuteNonQuery();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = reader.GetString(0);
                        }
                    }
                }
                cnn.Close();
            }

            return result;
        }

        public static List<string> ViewNoteTitles()
        {
            string connectionString = GetConnectionString();
            string query = "select NoteTitleDescription from NoteTitle;";
            List<string> results = new List<string>();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader.GetString(0));
                        }
                    }
                }
                cnn.Close();
            }

            return results;
        }

        public void DeleteNote(string noteTitle)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection cnn = new SqlConnection(connectionString))
                using(SqlCommand command = new SqlCommand("DeleteNote",cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@NoteTitle", noteTitle));
                    command.ExecuteNonQuery();
                    cnn.Close();
                }

                    
        }


    }
}
