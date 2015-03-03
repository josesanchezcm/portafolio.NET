using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bingo
{
    public partial class FormPrincipalBingo : Form
    {
        private Random ran = new Random();
        private int r = 0;
        private int cont=0;
        private List<int> num = new List<int>();
        private string juego;
        private int seg;
        private int min;
        private int hrs;
       
        public FormPrincipalBingo()
        {
            InitializeComponent();
            this.agregar_filas_datagridview();
            this.agregar_numeros();
            this.agregar_filas_datagridviewTitulos();
            this.agregar_filas_datagridviewTipoJuego();
            this.buttonFinalizar.Visible = false;
            this.juego = "Finalizar Juego";
            this.comboBoxBinguito.SelectedIndex = 0;
            this.agregar_letras();
            this.pictureBoxLoadLetra.Visible = false;
            this.pictureBoxLoadNumero.Visible = false;
            this.pictureBoxPlay.Visible = false;
            this.pictureBoxPausa.Visible = false;
            this.agregar_titulos_2();
        }
        
        public void agregar_filas_datagridview()
        {
            for (int i = 0; i < 5; i++)
            {
                Object[] rows = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                dataGridView1.Rows.Add(rows);
            }
        }

        public void agregar_filas_datagridviewTitulos()
        {
            for (int i = 0; i < 5; i++)
            {
                Object[] rows = {""};
                dataGridViewTitulos.Rows.Add(rows);
            }
            
        }

        public void agregar_filas_datagridviewTipoJuego()
        {
            for (int i = 0; i < 5; i++)
            {
                Object[] rows = { "", "", "", "", ""};
                dataGridViewTipoJuego.Rows.Add(rows);
            }
        }

        public void agregar_letras()
        {
            for (int i = -1; i < 5; i++)
            {
                switch (i)
                {
                    case 0: dataGridViewTitulos.Rows[i].Cells[0].Value = "B";
                            break;
                    case 1: dataGridViewTitulos.Rows[i].Cells[0].Value = "I";
                            break;
                    case 2: dataGridViewTitulos.Rows[i].Cells[0].Value = "N";
                            break;
                    case 3: dataGridViewTitulos.Rows[i].Cells[0].Value = "G";
                            break;
                    case 4: dataGridViewTitulos.Rows[i].Cells[0].Value = "O";
                            break;
                }                    
            }
        }//agrga las letras al datagridviewtitulos

        public void agregar_titulos_2()
        {
            for (int i = -1; i < 5; i++)
            {
                switch (i)
                {
                    case 0: dataGridViewTitulos2.Rows[0].Cells[i].Value = "B";
                        break;
                    case 1: dataGridViewTitulos2.Rows[0].Cells[i].Value = "I";
                        break;
                    case 2: dataGridViewTitulos2.Rows[0].Cells[i].Value = "N";
                        break;
                    case 3: dataGridViewTitulos2.Rows[0].Cells[i].Value = "G";
                        break;
                    case 4: dataGridViewTitulos2.Rows[0].Cells[i].Value = "O";
                        break;
                }
            }
        }

        public void agregar_numeros()
        {
            int con = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = con++;
                }
            }
        }//agrega los numeros al datagrid principal

        public bool verificar(int verificar)
        {
            bool verifica = true;

            foreach (var n in num)
            {
                if (n == verificar)
                {
                    verifica = false;
                }
            }
            return verifica;
        }//Verifica si el numero ya se encuentra jugado

        public void seleccionar_letra(int r)
        {
            if (r > 0 && r <= 15)
            {
                this.textBoxLetra.Text = "B";
                dataGridViewTitulos.Rows[0].Cells[0].Style.BackColor = Color.Orange;
                dataGridViewTitulos.Rows[1].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[2].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[3].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[4].Cells[0].Style.BackColor = Color.White;
            }
            else if (r >= 16 && r <= 30)
            {
                this.textBoxLetra.Text = "I";
                dataGridViewTitulos.Rows[0].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[1].Cells[0].Style.BackColor = Color.Orange;
                dataGridViewTitulos.Rows[2].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[3].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[4].Cells[0].Style.BackColor = Color.White;
            }
            else if (r >= 31 && r <= 45)
            {
                this.textBoxLetra.Text = "N";
                dataGridViewTitulos.Rows[0].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[1].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[2].Cells[0].Style.BackColor = Color.Orange;
                dataGridViewTitulos.Rows[3].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[4].Cells[0].Style.BackColor = Color.White;
            }
            else if (r >= 46 && r <= 60)
            {
                this.textBoxLetra.Text = "G";
                dataGridViewTitulos.Rows[0].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[1].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[2].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[3].Cells[0].Style.BackColor = Color.Orange;
                dataGridViewTitulos.Rows[4].Cells[0].Style.BackColor = Color.White;
            }
            else if (r >= 61 && r <= 75)
            {
                this.textBoxLetra.Text = "O";
                dataGridViewTitulos.Rows[0].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[1].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[2].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[3].Cells[0].Style.BackColor = Color.White;
                dataGridViewTitulos.Rows[4].Cells[0].Style.BackColor = Color.Orange;
            }
        }//selecciona la letra correspondiente al numero obtenido, además pinta el titulo del datagrid principal
        
        //metodo para limpiar

        public void limpiar_dataGrid()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 15; j++)
                {                    
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                    dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    dataGridView1.Rows[i].Cells[j].Style.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                }
            }
        }

        public void limpiar_datagridtipojuego()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < dataGridViewTipoJuego.ColumnCount; j++)
                {
                    dataGridViewTipoJuego.Rows[i].Cells[j].Value = "";      
                    if (i == 2 && j == 2)
                    {
                        dataGridViewTipoJuego.Rows[i].Cells[j].Value = "X";
                    } 
                   dataGridViewTipoJuego.Rows[i].Cells[j].Style.BackColor = Color.White;
                              
                }
            }
            this.dataGridViewTipoJuego.ClearSelection();
        }

        public void limpiar_dataGridViewTitulos() 
        {
            for (int i = 0; i < dataGridViewTitulos.RowCount; i++)
            {
                dataGridViewTitulos.Rows[i].Cells[0].Style.BackColor=Color.White;
            }
        }

        public void juego_nuevo()
        {
            this.limpiar_dataGrid();
            this.limpiar_dataGridViewTitulos();
            textBoxLetra.Text = "!";
            textBoxNumero.Text = "!";
            r = 0;
            cont = 0;
            num.Clear();
            this.checkBoxCartonCompleto.Checked = false;
            this.comboBoxBinguito.SelectedIndex = 0;
            this.limpiar_datagridtipojuego();
            this.buttonFinalizar.Visible = false;
            this.labelNumerosJugados.Text = "0";
            this.labelNumerosRestantes.Text = "75";
        }

        //Fin metodo para limpiar

        //Metodos tipos de juegos

        public void cuatro_esquinas()
        {
            for (int i = 0; i < dataGridViewTipoJuego.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewTipoJuego.ColumnCount; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        dataGridViewTipoJuego.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                    }
                    else if (i == 0 && j == 4)
                    {
                        dataGridViewTipoJuego.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                    }
                    else if (i == 4 && j == 0)
                    {
                        dataGridViewTipoJuego.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                    }
                    else if (i == 4 && j == 4)
                    {
                        dataGridViewTipoJuego.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                    }
                }
            }    
        }

        public void cruz()
        {

            for (int i = 0; i < dataGridViewTipoJuego.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewTipoJuego.ColumnCount; j++)
                {
                    if (i==j)
                    {
                        dataGridViewTipoJuego.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                    }
                }
            }
                    
          dataGridViewTipoJuego.Rows[0].Cells[4].Style.BackColor = Color.Orange;
          dataGridViewTipoJuego.Rows[1].Cells[3].Style.BackColor = Color.Orange;
          dataGridViewTipoJuego.Rows[3].Cells[1].Style.BackColor = Color.Orange;
          dataGridViewTipoJuego.Rows[4].Cells[0].Style.BackColor = Color.Orange;
        }

        public void linea_superior()
        {
            for (int i = 0; i < dataGridViewTipoJuego.RowCount; i++)
            {
                dataGridViewTipoJuego.Rows[0].Cells[i].Style.BackColor=Color.Orange;
            }   
        }

        public void linea_inferior()
        {
            for (int i = 0; i < dataGridViewTipoJuego.RowCount; i++)
            {
                dataGridViewTipoJuego.Rows[4].Cells[i].Style.BackColor = Color.Orange;
            }   
        }

        public void linea_media()
                {
                    for (int i = 0; i < dataGridViewTipoJuego.RowCount; i++)
                    {
                        dataGridViewTipoJuego.Rows[2].Cells[i].Style.BackColor = Color.Orange;
                    } 
                }
        
        public void linea_izquerda()
        {
            for (int i = 0; i < dataGridViewTipoJuego.RowCount; i++)
            {
                dataGridViewTipoJuego.Rows[i].Cells[0].Style.BackColor = Color.Orange;
            }  
        }

        public void linea_derecha()
        {
            for (int i = 0; i < dataGridViewTipoJuego.RowCount; i++)
            {
                dataGridViewTipoJuego.Rows[i].Cells[4].Style.BackColor = Color.Orange;
            }  
        }

        public void letra_O()
        {
            for (int i = 0; i < dataGridViewTipoJuego.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewTipoJuego.ColumnCount; j++)
                {

                }
            }
        }

        //Fin Metodos tipos de juegos
        
        //Eventos
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridViewTitulos.ClearSelection();
            this.dataGridViewTipoJuego.ClearSelection();
            this.limpiar_datagridtipojuego();
        } //Al cargar el formulario

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            if (MessageBox.Show(juego, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.juego_nuevo();
                timer2.Stop();
                timer3.Stop();
                this.seg = 0;
                this.min = 0;
                this.hrs = 0;
                this.labelSegundo.Text = "00";
                this.labelMinunto.Text = "00";
                this.labelHora.Text = "00";
                this.labelestado.Text = "En espera.";
                this.pictureBoxPausa.Visible = false;
                this.pictureBoxPlay.Visible = false;
                this.buttonLanzar.Enabled = true;
            }
            else
            {
                timer2.Start();
            }
        }//Evento para finalizar el juego
        
        private void checkBoxCartonCompleto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCartonCompleto.Checked)
            {
                comboBoxBinguito.SelectedIndex = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < dataGridViewTipoJuego.ColumnCount; j++)
                    {
                        if (i == 2 && j == 2)
                        {
                            dataGridViewTipoJuego.Rows[i].Cells[j].Value = "X";
                        }
                        else
                        {
                            dataGridViewTipoJuego.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                        }
                        this.dataGridViewTipoJuego.ClearSelection();
                    }
                }
            }
            else
            {
                this.limpiar_datagridtipojuego();
            }           
        }//Evento selecciona carton Completo

        private void buttonLanzar_Click_1(object sender, EventArgs e)
        {
            if (comboBoxBinguito.SelectedIndex == 0 && checkBoxCartonCompleto.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un Juego","Seleccione",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                timer2.Start();
                textBoxLetra.Text = "";
                textBoxNumero.Text = "";
                pictureBoxLoadLetra.Visible = true;
                pictureBoxLoadNumero.Visible = true;
                this.pictureBoxPausa.Visible = true;
                this.labelestado.Text = "Jugando.";
                timer1.Start();
            }
        }//Evento para lanzar nuevo número
       
        private void comboBoxBinguito_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxBinguito.SelectedIndex)
            {
                case 0: this.limpiar_datagridtipojuego();
                        break;
                case 1: this.limpiar_datagridtipojuego();
                        this.checkBoxCartonCompleto.Checked = false;
                        this.cuatro_esquinas();          
                        break;
                case 2: this.limpiar_datagridtipojuego();
                        this.checkBoxCartonCompleto.Checked = false;
                        this.cruz();
                        break;
                case 3: this.limpiar_datagridtipojuego();
                        this.checkBoxCartonCompleto.Checked = false;
                        this.linea_superior();
                        break;
                case 4: this.limpiar_datagridtipojuego();
                        this.checkBoxCartonCompleto.Checked = false;
                        this.linea_inferior();
                        break;
                case 5: this.limpiar_datagridtipojuego();
                        this.checkBoxCartonCompleto.Checked = false;
                        this.linea_media();
                        break;
                case 6: this.limpiar_datagridtipojuego();
                        this.checkBoxCartonCompleto.Checked = false;
                        this.linea_izquerda();
                        break;
                case 7: this.limpiar_datagridtipojuego();
                        this.checkBoxCartonCompleto.Checked = false;
                        this.linea_derecha();
                        break;
                case 8: this.limpiar_datagridtipojuego();
                        this.checkBoxCartonCompleto.Checked = false;
                        this.linea_superior();
                        this.linea_inferior();
                        this.linea_izquerda();
                        this.linea_derecha();
                        break;
                case 9: this.limpiar_datagridtipojuego();
                        this.checkBoxCartonCompleto.Checked = false;
                        this.linea_inferior();
                        this.linea_izquerda();
                        this.linea_derecha();
                        break;
                case 10: this.limpiar_datagridtipojuego();
                        this.checkBoxCartonCompleto.Checked = false;
                        this.linea_inferior();
                        this.linea_superior();
                        this.linea_media();
                        this.linea_izquerda();
                        break;
                case 11: this.limpiar_datagridtipojuego();
                        this.checkBoxCartonCompleto.Checked = false;
                        this.linea_inferior();
                        this.linea_superior();
                        dataGridViewTipoJuego.Rows[0].Cells[4].Style.BackColor = Color.Orange;
                        dataGridViewTipoJuego.Rows[1].Cells[3].Style.BackColor = Color.Orange;
                        dataGridViewTipoJuego.Rows[2].Cells[2].Style.BackColor = Color.Orange;
                        dataGridViewTipoJuego.Rows[3].Cells[1].Style.BackColor = Color.Orange;
                        dataGridViewTipoJuego.Rows[4].Cells[0].Style.BackColor = Color.Orange;
                        break;
            }
        }//Evento para seleccionar nuevo binguito

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Opacity=0.5;
            if (timer2.Enabled)
            {
                this.pictureBoxPausa.Visible = false;
                this.pictureBoxPlay.Visible = true;
                this.buttonLanzar.Enabled = false;
                this.labelestado.Text = "Juego Pausado.";
                timer3.Start();
            }
            this.timer2.Stop();
            FormGenerarCartones fgc = new FormGenerarCartones();
            fgc.ShowDialog();
        }

        private void FormPrincipalBingo_Activated(object sender, EventArgs e)
        {
            if (this.Opacity<100)
            {
                this.Opacity=100;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxLoadLetra.Visible = false;
            pictureBoxLoadNumero.Visible = false;
            bool continua = true;
            juego = "Seguro que quieres finalizar el juego...?";
            this.buttonFinalizar.Text = "Finalizar Juego";
            this.buttonFinalizar.Visible = true;

            if (num.Count != 0)
            {
                while (continua)
                {
                    if (cont < 75)
                    {
                        r = ran.Next(0, 76);

                        while (r == 0 || r == 76)
                        {
                            r = ran.Next(0, 76);
                        }

                        if (verificar(r))
                        {
                            continua = false;
                            this.textBoxNumero.Text = r.ToString();
                            this.seleccionar_letra(r);
                            cont++;
                            this.labelNumerosJugados.Text = cont.ToString();
                            this.labelNumerosRestantes.Text = (75 - cont).ToString();
                        }
                    }
                    else
                    {
                        timer1.Stop();
                        timer2.Stop();
                        continua = false;
                        if (MessageBox.Show("Cartón Terminado, ¿Quieres empezar un juego nuevo? ", "Juego Finalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            this.juego_nuevo();
                        }
                        juego = "Quieres comenzar otro juego...?";
                        this.buttonFinalizar.Text = "Nuevo Juego";
                        this.labelSegundo.Text = "00";
                        this.labelMinunto.Text = "00";
                        this.labelHora.Text = "00";
                        this.seg = 0;
                        this.min = 0;
                        this.hrs = 0;
                    }
                }
            }
            else
            {
                r = ran.Next(0, 76);

                while (r == 0 || r == 76)
                {
                    r = ran.Next(0, 76);
                }
                this.seleccionar_letra(r);
                this.cont++;
                this.labelNumerosJugados.Text = cont.ToString();
                this.textBoxNumero.Text = r.ToString();
                this.labelNumerosRestantes.Text = (75 - cont).ToString();
            }

            num.Add(r);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (r == Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value.ToString()))
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.SteelBlue;
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.White;
                        dataGridView1.Rows[i].Cells[j].Style.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                        this.dataGridView1.ClearSelection();
                    }
                }
            }
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg > 0 && seg < 60)
            {
                if (seg.ToString().Length == 1)
                {
                    this.labelSegundo.Text = "0" + seg.ToString();
                }
                else
                {
                    this.labelSegundo.Text = seg.ToString();
                }
            }
            else
            {
                this.labelSegundo.Text = "00";
                seg = 0;
                min++;
                if (min > 0 && min < 60)
                {
                    if (min.ToString().Length==1)
                    {
                        this.labelMinunto.Text = "0" + min.ToString();
                    }
                    else
                    {
                        this.labelMinunto.Text =min.ToString();
                    }
                }
                else
                {
                    this.labelMinunto.Text = "00";
                    min = 0;
                    hrs++;
                    if (hrs>0&&hrs<24)
                    {
                        if (hrs.ToString().Length==1)
                        {
                            this.labelHora.Text = "0"+hrs.ToString();
                        }
                        else
                        {
                            this.labelHora.Text = hrs.ToString();
                        }
                    }
                    else
                    {
                        this.labelHora.Text = "00";
                        hrs = 0;
                    }
                }
            }
        }//reloj

        //Fin Eventos

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            pictureBoxPlay.Visible = true;
            pictureBoxPausa.Visible = false;
            this.labelestado.Text = "Juego Pausado.";
            timer3.Start();
            buttonLanzar.Enabled = false;
        }
       
        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
            pictureBoxPlay.Visible = false;
            pictureBoxPausa.Visible = true;
            labelestado.Visible = true;
            this.labelestado.Text = "Jugando.";
            buttonLanzar.Enabled = true;
        }

        private void FormPrincipalBingo_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult seleccion = MessageBox.Show("Seguro que quieres salir...?", "Confirmar", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (seleccion.CompareTo(DialogResult.OK) != 0)
                e.Cancel = true;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (labelestado.Visible == true)
            {
                labelestado.Visible = false;
            }
            else
            {
                labelestado.Visible = true;
            }
        }
    }
}
