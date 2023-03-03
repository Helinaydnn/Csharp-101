using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Encapsulation
{
    internal class clsBank
    {
        #region Normal Durum
        public long AccountNumber;//hesap no
        public string Name;
        public int Balance; //miktar

        public void GetBalance()
        {

        }
        public void WithdrawAccount()
        {
            
        }
        public void Deposit()
        {

        }
        #endregion
        #region getter/setter

        //private double balance; //yani burada dışarıya kapalı bir değişken var.
        ////set (setter) / get(getter) metotlarının tanımlanması

        ////public getter metot
        ////bu metot balance değişkenimizde tutulan değeri almak için
        //public double GetBalanceCaps()
        //{
        //    //burada farklı işlemler var...
        //    return balance;
        //}
        //// public setter method
        ////bu metot balance değişkenimizde tutulan değeri değiştirmek/güncellemek/set için
        //public void SetBalanceCaps(double balance) //void geriye değer döndürmeyen metot
        //{
        //    //burada farklı işlemler var...
        //    this.balance = balance; //sen benim kendi değişkenimi güncelleyeceksin(this]..

        //}

        #endregion

        #region Eğer sınıfı tasarlarken kapsülleme (encapsulatıon) prensibine uymazsak ne olur?
        //public int Amount;
        //public int GetAmount() //get metodu
        //{
        //    return Amount;

        //}
        //public void SetAmount(int Amount)
        //{
        //    if (Amount > 0)
        //    {
        //     this.Amount = Amount;
        //    }
        //    else
        //    {
        //     throw new Exception("Lütfen pozitif bir sayı giriniz..");
        //    }
        //}
        #endregion

        #region Properties/değişkenlere de uygulanabilir...
        // Özellikler C#'da tanıtılan yeni bir dil özelliğidir. C# 'daki özellikler, değerleri okuyarak ve yazarak bir sınıfın
        // bir alanının veya değişkeninin korunmasına yardımcı olur. İlk yaklaşım, yani ayarlayıcı ve alıcının kendisi iyidir,
        // ancak C# 'daki veri kapsülleme özelliklerle çok daha pürüzsüz olarak gerçekleştirilebilir.
        private int _Amount1;
        public int Amount1
        {
            get 
            { 
                return _Amount1;
            }
            set 
            {
                if (value<0)
                {
                    throw new Exception("Lütfen pozitif bir değer giriniz...");
                }
                else
                {
                    _Amount1= value;
                }
            }
        }

         public int _Amount2 { get; set; }// en sade kullanımı


        #endregion
    }
}
