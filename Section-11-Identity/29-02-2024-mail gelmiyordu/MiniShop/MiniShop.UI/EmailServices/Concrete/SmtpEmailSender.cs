using Microsoft.EntityFrameworkCore.Migrations.Operations;
using MiniShop.UI.EmailServices.Abstract;
using System.Net;
using System.Net.Mail;

namespace MiniShop.UI.EmailServices.Concrete
{
    /*host:MAil server adresi
     *port:serverdeki port adresi
     *enableSsl:ssl sertifasına sahip olunup olunmadığı
     *userName ve password (5'i gerekli)
     *Bu bilgileri appsettings.json dosyasında tutup,dependency injection yönt buraya alıyoruz
     */
    public class SmtpEmailSender : IEmailSender
    {
        private readonly string _host;
        private readonly int _port;
        private readonly bool _enableSsl;
        private readonly string _userName;
        private readonly string _password;

        public SmtpEmailSender(string host,int port,bool enableSsl,string userName,string password)
        {
            //*burada almış olduğumuz şeyi yukarıda açıklamış oluyoruz.
            _host = host;
            _port = port;
            _enableSsl = enableSsl;
            _userName = userName;
            _password = password;
        }
        public async Task SendEmailAsync(string emailTo, string subject, string htmlMessage)
        {
            //*Maili gönderme ile ilgili kodlarımızı butrada yazıyoruz.
            var client = new SmtpClient(_host, _port)//* bu da bir istekte bulunma işi mail gönderme üzere:2 overloadı var;host ve portu kullanarak şu adresteki şu port nu sundan yayın yapan smpt mainserver'ına bağlancak şekilde sen hazır ol;oluşturururken yapabileceği işler için parntezi burada açıyoruz;
            {
              Credentials=new NetworkCredential(_userName,_password) , //*Kullanıcı adının ve şifresini verebilmemiz içinn bu propertiysi
              EnableSsl = _enableSsl
              //*Böylece Client'ım üsteki (_host= host gibi)bilgilerle donatılmış oldu
            };
            //*Şimdi bu Client nesnesini kullanarak mail gönderme işlemini yapıcaz;
            await client.SendMailAsync(new MailMessage(_userName, emailTo, subject, htmlMessage)
            {
                IsBodyHtml = true
            });

        }
    }
}
