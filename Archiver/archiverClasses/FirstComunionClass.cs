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
    class FirstComunionClass
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

        // Select all from tbl_fist_comunion table
        public DataTable Select()
        {
            // Database Connection
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                // Query
                string sql = "SELECT Id, date, name, father_name, mother_name, first_godfather, second_godfather, state, municipality, notes, book_number, sheet_number, entry_number from tbl_first_comunion";
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

        // Insert data into tbl_first_comunion
        public bool Insert(FirstComunionClass firstComunion)
        {
            // Return type
            bool isSuccessfull = false;

            // Database Connection
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "INSERT INTO tbl_first_comunion (date, name, father_name, mother_name, first_godfather, second_godfather, state, municipality, notes, book_number, sheet_number, entry_number, created_at) VALUES (@date, @name, @father_name, @mother_name, @first_godfather, @second_godfather, @state, @municipality, @notes, @book_number, @sheet_number, @entry_number, @created_at)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", firstComunion.date);
                cmd.Parameters.AddWithValue("@name", firstComunion.name);
                cmd.Parameters.AddWithValue("@father_name", firstComunion.fatherName);
                cmd.Parameters.AddWithValue("@mother_name", firstComunion.motherName);
                cmd.Parameters.AddWithValue("@first_godfather", firstComunion.firstGodfather);
                cmd.Parameters.AddWithValue("@second_godfather", firstComunion.secondGodfather);
                cmd.Parameters.AddWithValue("@state", firstComunion.state);
                cmd.Parameters.AddWithValue("@municipality", firstComunion.municipality);
                cmd.Parameters.AddWithValue("@notes", firstComunion.notes);
                cmd.Parameters.AddWithValue("@book_number", firstComunion.bookNumber);
                cmd.Parameters.AddWithValue("@sheet_number", firstComunion.sheetNumber);
                cmd.Parameters.AddWithValue("@entry_number", firstComunion.entryNumber);
                cmd.Parameters.AddWithValue("@created_at", firstComunion.created_at);

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

        // Update data into tbl_first_comunion
        public bool Update(FirstComunionClass firstComunion)
        {
            // Return type
            bool isSuccessfull = false;

            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "UPDATE tbl_first_comunion SET date = @date, name = @name, father_name = @father_name, mother_name = @mother_name, first_godfather = @first_godfather, second_godfather = @second_godfather, state = @state, municipality = @municipality, notes = @notes, book_number = @book_number, sheet_number = @sheet_number, entry_number = @entry_number WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", firstComunion.date);
                cmd.Parameters.AddWithValue("@name", firstComunion.name);
                cmd.Parameters.AddWithValue("@father_name", firstComunion.fatherName);
                cmd.Parameters.AddWithValue("@mother_name", firstComunion.motherName);
                cmd.Parameters.AddWithValue("@first_godfather", firstComunion.firstGodfather);
                cmd.Parameters.AddWithValue("@second_godfather", firstComunion.secondGodfather);
                cmd.Parameters.AddWithValue("@state", firstComunion.state);
                cmd.Parameters.AddWithValue("@municipality", firstComunion.municipality);
                cmd.Parameters.AddWithValue("@notes", firstComunion.notes);
                cmd.Parameters.AddWithValue("@book_number", firstComunion.bookNumber);
                cmd.Parameters.AddWithValue("@sheet_number", firstComunion.sheetNumber);
                cmd.Parameters.AddWithValue("@entry_number", firstComunion.entryNumber);
                cmd.Parameters.AddWithValue("@id", firstComunion.Id);

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

        // Delete data into tbl_first_comunion
        public bool Delete(FirstComunionClass firstComunion)
        {
            // Return type
            bool isSuccessfull = false;

            // Database connection
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "DELETE FROM tbl_first_comunion WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", firstComunion.Id);

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
