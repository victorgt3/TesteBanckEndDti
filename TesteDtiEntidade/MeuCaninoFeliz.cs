using System;

namespace TesteDtiEntidade
{
    public class MeuCaninoFeliz : PetShop
    {
        public double ValorCaoPequeno { get; private set; }
        public double ValorCaoGrande { get; private set; }
        public DateTime Data { get; private set; }
        public double Distancia { get; private set; }
        public int QuantidadeCaesPequenos { get; private set; }
        public int QuantidadeCaesGrandes { get; private set; }
        public MeuCaninoFeliz(DateTime data, int quantidadeCaesPequenos, int quantidadeCaesGrandes)
        {
            Data = data;
            QuantidadeCaesPequenos = quantidadeCaesPequenos;
            QuantidadeCaesGrandes = quantidadeCaesGrandes;
        }
        public MeuCaninoFeliz GetMeuCaninoFeliz(MeuCaninoFeliz meuCaninoFeliz)
        {


            if (meuCaninoFeliz.Data.DayOfWeek == DayOfWeek.Saturday || meuCaninoFeliz.Data.DayOfWeek == DayOfWeek.Sunday)
            {
                meuCaninoFeliz.Nome = "Meu Canino Feliz";

                meuCaninoFeliz.Distancia = 2000.00;

                double percentual = 20.00 / 100.00;
                double valorCaoPequeno = 20.00;
                double valorCaoGrande = 40.00;

                meuCaninoFeliz.ValorCaoPequeno = valorCaoPequeno + (percentual * valorCaoPequeno);
                meuCaninoFeliz.ValorCaoGrande = valorCaoGrande + (percentual * valorCaoGrande);

                meuCaninoFeliz.ValorCaoPequeno = meuCaninoFeliz.QuantidadeCaesPequenos * meuCaninoFeliz.ValorCaoPequeno;
                meuCaninoFeliz.ValorCaoGrande = meuCaninoFeliz.QuantidadeCaesGrandes * meuCaninoFeliz.ValorCaoGrande;

                meuCaninoFeliz.ValorTotalBanhos = meuCaninoFeliz.ValorCaoPequeno + meuCaninoFeliz.ValorCaoGrande;

                return meuCaninoFeliz;
            }
            else
            {
                meuCaninoFeliz.Nome = "Meu Canino Feliz";
                meuCaninoFeliz.Distancia = 2000;

                int valorCaoPequeno = 20;
                int valorCaoGrande = 40;

                meuCaninoFeliz.ValorCaoPequeno = valorCaoPequeno;
                meuCaninoFeliz.ValorCaoGrande = valorCaoGrande;

                meuCaninoFeliz.ValorCaoPequeno = meuCaninoFeliz.QuantidadeCaesPequenos * meuCaninoFeliz.ValorCaoPequeno;
                meuCaninoFeliz.ValorCaoGrande = meuCaninoFeliz.QuantidadeCaesGrandes * meuCaninoFeliz.ValorCaoGrande;

                meuCaninoFeliz.ValorTotalBanhos = meuCaninoFeliz.ValorCaoPequeno + meuCaninoFeliz.ValorCaoGrande;

                return meuCaninoFeliz;
            }

        }
    }
}
