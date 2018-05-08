using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archiver.archiverClasses
{
    class ConfirmationClass
    {
        // Getter Setter Properties

        public int Id { get; set; }
        public DateTime date { get; set; }
        public string name { get; set; }
        public string fatherName { get; set; }
        public string motherName { get; set; }
        public string firstGodfather { get; set; }
        public string secondGodfather { get; set; }
        public string state { get; set; }
        public string municipality { get; set; }
        public string notes { get; set; }
        public int bookNumber { get; set; }
        public int sheetNumber { get; set; }
        public int entryNumber { get; set; }
        public DateTime created_at { get; set; }

        static string myconnection = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        // Select all from tbl_confirmation table
        public DataTable Select(string options = " WHERE 1=1")
        {
            // Database Connection
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                // Query
                string sql = "SELECT Id, date, name, father_name, mother_name, first_godfather, second_godfather, state, municipality, notes, book_number, sheet_number, entry_number from tbl_confirmation" + options;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        // Insert data into tbl_confirmation
        public bool Insert(ConfirmationClass confirmation)
        {
            // Return type
            bool isSuccessfull = false;

            // Database Connection
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "INSERT INTO tbl_confirmation (date, name, father_name, mother_name, first_godfather, second_godfather, state, municipality, notes, book_number, sheet_number, entry_number, created_at) VALUES (@date, @name, @father_name, @mother_name, @first_godfather, @second_godfather, @state, @municipality, @notes, @book_number, @sheet_number, @entry_number, @created_at)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", confirmation.date);
                cmd.Parameters.AddWithValue("@name", confirmation.name);
                cmd.Parameters.AddWithValue("@father_name", confirmation.fatherName);
                cmd.Parameters.AddWithValue("@mother_name", confirmation.motherName);
                cmd.Parameters.AddWithValue("@first_godfather", confirmation.firstGodfather);
                cmd.Parameters.AddWithValue("@second_godfather", confirmation.secondGodfather);
                cmd.Parameters.AddWithValue("@state", confirmation.state);
                cmd.Parameters.AddWithValue("@municipality", confirmation.municipality);
                cmd.Parameters.AddWithValue("@notes", confirmation.notes);
                cmd.Parameters.AddWithValue("@book_number", confirmation.bookNumber);
                cmd.Parameters.AddWithValue("@sheet_number", confirmation.sheetNumber);
                cmd.Parameters.AddWithValue("@entry_number", confirmation.entryNumber);
                cmd.Parameters.AddWithValue("@created_at", confirmation.created_at);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccessfull = true;
                }
                else
                {
                    isSuccessfull = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccessfull;
        }

        // Update data into tbl_confirmation
        public bool Update(ConfirmationClass confirmation)
        {
            // Return type
            bool isSuccessfull = false;

            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "UPDATE tbl_confirmation SET date = @date, name = @name, father_name = @father_name, mother_name = @mother_name, first_godfather = @first_godfather, second_godfather = @second_godfather, state = @state, municipality = @municipality, notes = @notes, book_number = @book_number, sheet_number = @sheet_number, entry_number = @entry_number WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", confirmation.date);
                cmd.Parameters.AddWithValue("@name", confirmation.name);
                cmd.Parameters.AddWithValue("@father_name", confirmation.fatherName);
                cmd.Parameters.AddWithValue("@mother_name", confirmation.motherName);
                cmd.Parameters.AddWithValue("@first_godfather", confirmation.firstGodfather);
                cmd.Parameters.AddWithValue("@second_godfather", confirmation.secondGodfather);
                cmd.Parameters.AddWithValue("@state", confirmation.state);
                cmd.Parameters.AddWithValue("@municipality", confirmation.municipality);
                cmd.Parameters.AddWithValue("@notes", confirmation.notes);
                cmd.Parameters.AddWithValue("@book_number", confirmation.bookNumber);
                cmd.Parameters.AddWithValue("@sheet_number", confirmation.sheetNumber);
                cmd.Parameters.AddWithValue("@entry_number", confirmation.entryNumber);
                cmd.Parameters.AddWithValue("@id", confirmation.Id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccessfull = true;
                }
                else
                {
                    isSuccessfull = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccessfull;
        }

        // Delete data into tbl_confirmation
        public bool Delete(ConfirmationClass confirmation)
        {
            // Return type
            bool isSuccessfull = false;

            // Database connection
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "DELETE FROM tbl_confirmation WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", confirmation.Id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccessfull = true;
                }
                else
                {
                    isSuccessfull = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccessfull;
        }
    }
}
