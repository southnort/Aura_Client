using System.Text;


namespace Aura_Client.Network
{
    /// <summary>
    /// Мост между основной программой и модулем сетевого взаимодействия.
    /// Переводит методы в текст для запроса по сети.
    /// </summary>
    class NetworkBridge : NetworkManager
    {
        public string TryLogin(string login, string password)
        {
            //запрос серверу на логин            
            var request = "LOGIN#" + login + "#" + password;
            return messageHandler.HandleMessage(ReceiveMessage(request), null);

        }

        public void ChangePassword(int userID, string newPassword)
        {
            var request = "CHANGEPASSWORD#" + userID + "#" + newPassword;
            SendMessage(request);
        }

        public void SendUser(Aura.Model.User user)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("USER#");
            sb.Append(user.ID);
            sb.Append("#");
            sb.Append(user.name);
            sb.Append("#");
            sb.Append(user.login);
            sb.Append("#");
            sb.Append(user.password);
            sb.Append("#");
            sb.Append(user.roleID);

            SendMessage(sb.ToString());

        }

        public void SendUpdateReport(Aura.Model.Report report)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATEREPORT#");            
            sb.Append("REPLACE INTO Reports (organisationID, commonPurchasesContractsReport, ");
            sb.Append("singleSupplierContractsReport, failedPurchasesContractsReport)");
            sb.Append(" VALUES ('");
            sb.Append(report.organisationID);
            sb.Append("', '");
            sb.Append(report.commonPurchasesContractsReport);
            sb.Append("', '");
            sb.Append(report.singleSupplierContractsReport);
            sb.Append("', '");
            sb.Append(report.failedPurchasesContractsReport);
            sb.Append("')");

            sb.Append("#");
            sb.Append(report.organisationID);
            sb.Append("#");

            SendMessage(sb.ToString());

        }

        public void SendCheckAllReports(string month)
        {
            //отправить на сервер команду "Все отчеты за месяц готовы"
            //month - месяц, за который делается отчет в формате " M.year,";
            StringBuilder sb = new StringBuilder();
            sb.Append("CHECKALLREPORTS#");
            sb.Append(month);
            SendMessage(sb.ToString());

        }

        public void SendUncheckAllReports(string month)
        {
            //отправить на сервер команду "Все отчеты за месяц не готовы"
            //month - месяц, за который делается отчет в формате " M.year,";
            StringBuilder sb = new StringBuilder();
            sb.Append("UNCHECKALLREPORTS#");
            sb.Append(month);
            SendMessage(sb.ToString());

        }

    }
}
