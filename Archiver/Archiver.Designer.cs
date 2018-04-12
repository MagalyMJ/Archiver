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
            this.tabControl1.SuspendLayout();
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
            this.tabBaptism.Location = new System.Drawing.Point(4, 22);
            this.tabBaptism.Name = "tabBaptism";
            this.tabBaptism.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaptism.Size = new System.Drawing.Size(849, 460);
            this.tabBaptism.TabIndex = 1;
            this.tabBaptism.Text = "Bautismo";
            this.tabBaptism.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabBaptism;
        private System.Windows.Forms.TabPage tabFirstComunion;
        private System.Windows.Forms.TabPage tabConfirmation;
        private System.Windows.Forms.TabPage tabMarriage;
    }
}

