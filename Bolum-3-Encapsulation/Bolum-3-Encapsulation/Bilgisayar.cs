

namespace Bolum_3_Encapsulation
{
    class Bilgisayar
    {
        //Bir bilgisayarın ..... sı olur.

        //field
        //public string marka;
        //public string model;
        //public double ekranBoyut;
        //public string ekranKarti;
        //public string isletimSistemi;
        //public string islemci;
        //public int ram;
        //public int hdKapasite;
        //public decimal fiyat;

        //Property
        //public string Marka { get; set; }
        private string marka;
        public string Marka
        {
            get//getter
            {
                return marka;
            }
            set//setter
            {
                if (value != "dell")
                {
                    marka = "tanımsız marka";
                }
                else
                {
                    marka = value;
                }
            }
        }

        public string Model { get; set; }
        public double EkranBoyutu { get; set; }
        public string EkranKarti { get; set; }
        public string IsletimSistemi { get; set; }
        public string Islemci { get; set; }
        public int Ram { get; set; }
        public int HdKapasite { get; set; }
        public decimal Fiyat { get; set; }

        //read-only
        public decimal KdvDahilFiyat
        {

            get
            {
                return Fiyat + (Fiyat * 0.18m);
            }
        }




    }
}
