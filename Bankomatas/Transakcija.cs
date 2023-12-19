using System;
namespace Bankomatas
{
    public class Transakcija
    {
        public decimal Suma;
        public DateTime Data;
        public string Valiuta;
        public string MokejimoPaskirtis;

        public Transakcija(decimal amount, DateTime Data, string Valiuta, string MokejimoPaskirtis) // konstruktorius
        {
            this.Suma = amount;
            this.Data = Data;
            this.Valiuta = Valiuta;
            this.MokejimoPaskirtis = MokejimoPaskirtis;
        }

        /*
		public double Amount { get; set; }
        public DateTime Date { get; }
        public string Currency { get; }
        public string Purpose { get; }

        public Transaction(double amount, string currency, string purpose)
        {
            Amount = amount;
            Date = DateTime.Now;
            Currency = currency;
            Purpose = purpose;
        }

        public override string ToString()
        {
            return $"Date: {Date}, Amount: {Amount} {Currency}, Purpose: {Purpose}";
        }*/
    }
}

