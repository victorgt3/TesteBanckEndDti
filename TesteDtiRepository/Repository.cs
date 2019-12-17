using System;
using TesteDtiEntidade;

namespace TesteDtiRepository
{
    public class Repository : IRepository
    {
        public PetShop _resultado;
        public PetShop GetPetShop(DateTime data, int quantidadeCaesPequenos, int quantidadeCaesGrandes)
        {
            PetShop petShop = new PetShop(/*data, quantidadeCaesPequenos, quantidadeCaesGrandes*/);

            var meuCaninoFeliz = petShop.MeuCaninoFeliz(petShop);

            var vaiRex = petShop.VaiRex(petShop);

            var chowChawgas = petShop.ChowChawgas(petShop);

            var totalCaninoFeliz = meuCaninoFeliz.ValorCaoGrande + meuCaninoFeliz.ValorCaoPequeno;

            var totalVaiRex = vaiRex.ValorCaoGrande + vaiRex.ValorCaoPequeno;

            var totalchowChawgas = chowChawgas.ValorCaoPequeno + chowChawgas.ValorCaoPequeno;

            if(totalCaninoFeliz < totalVaiRex && totalCaninoFeliz < totalchowChawgas)
            {
                _resultado = meuCaninoFeliz;
            }

            if (totalVaiRex < totalCaninoFeliz && totalVaiRex < totalchowChawgas)
            {
                _resultado = vaiRex;
            }

            if (totalchowChawgas < totalCaninoFeliz && totalchowChawgas < totalVaiRex)
            {
                _resultado = chowChawgas;
            }

            return _resultado;
        }
    }
}
