using SAPbobsCOM;
using System.IO;

namespace CriadorTabelas.Entities
{
    class ExceptionError
    {
        StreamWriter sw = new StreamWriter("C:\\LogTest.txt");
        public ExceptionError(int lretcode, UserObjectsMD oUserObjectsMD)
        {
            int errorCode = lretcode;
            string errorMsg;
            switch (errorCode)
            {
                case 0:
                    sw.WriteLine($"[Sucesso] - Objeto: {oUserObjectsMD.Name} criado com sucesso.");
                    break;

                case -2035:
                    sw.WriteLine($"[Aviso] - Objeto: {oUserObjectsMD.Name}, já existe na base de dados.");
                    break;

                case -5002:
                    sw.WriteLine($"[Aviso] - Objeto: {oUserObjectsMD.Name}, já existe na base de dados.");
                    break;

                default:
                    ConnectionDB.oCompany.GetLastError(out errorCode, out errorMsg);
                    sw.WriteLine($"[Erro]: {errorCode}, Mensagem: {errorMsg}");
                    break;
            }
        }
    }
}
