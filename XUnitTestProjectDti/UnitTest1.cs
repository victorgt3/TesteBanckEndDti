using System;
using TesteDtiEntidade;
using Xunit;

namespace XUnitTestProjectDti
{
    public class UnitTest1
    {
        public PetShop _petShop;

        [Fact]
        public void Test1()
        {

            DateTime data = new DateTime(2018, 08, 04);
            MeuCaninoFeliz meuCaninoFeliz = new MeuCaninoFeliz(data, 3, 5);
            VaiRex vaiRex = new VaiRex(data, 3, 5);
            ChowChawgas chowChawgas = new ChowChawgas(data, 3, 5);
            meuCaninoFeliz.GetMeuCaninoFeliz(meuCaninoFeliz);
            vaiRex.GetVaiRex(vaiRex);
            chowChawgas.GetChowChawgas(chowChawgas);

            var totalMeCaninoFeliz = meuCaninoFeliz.ValorCaoGrande + meuCaninoFeliz.ValorCaoPequeno;
            var totalVaiRex = vaiRex.ValorCaoGrande + vaiRex.ValorCaoPequeno;
            var totalChowChawgas = chowChawgas.ValorCaoGrande + chowChawgas.ValorCaoPequeno;

            if (totalMeCaninoFeliz < totalVaiRex && totalMeCaninoFeliz < totalChowChawgas)
            {
                PetShop petShop = new PetShop();
                petShop.Nome = meuCaninoFeliz.Nome;
                petShop.ValorTotalBanhos = meuCaninoFeliz.ValorTotalBanhos;

                _petShop = petShop;
            }

            if (totalVaiRex < totalMeCaninoFeliz && totalVaiRex < totalChowChawgas)
            {
                PetShop petShop = new PetShop();
                petShop.Nome = vaiRex.Nome;
                petShop.ValorTotalBanhos = vaiRex.ValorTotalBanhos;

                _petShop = petShop;
            }

            if (totalChowChawgas < totalVaiRex && totalChowChawgas < totalVaiRex)
            {
                PetShop petShop = new PetShop();
                petShop.Nome = chowChawgas.Nome;
                petShop.ValorTotalBanhos = chowChawgas.ValorTotalBanhos;

                _petShop = petShop;
            }

            if (totalMeCaninoFeliz == totalVaiRex && totalMeCaninoFeliz == totalChowChawgas)
            {
                if (meuCaninoFeliz.Distancia < vaiRex.Distancia && meuCaninoFeliz.Distancia < chowChawgas.Distancia)
                {
                    PetShop petShop = new PetShop();
                    petShop.Nome = meuCaninoFeliz.Nome;
                    petShop.ValorTotalBanhos = meuCaninoFeliz.ValorTotalBanhos;

                    _petShop = petShop;
                }

                if (chowChawgas.Distancia < vaiRex.Distancia && chowChawgas.Distancia < meuCaninoFeliz.Distancia)
                {
                    PetShop petShop = new PetShop();
                    petShop.Nome = chowChawgas.Nome;
                    petShop.ValorTotalBanhos = chowChawgas.ValorTotalBanhos;

                    _petShop = petShop;
                }

                if (vaiRex.Distancia < meuCaninoFeliz.Distancia && vaiRex.Distancia < chowChawgas.Distancia)
                {
                    PetShop petShop = new PetShop();
                    petShop.Nome = vaiRex.Nome;
                    petShop.ValorTotalBanhos = vaiRex.ValorTotalBanhos;

                    _petShop = petShop;
                }
            }

            Assert.NotNull(_petShop);
        }
    }
}
