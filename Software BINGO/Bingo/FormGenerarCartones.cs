using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bingo
{
    public partial class FormGenerarCartones : Form
    {

        private List<int> bl = new List<int>();
        private List<int> il = new List<int>();
        private List<int> nl = new List<int>();
        private List<int> gl = new List<int>();
        private List<int> ol = new List<int>();

        private Random br = new Random();
        private Random ir = new Random();
        private Random nr = new Random();
        private Random gr = new Random();
        private Random or = new Random();

        private int b = 0;
        private int i = 0;
        private int n = 0;
        private int g = 0;
        private int o = 0;

        private bool bb;
        private bool ib;
        private bool nb;
        private bool gb;
        private bool ob;

        private DataTable dt;
        private DataRow r1, r2, r3, r4, r5;
        private DataColumn c1, c2, c3, c4, c5;



        public FormGenerarCartones()
        {
            InitializeComponent();
            this.agregar_filas_carton();
            this.buttonImprimirUno.Visible = false;
            this.buttonImprimirTodos.Visible = false;
            this.pictureBoxLoad.Visible = false;
            this.posicionar_x();
        }

        public void llenar_cartones_numeros(DataGridView datagridview1, DataGridView datagridview2, DataGridView datagridview3, DataGridView datagridview4, DataGridView datagridview5, DataGridView datagridview6, DataGridView datagridview7, DataGridView datagridview8, DataGridView datagridview9, DataGridView datagridview10, DataGridView datagridview11, DataGridView datagridview12, DataGridView datagridview13, DataGridView datagridview14, DataGridView datagridview15)
        {
            bb = true;
            ib = true;
            nb = true;
            gb = true;
            ob = true;

            for (int i = 0; i < 5; i++)
            {                
                while (bb)
                {
                    this.b = br.Next(0, 16);

                    while (b==0||b==16)
                    {
                        this.b = br.Next(0, 16);
                    }

                    if (verifica_b(b))
                    {
                        bb = false;
                    }
                }

                datagridview1.Rows[i].Cells[0].Value = b.ToString();
                datagridview2.Rows[i].Cells[0].Value = b.ToString();
                datagridview3.Rows[i].Cells[0].Value = b.ToString();
                datagridview4.Rows[i].Cells[0].Value = b.ToString();
                datagridview5.Rows[i].Cells[0].Value = b.ToString();
                datagridview6.Rows[i].Cells[0].Value = b.ToString();
                datagridview7.Rows[i].Cells[0].Value = b.ToString();
                datagridview8.Rows[i].Cells[0].Value = b.ToString();
                datagridview9.Rows[i].Cells[0].Value = b.ToString();
                datagridview10.Rows[i].Cells[0].Value = b.ToString();
                datagridview11.Rows[i].Cells[0].Value = b.ToString();
                datagridview12.Rows[i].Cells[0].Value = b.ToString();
                datagridview13.Rows[i].Cells[0].Value = b.ToString();
                datagridview14.Rows[i].Cells[0].Value = b.ToString();
                datagridview15.Rows[i].Cells[0].Value = b.ToString();

                bb = true;
                bl.Add(b);
            }

            for (int h = 0; h < 5; h++)
            {
                while (ib)
                {
                    this.i = ir.Next(15, 31);

                    while (i == 15 || i == 31)
                    {
                        this.i = ir.Next(15, 31);
                    }

                    if (verifica_i(i))
                    {
                        ib = false;
                    }
                }

                datagridview1.Rows[h].Cells[1].Value = i.ToString();
                datagridview2.Rows[h].Cells[1].Value = i.ToString();
                datagridview3.Rows[h].Cells[1].Value = i.ToString();
                datagridview4.Rows[h].Cells[1].Value = i.ToString();
                datagridview5.Rows[h].Cells[1].Value = i.ToString();
                datagridview6.Rows[h].Cells[1].Value = i.ToString();
                datagridview7.Rows[h].Cells[1].Value = i.ToString();
                datagridview8.Rows[h].Cells[1].Value = i.ToString();
                datagridview9.Rows[h].Cells[1].Value = i.ToString();
                datagridview10.Rows[h].Cells[1].Value = i.ToString();
                datagridview11.Rows[h].Cells[1].Value = i.ToString();
                datagridview12.Rows[h].Cells[1].Value = i.ToString();
                datagridview13.Rows[h].Cells[1].Value = i.ToString();
                datagridview14.Rows[h].Cells[1].Value = i.ToString();
                datagridview15.Rows[h].Cells[1].Value = i.ToString();

                ib = true;
                il.Add(i);
            }

            for (int i = 0; i < 5; i++)
            {
                while (nb)
                {
                    this.n = nr.Next(30, 46);

                    while (n == 30 || n == 46)
                    {
                        this.n = nr.Next(30, 46);
                    }

                    if (verifica_n(n))
                    {
                        nb = false;
                    }
                }

                datagridview1.Rows[i].Cells[2].Value = n.ToString();
                datagridview2.Rows[i].Cells[2].Value = n.ToString();
                datagridview3.Rows[i].Cells[2].Value = n.ToString();
                datagridview4.Rows[i].Cells[2].Value = n.ToString();
                datagridview5.Rows[i].Cells[2].Value = n.ToString();
                datagridview6.Rows[i].Cells[2].Value = n.ToString();
                datagridview7.Rows[i].Cells[2].Value = n.ToString();
                datagridview8.Rows[i].Cells[2].Value = n.ToString();
                datagridview9.Rows[i].Cells[2].Value = n.ToString();
                datagridview10.Rows[i].Cells[2].Value = n.ToString();
                datagridview11.Rows[i].Cells[2].Value = n.ToString();
                datagridview12.Rows[i].Cells[2].Value = n.ToString();
                datagridview13.Rows[i].Cells[2].Value = n.ToString();
                datagridview14.Rows[i].Cells[2].Value = n.ToString();
                datagridview15.Rows[i].Cells[2].Value = n.ToString();

                nb = true;
                nl.Add(n);
            }

            for (int i = 0; i < 5; i++)
            {
                while (gb)
                {
                    this.g = gr.Next(45, 61);

                    while (g == 45 || g == 61)
                    {
                        this.g = gr.Next(45, 61);
                    }

                    if (verifica_g(g))
                    {
                        gb = false;
                    }
                }

                datagridview1.Rows[i].Cells[3].Value = g.ToString();
                datagridview2.Rows[i].Cells[3].Value = g.ToString();
                datagridview3.Rows[i].Cells[3].Value = g.ToString();
                datagridview4.Rows[i].Cells[3].Value = g.ToString();
                datagridview5.Rows[i].Cells[3].Value = g.ToString();
                datagridview6.Rows[i].Cells[3].Value = g.ToString();
                datagridview7.Rows[i].Cells[3].Value = g.ToString();
                datagridview8.Rows[i].Cells[3].Value = g.ToString();
                datagridview9.Rows[i].Cells[3].Value = g.ToString();
                datagridview10.Rows[i].Cells[3].Value = g.ToString();
                datagridview11.Rows[i].Cells[3].Value = g.ToString();
                datagridview12.Rows[i].Cells[3].Value = g.ToString();
                datagridview13.Rows[i].Cells[3].Value = g.ToString();
                datagridview14.Rows[i].Cells[3].Value = g.ToString();
                datagridview15.Rows[i].Cells[3].Value = g.ToString();

                gb = true;
                gl.Add(g);
            }

            for (int i = 0; i < 5; i++)
            {
                while (ob)
                {
                    this.o = or.Next(60, 76);

                    while (o == 60 || o == 76)
                    {
                        this.o = or.Next(60, 76);
                    }

                    if (verifica_o(o))
                    {
                        ob = false;
                    }
                }

                datagridview1.Rows[i].Cells[4].Value = o.ToString();
                datagridview2.Rows[i].Cells[4].Value = o.ToString();
                datagridview3.Rows[i].Cells[4].Value = o.ToString();
                datagridview4.Rows[i].Cells[4].Value = o.ToString();
                datagridview5.Rows[i].Cells[4].Value = o.ToString();
                datagridview6.Rows[i].Cells[4].Value = o.ToString();
                datagridview7.Rows[i].Cells[4].Value = o.ToString();
                datagridview8.Rows[i].Cells[4].Value = o.ToString();
                datagridview9.Rows[i].Cells[4].Value = o.ToString();
                datagridview10.Rows[i].Cells[4].Value = o.ToString();
                datagridview11.Rows[i].Cells[4].Value = o.ToString();
                datagridview12.Rows[i].Cells[4].Value = o.ToString();
                datagridview13.Rows[i].Cells[4].Value = o.ToString();
                datagridview14.Rows[i].Cells[4].Value = o.ToString();
                datagridview15.Rows[i].Cells[4].Value = o.ToString();

                ob = true;
                ol.Add(o);
            }
            

            bl.Clear();
            il.Clear();
            nl.Clear();
            gl.Clear();
            ol.Clear();
            this.posicionar_x();

        }

        public bool verifica_b(int n)
        {
            bool verifica = true;
            foreach (var num in bl)
            {
                if (num == n)
                {
                    verifica = false;
                }
            }

            return verifica;
        }

        public bool verifica_i(int n)
        {
            bool verifica = true;
            foreach (var num in il)
            {
                if (num == n)
                {
                    verifica = false;
                }
            }

            return verifica;
        }

        public bool verifica_n(int n)
        {
            bool verifica = true;
            foreach (var num in nl)
            {
                if (num == n)
                {
                    verifica = false;
                }
            }

            return verifica;
        }

        public bool verifica_g(int n)
        {
            bool verifica = true;
            foreach (var num in gl)
            {
                if (num == n)
                {
                    verifica = false;
                }
            }

            return verifica;
        }

        public bool verifica_o(int n)
        {
            bool verifica = true;
            foreach (var num in ol)
            {
                if (num == n)
                {
                    verifica = false;
                }
            }

            return verifica;
        }

        public void agregar_filas_carton()
        {
            for (int i = 0; i < 5; i++)
            {
                Object[] row={"","","","",""};
                dataGridViewCarton1.Rows.Add(row);
                dataGridViewCarton2.Rows.Add(row);
                dataGridViewCarton3.Rows.Add(row);
                dataGridViewCarton4.Rows.Add(row);
                dataGridViewCarton5.Rows.Add(row);
                dataGridViewCarton6.Rows.Add(row);
                dataGridViewCarton7.Rows.Add(row);
                dataGridViewCarton8.Rows.Add(row);
                dataGridViewCarton9.Rows.Add(row);
                dataGridViewCarton10.Rows.Add(row);
                dataGridViewCarton11.Rows.Add(row);
                dataGridViewCarton12.Rows.Add(row);
                dataGridViewCarton13.Rows.Add(row);
                dataGridViewCarton14.Rows.Add(row);
                dataGridViewCarton15.Rows.Add(row);
            }
        }

        public void posicionar_x()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (i==2&&j==2)
	                {
		                dataGridViewCarton1.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton2.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton2.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton3.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton3.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton4.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton4.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton5.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton5.Rows[i].Cells[j].Style.ForeColor = Color.Black;

                        dataGridViewCarton6.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton6.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton7.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton7.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton8.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton8.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton9.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton9.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton10.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton10.Rows[i].Cells[j].Style.ForeColor = Color.Black;

                        dataGridViewCarton11.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton11.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton12.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton12.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton13.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton13.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton14.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton14.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        dataGridViewCarton15.Rows[i].Cells[j].Value = "X";
                        dataGridViewCarton15.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void FormGenerarCartones_Load(object sender, EventArgs e)
        {
            dataGridViewCarton1.ClearSelection();
            dataGridViewCarton2.ClearSelection();
            dataGridViewCarton3.ClearSelection();
            dataGridViewCarton4.ClearSelection();
            dataGridViewCarton5.ClearSelection();
            dataGridViewCarton6.ClearSelection();
            dataGridViewCarton7.ClearSelection();
            dataGridViewCarton8.ClearSelection();
            dataGridViewCarton9.ClearSelection();
            dataGridViewCarton10.ClearSelection();
            dataGridViewCarton11.ClearSelection();
            dataGridViewCarton12.ClearSelection();
            dataGridViewCarton13.ClearSelection();
            dataGridViewCarton14.ClearSelection();
            dataGridViewCarton15.ClearSelection();
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            this.buttonImprimirUno.Visible = false;
            this.buttonImprimirTodos.Visible = false;
            pictureBoxLoad.Visible = true;
            timer1.Start();
        }

        private void linkLabelColorDialog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            if (dataGridViewCarton1.Rows[0].Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Primero se deben generar los números","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                ColorDialog cdialog = new ColorDialog();
                cdialog.ShowDialog();

                for (int i = 0; i < dataGridViewCarton1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewCarton1.ColumnCount; j++)
                    {
                        dataGridViewCarton1.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton2.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton3.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton4.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton5.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton6.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton7.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton8.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton9.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton10.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton11.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton12.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton13.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton14.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        dataGridViewCarton15.Rows[i].Cells[j].Style.ForeColor = cdialog.Color;
                        if (i == 2 && j == 2)
                        {
                            dataGridViewCarton1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton2.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton3.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton4.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton5.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton6.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton7.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton8.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton9.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton10.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton11.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton12.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton13.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton14.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            dataGridViewCarton15.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        private void buttonImprimirUno_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarton1.Rows[0].Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Primero se deben generar los números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DirectoryInfo info = new DirectoryInfo(@"C:\InfoBingo");
                dt = new DataTable();
                dt.TableName = "CartonBingo";

                if (!info.Exists)
                {
                    info.Create();
                    dt.WriteXml("C:/InfoBingo/carton.xml", XmlWriteMode.WriteSchema);
                }

                int num = 2;
                string valor;
                this.agregar_columnas_y_fials_datatable(dt);

                for (int i = 0; i < dataGridViewCarton1.RowCount; i++)
                {
                    if (i == 2 && num == 2)
                    {
                        valor = "X";
                    }
                    else
                    {
                        valor = dataGridViewCarton1.Rows[i].Cells[2].Value.ToString();
                    }

                    String[] row = { dataGridViewCarton1.Rows[i].Cells[0].Value.ToString(), dataGridViewCarton1.Rows[i].Cells[1].Value.ToString(), valor, dataGridViewCarton1.Rows[i].Cells[3].Value.ToString(), dataGridViewCarton1.Rows[i].Cells[4].Value.ToString() };
                    dt.Rows.Add(row);
                }

                dt.WriteXml("C:/InfoBingo/carton.xml", XmlWriteMode.WriteSchema);

                FormImprimirUno f = new FormImprimirUno();
                f.ShowDialog();
            }
            
        }

        public void agregar_columnas_y_fials_datatable(DataTable dt)
        {
            c1 = new DataColumn();
            c1.DataType = System.Type.GetType("System.String");
            c1.ColumnName = "B";
            c1.AutoIncrement = false;
            c1.Caption = "ChildItem";
            c1.ReadOnly = false;
            c1.Unique = false;
            dt.Columns.Add(c1);

            c2 = new DataColumn();
            c2.DataType = System.Type.GetType("System.String");
            c2.ColumnName = "I";
            c2.AutoIncrement = false;
            c2.Caption = "ChildItem";
            c2.ReadOnly = false;
            c2.Unique = false;
            dt.Columns.Add(c2);

            c3 = new DataColumn();
            c3.DataType = System.Type.GetType("System.String");
            c3.ColumnName = "N";
            c3.AutoIncrement = false;
            c3.Caption = "ChildItem";
            c3.ReadOnly = false;
            c3.Unique = false;
            dt.Columns.Add(c3);

            c4 = new DataColumn();
            c4.DataType = System.Type.GetType("System.String");
            c4.ColumnName = "G";
            c4.AutoIncrement = false;
            c4.Caption = "ChildItem";
            c4.ReadOnly = false;
            c4.Unique = false;
            dt.Columns.Add(c4);

            c5 = new DataColumn();
            c5.DataType = System.Type.GetType("System.String");
            c5.ColumnName = "O";
            c5.AutoIncrement = false;
            c5.Caption = "ChildItem";
            c5.ReadOnly = false;
            c5.Unique = false;
            dt.Columns.Add(c5);

            r1 = dt.NewRow();
            r2 = dt.NewRow();
            r3 = dt.NewRow();
            r4 = dt.NewRow();
            r5 = dt.NewRow();
        }

        private void buttonImprimirTodos_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarton1.Rows[0].Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Primero se deben generar los números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DirectoryInfo info = new DirectoryInfo(@"C:\InfoBingo");
                dt = new DataTable();
                dt.TableName = "CartonBingo";

                if (!info.Exists)
                {
                    info.Create();
                    dt.WriteXml("C:/InfoBingo/carton.xml", XmlWriteMode.WriteSchema);
                }

                int num = 2;
                string valor;
                this.agregar_columnas_y_fials_datatable(dt);

                for (int i = 0; i < dataGridViewCarton1.RowCount; i++)
                {
                    if (i == 2 && num == 2)
                    {
                        valor = "X";
                    }
                    else
                    {
                        valor = dataGridViewCarton1.Rows[i].Cells[2].Value.ToString();
                    }

                    String[] row = { dataGridViewCarton1.Rows[i].Cells[0].Value.ToString(), dataGridViewCarton1.Rows[i].Cells[1].Value.ToString(), valor, dataGridViewCarton1.Rows[i].Cells[3].Value.ToString(), dataGridViewCarton1.Rows[i].Cells[4].Value.ToString() };
                    dt.Rows.Add(row);
                }

                dt.WriteXml("C:/InfoBingo/carton.xml", XmlWriteMode.WriteSchema);

                FormImprimirVarios f = new FormImprimirVarios();
                f.ShowDialog();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.llenar_cartones_numeros(dataGridViewCarton1, dataGridViewCarton2, dataGridViewCarton3, dataGridViewCarton4, dataGridViewCarton5, dataGridViewCarton6, dataGridViewCarton7, dataGridViewCarton8,dataGridViewCarton9, dataGridViewCarton10, dataGridViewCarton11, dataGridViewCarton12, dataGridViewCarton13, dataGridViewCarton14, dataGridViewCarton15);
            this.buttonImprimirUno.Visible = true;
            this.buttonImprimirTodos.Visible = true;
            pictureBoxLoad.Visible = false;
            timer1.Stop();
        }
    }
}
