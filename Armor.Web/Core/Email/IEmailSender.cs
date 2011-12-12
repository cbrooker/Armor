using RichmondDay.Helpers;

namespace Armor.Web.Core.Email {
    public interface IEmailSender {
        void Send(SmtpConfiguration smtpConfig, string toAddress, string fromAddress, string subject, string message);
    }
}
