using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Despertador
{
    public partial class Form1 : Form
    {
        
        static System.Windows.Forms.Timer temporizador = new System.Windows.Forms.Timer();
      
        SoundPlayer musica = new SoundPlayer();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'despertadorDataSet.Horas' Puede moverla o quitarla según sea necesario.
            temporizador.Interval = 1000;
            temporizador.Tick += T_Tick;
        }

        public void empezarAlarma()
        {
            temporizador.Start();
            cbActivada.Checked = true;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            //Aqui defino 2 variables de DateTime para comparar entre ellas que seran la hora del equipo y la hora que ponga el usuario
            DateTime horaUsuario = fechaDateTimePicker.Value;
            DateTime horaActual = DateTime.Now;

            if (horaUsuario.Hour == horaActual.Hour && horaUsuario.Minute == horaActual.Minute && horaUsuario.Second == horaActual.Second)
            {
                temporizador.Stop(); //Al cumplir las condiciones, que el temporizador se pare
                try
                {
                    //El SoundPlayer para que suene la musica elegida
                    SoundPlayer musica = new SoundPlayer();
                    musica.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                    musica.PlayLooping();
                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message, "Error - Ha habido un error al procesar la alarma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlarma_Click(object sender, EventArgs e) // Boton Guardar 
        {
            empezarAlarma();
        } 


        public void cambiar()
        {
            cbActivada.Checked = true;
        }

        
        private void guardarAlarma() {
          
            String cambioAlarma;

            cambioAlarma = "UPDATE Horas SET Fecha='" + fechaDateTimePicker.Value + "',Activo='" + ((cbActivada.Checked) ? 1 : 0) + "'" + " WHERE id like '" + 1 + "'";

            alarmaEnBd.guardarBd(cambioAlarma); //Llamamos a la clase de alarmaEnBd, al metodo que tiene para enviar la alarma a la base de datos.

        }

        private void btnParar_Click(object sender, EventArgs e) // Boton Parar 
        {
            temporizador.Stop();
            musica.Stop();
            cbActivada.Checked = false;
        }

     
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            guardarAlarma(); //Cuando la app se cierre, que llame a la funcion guardar para mantener la alarma
        }

        private void timerTick(object sender, EventArgs e)
        {
            if (cbActivada.Checked)
            {
                empezarAlarma();
            }

            String hora = DateTime.Now.ToLongTimeString();

            label1.Text = DateTime.Now.ToString(hora + " " + "tt");

            label2.Text = DateTime.Now.ToString("dddd, dd, MMMM, yyyy");
        }

    }


    public static class alarmaEnBd
    {
        public static void guardarBd(String nuevaAlarma)
        {
            OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Despertador.accdb");
            conexion.Open();
            OleDbCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = nuevaAlarma;

            cmd.ExecuteNonQuery(); //Este query ejecuta la consulta que pasamos al metodo por parametros, osea el "Update"

            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dt);

            conexion.Close();
        }
    }
}
