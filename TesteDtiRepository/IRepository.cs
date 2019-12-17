using System;
using TesteDtiEntidade;

namespace TesteDtiRepository
{
    public interface IRepository 
    {
        PetShop GetPetShop(DateTime data, int quantidadeCaesPequenos, int quantidadeCaesGrandes);
    }
}
