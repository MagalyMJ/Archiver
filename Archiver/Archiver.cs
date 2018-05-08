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
    }
}
