using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetorFinanceiro
{
    public partial class RelatorioFinanceiro : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OSA0625259W10-1;Initial Catalog=RELATORIO_FINANCEIRO;Integrated Security=True"); //  > CON variavel para conexão
        SqlCommand comando = new SqlCommand(); //Comando > Variavel para comando 
        SqlDataReader dr;// Consultar os dados  
        public RelatorioFinanceiro()
        {
            InitializeComponent();
        }

        private void RelatorioFinanceiro_Load(object sender, EventArgs e)
        {
            comando.Connection = conn; //Conectando o formulario com o banco de dados 
            MostrarSemestre();

        }


        private void MostrarSemestre()
        {
            // limpa as informações após salvar
            lboCod.Items.Clear();
            lboProd.Items.Clear();
            lboJan.Items.Clear();
            lboFev.Items.Clear();
            lboMar.Items.Clear();
            lboAbri.Items.Clear();
            lboMai.Items.Clear();
            lboJunh.Items.Clear();

            conn.Open(); //Executar abertura do banco de dados 
            comando.CommandText = "select * from Despesas";
            dr = comando.ExecuteReader();

            if (dr.HasRows)  // Se estiver na linha 

            {
                while (dr.Read())
                {
                    lboCod.Items.Add(dr[0].ToString());
                    lboProd.Items.Add(dr[1].ToString());
                    lboJan.Items.Add(dr[2].ToString()); // Se inicia em zero listbox 
                    lboFev.Items.Add(dr[3].ToString());
                    lboMar.Items.Add(dr[4].ToString());
                    lboAbri.Items.Add(dr[5].ToString());
                    lboMai.Items.Add(dr[6].ToString());
                    lboJunh.Items.Add(dr[7].ToString());

                }

            }
            conn.Close(); // fechar o banco de dados


        }

        private void lboCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox; // 1 Variavel 
            if (l.SelectedIndex != -1) //irá setar a linha toda selecionada  

            {
                lboCod.SelectedIndex = l.SelectedIndex;
                lboProd.SelectedIndex = l.SelectedIndex;
                lboJan.SelectedIndex = l.SelectedIndex;
                lboFev.SelectedIndex = l.SelectedIndex;
                lboMar.SelectedIndex = l.SelectedIndex;
                lboAbri.SelectedIndex = l.SelectedIndex;
                lboMai.SelectedIndex = l.SelectedIndex;
                lboJunh.SelectedIndex = l.SelectedIndex;

                // Quando a linha for selecionada trazer para textbox.
                TxtCodigo.Text = lboCod.SelectedItem.ToString();
                TxtProd.Text = lboProd.SelectedItem.ToString();
                TxtJan.Text = lboJan.SelectedItem.ToString();
                TxtFev.Text = lboFev.SelectedItem.ToString();
                TxtMar.Text = lboMar.SelectedItem.ToString();
                TxtAbr.Text = lboAbri.SelectedItem.ToString();
                TxtMai.Text = lboMai.SelectedItem.ToString();
                TxtJunh.Text = lboJunh.SelectedItem.ToString();
            }
        }

        private void lboJan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lboCod.SelectedIndex = l.SelectedIndex;
                lboProd.SelectedIndex = l.SelectedIndex;
                lboJan.SelectedIndex = l.SelectedIndex;
                lboFev.SelectedIndex = l.SelectedIndex;
                lboMar.SelectedIndex = l.SelectedIndex;
                lboAbri.SelectedIndex = l.SelectedIndex;
                lboMai.SelectedIndex = l.SelectedIndex;
                lboJunh.SelectedIndex = l.SelectedIndex;
            }
        }

        private void lboFev_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lboCod.SelectedIndex = l.SelectedIndex;
                lboProd.SelectedIndex = l.SelectedIndex;
                lboJan.SelectedIndex = l.SelectedIndex;
                lboFev.SelectedIndex = l.SelectedIndex;
                lboMar.SelectedIndex = l.SelectedIndex;
                lboAbri.SelectedIndex = l.SelectedIndex;
                lboMai.SelectedIndex = l.SelectedIndex;
                lboJunh.SelectedIndex = l.SelectedIndex;
            }
        }

        private void lboMar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lboCod.SelectedIndex = l.SelectedIndex;
                lboProd.SelectedIndex = l.SelectedIndex;
                lboJan.SelectedIndex = l.SelectedIndex;
                lboFev.SelectedIndex = l.SelectedIndex;
                lboMar.SelectedIndex = l.SelectedIndex;
                lboAbri.SelectedIndex = l.SelectedIndex;
                lboMai.SelectedIndex = l.SelectedIndex;
                lboJunh.SelectedIndex = l.SelectedIndex;
            }
        }

        private void lboAbri_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lboCod.SelectedIndex = l.SelectedIndex;
                lboProd.SelectedIndex = l.SelectedIndex;
                lboJan.SelectedIndex = l.SelectedIndex;
                lboFev.SelectedIndex = l.SelectedIndex;
                lboMar.SelectedIndex = l.SelectedIndex;
                lboAbri.SelectedIndex = l.SelectedIndex;
                lboMai.SelectedIndex = l.SelectedIndex;
                lboJunh.SelectedIndex = l.SelectedIndex;
            }
        }

        private void lboMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lboCod.SelectedIndex = l.SelectedIndex;
                lboProd.SelectedIndex = l.SelectedIndex;
                lboJan.SelectedIndex = l.SelectedIndex;
                lboFev.SelectedIndex = l.SelectedIndex;
                lboMar.SelectedIndex = l.SelectedIndex;
                lboAbri.SelectedIndex = l.SelectedIndex;
                lboMai.SelectedIndex = l.SelectedIndex;
                lboJunh.SelectedIndex = l.SelectedIndex;
            }
        }

        private void lboJulh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lboCod.SelectedIndex = l.SelectedIndex;
                lboProd.SelectedIndex = l.SelectedIndex;
                lboJan.SelectedIndex = l.SelectedIndex;
                lboFev.SelectedIndex = l.SelectedIndex;
                lboMar.SelectedIndex = l.SelectedIndex;
                lboAbri.SelectedIndex = l.SelectedIndex;
                lboMai.SelectedIndex = l.SelectedIndex;
                lboJunh.SelectedIndex = l.SelectedIndex;
            }
        }

        private void lboResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // RESUTADOS
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            TxtProd.Clear();
            TxtJan.Clear();
            TxtFev.Clear();
            TxtMar.Clear();
            TxtAbr.Clear();
            TxtMai.Clear();
            TxtJunh.Clear();
            TxtProd.Focus();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conn.Open(); // abrir banco de dados 
            comando.CommandText = "insert into Despesas (Produto,Janeiro,Fevereiro,Março,Abril,Maio,Julho) " +
            " values ('" + TxtProd.Text + "', '" + TxtJan.Text + "','" + TxtFev.Text + "', '"
            + TxtMar.Text + "', '" + TxtAbr.Text + "', '" + TxtMai.Text + "', '" + TxtJunh.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close(); //fechar banco de dados 
            MostrarSemestre();
            TxtProd.Clear();
            TxtJan.Clear();
            TxtFev.Clear();
            TxtMar.Clear();
            TxtAbr.Clear();
            TxtMai.Clear();
            TxtJunh.Clear();
            TxtProd.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            conn.Open(); // abrir banco de dados 
            comando.CommandText = " update Despesas set Produto = '" + TxtProd.Text + "', Janeiro = '" + TxtJan.Text + "', Fevereiro = '" + TxtFev.Text + "', Março = '" + TxtMar.Text + "', Abril = '" + TxtAbr.Text + "', Maio = '" + TxtMai.Text +
            "', Junho = '" + TxtJunh.Text + "' where codigo = '" + lboCod.SelectedItem.ToString() + "'";
            comando.ExecuteNonQuery();
            conn.Close();
            MostrarSemestre();
            TxtProd.Clear();
            TxtJan.Clear();
            TxtFev.Clear();
            TxtMar.Clear();
            TxtAbr.Clear();
            TxtMai.Clear();
            TxtJunh.Clear();
            TxtProd.Focus();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = 0; for (int i = 0; i < lboJan.Items.Count; i++)
            {
                double jan = 0, fev = 0, mar = 0, abr = 0, mai = 0, jun = 0;
                double.TryParse(lboJan.Items[i].ToString(), out jan);
                double.TryParse(lboFev.Items[i].ToString(), out fev);
                double.TryParse(lboMar.Items[i].ToString(), out mar);
                double.TryParse(lboAbri.Items[i].ToString(), out abr);
                double.TryParse(lboMai.Items[i].ToString(), out mai);
                double.TryParse(lboJunh.Items[i].ToString(), out jun); double semestre = jan + fev + mar + abr + mai + jun; // Não é necessário selecionar para o cálculo, será cálculado toda a tabela
                total += semestre;
            }

            lboResultado.Items.Clear();
            lboResultado.Items.Add(total.ToString("C"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0; for (int i = 0; i < lboJan.Items.Count; i++)
            {
                double jan = 0;
                double.TryParse(lboJan.Items[i].ToString(), out jan);
                double.TryParse(lboJan.Items[i].ToString(), out jan); double semestre = jan;
                total += semestre;
            }
            Jan.Items.Clear();
            Jan.Items.Add(total.ToString("C"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = 0; for (int i = 0; i < lboJan.Items.Count; i++)
            {
                double fev = 0;
                double.TryParse(lboFev.Items[i].ToString(), out fev);
                double.TryParse(lboFev.Items[i].ToString(), out fev); double semestre = fev;
                total += semestre;
            }
            Fev.Items.Clear();
            Fev.Items.Add(total.ToString("C"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double total = 0; for (int i = 0; i < lboJan.Items.Count; i++)
            {
                double mar = 0;
                double.TryParse(lboMar.Items[i].ToString(), out mar);
                double.TryParse(lboMar.Items[i].ToString(), out mar); double semestre = mar;
                total += semestre;
            }
            Mar.Items.Clear();
            Mar.Items.Add(total.ToString("C"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double total = 0; for (int i = 0; i < lboJan.Items.Count; i++)
            {
                double abr = 0;
                double.TryParse(lboAbri.Items[i].ToString(), out abr);
                double.TryParse(lboAbri.Items[i].ToString(), out abr); double semestre = abr;
                total += semestre;
            }
            Abri.Items.Clear();
            Abri.Items.Add(total.ToString("C"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double total = 0; for (int i = 0; i < lboJan.Items.Count; i++)
            {
                double mai = 0;
                double.TryParse(lboMai.Items[i].ToString(), out mai);
                double.TryParse(lboMai.Items[i].ToString(), out mai); double semestre = mai;
                total += semestre;
            }
            Mai.Items.Clear();
            Mai.Items.Add(total.ToString("C"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double total = 0; for (int i = 0; i < lboJan.Items.Count; i++)
            {
                double jun = 0;
                double.TryParse(lboJunh.Items[i].ToString(), out jun);
                double.TryParse(lboJunh.Items[i].ToString(), out jun); double semestre = jun;
                total += semestre;
            }
            Junh.Items.Clear();
            Junh.Items.Add(total.ToString("C"));
        }
    }
}
