namespace WinFormsGiris
{
    public partial class Form1 : Form
    {
        Araba _araba;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbBeygirGucu_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bOlustur_Click(object sender, EventArgs e)
        {
            _araba = new Araba();
            _araba.Marka = tbMarka.Text;
            _araba.Model = tbModel.Text;
            //araba.KapiSayisi = (byte)numKapiSayisi.Value; casting dikkatli kullaným
            _araba.KapiSayisi = Convert.ToByte(numKapiSayisi.Value);
            _araba.BeygirGucu = short.Parse(tbBeygirGucu.Text);
            _araba.SifirYuz = Convert.ToDouble(tbSifirYuz.Text);
            _araba.UretimTarihi = dtpUretimTarihi.Value;
            _araba.IkýncýEl = cbIkinciEl.Checked;
            _araba.ArabaTuru = (ArabaTuru)ddlArabaTuru.SelectedIndex;//casting kullanman þart 
            MessageBox.Show("Araba Olusturuldu");

        }

        private void bGetir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("marka: " + _araba.Marka +
                             "\n" + "model:" + _araba.Model +
                             "\n" + "kapý sayýsý:" + _araba.KapiSayisi +
                             "\n" + "beygir gücü:" + _araba.BeygirGucu "\n" +
                             "araba 0-100:" + "ikinci el :" + (if (_araba.IkýncýEl==true)
            {

            });// global olarak tanýmlamak için field olarak tanýmlandý en baþta
           
        }
    }
}