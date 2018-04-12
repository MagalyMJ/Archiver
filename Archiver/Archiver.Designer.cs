namespace Archiver
{
    partial class Archiver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabBaptism = new System.Windows.Forms.TabPage();
            this.tabFirstComunion = new System.Windows.Forms.TabPage();
            this.tabConfirmation = new System.Windows.Forms.TabPage();
            this.tabMarriage = new System.Windows.Forms.TabPage();
            this.labelNameB = new System.Windows.Forms.Label();
            this.dateTimePickerBaptism = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFemeninB = new System.Windows.Forms.CheckBox();
            this.checkBoxMasculinB = new System.Windows.Forms.CheckBox();
            this.groupBoxBaptismGender = new System.Windows.Forms.GroupBox();
            this.textBoxNameB = new System.Windows.Forms.TextBox();
            this.textBoxMotherNameB = new System.Windows.Forms.TextBox();
            this.labelMotherNameB = new System.Windows.Forms.Label();
            this.textBoxFatherNameB = new System.Windows.Forms.TextBox();
            this.labelFatherNameB = new System.Windows.Forms.Label();
            this.textBoxGodFather1B = new System.Windows.Forms.TextBox();
            this.labelGodFather1B = new System.Windows.Forms.Label();
            this.textBoxGodFather2B = new System.Windows.Forms.TextBox();
            this.labelGodFather2B = new System.Windows.Forms.Label();
            this.textBoxBookNumberB = new System.Windows.Forms.TextBox();
            this.labelBookNumberB = new System.Windows.Forms.Label();
            this.textBoxSheetNumberB = new System.Windows.Forms.TextBox();
            this.labelSheetNumberB = new System.Windows.Forms.Label();
            this.textBoxEntryNumberB = new System.Windows.Forms.TextBox();
            this.labelEntryNumberB = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabBaptism.SuspendLayout();
            this.groupBoxBaptismGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabBaptism);
            this.tabControl1.Controls.Add(this.tabFirstComunion);
            this.tabControl1.Controls.Add(this.tabConfirmation);
            this.tabControl1.Controls.Add(this.tabMarriage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(849, 460);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Inicio";
            this.tabHome.UseVisualStyleBackColor = true;
            this.tabHome.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabBaptism
            // 
            this.tabBaptism.BackColor = System.Drawing.Color.White;
            this.tabBaptism.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBaptism.Controls.Add(this.textBoxEntryNumberB);
            this.tabBaptism.Controls.Add(this.labelEntryNumberB);
            this.tabBaptism.Controls.Add(this.textBoxSheetNumberB);
            this.tabBaptism.Controls.Add(this.labelSheetNumberB);
            this.tabBaptism.Controls.Add(this.textBoxBookNumberB);
            this.tabBaptism.Controls.Add(this.labelBookNumberB);
            this.tabBaptism.Controls.Add(this.textBoxGodFather2B);
            this.tabBaptism.Controls.Add(this.labelGodFather2B);
            this.tabBaptism.Controls.Add(this.textBoxGodFather1B);
            this.tabBaptism.Controls.Add(this.labelGodFather1B);
            this.tabBaptism.Controls.Add(this.textBoxFatherNameB);
            this.tabBaptism.Controls.Add(this.labelFatherNameB);
            this.tabBaptism.Controls.Add(this.textBoxMotherNameB);
            this.tabBaptism.Controls.Add(this.labelMotherNameB);
            this.tabBaptism.Controls.Add(this.textBoxNameB);
            this.tabBaptism.Controls.Add(this.groupBoxBaptismGender);
            this.tabBaptism.Controls.Add(this.labelNameB);
            this.tabBaptism.Controls.Add(this.dateTimePickerBaptism);
            this.tabBaptism.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabBaptism.Location = new System.Drawing.Point(4, 22);
            this.tabBaptism.Name = "tabBaptism";
            this.tabBaptism.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaptism.Size = new System.Drawing.Size(849, 460);
            this.tabBaptism.TabIndex = 1;
            this.tabBaptism.Text = "Bautismo";
            // 
            // tabFirstComunion
            // 
            this.tabFirstComunion.Location = new System.Drawing.Point(4, 22);
            this.tabFirstComunion.Name = "tabFirstComunion";
            this.tabFirstComunion.Size = new System.Drawing.Size(849, 460);
            this.tabFirstComunion.TabIndex = 2;
            this.tabFirstComunion.Text = "Primera Comunión";
            this.tabFirstComunion.UseVisualStyleBackColor = true;
            // 
            // tabConfirmation
            // 
            this.tabConfirmation.Location = new System.Drawing.Point(4, 22);
            this.tabConfirmation.Name = "tabConfirmation";
            this.tabConfirmation.Size = new System.Drawing.Size(849, 460);
            this.tabConfirmation.TabIndex = 3;
            this.tabConfirmation.Text = "Confirmación";
            this.tabConfirmation.UseVisualStyleBackColor = true;
            // 
            // tabMarriage
            // 
            this.tabMarriage.Location = new System.Drawing.Point(4, 22);
            this.tabMarriage.Name = "tabMarriage";
            this.tabMarriage.Size = new System.Drawing.Size(849, 460);
            this.tabMarriage.TabIndex = 4;
            this.tabMarriage.Text = "Matrimonio";
            this.tabMarriage.UseVisualStyleBackColor = true;
            // 
            // labelNameB
            // 
            this.labelNameB.AutoSize = true;
            this.labelNameB.Location = new System.Drawing.Point(35, 72);
            this.labelNameB.Name = "labelNameB";
            this.labelNameB.Size = new System.Drawing.Size(47, 13);
            this.labelNameB.TabIndex = 1;
            this.labelNameB.Text = "Nombre:";
            this.labelNameB.Click += new System.EventHandler(this.labelName_Click);
            // 
            // dateTimePickerBaptism
            // 
            this.dateTimePickerBaptism.Location = new System.Drawing.Point(625, 27);
            this.dateTimePickerBaptism.Name = "dateTimePickerBaptism";
            this.dateTimePickerBaptism.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBaptism.TabIndex = 0;
            // 
            // checkBoxFemeninB
            // 
            this.checkBoxFemeninB.AutoSize = true;
            this.checkBoxFemeninB.Location = new System.Drawing.Point(13, 24);
            this.checkBoxFemeninB.Name = "checkBoxFemeninB";
            this.checkBoxFemeninB.Size = new System.Drawing.Size(72, 17);
            this.checkBoxFemeninB.TabIndex = 0;
            this.checkBoxFemeninB.Text = "Femenino";
            this.checkBoxFemeninB.UseVisualStyleBackColor = true;
            // 
            // checkBoxMasculinB
            // 
            this.checkBoxMasculinB.AutoSize = true;
            this.checkBoxMasculinB.Location = new System.Drawing.Point(13, 53);
            this.checkBoxMasculinB.Name = "checkBoxMasculinB";
            this.checkBoxMasculinB.Size = new System.Drawing.Size(74, 17);
            this.checkBoxMasculinB.TabIndex = 1;
            this.checkBoxMasculinB.Text = "Masculino";
            this.checkBoxMasculinB.UseVisualStyleBackColor = true;
            // 
            // groupBoxBaptismGender
            // 
            this.groupBoxBaptismGender.Controls.Add(this.checkBoxMasculinB);
            this.groupBoxBaptismGender.Controls.Add(this.checkBoxFemeninB);
            this.groupBoxBaptismGender.Location = new System.Drawing.Point(711, 72);
            this.groupBoxBaptismGender.Name = "groupBoxBaptismGender";
            this.groupBoxBaptismGender.Size = new System.Drawing.Size(114, 81);
            this.groupBoxBaptismGender.TabIndex = 2;
            this.groupBoxBaptismGender.TabStop = false;
            this.groupBoxBaptismGender.Text = "Sexo";
            // 
            // textBoxNameB
            // 
            this.textBoxNameB.Location = new System.Drawing.Point(88, 69);
            this.textBoxNameB.Name = "textBoxNameB";
            this.textBoxNameB.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameB.TabIndex = 3;
            // 
            // textBoxMotherNameB
            // 
            this.textBoxMotherNameB.Location = new System.Drawing.Point(153, 96);
            this.textBoxMotherNameB.Name = "textBoxMotherNameB";
            this.textBoxMotherNameB.Size = new System.Drawing.Size(100, 20);
            this.textBoxMotherNameB.TabIndex = 5;
            // 
            // labelMotherNameB
            // 
            this.labelMotherNameB.AutoSize = true;
            this.labelMotherNameB.Location = new System.Drawing.Point(35, 99);
            this.labelMotherNameB.Name = "labelMotherNameB";
            this.labelMotherNameB.Size = new System.Drawing.Size(108, 13);
            this.labelMotherNameB.TabIndex = 4;
            this.labelMotherNameB.Text = "Nombre de la madre: ";
            // 
            // textBoxFatherNameB
            // 
            this.textBoxFatherNameB.Location = new System.Drawing.Point(154, 125);
            this.textBoxFatherNameB.Name = "textBoxFatherNameB";
            this.textBoxFatherNameB.Size = new System.Drawing.Size(100, 20);
            this.textBoxFatherNameB.TabIndex = 7;
            // 
            // labelFatherNameB
            // 
            this.labelFatherNameB.AutoSize = true;
            this.labelFatherNameB.Location = new System.Drawing.Point(35, 128);
            this.labelFatherNameB.Name = "labelFatherNameB";
            this.labelFatherNameB.Size = new System.Drawing.Size(94, 13);
            this.labelFatherNameB.TabIndex = 6;
            this.labelFatherNameB.Text = "Nombre del padre:";
            // 
            // textBoxGodFather1B
            // 
            this.textBoxGodFather1B.Location = new System.Drawing.Point(159, 151);
            this.textBoxGodFather1B.Name = "textBoxGodFather1B";
            this.textBoxGodFather1B.Size = new System.Drawing.Size(100, 20);
            this.textBoxGodFather1B.TabIndex = 9;
            // 
            // labelGodFather1B
            // 
            this.labelGodFather1B.AutoSize = true;
            this.labelGodFather1B.Location = new System.Drawing.Point(35, 154);
            this.labelGodFather1B.Name = "labelGodFather1B";
            this.labelGodFather1B.Size = new System.Drawing.Size(114, 13);
            this.labelGodFather1B.TabIndex = 8;
            this.labelGodFather1B.Text = "Nombre del padrino(1):";
            // 
            // textBoxGodFather2B
            // 
            this.textBoxGodFather2B.Location = new System.Drawing.Point(160, 177);
            this.textBoxGodFather2B.Name = "textBoxGodFather2B";
            this.textBoxGodFather2B.Size = new System.Drawing.Size(100, 20);
            this.textBoxGodFather2B.TabIndex = 11;
            // 
            // labelGodFather2B
            // 
            this.labelGodFather2B.AutoSize = true;
            this.labelGodFather2B.Location = new System.Drawing.Point(35, 180);
            this.labelGodFather2B.Name = "labelGodFather2B";
            this.labelGodFather2B.Size = new System.Drawing.Size(114, 13);
            this.labelGodFather2B.TabIndex = 10;
            this.labelGodFather2B.Text = "Nombre del padrino(2):";
            // 
            // textBoxBookNumberB
            // 
            this.textBoxBookNumberB.Location = new System.Drawing.Point(122, 332);
            this.textBoxBookNumberB.Name = "textBoxBookNumberB";
            this.textBoxBookNumberB.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookNumberB.TabIndex = 13;
            // 
            // labelBookNumberB
            // 
            this.labelBookNumberB.AutoSize = true;
            this.labelBookNumberB.Location = new System.Drawing.Point(45, 332);
            this.labelBookNumberB.Name = "labelBookNumberB";
            this.labelBookNumberB.Size = new System.Drawing.Size(71, 13);
            this.labelBookNumberB.TabIndex = 12;
            this.labelBookNumberB.Text = "Libro número:";
            // 
            // textBoxSheetNumberB
            // 
            this.textBoxSheetNumberB.Location = new System.Drawing.Point(322, 335);
            this.textBoxSheetNumberB.Name = "textBoxSheetNumberB";
            this.textBoxSheetNumberB.Size = new System.Drawing.Size(100, 20);
            this.textBoxSheetNumberB.TabIndex = 15;
            // 
            // labelSheetNumberB
            // 
            this.labelSheetNumberB.AutoSize = true;
            this.labelSheetNumberB.Location = new System.Drawing.Point(246, 338);
            this.labelSheetNumberB.Name = "labelSheetNumberB";
            this.labelSheetNumberB.Size = new System.Drawing.Size(70, 13);
            this.labelSheetNumberB.TabIndex = 14;
            this.labelSheetNumberB.Text = "Folio número:";
            // 
            // textBoxEntryNumberB
            // 
            this.textBoxEntryNumberB.Location = new System.Drawing.Point(537, 334);
            this.textBoxEntryNumberB.Name = "textBoxEntryNumberB";
            this.textBoxEntryNumberB.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntryNumberB.TabIndex = 17;
            // 
            // labelEntryNumberB
            // 
            this.labelEntryNumberB.AutoSize = true;
            this.labelEntryNumberB.Location = new System.Drawing.Point(447, 337);
            this.labelEntryNumberB.Name = "labelEntryNumberB";
            this.labelEntryNumberB.Size = new System.Drawing.Size(81, 13);
            this.labelEntryNumberB.TabIndex = 16;
            this.labelEntryNumberB.Text = "Partida número:";
            // 
            // Archiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "Archiver";
            this.Text = "Archiver";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Archiver_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBaptism.ResumeLayout(false);
            this.tabBaptism.PerformLayout();
            this.groupBoxBaptismGender.ResumeLayout(false);
            this.groupBoxBaptismGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabBaptism;
        private System.Windows.Forms.TabPage tabFirstComunion;
        private System.Windows.Forms.TabPage tabConfirmation;
        private System.Windows.Forms.TabPage tabMarriage;
        private System.Windows.Forms.TextBox textBoxEntryNumberB;
        private System.Windows.Forms.Label labelEntryNumberB;
        private System.Windows.Forms.TextBox textBoxSheetNumberB;
        private System.Windows.Forms.Label labelSheetNumberB;
        private System.Windows.Forms.TextBox textBoxBookNumberB;
        private System.Windows.Forms.Label labelBookNumberB;
        private System.Windows.Forms.TextBox textBoxGodFather2B;
        private System.Windows.Forms.Label labelGodFather2B;
        private System.Windows.Forms.TextBox textBoxGodFather1B;
        private System.Windows.Forms.Label labelGodFather1B;
        private System.Windows.Forms.TextBox textBoxFatherNameB;
        private System.Windows.Forms.Label labelFatherNameB;
        private System.Windows.Forms.TextBox textBoxMotherNameB;
        private System.Windows.Forms.Label labelMotherNameB;
        private System.Windows.Forms.TextBox textBoxNameB;
        private System.Windows.Forms.GroupBox groupBoxBaptismGender;
        private System.Windows.Forms.CheckBox checkBoxMasculinB;
        private System.Windows.Forms.CheckBox checkBoxFemeninB;
        private System.Windows.Forms.Label labelNameB;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaptism;
    }
}

