namespace WinFormsGiris
{
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public byte KapiSayisi { get; set; }
        public short BeygirGucu { get; set; }

        public ArabaTuru ArabaTuru { get; set; }

        public double SifirYuz { get; set; }

        public DateTime UretimTarihi { get; set; }

        public bool IkıncıEl { get; set; }


    }
}
