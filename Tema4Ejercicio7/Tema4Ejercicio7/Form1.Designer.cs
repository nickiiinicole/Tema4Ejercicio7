namespace Tema4Ejercicio7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.labelInfoMedia = new System.Windows.Forms.Label();
            this.labelNoteMinMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(202, 27);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(179, 25);
            this.comboBoxStudents.TabIndex = 0;
            this.comboBoxStudents.SelectedIndexChanged += new System.EventHandler(this.SelectCb);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(387, 27);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(179, 25);
            this.comboBoxSubject.TabIndex = 1;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.SelectCb);
            // 
            // labelInfoMedia
            // 
            this.labelInfoMedia.AutoSize = true;
            this.labelInfoMedia.BackColor = System.Drawing.Color.LightGray;
            this.labelInfoMedia.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoMedia.Location = new System.Drawing.Point(623, 33);
            this.labelInfoMedia.Name = "labelInfoMedia";
            this.labelInfoMedia.Size = new System.Drawing.Size(0, 19);
            this.labelInfoMedia.TabIndex = 2;
            // 
            // labelNoteMinMax
            // 
            this.labelNoteMinMax.AutoSize = true;
            this.labelNoteMinMax.BackColor = System.Drawing.Color.LightGray;
            this.labelNoteMinMax.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoteMinMax.Location = new System.Drawing.Point(779, 33);
            this.labelNoteMinMax.Name = "labelNoteMinMax";
            this.labelNoteMinMax.Size = new System.Drawing.Size(0, 19);
            this.labelNoteMinMax.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 531);
            this.Controls.Add(this.labelNoteMinMax);
            this.Controls.Add(this.labelInfoMedia);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.comboBoxStudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label labelInfoMedia;
        private System.Windows.Forms.Label labelNoteMinMax;
    }
}

