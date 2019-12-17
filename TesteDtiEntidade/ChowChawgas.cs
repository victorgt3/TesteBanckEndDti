using System;

namespace TesteDtiEntidade
{
    public class ChowChawgas : PetShop
    {
        public double ValorCaoPequeno { get; private set; }
        public double ValorCaoGrande { get; private set; }
        public DateTime Data { get; private set; }
        public double Distancia { get; private set; }
        public int QuantidadeCaesPequenos { get; private set; }
        public int QuantidadeCaesGrandes { get; private set; }
        public ChowChawgas(DateTime data, int quantidadeCaesPequenos, int quantidadeCaesGrandes)
        {
            Data = data;
            QuantidadeCaesPequenos = quantidadeCaesPequenos;
            QuantidadeCaesGrandes = quantidadeCaesGrandes;
        }
        public ChowChawgas GetChowChawgas(ChowChawgas chowChawgas)
        {


            chowChawgas.Nome = "ChowChawgas";
            chowChawgas.Distancia = 800.00;

            double valorCaoPequeno = 30.00;
            double valorCaoGrande = 45.00;

            chowChawgas.ValorCaoPequeno = valorCaoPequeno;
            chowChawgas.ValorCaoGrande = valorCaoGrande;

            chowChawgas.ValorCaoPequeno = chowChawgas.QuantidadeCaesPequenos * chowChawgas.ValorCaoPequeno;
            chowChawgas.ValorCaoGrande = chowChawgas.QuantidadeCaesGrandes * chowChawgas.ValorCaoGrande;

            chowChawgas.ValorTotalBanhos = chowChawgas.ValorCaoPequeno + chowChawgas.ValorCaoGrande;

            return chowChawgas;

        }
    }
}
