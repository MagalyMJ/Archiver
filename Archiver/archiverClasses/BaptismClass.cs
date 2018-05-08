using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.archiverClasses
{
    class BaptismClass
    {
        // Getter Setter Properties

        public int Id { get; set; }
        public DateTime date { get; set; }
        public string name { get; set; }
        public string fatherName { get; set; }
        public string motherName { get; set; }
        public string firstGodfather { get; set; }
        public string secondGodfather { get; set; }
        public string gender { get; set; }
        public string state { get; set; }
        public string municipality { get; set; }
        public string notes { get; set; }
        public int bookNumber { get; set; }
        public int sheetNumber { get; set; }
        public int entryNumber { get; set; }
        public DateTime created_at { get; set; }

        static string myconnection = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        // Select all from tbl_baptism table
        public DataTable Select()
        {
            // Database Connection
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                // Query
                string sql = "SELECT * from tbl_baptism";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        // Insert data into tbl_baptism
        public bool Insert(BaptismClass baptism)
        {
            // Return type
            bool isSuccessfull = false;

            // Database Connection
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "INSERT INTO tbl_baptism (date, name, gender, father_name, mother_name, first_godfather, second_godfather, state, municipality, notes, book_number, sheet_number, entry_number, created_at) VALUES (@date, @name, @gender, @father_name, @mother_name, @first_godfather, @second_godfather, @state, @municipality, @notes, @book_number, @sheet_number, @entry_number, @created_at)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", baptism.date);
                cmd.Parameters.AddWithValue("@name", baptism.name);
                cmd.Parameters.AddWithValue("@gender", baptism.gender);
                cmd.Parameters.AddWithValue("@father_name", baptism.fatherName);
                cmd.Parameters.AddWithValue("@mother_name", baptism.motherName);
                cmd.Parameters.AddWithValue("@first_godfather", baptism.firstGodfather);
                cmd.Parameters.AddWithValue("@second_godfather", baptism.secondGodfather);
                cmd.Parameters.AddWithValue("@state", baptism.state);
                cmd.Parameters.AddWithValue("@municipality", baptism.municipality);
                cmd.Parameters.AddWithValue("@notes", baptism.notes);
                cmd.Parameters.AddWithValue("@book_number", baptism.bookNumber);
                cmd.Parameters.AddWithValue("@sheet_number", baptism.sheetNumber);
                cmd.Parameters.AddWithValue("@entry_number", baptism.entryNumber);
                cmd.Parameters.AddWithValue("@created_at", baptism.created_at);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccessfull = true;
                }
                else
                {
                    isSuccessfull = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccessfull; 
        }

        // Update data into tbl_baptism
        public bool Update(BaptismClass baptism)
        {
            // Return type
            bool isSuccessfull = false;

            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "UPDATE tbl_baptism SET date = @date, name = @name, gender = @gender, father_name = @father_name, mother_name = @mother_name, first_godfather = @first_godfather, second_godfather = @second_godfather, state = @state, municipality = @municipality, notes = @notes, book_number = @book_number, sheet_number = @sheet_number, entry_number = @entry_number WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", baptism.date);
                cmd.Parameters.AddWithValue("@name", baptism.name);
                cmd.Parameters.AddWithValue("@gender", baptism.gender);
                cmd.Parameters.AddWithValue("@father_name", baptism.fatherName);
                cmd.Parameters.AddWithValue("@mother_name", baptism.motherName);
                cmd.Parameters.AddWithValue("@first_godfather", baptism.firstGodfather);
                cmd.Parameters.AddWithValue("@second_godfather", baptism.secondGodfather);
                cmd.Parameters.AddWithValue("@state", baptism.state);
                cmd.Parameters.AddWithValue("@municipality", baptism.municipality);
                cmd.Parameters.AddWithValue("@notes", baptism.notes);
                cmd.Parameters.AddWithValue("@book_number", baptism.bookNumber);
                cmd.Parameters.AddWithValue("@sheet_number", baptism.sheetNumber);
                cmd.Parameters.AddWithValue("@entry_number", baptism.entryNumber);
                cmd.Parameters.AddWithValue("@id", baptism.Id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccessfull = true;
                }
                else
                {
                    isSuccessfull = false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccessfull;
        }

        // Delete data into tbl_baptism
        public bool Delete(BaptismClass baptism)
        {
            // Return type
            bool isSuccessfull = false;

            // Database connection
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "DELETE FROM tbl_baptism WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", baptism.Id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccessfull = true;
                }
                else
                {
                    isSuccessfull = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccessfull;
        }
    }
}
