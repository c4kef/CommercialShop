using OpenPop.Mime;
using OpenPop.Pop3;
using System.Text.RegularExpressions;

namespace Client.Manager
{
    class EMail
    {
        public static string GetMailCode()
        {
            string body = "";
            Pop3Client client = new Pop3Client();
            client.Connect(Globals.m_MailServer, 995, true);

            client.Authenticate(Globals.m_MailLogin, Globals.m_MailPassword, AuthenticationMethod.UsernameAndPassword);
            if (client.Connected)
            {
                int messageCount = client.GetMessageCount();
                if (messageCount <= 0)
                    return string.Empty;

                Message message = client.GetMessage(Globals.m_MailServer.Contains("yandex") ? 1 : messageCount);
                body = message.FindFirstPlainTextVersion() != null ? message.FindFirstPlainTextVersion().GetBodyAsText() : message.FindAllTextVersions()[0].GetBodyAsText();
                body = new Regex(@"\D").Replace(body.Remove(0, body.IndexOf("Код безопасности:")), "");
                body = body.Remove(7, body.Length - 7);
            }
            return body;
        }
    }
}
