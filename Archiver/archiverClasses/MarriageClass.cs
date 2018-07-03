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
    class MarriageClass
    {
        // Getter Setter Properties

        public int Id { get; set; }
        public DateTime date { get; set; }
        public string husbandName { get; set; }
        public string husbandFatherName { get; set; }
        public string husbandMotherName { get; set; }
        public string wifeName { get; set; }
        public string wifeFatherName { get; set; }
        public string wifeMotherName { get; set; }
        public string firstGodfather { get; set; }
        public string secondGodfather { get; set; }
        public string state { get; set; }
        public string rc { get; set; }
        public string notes { get; set; }
        public int bookNumber { get; set; }
        public int sheetNumber { get; set; }
        public int entryNumber { get; set; }
        public DateTime created_at { get; set; }
        public string placeBaptism { get; set; }

        static string myconnection = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        // Select all from tbl_marriage table
        public DataTable Select(string options = " WHERE 1=1")
        {
            // Database Connection
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                // Query
                string sql = "SELECT Id, date, husband_name, wife_name, husband_father_name, husband_mother_name, wife_father_name, wife_mother_name, first_godfather, second_godfather, state, rc, notes, book_number, sheet_number, entry_number, place_baptism from tbl_marriage" + options;
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

        // Insert data into tbl_marriage
        public bool Insert(MarriageClass marriage)
        {
            // Return type
            bool isSuccessfull = false;

            // Database Connection
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "INSERT INTO tbl_marriage (date, husband_name, wife_name, husband_father_name, husband_mother_name, wife_father_name, wife_mother_name, first_godfather, second_godfather, state, rc, notes, book_number, sheet_number, entry_number, created_at, place_baptism) VALUES (@date, @husband_name, @wife_name, @husband_father_name, @husband_mother_name, @wife_father_name, @wife_mother_name, @first_godfather, @second_godfather, @state, @rc, @notes, @book_number, @sheet_number, @entry_number, @created_at, @place_baptism)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", marriage.date);
                cmd.Parameters.AddWithValue("@husband_name", marriage.husbandName);
                cmd.Parameters.AddWithValue("@husband_father_name", marriage.husbandFatherName);
                cmd.Parameters.AddWithValue("@husband_mother_name", marriage.husbandMotherName);
                cmd.Parameters.AddWithValue("@wife_name", marriage.wifeName);
                cmd.Parameters.AddWithValue("@wife_father_name", marriage.wifeFatherName);
                cmd.Parameters.AddWithValue("@wife_mother_name", marriage.wifeMotherName);
                cmd.Parameters.AddWithValue("@first_godfather", marriage.firstGodfather);
                cmd.Parameters.AddWithValue("@second_godfather", marriage.secondGodfather);
                cmd.Parameters.AddWithValue("@state", marriage.state);
                cmd.Parameters.AddWithValue("@rc", marriage.rc);
                cmd.Parameters.AddWithValue("@notes", marriage.notes);
                cmd.Parameters.AddWithValue("@book_number", marriage.bookNumber);
                cmd.Parameters.AddWithValue("@sheet_number", marriage.sheetNumber);
                cmd.Parameters.AddWithValue("@entry_number", marriage.entryNumber);
                cmd.Parameters.AddWithValue("@created_at", marriage.created_at);
                cmd.Parameters.AddWithValue("@place_baptism", marriage.placeBaptism);

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

        // Update data into tbl_marriage
        public bool Update(MarriageClass marriage)
        {
            // Return type
            bool isSuccessfull = false;

            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "UPDATE tbl_marriage SET date = @date, husband_name = @husband_name, wife_name = @wife_name, husband_father_name = @husband_father_name, husband_mother_name = @husband_mother_name, wife_father_name = @wife_father_name, wife_mother_name = @wife_mother_name, first_godfather = @first_godfather, second_godfather = @second_godfather, state = @state, rc = @rc, notes = @notes, book_number = @book_number, sheet_number = @sheet_number, entry_number = @entry_number, place_baptism = @place_baptism WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", marriage.date);
                cmd.Parameters.AddWithValue("@husband_name", marriage.husbandName);
                cmd.Parameters.AddWithValue("@husband_father_name", marriage.husbandFatherName);
                cmd.Parameters.AddWithValue("@husband_mother_name", marriage.husbandMotherName);
                cmd.Parameters.AddWithValue("@wife_name", marriage.wifeName);
                cmd.Parameters.AddWithValue("@wife_father_name", marriage.wifeFatherName);
                cmd.Parameters.AddWithValue("@wife_mother_name", marriage.wifeMotherName);
                cmd.Parameters.AddWithValue("@first_godfather", marriage.firstGodfather);
                cmd.Parameters.AddWithValue("@second_godfather", marriage.secondGodfather);
                cmd.Parameters.AddWithValue("@state", marriage.state);
                cmd.Parameters.AddWithValue("@rc", marriage.rc);
                cmd.Parameters.AddWithValue("@notes", marriage.notes);
                cmd.Parameters.AddWithValue("@book_number", marriage.bookNumber);
                cmd.Parameters.AddWithValue("@sheet_number", marriage.sheetNumber);
                cmd.Parameters.AddWithValue("@entry_number", marriage.entryNumber);
                cmd.Parameters.AddWithValue("@place_baptism", marriage.placeBaptism);
                cmd.Parameters.AddWithValue("@id", marriage.Id);

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

        // Delete data into tbl_marriage
        public bool Delete(MarriageClass marriage)
        {
            // Return type
            bool isSuccessfull = false;

            // Database connection
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                // Query
                string sql = "DELETE FROM tbl_marriage WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", marriage.Id);

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
