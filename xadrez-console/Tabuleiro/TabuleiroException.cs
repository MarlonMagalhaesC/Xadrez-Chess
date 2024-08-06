using System;


namespace tabuleiro
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string mensagem) : base(mensagem) { }
    }
}
