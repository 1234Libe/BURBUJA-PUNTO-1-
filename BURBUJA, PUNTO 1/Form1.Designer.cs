
namespace BURBUJA__PUNTO_1
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
            this.bntOrdenar = new DevComponents.DotNetBar.ButtonX();
            this.txtVector = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // bntOrdenar
            // 
            this.bntOrdenar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntOrdenar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntOrdenar.Location = new System.Drawing.Point(398, 51);
            this.bntOrdenar.Name = "bntOrdenar";
            this.bntOrdenar.Size = new System.Drawing.Size(98, 35);
            this.bntOrdenar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bntOrdenar.TabIndex = 2;
            this.bntOrdenar.Text = "Ejecutar";
            this.bntOrdenar.Click += new System.EventHandler(this.bntOrdenar_Click);
            // 
            // txtVector
            // 
            this.txtVector.BackColor = System.Drawing.SystemColors.InactiveCaption;
            // 
            // 
            // 
            this.txtVector.Border.Class = "TextBoxBorder";
            this.txtVector.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVector.Location = new System.Drawing.Point(22, 75);
            this.txtVector.Multiline = true;
            this.txtVector.Name = "txtVector";
            this.txtVector.PreventEnterBeep = true;
            this.txtVector.Size = new System.Drawing.Size(162, 253);
            this.txtVector.TabIndex = 3;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(152, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(181, 33);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Ordenamiento Burbuja";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(508, 356);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtVector);
            this.Controls.Add(this.bntOrdenar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burbuja";
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX bntOrdenar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVector;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}

