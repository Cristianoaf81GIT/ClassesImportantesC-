using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnMessageBox_Click(object sender, EventArgs e)
    {
      //MessageBox.Show("Olá meus amigos !!!");
      // MessageBox.Show("Mensagem a ser impressa", "Título da mensagem*/");
      // MessageBox.Show("Texto da mensagem", "Título", MessageBoxButtons.YesNoCancel);
      //DialogResult res = MessageBox.Show("Texto da mensagem", "Título", MessageBoxButtons.OKCancel);
      //if (res == DialogResult.OK)
      //{
      //    lblResultado.Text = "Clicou em Ok";
      //}
      //else if (res == DialogResult.Cancel)
      //{
      //    lblResultado.Text = "Clicou em Cancelar";
      //}
      //MessageBox.Show("Mensagem", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      MessageBox
          .Show(
          "Mensagem",
          "Título",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Information,
          MessageBoxDefaultButton.Button2
      );
    }

    private void aleatorio_Click(object sender, EventArgs e)
    {
      Random r = new Random(DateTime.Now.Millisecond);
      int valor = r.Next(100);
      double valor2 = r.NextDouble() * valor;
      lblResultado.Text = "Número: " + valor2;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //lblResultado.Text = TimeSpan.FromMinutes(90.5).ToString();
      //lblResultado.Text = TimeSpan.FromDays(7.35).ToString();
      //lblResultado.Text = TimeSpan.FromTicks(100000).ToString();
      // lblResultado.Text = TimeSpan.TicksPerMinute.ToString();
      TimeSpan inicio = new TimeSpan(1, 0, 0);
      TimeSpan fim = new TimeSpan(3, 30, 0);
      //TimeSpan intervalo = fim - inicio;
      //TimeSpan intervalo = inicio.Add(fim);
      TimeSpan intervalo = fim.Subtract(inicio);
      lblResultado.Text = intervalo.TotalHours.ToString();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      //lblResultado.Text = DateTime.Now.ToString()
      //lblResultado.Text = DateTime.Today.ToString();
      //lblResultado.Text = DateTime.DaysInMonth(2022,04).ToString();
      //lblResultado.Text = DateTime.IsLeapYear(2022).ToString();
      //lblResultado.Text = DateTime.Now.ToLongDateString();
      //lblResultado.Text = DateTime.Now.ToShortDateString();
      //lblResultado.Text = DateTime.Now.ToLongTimeString();
      //lblResultado.Text = DateTime.Now.ToShortTimeString();
      //lblResultado.Text = DateTime.Now.ToUniversalTime().ToString();
      //lblResultado.Text = DateTime.Now.ToString("dd-MM-yy H:mm:ss");
      DateTime data = new DateTime(1985, 01, 10, 14, 35, 30);
      //lblResultado.Text = data.AddYears(2).ToString();
      //TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
      //lblResultado.Text = data.Add(tempo).ToString();
      //lblResultado.Text = data.DayOfWeek.ToString();
      lblResultado.Text = data.DayOfYear.ToString();
    }

    private void btnName_Click(object sender, EventArgs e)
    {
      Color vermelho = Color.Red;
      Color amarelo = Color.Yellow;

      //Color cor = Color.FromArgb(125, Color.DarkGreen);
      //Color cor = Color.FromArgb(225, 255, 255, 255);
      Color cor = Color.FromArgb(100, 50, 135);
      Color cor1 = Color.FromKnownColor(KnownColor.Control);
      Color cor2 = Color.FromName("DarkRed");


      lblResultado.BackColor = cor2;
      lblResultado.ForeColor = amarelo;
      lblResultado.Text = "Exemplo Struct Color";

      Color cor3 = lblResultado.BackColor;
      btnColor.BackColor = cor3;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnFont_Click(object sender, EventArgs e)
    {
      Font letra = new Font("Helvetica, Arial, sans-serif, Comic Sans MS", 36, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel);
      Font letra2 = new Font(FontFamily.GenericMonospace, 36, FontStyle.Regular, GraphicsUnit.Pixel);
      lblResultado.Text = "Bem vindo ao C# trabalho com fontes";
      lblResultado.Font = letra;
    }

    private void btnEnvironment_Click(object sender, EventArgs e)
    {
      String meusDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      // Environment.CurrentDirectory = "c:\\";
      String dirAtual = Environment.CurrentDirectory;
      // Environment.NewLine
      String varAmb = Environment.GetEnvironmentVariable("Path");
      String[] discos = Environment.GetLogicalDrives();
      Action<String> discosAction = new Action<string>(showDiscos);
      // Array.ForEach(discos, discosAction);
      String user = Environment.UserName;
      String domain = Environment.UserDomainName;
      int processors = Environment.ProcessorCount;
      lblResultado.Text = user + Environment.NewLine + domain + Environment.NewLine + processors;
    }

    private void showDiscos(String disco)
    {
      String result = disco + " disco do sistema";
      MessageBox.Show(result, "\nDisco(s) do sistema");
      lblResultado.Text += "\n" + disco;
    }
  }
}
