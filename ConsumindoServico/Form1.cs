using ConsumindoServico.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumindoServico
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string nome = textBox1.Text;
			string cpf = textBox2.Text;
			try
			{
				ClienteServiceClient servico = new ClienteServiceClient();
				Cliente cliente = new Cliente();
				cliente.Nome = nome;
				cliente.Cpf = cpf;
				servico.Add(cliente);
				MessageBox.Show("Cadastrado com sucesso");
			}
			catch (Exception)
			{
				throw;
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string nome = textBox1.Text;
			try
			{
				ClienteServiceClient servico = new ClienteServiceClient();
				Cliente resultado = servico.Buscar(nome);
				textBox2.Text = resultado.Cpf;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
