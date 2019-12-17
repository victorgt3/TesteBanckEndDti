using System;

namespace TesteDtiEntidade
{
    public class VaiRex : PetShop
    {
        public double ValorCaoPequeno { get; private set; }
        public double ValorCaoGrande { get; private set; }
        public DateTime Data { get; private set; }
        public double Distancia { get; private set; }
        public int QuantidadeCaesPequenos { get; private set; }
        public int QuantidadeCaesGrandes { get; private set; }
        public VaiRex(DateTime data, int quantidadeCaesPequenos, int quantidadeCaesGrandes)
        {
            Data = data;
            QuantidadeCaesPequenos = quantidadeCaesPequenos;
            QuantidadeCaesGrandes = quantidadeCaesGrandes;
        }
        public VaiRex GetVaiRex(VaiRex vaiRex)
        {


            if (vaiRex.Data.DayOfWeek == DayOfWeek.Saturday || vaiRex.Data.DayOfWeek == DayOfWeek.Sunday)
            {
                vaiRex.Nome = "Vai Rex";

                vaiRex.Distancia = 1700.00;

                double aumento = 5.00;
                double valorCaoPequeno = 15.00;
                double valorCaoGrande = 50.00;

                vaiRex.ValorCaoPequeno = valorCaoPequeno + aumento;
                vaiRex.ValorCaoGrande = valorCaoGrande + aumento;

                vaiRex.ValorCaoPequeno = vaiRex.QuantidadeCaesPequenos * vaiRex.ValorCaoPequeno;
                vaiRex.ValorCaoGrande = vaiRex.QuantidadeCaesGrandes * vaiRex.ValorCaoGrande;
                vaiRex.ValorTotalBanhos = vaiRex.ValorCaoPequeno + vaiRex.ValorCaoGrande;

                return vaiRex;
            }
            else
            {
                vaiRex.Nome = "Vai Rex";
                vaiRex.Distancia = 1700.00;

                double valorCaoPequeno = 15.00;
                double valorCaoGrande = 50.00;

                vaiRex.ValorCaoPequeno = valorCaoPequeno;
                vaiRex.ValorCaoGrande = valorCaoGrande;

                vaiRex.ValorCaoPequeno = vaiRex.QuantidadeCaesPequenos * vaiRex.ValorCaoPequeno;
                vaiRex.ValorCaoGrande = vaiRex.QuantidadeCaesGrandes * vaiRex.ValorCaoGrande;

                vaiRex.ValorTotalBanhos = vaiRex.ValorCaoPequeno + vaiRex.ValorCaoGrande;

                return vaiRex;
            }

        }
    }
}
