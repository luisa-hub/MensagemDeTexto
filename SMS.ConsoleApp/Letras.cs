using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.ConsoleApp
{
    public class Letras
    {
        
        public string mensagem; 
        private string mensagemEmNumeros;
        char[] mensagemChar;

        public Letras(string mensagem) {
            this.mensagem = mensagem.ToUpper();
            mensagemChar = mensagem.ToUpper().ToCharArray();

         }

       
        
       
        public string SeparacaoMensagemEmNumeros() {

            Validar();

            for (int i = 0; i < mensagemChar.Length; i++)
            {
                if (i > 0)
                    mensagemEmNumeros += VerificaUnderLine(mensagem[i - 1], mensagem[i]);

               mensagemEmNumeros += ReconhecimentoDeLetras(mensagemChar[i]);

                
                
            }

           return mensagemEmNumeros;
        }

        #region METODOS PRIVADOS 
        
        private string VerificaUnderLine(char anterior, char atual) {

            if ((atual == 'A' || atual == 'B' || atual == 'C') && (anterior == 'A' || anterior == 'B' || anterior == 'C'))
                return "_";

            if ((atual == 'D' || atual == 'E' || atual == 'F') && (anterior == 'D' || anterior == 'E' || anterior == 'F'))
                return "_";


            if ((atual == 'G' || atual == 'H' || atual == 'I') && (anterior == 'G' || anterior == 'H' || anterior == 'I'))
                return "_";

            if ((atual == 'J' || atual == 'K' || atual == 'L') && (anterior == 'J' || anterior == 'K' || anterior == 'L'))
                return "_";

            if ((atual == 'M' || atual == 'N' || atual == 'O') && (anterior == 'M' || anterior == 'N' || anterior == 'O'))
                return "_";

            if ((atual == 'P' || atual == 'Q' || atual == 'R' || atual == 'S') && (anterior == 'P' || anterior == 'Q' || anterior == 'R' || anterior == 'S'))
                return "_";

            if ((atual == 'T' || atual == 'U' || atual == 'V') && (anterior == 'T' || anterior == 'U' || anterior == 'V'))
                return "_";

            if ((atual == 'W' || atual == 'X' || atual == 'Y' || atual == 'Z') && (anterior == 'W' || anterior == 'X' || anterior == 'Y' || anterior == 'Z'))
                return "_";

            return null;
        
        }

        private string ReconhecimentoDeLetras(char letra)
        {
            switch (letra)
            {
                case ' ':
                    return "0";
                case 'A':
                    return "2";
                case 'B':
                    return "22";
                case 'C':
                    return "222";
                case 'D':
                    return "3";
                case 'E':
                    return "33";
                case 'F':
                    return "333";
                case 'G':
                    return "4";
                case 'H':
                    return "44";
                case 'I':
                    return "444";
                case 'J':
                    return "5";
                case 'K':
                    return "55";
                case 'L':
                    return "555";
                case 'M':
                    return "6";
                case 'N':
                    return "66";
                case 'O':
                    return "666";
                case 'P':
                    return "7";
                case 'Q':
                    return "77";
                case 'R':
                    return "777";
                case 'S':
                    return "7777";
                case 'T':
                    return "8";
                case 'U':
                    return "88";
                case 'V':
                    return "888";
                case 'W':
                    return "9";
                case 'X':
                    return "99";
                case 'Y':
                    return "999";
                case 'Z':
                    return "9999";
            }

            return null;



        }

        private void Validar()
        {
            
            if (mensagemChar.Length > 255)
            {
                throw new ArgumentOutOfRangeException("mensagemChar", "A mensagem é maior que 255 caracteres");
            }

            foreach (var item in mensagem)
            {
                if (Char.IsNumber(item))
                    throw new ArgumentException("mensagem", "A mensagem possui números");
            }



        }

        #endregion



    }
}
