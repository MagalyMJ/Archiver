using Archiver.archiverClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Word = Microsoft.Office.Interop.Word;
using System.Globalization;

namespace Archiver
{
    public partial class Archiver : Form
    {
        public Archiver()
        {
            InitializeComponent();
        }

        BaptismClass baptism = new BaptismClass();
        FirstComunionClass firstComunion = new FirstComunionClass();
        ConfirmationClass confirmation = new ConfirmationClass();
        MarriageClass marriage = new MarriageClass();

        // Clear baptism text boxes
        public void clearBaptism()
        {
            textBoxIdB.Text = "0";
            dateTimePickerBaptism.Value = DateTime.Now;
            textBoxNameB.Text = "";
            textBoxFatherNameB.Text = "";
            textBoxMotherNameB.Text = "";
            textBoxGodFather1B.Text = "";
            textBoxGodFather2B.Text = "";
            textBoxStateB.Text = "";
            textBoxRCB.Text = "";
            textBoxNotesB.Text = "";
            textBoxBookNumberB.Text = "";
            textBoxSheetNumberB.Text = "";
            textBoxEntryNumberB.Text = "";
        }

        public void clearSearchBaptism()
        {
            textBoxSearchNameB.Text = "";
            textBoxSearchBookB.Text = "";
            textBoxSearchSheetB.Text = "";
            textBoxEntryNumberB.Text = "";
        }

        // Clear first comunion text boxes
        public void clearFirstComunion()
        {
            textBoxIdF.Text = "0";
            dateTimePickerFirstComunion.Value = DateTime.Now;
            textBoxNameF.Text = "";
            textBoxFatherNameF.Text = "";
            textBoxMotherNameF.Text = "";
            textBoxGodFather1F.Text = "";
            textBoxGodFather2F.Text = "";
            textBoxStateF.Text = "";
            textBoxRCF.Text = "";
            textBoxNotesF.Text = "";
            textBoxBookNumberF.Text = "";
            textBoxSheetNumberF.Text = "";
            textBoxEntryNumberF.Text = "";
        }

        public void clearSearchFirstComunion()
        {
            textBoxSearchNameF.Text = "";
            textBoxSearchBookF.Text = "";
            textBoxSearchSheetF.Text = "";
            textBoxEntryNumberF.Text = "";
        }

        // Clear confirmation text boxes
        public void clearConfirmation()
        {
            textBoxIdC.Text = "0";
            dateTimePickerConfirmation.Value = DateTime.Now;
            textBoxNameC.Text = "";
            textBoxFatherNameC.Text = "";
            textBoxMotherNameC.Text = "";
            textBoxGodFather1C.Text = "";
            textBoxGodFather2C.Text = "";
            textBoxStateC.Text = "";
            textBoxRCC.Text = "";
            textBoxNotesC.Text = "";
            textBoxBookNumberC.Text = "";
            textBoxSheetNumberC.Text = "";
            textBoxEntryNumberC.Text = "";
        }

        public void clearSearchConfirmation()
        {
            textBoxSearchNameC.Text = "";
            textBoxSearchBookC.Text = "";
            textBoxSearchSheetC.Text = "";
            textBoxEntryNumberC.Text = "";
        }

        // Clear confirmation text boxes
        public void clearMarriage()
        {
            textBoxIdM.Text = "0";
            dateTimePickerMarriage.Value = DateTime.Now;
            textBoxWifeNameM.Text = "";
            textBoxHusbandNameM.Text = "";
            textBoxWifeMotherNameM.Text = "";
            textBoxWifeFatherNameM.Text = "";
            textBoxHusbandMotherNameM.Text = "";
            textBoxHusbandFatherNameM.Text = "";
            textBoxGodFather1M.Text = "";
            textBoxGodFather2M.Text = "";
            textBoxPlaceBaptismM.Text = "";
            textBoxStateM.Text = "";
            textBoxRCM.Text = "";
            textBoxNotesM.Text = "";
            textBoxBookNumberM.Text = "";
            textBoxSheetNumberM.Text = "";
            textBoxEntryNumberM.Text = "";
        }

        public void clearSearchMarriage()
        {
            textBoxSearchNameM.Text = "";
            textBoxSearchBookM.Text = "";
            textBoxSearchSheetM.Text = "";
            textBoxEntryNumberM.Text = "";
        }

        private void buttonSaveB_Click(object sender, EventArgs e)
        {
            // Get values from text boxes
            baptism.Id = int.Parse(textBoxIdB.Text);
            baptism.date = dateTimePickerBaptism.Value;
            baptism.name = textBoxNameB.Text;
            baptism.fatherName = textBoxFatherNameB.Text;
            baptism.motherName = textBoxMotherNameB.Text;
            baptism.firstGodfather = textBoxGodFather1B.Text;
            baptism.secondGodfather = textBoxGodFather2B.Text;
            if (radioButtonFemeninB.Checked)
                baptism.gender = radioButtonFemeninB.Text;
            else
                baptism.gender = radioButtonMasculinB.Text;
            baptism.state = textBoxStateB.Text;
            baptism.rc = textBoxRCB.Text;
            baptism.notes = textBoxNotesB.Text;
            int bookValue;
            if (int.TryParse(textBoxBookNumberB.Text, out bookValue))
                baptism.bookNumber = bookValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para el libro.");
                return;
            }
            int sheetValue;
            if (int.TryParse(textBoxSheetNumberB.Text, out sheetValue))
                baptism.sheetNumber = sheetValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para el folio.");
                return;
            }
            int entryValue;
            if (int.TryParse(textBoxEntryNumberB.Text, out entryValue))
                baptism.entryNumber = entryValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para la partida.");
                return;
            }
            baptism.created_at = DateTime.Now;

            if(baptism.Id > 0)
            {
                // Update data
                if(baptism.Update(baptism))
                {
                    MessageBox.Show("El registro fue guardado exitosamente.");
                    clearBaptism();
                }
                else
                    MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");
            }
            else
            {
                // Insert data
                if (baptism.Insert(baptism))
                {
                    MessageBox.Show("El registro fue guardado exitosamente.");
                    clearBaptism();
                }
                else
                    MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");
            }

            // Load data in gridView
            DataTable dt = baptism.Select();
            dataGridViewBaptism.DataSource = dt;
        }

        private void buttonSaveF_Click(object sender, EventArgs e)
        {
            // Get values from text boxes
            firstComunion.Id = int.Parse(textBoxIdF.Text);
            firstComunion.date = dateTimePickerFirstComunion.Value;
            firstComunion.name = textBoxNameF.Text;
            firstComunion.fatherName = textBoxFatherNameF.Text;
            firstComunion.motherName = textBoxMotherNameF.Text;
            firstComunion.firstGodfather = textBoxGodFather1F.Text;
            firstComunion.secondGodfather = textBoxGodFather2F.Text;
            firstComunion.state = textBoxStateF.Text;
            firstComunion.rc = textBoxRCF.Text;
            firstComunion.notes = textBoxNotesF.Text;
            int bookValue;
            if (int.TryParse(textBoxBookNumberF.Text, out bookValue))
                firstComunion.bookNumber = bookValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para el libro.");
                return;
            }
            int sheetValue;
            if (int.TryParse(textBoxSheetNumberF.Text, out sheetValue))
                firstComunion.sheetNumber = sheetValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para el folio.");
                return;
            }
            int entryValue;
            if (int.TryParse(textBoxEntryNumberF.Text, out entryValue))
                firstComunion.entryNumber = entryValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para la partida.");
                return;
            }
            firstComunion.created_at = DateTime.Now;

            if (firstComunion.Id > 0)
            {
                // Update data
                if (firstComunion.Update(firstComunion))
                {
                    MessageBox.Show("El registro fue guardado exitosamente.");
                    clearFirstComunion();
                }
                else
                    MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");
            }
            else
            {
                // Insert data
                if (firstComunion.Insert(firstComunion))
                {
                    MessageBox.Show("El registro fue guardado exitosamente.");
                    clearFirstComunion();
                }
                else
                    MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");
            }

            // Load data in gridView
            DataTable dt = firstComunion.Select();
            dataGridViewFisrtComunion.DataSource = dt;
        }

        private void buttonSaveC_Click(object sender, EventArgs e)
        {
            // Get values from text boxes
            confirmation.Id = int.Parse(textBoxIdC.Text);
            confirmation.date = dateTimePickerConfirmation.Value;
            confirmation.name = textBoxNameC.Text;
            confirmation.fatherName = textBoxFatherNameC.Text;
            confirmation.motherName = textBoxMotherNameC.Text;
            confirmation.firstGodfather = textBoxGodFather1C.Text;
            confirmation.secondGodfather = textBoxGodFather2C.Text;
            confirmation.state = textBoxStateC.Text;
            confirmation.rc = textBoxRCC.Text;
            confirmation.notes = textBoxNotesC.Text;
            int bookValue;
            if (int.TryParse(textBoxBookNumberC.Text, out bookValue))
                confirmation.bookNumber = bookValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para el libro.");
                return;
            }
            int sheetValue;
            if (int.TryParse(textBoxSheetNumberC.Text, out sheetValue))
                confirmation.sheetNumber = sheetValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para el folio.");
                return;
            }
            int entryValue;
            if (int.TryParse(textBoxEntryNumberC.Text, out entryValue))
                confirmation.entryNumber = entryValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para la partida.");
                return;
            }
            confirmation.created_at = DateTime.Now;

            if (confirmation.Id > 0)
            {
                // Update data
                if (confirmation.Update(confirmation))
                {
                    MessageBox.Show("El registro fue guardado exitosamente.");
                    clearConfirmation();
                }
                else
                    MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");
            }
            else
            {
                // Insert data
                if (confirmation.Insert(confirmation))
                {
                    MessageBox.Show("El registro fue guardado exitosamente.");
                    clearConfirmation();
                }
                else
                    MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");
            }

            // Load data in gridView
            DataTable dt = confirmation.Select();
            dataGridViewConfirmation.DataSource = dt;
        }

        private void buttonSaveM_Click(object sender, EventArgs e)
        {
            // Get values from text boxes
            marriage.Id = int.Parse(textBoxIdM.Text);
            marriage.date = dateTimePickerMarriage.Value;
            marriage.wifeName = textBoxWifeNameM.Text;
            marriage.husbandName = textBoxHusbandNameM.Text;
            marriage.wifeMotherName = textBoxWifeMotherNameM.Text;
            marriage.wifeFatherName = textBoxWifeFatherNameM.Text;
            marriage.husbandMotherName = textBoxHusbandMotherNameM.Text;
            marriage.husbandFatherName = textBoxHusbandFatherNameM.Text;
            marriage.firstGodfather = textBoxGodFather1M.Text;
            marriage.secondGodfather = textBoxGodFather2M.Text;
            marriage.placeBaptism = textBoxPlaceBaptismM.Text;
            marriage.state = textBoxStateM.Text;
            marriage.rc = textBoxRCM.Text;
            marriage.notes = textBoxNotesM.Text;
            int bookValue;
            if (int.TryParse(textBoxBookNumberM.Text, out bookValue))
                marriage.bookNumber = bookValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para el libro.");
                return;
            }
            int sheetValue;
            if (int.TryParse(textBoxSheetNumberM.Text, out sheetValue))
                marriage.sheetNumber = sheetValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para el folio.");
                return;
            }
            int entryValue;
            if (int.TryParse(textBoxEntryNumberM.Text, out entryValue))
                marriage.entryNumber = entryValue;
            else
            {
                MessageBox.Show("Solo se permiten números enteros para la partida.");
                return;
            }
            marriage.created_at = DateTime.Now;

            if (marriage.Id > 0)
            {
                // Update data
                if (marriage.Update(marriage))
                {
                    MessageBox.Show("El registro fue guardado exitosamente.");
                    clearMarriage();
                }
                else
                    MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");
            }
            else
            {
                // Insert data
                if (marriage.Insert(marriage))
                {
                    MessageBox.Show("El registro fue guardado exitosamente.");
                    clearMarriage();
                }
                else
                    MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");
            }

            // Load data in gridView
            DataTable dt = marriage.Select();
            dataGridViewMarriage.DataSource = dt;
        }

        private void dataGridViewBaptism_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get data from data grid view into text boxes
            int rowIndex = e.RowIndex;
            textBoxIdB.Text = dataGridViewBaptism.Rows[rowIndex].Cells[0].Value.ToString();
            dateTimePickerBaptism.Value = Convert.ToDateTime(dataGridViewBaptism.Rows[rowIndex].Cells[1].Value);
            textBoxNameB.Text = dataGridViewBaptism.Rows[rowIndex].Cells[2].Value.ToString();
            if (dataGridViewBaptism.Rows[rowIndex].Cells[3].Value.ToString() == "Femenino")
            {
                radioButtonFemeninB.Checked = true;
                radioButtonMasculinB.Checked = false;
            }
            else
            {
                radioButtonFemeninB.Checked = false;
                radioButtonMasculinB.Checked = true;
            }
            textBoxFatherNameB.Text = dataGridViewBaptism.Rows[rowIndex].Cells[4].Value.ToString();
            textBoxMotherNameB.Text = dataGridViewBaptism.Rows[rowIndex].Cells[5].Value.ToString();
            textBoxGodFather1B.Text = dataGridViewBaptism.Rows[rowIndex].Cells[6].Value.ToString();
            textBoxGodFather2B.Text = dataGridViewBaptism.Rows[rowIndex].Cells[7].Value.ToString();
            textBoxStateB.Text = dataGridViewBaptism.Rows[rowIndex].Cells[8].Value.ToString();
            textBoxRCB.Text = dataGridViewBaptism.Rows[rowIndex].Cells[9].Value.ToString();
            textBoxNotesB.Text = dataGridViewBaptism.Rows[rowIndex].Cells[10].Value.ToString();
            textBoxBookNumberB.Text = dataGridViewBaptism.Rows[rowIndex].Cells[11].Value.ToString();
            textBoxSheetNumberB.Text = dataGridViewBaptism.Rows[rowIndex].Cells[12].Value.ToString();
            textBoxEntryNumberB.Text = dataGridViewBaptism.Rows[rowIndex].Cells[13].Value.ToString();
        }

        private void dataGridViewFisrtComunion_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get data from data grid view into text boxes
            int rowIndex = e.RowIndex;
            textBoxIdF.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[0].Value.ToString();
            dateTimePickerFirstComunion.Value = Convert.ToDateTime(dataGridViewFisrtComunion.Rows[rowIndex].Cells[1].Value);
            textBoxNameF.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxFatherNameF.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxMotherNameF.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[4].Value.ToString();
            textBoxGodFather1F.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[5].Value.ToString();
            textBoxGodFather2F.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[6].Value.ToString();
            textBoxStateF.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[7].Value.ToString();
            textBoxRCF.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[8].Value.ToString();
            textBoxNotesF.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[9].Value.ToString();
            textBoxBookNumberF.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[10].Value.ToString();
            textBoxSheetNumberF.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[11].Value.ToString();
            textBoxEntryNumberF.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[12].Value.ToString();
        }

        private void dataGridViewConfirmation_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get data from data grid view into text boxes
            int rowIndex = e.RowIndex;
            textBoxIdC.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[0].Value.ToString();
            dateTimePickerConfirmation.Value = Convert.ToDateTime(dataGridViewConfirmation.Rows[rowIndex].Cells[1].Value);
            textBoxNameC.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[2].Value.ToString(); ;
            textBoxFatherNameC.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[3].Value.ToString(); ;
            textBoxMotherNameC.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[4].Value.ToString(); ;
            textBoxGodFather1C.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[5].Value.ToString(); ;
            textBoxGodFather2C.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[6].Value.ToString(); ;
            textBoxStateC.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[7].Value.ToString(); ;
            textBoxRCC.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[8].Value.ToString(); ;
            textBoxNotesC.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[9].Value.ToString(); ;
            textBoxBookNumberC.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[10].Value.ToString(); ;
            textBoxSheetNumberC.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[11].Value.ToString(); ;
            textBoxEntryNumberC.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[12].Value.ToString(); ;
        }

        private void dataGridViewMarriage_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get data from data grid view into text boxes
            int rowIndex = e.RowIndex;
            textBoxIdM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[0].Value.ToString();
            dateTimePickerMarriage.Value = Convert.ToDateTime(dataGridViewMarriage.Rows[rowIndex].Cells[1].Value);
            textBoxWifeNameM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxHusbandNameM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxWifeMotherNameM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[7].Value.ToString();
            textBoxWifeFatherNameM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[6].Value.ToString();
            textBoxHusbandMotherNameM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[5].Value.ToString();
            textBoxHusbandFatherNameM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[4].Value.ToString();
            textBoxGodFather1M.Text = dataGridViewMarriage.Rows[rowIndex].Cells[8].Value.ToString();
            textBoxGodFather2M.Text = dataGridViewMarriage.Rows[rowIndex].Cells[9].Value.ToString();
            textBoxStateM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[10].Value.ToString();
            textBoxRCM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[11].Value.ToString();
            textBoxNotesM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[12].Value.ToString();
            textBoxBookNumberM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[13].Value.ToString();
            textBoxSheetNumberM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[14].Value.ToString();
            textBoxEntryNumberM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[15].Value.ToString();
            textBoxPlaceBaptismM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[16].Value.ToString();
        }

        private void buttonClearB_Click(object sender, EventArgs e)
        {
            clearBaptism();
        }

        private void buttonClearF_Click(object sender, EventArgs e)
        {
            clearFirstComunion();
        }

        private void buttonClearC_Click(object sender, EventArgs e)
        {
            clearConfirmation();
        }

        private void buttonClearM_Click(object sender, EventArgs e)
        {
            clearMarriage();
        }

        private void buttonDeleteB_Click(object sender, EventArgs e)
        {
            // Get id from text box
            baptism.Id = int.Parse(textBoxIdB.Text);

            DialogResult result = MessageBox.Show("¿Estas seguro que quieres borrar el registro No. " + baptism.Id + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Delete data
                if (baptism.Delete(baptism))
                {
                    MessageBox.Show("El registro se elimino exitosamente.");
                    clearBaptism();
                }
                else
                    MessageBox.Show("No se pudo eliminar el registro, inténtelo nuevamente.");

                // Load data in gridView
                DataTable dt = baptism.Select();
                dataGridViewBaptism.DataSource = dt;
            }
        }

        private void buttonDeleteF_Click(object sender, EventArgs e)
        {
            // Get id from text box
            firstComunion.Id = int.Parse(textBoxIdF.Text);

            DialogResult result = MessageBox.Show("¿Estas seguro que quieres borrar el registro No. " + firstComunion.Id + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Delete data
                if (firstComunion.Delete(firstComunion))
                {
                    MessageBox.Show("El registro se elimino exitosamente.");
                    clearFirstComunion();
                }
                else
                    MessageBox.Show("No se pudo eliminar el registro, inténtelo nuevamente.");

                // Load data in gridView
                DataTable dt = firstComunion.Select();
                dataGridViewFisrtComunion.DataSource = dt;
            }
        }

        private void buttonDeleteC_Click(object sender, EventArgs e)
        {
            // Get id from text box
            confirmation.Id = int.Parse(textBoxIdC.Text);

            DialogResult result = MessageBox.Show("¿Estas seguro que quieres borrar el registro No. " + confirmation.Id + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Delete data
                if (confirmation.Delete(confirmation))
                {
                    MessageBox.Show("El registro se elimino exitosamente.");
                    clearConfirmation();
                }
                else
                    MessageBox.Show("No se pudo eliminar el registro, inténtelo nuevamente.");

                // Load data in gridView
                DataTable dt = confirmation.Select();
                dataGridViewConfirmation.DataSource = dt;
            }
        }

        private void buttonDeleteM_Click(object sender, EventArgs e)
        {
            // Get id from text box
            marriage.Id = int.Parse(textBoxIdM.Text);

            DialogResult result = MessageBox.Show("¿Estas seguro que quieres borrar el registro No. " + marriage.Id + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Delete data
                if (marriage.Delete(marriage))
                {
                    MessageBox.Show("El registro se elimino exitosamente.");
                    clearMarriage();
                }
                else
                    MessageBox.Show("No se pudo eliminar el registro, inténtelo nuevamente.");

                // Load data in gridView
                DataTable dt = marriage.Select();
                dataGridViewMarriage.DataSource = dt;
            }
        }

        private void buttonSearchB_Click(object sender, EventArgs e)
        {
            string sqlOptions = " WHERE 1=1";

            // Get values to search
            if (textBoxSearchNameB.Text != "")
                sqlOptions += " AND name LIKE '%" + textBoxSearchNameB.Text + "%'";
            if (textBoxSearchBookB.Text != "")
                sqlOptions += " AND book_number = " + textBoxSearchBookB.Text;
            if (textBoxSearchSheetB.Text != "")
                sqlOptions += " AND sheet_number = " + textBoxSearchSheetB.Text;
            if (textBoxSearchEntryB.Text != "")
                sqlOptions += " AND entry_number = " + textBoxSearchEntryB.Text;
            if (dateTimePickerSearchB.Checked)
                sqlOptions += " AND date BETWEEN '" + dateTimePickerSearchB.Value.ToShortDateString() + " 00:00' AND '" + dateTimePickerSearchB.Value.ToShortDateString() + " 23:59:59'";

            DataTable dt = baptism.Select(sqlOptions);
            dataGridViewBaptism.DataSource = dt;

            clearSearchBaptism();
        }

        private void buttonSearchF_Click(object sender, EventArgs e)
        {
            string sqlOptions = " WHERE 1=1";

            // Get values to search
            if (textBoxSearchNameF.Text != "")
                sqlOptions += " AND name LIKE '%" + textBoxSearchNameF.Text + "%'";
            if (textBoxSearchBookF.Text != "")
                sqlOptions += " AND book_number = " + textBoxSearchBookF.Text;
            if (textBoxSearchSheetF.Text != "")
                sqlOptions += " AND sheet_number = " + textBoxSearchSheetF.Text;
            if (textBoxSearchEntryF.Text != "")
                sqlOptions += " AND entry_number = " + textBoxSearchEntryF.Text;
            if (dateTimePickerSearchF.Checked)
                sqlOptions += " AND date BETWEEN '" + dateTimePickerSearchF.Value.ToShortDateString() + " 00:00' AND '" + dateTimePickerSearchF.Value.ToShortDateString() + " 23:59:59'";

            DataTable dt = firstComunion.Select(sqlOptions);
            dataGridViewFisrtComunion.DataSource = dt;

            clearSearchFirstComunion();
        }

        private void buttonSearchC_Click(object sender, EventArgs e)
        {
            string sqlOptions = " WHERE 1=1";

            // Get values to search
            if (textBoxSearchNameC.Text != "")
                sqlOptions += " AND name LIKE '%" + textBoxSearchNameC.Text + "%'";
            if (textBoxSearchBookC.Text != "")
                sqlOptions += " AND book_number = " + textBoxSearchBookC.Text;
            if (textBoxSearchSheetC.Text != "")
                sqlOptions += " AND sheet_number = " + textBoxSearchSheetC.Text;
            if (textBoxSearchEntryC.Text != "")
                sqlOptions += " AND entry_number = " + textBoxSearchEntryC.Text;
            if (dateTimePickerSearchC.Checked)
                sqlOptions += " AND date BETWEEN '" + dateTimePickerSearchC.Value.ToShortDateString() + " 00:00' AND '" + dateTimePickerSearchC.Value.ToShortDateString() + " 23:59:59'";

            DataTable dt = confirmation.Select(sqlOptions);
            dataGridViewConfirmation.DataSource = dt;

            clearSearchConfirmation();
        }

        private void buttonSearchM_Click(object sender, EventArgs e)
        {
            string sqlOptions = " WHERE 1=1";

            // Get values to search
            if (textBoxSearchNameM.Text != "")
                sqlOptions += " AND name LIKE '%" + textBoxSearchNameM.Text + "%'";
            if (textBoxSearchBookM.Text != "")
                sqlOptions += " AND book_number = " + textBoxSearchBookM.Text;
            if (textBoxSearchSheetM.Text != "")
                sqlOptions += " AND sheet_number = " + textBoxSearchSheetM.Text;
            if (textBoxSearchEntryM.Text != "")
                sqlOptions += " AND entry_number = " + textBoxSearchEntryM.Text;
            if (dateTimePickerSearchM.Checked)
                sqlOptions += " AND date BETWEEN '" + dateTimePickerSearchM.Value.ToShortDateString() + " 00:00' AND '" + dateTimePickerSearchM.Value.ToShortDateString() + " 23:59:59'";

            DataTable dt = marriage.Select(sqlOptions);
            dataGridViewMarriage.DataSource = dt;

            clearSearchMarriage();

        }
        
        private void buttonBaptism_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabBaptism;
            buttonBaptism.BackColor = Color.FromArgb(35, 45, 43);
            buttonFirstComunion.BackColor = Color.FromArgb(41, 53, 55);
            buttonConfirmation.BackColor = Color.FromArgb(41, 53, 55);
            buttonMarriage.BackColor = Color.FromArgb(41, 53, 55);
        }

        private void buttonBaptism_MouseEnter(object sender, EventArgs e)
        {
            buttonBaptism.ForeColor = Color.FromArgb(229, 126, 49);

        }
        private void buttonBaptism_MouseLeave(object sender, EventArgs e)
        {
            buttonBaptism.ForeColor = Color.LightGray;
         

        }

        private void buttonFirstComunion_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabFirstComunion;
            buttonBaptism.BackColor = Color.FromArgb(41, 53, 55);
            buttonFirstComunion.BackColor = Color.FromArgb(35, 45, 43);
            buttonConfirmation.BackColor = Color.FromArgb(41, 53, 55);
            buttonMarriage.BackColor = Color.FromArgb(41, 53, 55);
        }

        private void buttonFirstComunion_Enter(object sender, EventArgs e)
        {
            buttonFirstComunion.ForeColor = Color.FromArgb(229, 126, 49);

        }
        private void buttonFirstComunion_Leave(object sender, EventArgs e)
        {
            buttonFirstComunion.ForeColor = Color.LightGray;
        }

        private void buttonConfirmation_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabConfirmation;
            buttonBaptism.BackColor = Color.FromArgb(41, 53, 55);
            buttonFirstComunion.BackColor = Color.FromArgb(41, 53, 55);
            buttonConfirmation.BackColor = Color.FromArgb(35, 45, 43);
            buttonMarriage.BackColor = Color.FromArgb(41, 53, 55);
        }
        private void buttonConfirmation_Enter(object sender, EventArgs e)
        {
            buttonConfirmation.ForeColor = Color.FromArgb(229, 126, 49);

        }
        private void buttonConfirmation_MouseLeave(object sender, EventArgs e)
        {
            buttonConfirmation.ForeColor = Color.LightGray;
        }
        private void buttonMarriage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabMarriage;
            buttonBaptism.BackColor = Color.FromArgb(41, 53, 55);
            buttonFirstComunion.BackColor = Color.FromArgb(41, 53, 55);
            buttonConfirmation.BackColor = Color.FromArgb(41, 53, 55);
            buttonMarriage.BackColor = Color.FromArgb(35, 45, 43);
        }
        private void buttonMarriage_Enter(object sender, EventArgs e)
        {
            buttonMarriage.ForeColor = Color.FromArgb(229, 126, 49);

        }
        private void buttonMarriage_MouseLeave(object sender, EventArgs e)
        {
            buttonMarriage.ForeColor = Color.LightGray;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabHome;
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabFirstComunion"])
            {
                object objMissing = System.Reflection.Missing.Value;
                Word.Application objWord = new Word.Application();
                string route = Application.StartupPath + @"\acta_primera_comunion.docx";
                object param = route;
                Word.Document objDoc = objWord.Documents.Open(param, ref objMissing);

                DateTime date = dateTimePickerFirstComunion.Value;

                Word.ContentControls days = objDoc.SelectContentControlsByTag("day");
                if (days.Count > 0)
                {
                    foreach (Word.ContentControl day in days)
                    {
                        Word.Range r = day.Range;
                        r.Text = date.ToString("dd");
                        Word.Range dayRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, dayRange);
                    }
                }

                Word.ContentControls months = objDoc.SelectContentControlsByTag("month");
                if (months.Count > 0)
                {
                    foreach (Word.ContentControl month in months)
                    {
                        Word.Range r = month.Range;
                        r.Text = date.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
                        Word.Range monthRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, monthRange);
                    }
                }

                Word.ContentControls years = objDoc.SelectContentControlsByTag("year");
                if (years.Count > 0)
                {
                    foreach (Word.ContentControl year in years)
                    {
                        Word.Range r = year.Range;
                        r.Text = date.ToString("yy");
                        Word.Range yearRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, yearRange);
                    }
                }

                Word.ContentControls names = objDoc.SelectContentControlsByTag("name");
                if (names.Count > 0)
                {
                    foreach (Word.ContentControl name in names)
                    {
                        Word.Range r = name.Range;
                        r.Text = textBoxNameF.Text;
                        Word.Range nameRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, nameRange);
                    }
                }

                Word.ContentControls fathers = objDoc.SelectContentControlsByTag("father");
                if (fathers.Count > 0)
                {
                    foreach (Word.ContentControl father in fathers)
                    {
                        Word.Range r = father.Range;
                        r.Text = textBoxFatherNameF.Text;
                        Word.Range fatherRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, fatherRange);
                    }
                }

                Word.ContentControls mothers = objDoc.SelectContentControlsByTag("mother");
                if (mothers.Count > 0)
                {
                    foreach (Word.ContentControl mother in mothers)
                    {
                        Word.Range r = mother.Range;
                        r.Text = "Y " + textBoxMotherNameF.Text;
                        Word.Range motherRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, motherRange);
                    }
                }

                Word.ContentControls godfathers = objDoc.SelectContentControlsByTag("godfathers");
                if (godfathers.Count > 0)
                {
                    foreach (Word.ContentControl godfather in godfathers)
                    {
                        Word.Range r = godfather.Range;
                        r.Text = (textBoxGodFather1F.Text != "" ? (textBoxGodFather1F.Text + (textBoxGodFather2F.Text != "" ? (" Y " + textBoxGodFather2F.Text) : "")) : textBoxGodFather2F.Text);
                        Word.Range godfathersRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, godfathersRange);
                    }
                }

                Word.ContentControls books = objDoc.SelectContentControlsByTag("book");
                if (books.Count > 0)
                {
                    foreach (Word.ContentControl book in books)
                    {
                        Word.Range r = book.Range;
                        r.Text = textBoxBookNumberF.Text;
                        Word.Range bookRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, bookRange);
                    }
                }

                Word.ContentControls sheets = objDoc.SelectContentControlsByTag("sheet");
                if (sheets.Count > 0)
                {
                    foreach (Word.ContentControl sheet in sheets)
                    {
                        Word.Range r = sheet.Range;
                        r.Text = textBoxSheetNumberF.Text;
                        Word.Range sheetRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, sheetRange);
                    }
                }

                Word.ContentControls entries = objDoc.SelectContentControlsByTag("entry");
                if (entries.Count > 0)
                {
                    foreach (Word.ContentControl entry in entries)
                    {
                        Word.Range r = entry.Range;
                        r.Text = textBoxEntryNumberF.Text;
                        Word.Range entryRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, entryRange);
                    }
                }

                Word.ContentControls todays = objDoc.SelectContentControlsByTag("today");
                if (todays.Count > 0)
                {
                    foreach (Word.ContentControl today in todays)
                    {
                        Word.Range r = today.Range;
                        r.Text = DateTime.Now.ToString("dd") + " de " + DateTime.Now.ToString("MMMM", new CultureInfo("es-ES")) + " de " + DateTime.Now.ToString("yyyy");
                        Word.Range todayRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, todayRange);
                    }
                }

                objWord.Visible = true;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(objWord);
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabBaptism"])
            {
                object objMissing = System.Reflection.Missing.Value;
                Word.Application objWord = new Word.Application();
                string route = Application.StartupPath + @"\acta_matrimonio_bautismo.docx";
                object param = route;
                Word.Document objDoc = objWord.Documents.Open(param, ref objMissing);

                Word.ContentControls originals = objDoc.SelectContentControlsByTag("original");
                if (originals.Count > 0)
                {
                    foreach (Word.ContentControl original in originals)
                    {
                        Word.Range r = original.Range;
                        r.Text = "ORIGINAL";
                        Word.Range originalRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, originalRange);
                    }
                }

                DateTime date = dateTimePickerBaptism.Value;

                Word.ContentControls days = objDoc.SelectContentControlsByTag("day");
                if (days.Count > 0)
                {
                    foreach (Word.ContentControl day in days)
                    {
                        Word.Range r = day.Range;
                        r.Text = date.ToString("dd");
                        Word.Range dayRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, dayRange);
                    }
                }

                Word.ContentControls months = objDoc.SelectContentControlsByTag("month");
                if (months.Count > 0)
                {
                    foreach (Word.ContentControl month in months)
                    {
                        Word.Range r = month.Range;
                        r.Text = date.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
                        Word.Range monthRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, monthRange);
                    }
                }

                Word.ContentControls years = objDoc.SelectContentControlsByTag("year");
                if (years.Count > 0)
                {
                    foreach (Word.ContentControl year in years)
                    {
                        Word.Range r = year.Range;
                        r.Text = date.ToString("yyyy");
                        Word.Range yearRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, yearRange);
                    }
                }

                Word.ContentControls os = objDoc.SelectContentControlsByTag("o-os");
                if (os.Count > 0)
                {
                    foreach (Word.ContentControl o in os)
                    {
                        Word.Range r = o.Range;
                        r.Text = "O";
                        Word.Range oRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, oRange);
                    }
                }

                Word.ContentControls sacraments = objDoc.SelectContentControlsByTag("sacrament");
                if (sacraments.Count > 0)
                {
                    foreach (Word.ContentControl sacrament in sacraments)
                    {
                        Word.Range r = sacrament.Range;
                        r.Text = "BAUTISMO";
                        Word.Range sacramentRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, sacramentRange);
                    }
                }

                Word.ContentControls names = objDoc.SelectContentControlsByTag("name1");
                if (names.Count > 0)
                {
                    foreach (Word.ContentControl name in names)
                    {
                        Word.Range r = name.Range;
                        r.Text = textBoxNameB.Text;
                        Word.Range nameRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, nameRange);
                    }
                }

                Word.ContentControls erons = objDoc.SelectContentControlsByTag("o-eron");
                if (erons.Count > 0)
                {
                    foreach (Word.ContentControl eron in erons)
                    {
                        Word.Range r = eron.Range;
                        r.Text = "O";
                        Word.Range eronRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, eronRange);
                    }
                }

                Word.ContentControls fathers = objDoc.SelectContentControlsByTag("parents1");
                if (fathers.Count > 0)
                {
                    foreach (Word.ContentControl father in fathers)
                    {
                        Word.Range r = father.Range;
                        r.Text = textBoxFatherNameB.Text;
                        Word.Range fatherRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, fatherRange);
                    }
                }

                Word.ContentControls mothers = objDoc.SelectContentControlsByTag("parents2");
                if (mothers.Count > 0)
                {
                    foreach (Word.ContentControl mother in mothers)
                    {
                        Word.Range r = mother.Range;
                        r.Text = "Y " + textBoxMotherNameB.Text;
                        Word.Range motherRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, motherRange);
                    }
                }

                Word.ContentControls godparents1 = objDoc.SelectContentControlsByTag("godparents1");
                if (godparents1.Count > 0)
                {
                    foreach (Word.ContentControl godparent1 in godparents1)
                    {
                        Word.Range r = godparent1.Range;
                        r.Text = "PADRINOS: " + textBoxGodFather1B.Text;
                        Word.Range godparent1Range = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, godparent1Range);
                    }
                }

                Word.ContentControls godparents2 = objDoc.SelectContentControlsByTag("godparents2");
                if (godparents2.Count > 0)
                {
                    foreach (Word.ContentControl godparent2 in godparents2)
                    {
                        Word.Range r = godparent2.Range;
                        r.Text = "Y " + textBoxGodFather2B.Text;
                        Word.Range godparent2Range = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, godparent2Range);
                    }
                }

                Word.ContentControls books = objDoc.SelectContentControlsByTag("book");
                if (books.Count > 0)
                {
                    foreach (Word.ContentControl book in books)
                    {
                        Word.Range r = book.Range;
                        r.Text = textBoxBookNumberB.Text;
                        Word.Range bookRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, bookRange);
                    }
                }

                Word.ContentControls sheets = objDoc.SelectContentControlsByTag("sheet");
                if (sheets.Count > 0)
                {
                    foreach (Word.ContentControl sheet in sheets)
                    {
                        Word.Range r = sheet.Range;
                        r.Text = textBoxSheetNumberB.Text;
                        Word.Range sheetRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, sheetRange);
                    }
                }

                Word.ContentControls entries = objDoc.SelectContentControlsByTag("entry");
                if (entries.Count > 0)
                {
                    foreach (Word.ContentControl entry in entries)
                    {
                        Word.Range r = entry.Range;
                        r.Text = textBoxEntryNumberB.Text;
                        Word.Range entryRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, entryRange);
                    }
                }

                Word.ContentControls todays = objDoc.SelectContentControlsByTag("today");
                if (todays.Count > 0)
                {
                    foreach (Word.ContentControl today in todays)
                    {
                        Word.Range r = today.Range;
                        r.Text = DateTime.Now.ToString("dd") + " de " + DateTime.Now.ToString("MMMM", new CultureInfo("es-ES")) + " de " + DateTime.Now.ToString("yyyy");
                        Word.Range todayRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, todayRange);
                    }
                }

                objWord.Visible = true;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(objWord);
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabConfirmation"])
            {
                object objMissing = System.Reflection.Missing.Value;
                Word.Application objWord = new Word.Application();
                string route = Application.StartupPath + @"\acta_confirmacion.docx";
                object param = route;
                Word.Document objDoc = objWord.Documents.Open(param, ref objMissing);

                DateTime dateVal = dateTimePickerConfirmation.Value;

                Word.ContentControls dates = objDoc.SelectContentControlsByTag("date");
                if (dates.Count > 0)
                {
                    foreach (Word.ContentControl date in dates)
                    {
                        Word.Range r = date.Range;
                        r.Text = dateVal.ToString("D", new CultureInfo("es-ES"));
                        Word.Range dateRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, dateRange);
                    }
                }

                Word.ContentControls names = objDoc.SelectContentControlsByTag("name");
                if (names.Count > 0)
                {
                    foreach (Word.ContentControl name in names)
                    {
                        Word.Range r = name.Range;
                        r.Text = textBoxNameC.Text;
                        Word.Range nameRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, nameRange);
                    }
                }

                Word.ContentControls fathers = objDoc.SelectContentControlsByTag("father");
                if (fathers.Count > 0)
                {
                    foreach (Word.ContentControl father in fathers)
                    {
                        Word.Range r = father.Range;
                        r.Text = textBoxFatherNameC.Text;
                        Word.Range fatherRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, fatherRange);
                    }
                }

                Word.ContentControls mothers = objDoc.SelectContentControlsByTag("mother");
                if (mothers.Count > 0)
                {
                    foreach (Word.ContentControl mother in mothers)
                    {
                        Word.Range r = mother.Range;
                        r.Text = "Y " + textBoxMotherNameC.Text;
                        Word.Range motherRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, motherRange);
                    }
                }

                Word.ContentControls godparents = objDoc.SelectContentControlsByTag("godparents");
                if (godparents.Count > 0)
                {
                    foreach (Word.ContentControl godparent in godparents)
                    {
                        Word.Range r = godparent.Range;
                        r.Text = (textBoxGodFather1C.Text != "" ? (textBoxGodFather1C.Text + (textBoxGodFather2C.Text != "" ? (" Y " + textBoxGodFather2C.Text) : "")) : textBoxGodFather2C.Text);
                        Word.Range godparentsRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, godparentsRange);
                    }
                }

                Word.ContentControls books = objDoc.SelectContentControlsByTag("book");
                if (books.Count > 0)
                {
                    foreach (Word.ContentControl book in books)
                    {
                        Word.Range r = book.Range;
                        r.Text = textBoxBookNumberC.Text;
                        Word.Range bookRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, bookRange);
                    }
                }

                Word.ContentControls sheets = objDoc.SelectContentControlsByTag("sheet");
                if (sheets.Count > 0)
                {
                    foreach (Word.ContentControl sheet in sheets)
                    {
                        Word.Range r = sheet.Range;
                        r.Text = textBoxSheetNumberC.Text;
                        Word.Range sheetRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, sheetRange);
                    }
                }

                Word.ContentControls entries = objDoc.SelectContentControlsByTag("entry");
                if (entries.Count > 0)
                {
                    foreach (Word.ContentControl entry in entries)
                    {
                        Word.Range r = entry.Range;
                        r.Text = textBoxEntryNumberC.Text;
                        Word.Range entryRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, entryRange);
                    }
                }

                Word.ContentControls todays = objDoc.SelectContentControlsByTag("today");
                if (todays.Count > 0)
                {
                    foreach (Word.ContentControl today in todays)
                    {
                        Word.Range r = today.Range;
                        r.Text = "AGUASCALIENTES, AGS., " + DateTime.Now.ToString("dd") + " de " + DateTime.Now.ToString("MMMM", new CultureInfo("es-ES")) + " de " + DateTime.Now.ToString("yyyy");
                        Word.Range todayRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, todayRange);
                    }
                }

                objWord.Visible = true;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(objWord);
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabMarriage"])
            {
                object objMissing = System.Reflection.Missing.Value;
                Word.Application objWord = new Word.Application();
                string route = Application.StartupPath + @"\acta_matrimonio_primera_comunion.docx";
                object param = route;
                Word.Document objDoc = objWord.Documents.Open(param, ref objMissing);

                Word.ContentControls originals = objDoc.SelectContentControlsByTag("original");
                if (originals.Count > 0)
                {
                    foreach (Word.ContentControl original in originals)
                    {
                        Word.Range r = original.Range;
                        r.Text = "ORIGINAL";
                        Word.Range originalRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, originalRange);
                    }
                }

                DateTime date = dateTimePickerMarriage.Value;

                Word.ContentControls days = objDoc.SelectContentControlsByTag("day");
                if (days.Count > 0)
                {
                    foreach (Word.ContentControl day in days)
                    {
                        Word.Range r = day.Range;
                        r.Text = date.ToString("dd");
                        Word.Range dayRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, dayRange);
                    }
                }

                Word.ContentControls months = objDoc.SelectContentControlsByTag("month");
                if (months.Count > 0)
                {
                    foreach (Word.ContentControl month in months)
                    {
                        Word.Range r = month.Range;
                        r.Text = date.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
                        Word.Range monthRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, monthRange);
                    }
                }

                Word.ContentControls years = objDoc.SelectContentControlsByTag("year");
                if (years.Count > 0)
                {
                    foreach (Word.ContentControl year in years)
                    {
                        Word.Range r = year.Range;
                        r.Text = date.ToString("yyyy");
                        Word.Range yearRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, yearRange);
                    }
                }

                Word.ContentControls os = objDoc.SelectContentControlsByTag("o-os");
                if (os.Count > 0)
                {
                    foreach (Word.ContentControl o in os)
                    {
                        Word.Range r = o.Range;
                        r.Text = "OS";
                        Word.Range oRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, oRange);
                    }
                }

                Word.ContentControls sacraments = objDoc.SelectContentControlsByTag("sacrament");
                if (sacraments.Count > 0)
                {
                    foreach (Word.ContentControl sacrament in sacraments)
                    {
                        Word.Range r = sacrament.Range;
                        r.Text = "MATRIMONIO";
                        Word.Range sacramentRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, sacramentRange);
                    }
                }

                Word.ContentControls names1 = objDoc.SelectContentControlsByTag("name1");
                if (names1.Count > 0)
                {
                    foreach (Word.ContentControl name1 in names1)
                    {
                        Word.Range r = name1.Range;
                        r.Text = textBoxHusbandNameM.Text + " Y ";
                        Word.Range name1Range = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, name1Range);
                    }
                }

                Word.ContentControls names2 = objDoc.SelectContentControlsByTag("name2");
                if (names2.Count > 0)
                {
                    foreach (Word.ContentControl name2 in names2)
                    {
                        Word.Range r = name2.Range;
                        r.Text = textBoxWifeNameM.Text;
                        Word.Range name2Range = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, name2Range);
                    }
                }

                Word.ContentControls erons = objDoc.SelectContentControlsByTag("o-eron");
                if (erons.Count > 0)
                {
                    foreach (Word.ContentControl eron in erons)
                    {
                        Word.Range r = eron.Range;
                        r.Text = "ERON";
                        Word.Range eronRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, eronRange);
                    }
                }

                Word.ContentControls parents1 = objDoc.SelectContentControlsByTag("parents1");
                if (parents1.Count > 0)
                {
                    foreach (Word.ContentControl parent1 in parents1)
                    {
                        Word.Range r = parent1.Range;
                        r.Text = textBoxHusbandFatherNameM.Text + " Y " + textBoxHusbandMotherNameM.Text;
                        Word.Range parent1Range = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, parent1Range);
                    }
                }

                Word.ContentControls parents2 = objDoc.SelectContentControlsByTag("parents2");
                if (parents2.Count > 0)
                {
                    foreach (Word.ContentControl parent2 in parents2)
                    {
                        Word.Range r = parent2.Range;
                        r.Text = textBoxWifeFatherNameM.Text + " Y " + textBoxWifeMotherNameM;
                        Word.Range parent2Range = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, parent2Range);
                    }
                }

                Word.ContentControls godparents1 = objDoc.SelectContentControlsByTag("godparents1");
                if (godparents1.Count > 0)
                {
                    foreach (Word.ContentControl godparent1 in godparents1)
                    {
                        Word.Range r = godparent1.Range;
                        r.Text = "PADRINOS: " + textBoxGodFather1M.Text + " Y ";
                        Word.Range godparent1Range = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, godparent1Range);
                    }
                }

                Word.ContentControls godparents2 = objDoc.SelectContentControlsByTag("godparents2");
                if (godparents2.Count > 0)
                {
                    foreach (Word.ContentControl godparent2 in godparents2)
                    {
                        Word.Range r = godparent2.Range;
                        r.Text = textBoxGodFather2M.Text;
                        Word.Range godparent2Range = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, godparent2Range);
                    }
                }

                Word.ContentControls books = objDoc.SelectContentControlsByTag("book");
                if (books.Count > 0)
                {
                    foreach (Word.ContentControl book in books)
                    {
                        Word.Range r = book.Range;
                        r.Text = textBoxBookNumberM.Text;
                        Word.Range bookRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, bookRange);
                    }
                }

                Word.ContentControls sheets = objDoc.SelectContentControlsByTag("sheet");
                if (sheets.Count > 0)
                {
                    foreach (Word.ContentControl sheet in sheets)
                    {
                        Word.Range r = sheet.Range;
                        r.Text = textBoxSheetNumberM.Text;
                        Word.Range sheetRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, sheetRange);
                    }
                }

                Word.ContentControls entries = objDoc.SelectContentControlsByTag("entry");
                if (entries.Count > 0)
                {
                    foreach (Word.ContentControl entry in entries)
                    {
                        Word.Range r = entry.Range;
                        r.Text = textBoxEntryNumberM.Text;
                        Word.Range entryRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, entryRange);
                    }
                }

                Word.ContentControls todays = objDoc.SelectContentControlsByTag("today");
                if (todays.Count > 0)
                {
                    foreach (Word.ContentControl today in todays)
                    {
                        Word.Range r = today.Range;
                        r.Text = DateTime.Now.ToString("dd") + " de " + DateTime.Now.ToString("MMMM", new CultureInfo("es-ES")) + " de " + DateTime.Now.ToString("yyyy");
                        Word.Range todayRange = r;
                        objDoc.ContentControls.Add(Word.WdContentControlType.wdContentControlText, todayRange);
                    }
                }

                objWord.Visible = true;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(objWord);
            }
        }
    }
}
