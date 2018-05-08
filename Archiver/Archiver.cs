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

        // Clear baptism inputs
        public void clearBaptism()
        {
            dateTimePickerBaptism.Value = DateTime.Now;
            textBoxNameB.Text = "";
            textBoxFatherNameB.Text = "";
            textBoxMotherNameB.Text = "";
            textBoxGodFather1B.Text = "";
            textBoxGodFather2B.Text = "";
            textBoxStateB.Text = "";
            textBoxMunicipalityB.Text = "";
            textBoxNotesB.Text = "";
            textBoxBookNumberB.Text = "";
            textBoxSheetNumberB.Text = "";
            textBoxEntryNumberB.Text = "";
        }

        // Clear first comunion inputs
        public void clearFirstComunion()
        {
            dateTimePickerFirstComunion.Value = DateTime.Now;
            textBoxNameF.Text = "";
            textBoxFatherNameF.Text = "";
            textBoxMotherNameF.Text = "";
            textBoxGodFather1F.Text = "";
            textBoxGodFather2F.Text = "";
            textBoxStateF.Text = "";
            textBoxMunicipalityF.Text = "";
            textBoxNotesF.Text = "";
            textBoxBookNumberF.Text = "";
            textBoxSheetNumberF.Text = "";
            textBoxEntryNumberF.Text = "";
        }

        // Clear confirmation inputs
        public void clearConfirmation()
        {
            dateTimePickerConfirmation.Value = DateTime.Now;
            textBoxNameC.Text = "";
            textBoxFatherNameC.Text = "";
            textBoxMotherNameC.Text = "";
            textBoxGodFather1C.Text = "";
            textBoxGodFather2C.Text = "";
            textBoxStateC.Text = "";
            textBoxMunicipalityC.Text = "";
            textBoxNotesC.Text = "";
            textBoxBookNumberC.Text = "";
            textBoxSheetNumberC.Text = "";
            textBoxEntryNumberC.Text = "";
        }

        // Clear confirmation inputs
        public void clearMarriage()
        {
            dateTimePickerMarriage.Value = DateTime.Now;
            textBoxWifeNameM.Text = "";
            textBoxHusbandNameM.Text = "";
            textBoxWifeMotherNameM.Text = "";
            textBoxWifeFatherNameM.Text = "";
            textBoxHusbandMotherNameM.Text = "";
            textBoxHusbandFatherNameM.Text = "";
            textBoxGodFather1M.Text = "";
            textBoxGodFather2M.Text = "";
            textBoxStateM.Text = "";
            textBoxMunicipalityM.Text = "";
            textBoxNotesM.Text = "";
            textBoxBookNumberM.Text = "";
            textBoxSheetNumberM.Text = "";
            textBoxEntryNumberM.Text = "";
        }

        private void tabBaptism_Click(object sender, EventArgs e)
        {
            // Load data in gridView
            DataTable dt = baptism.Select();
            dataGridViewBaptism.DataSource = dt;
        }

        private void buttonSaveB_Click(object sender, EventArgs e)
        {
            // Get values from inputs
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
            baptism.municipality = textBoxMunicipalityB.Text;
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

            // Insert data
            if (baptism.Insert(baptism))
            {
                MessageBox.Show("El registro fue guardado exitosamente.");
                clearBaptism();
            }
            else
                MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");

            // Load data in gridView
            DataTable dt = baptism.Select();
            dataGridViewBaptism.DataSource = dt;
        }

        private void buttonSaveF_Click(object sender, EventArgs e)
        {
            // Get values from inputs
            firstComunion.date = dateTimePickerFirstComunion.Value;
            firstComunion.name = textBoxNameF.Text;
            firstComunion.fatherName = textBoxFatherNameF.Text;
            firstComunion.motherName = textBoxMotherNameF.Text;
            firstComunion.firstGodfather = textBoxGodFather1F.Text;
            firstComunion.secondGodfather = textBoxGodFather2F.Text;
            firstComunion.state = textBoxStateF.Text;
            firstComunion.municipality = textBoxMunicipalityF.Text;
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

            // Insert data
            if (firstComunion.Insert(firstComunion))
            {
                MessageBox.Show("El registro fue guardado exitosamente.");
                clearFirstComunion();
            }
            else
                MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");

            // Load data in gridView
            DataTable dt = firstComunion.Select();
            dataGridViewFisrtComunion.DataSource = dt;
        }

        private void tabFirstComunion_Click(object sender, EventArgs e)
        {
            // Load data in gridView
            DataTable dt = firstComunion.Select();
            dataGridViewFisrtComunion.DataSource = dt;
        }

        private void buttonSaveC_Click(object sender, EventArgs e)
        {
            // Get values from inputs
            confirmation.date = dateTimePickerConfirmation.Value;
            confirmation.name = textBoxNameC.Text;
            confirmation.fatherName = textBoxFatherNameC.Text;
            confirmation.motherName = textBoxMotherNameC.Text;
            confirmation.firstGodfather = textBoxGodFather1C.Text;
            confirmation.secondGodfather = textBoxGodFather2C.Text;
            confirmation.state = textBoxStateC.Text;
            confirmation.municipality = textBoxMunicipalityC.Text;
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

            // Insert data
            if (confirmation.Insert(confirmation))
            {
                MessageBox.Show("El registro fue guardado exitosamente.");
                clearConfirmation();
            }
            else
                MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");

            // Load data in gridView
            DataTable dt = confirmation.Select();
            dataGridViewConfirmation.DataSource = dt;
        }

        private void tabConfirmation_Click(object sender, EventArgs e)
        {
            // Load data in gridView
            DataTable dt = confirmation.Select();
            dataGridViewConfirmation.DataSource = dt;
        }

        private void buttonSaveM_Click(object sender, EventArgs e)
        {
            // Get values from inputs
            marriage.date = dateTimePickerMarriage.Value;
            marriage.wifeName = textBoxWifeNameM.Text;
            marriage.husbandName = textBoxHusbandNameM.Text;
            marriage.wifeMotherName = textBoxWifeMotherNameM.Text;
            marriage.wifeFatherName = textBoxWifeFatherNameM.Text;
            marriage.husbandMotherName = textBoxHusbandMotherNameM.Text;
            marriage.husbandFatherName = textBoxHusbandFatherNameM.Text;
            marriage.firstGodfather = textBoxGodFather1M.Text;
            marriage.secondGodfather = textBoxGodFather2M.Text;
            marriage.state = textBoxStateM.Text;
            marriage.municipality = textBoxMunicipalityM.Text;
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

            // Insert data
            if (marriage.Insert(marriage))
            {
                MessageBox.Show("El registro fue guardado exitosamente.");
                clearMarriage();
            }
            else
                MessageBox.Show("No se pudo guardar el registro, inténtelo nuevamente.");

            // Load data in gridView
            DataTable dt = marriage.Select();
            dataGridViewMarriage.DataSource = dt;
        }

        private void tabMarriage_Click(object sender, EventArgs e)
        {
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
            textBoxMunicipalityB.Text = dataGridViewBaptism.Rows[rowIndex].Cells[9].Value.ToString();
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
            textBoxMunicipalityF.Text = dataGridViewFisrtComunion.Rows[rowIndex].Cells[8].Value.ToString();
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
            textBoxMunicipalityC.Text = dataGridViewConfirmation.Rows[rowIndex].Cells[8].Value.ToString(); ;
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
            textBoxMunicipalityM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[11].Value.ToString();
            textBoxNotesM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[12].Value.ToString();
            textBoxBookNumberM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[13].Value.ToString();
            textBoxSheetNumberM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[14].Value.ToString();
            textBoxEntryNumberM.Text = dataGridViewMarriage.Rows[rowIndex].Cells[15].Value.ToString();
        }
    }
}
