using System;

namespace Exercício18.Entitites.Exception
{
    class DomainException : ApplicationException //Classe que diferencia a exceção do sistema para a exceção que foi criada
    {
        public DomainException (string message) : base(message)
        {

        }
    }
}
