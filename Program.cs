using System;

namespace methodlar // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=3,b=2;
            //Console.WriteLine(a+b);
            
            int sonuc=Topla(a,b);
            Console.WriteLine(sonuc);

            metotlar ornek = new metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2=ornek.ArttirveTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2)); //Çıktısı => 7
            ornek.EkranaYazdir(Convert.ToString(a+b)); // bellekteki yerlerine işaret edip değiştirdi. Çıktısı => 7
        }
        static int Topla(int deger1, int deger2)
        {
            return(deger1+deger2);
        }
    }
    class metotlar // yeni class
    {
        public void EkranaYazdir(string veri) // public olması her yerden erişim sağlar
        {
            Console.WriteLine(veri);
        }
        public int ArttirveTopla(ref int sayi1, ref int sayi2) // ref: bellekteki yerine işaret eder
        {
            sayi1+=1;
            sayi2+=1;
            return(sayi1+sayi2);
        }
    }
}