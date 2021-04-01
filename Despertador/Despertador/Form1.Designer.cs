
namespace Despertador
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlarma = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.despertadorDataSet = new Despertador.DespertadorDataSet();
            this.horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horasTableAdapter = new Despertador.DespertadorDataSetTableAdapters.HorasTableAdapter();
            this.tableAdapterManager = new Despertador.DespertadorDataSetTableAdapters.TableAdapterManager();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbActivada = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.despertadorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "hora (label1)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timerTick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "fecha (label2)";
            // 
            // btnAlarma
            // 
            this.btnAlarma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAlarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarma.Location = new System.Drawing.Point(169, 70);
            this.btnAlarma.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlarma.Name = "btnAlarma";
            this.btnAlarma.Size = new System.Drawing.Size(165, 53);
            this.btnAlarma.TabIndex = 3;
            this.btnAlarma.Text = "Alarma";
            this.btnAlarma.UseVisualStyleBackColor = false;
            this.btnAlarma.Click += new System.EventHandler(this.btnAlarma_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Stop.Location = new System.Drawing.Point(169, 126);
            this.Stop.Margin = new System.Windows.Forms.Padding(2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(165, 50);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Parar";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // despertadorDataSet
            // 
            this.despertadorDataSet.DataSetName = "DespertadorDataSet";
            this.despertadorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // horasBindingSource
            // 
            this.horasBindingSource.DataMember = "Horas";
            this.horasBindingSource.DataSource = this.despertadorDataSet;
            // 
            // horasTableAdapter
            // 
            this.horasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HorasTableAdapter = this.horasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Despertador.DespertadorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.horasBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(338, 117);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(162, 47);
            this.fechaDateTimePicker.TabIndex = 5;
            // 
            // cbActivada
            // 
            this.cbActivada.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.horasBindingSource, "Activo", true));
            this.cbActivada.Enabled = false;
            this.cbActivada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivada.Location = new System.Drawing.Point(338, 72);
            this.cbActivada.Name = "cbActivada";
            this.cbActivada.Size = new System.Drawing.Size(168, 39);
            this.cbActivada.TabIndex = 11;
            this.cbActivada.Text = "Activada?";
            this.cbActivada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbActivada.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(717, 187);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbActivada);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.btnAlarma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Alarma";
            this.TransparencyKey = System.Drawing.Color.DarkViolet;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.despertadorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlarma;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label3;
        private DespertadorDataSet despertadorDataSet;
        private System.Windows.Forms.BindingSource horasBindingSource;
        private DespertadorDataSetTableAdapters.HorasTableAdapter horasTableAdapter;
        private DespertadorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.CheckBox cbActivada;
        private System.Windows.Forms.Label label5;
    }
}

