using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace bicikliszerviz
{
    public static class Mailer
    {
        static string fromAddress = "bicikli@level14.hu";

        static string newOfferSubject = "A bicikli javítására ajánlat érkezett";
        static string newOfferText =
@"Kedves {0}!

A(z) ""{1}"" típusú biciklidre érkezett egy árajánlat.
A megtekintéséhez kattints az alábbi linkre:
{2}

Üdvözlettel,
A Bicikliszerviz portál csapata
";

        static string acceptedOfferSubject = "A felhasználó elfogadta az ajánlatot";
        static string acceptedOfferText =
@"Kedves {0}!

{1} felhasználó elfogadta a(z) ""{2}"" biciklire tett ajánlatát.

A felhasználó elérhetősége:
{3}

Az ajálatot itt tekintheti meg:
{4}

Üdvözlettel,
A Bicikliszerviz portál csapata
";


        public static void SendNewOfferToUser(Ajanlat a, HttpRequest request)
        {
            var user = a.Bicycle.Owner;
            string userName = user.UserName;
            string bikeType = a.Bicycle.Type;
            string url = GetAbsoluteUrl(request, "/ListBicycles");
            string body = string.Format(newOfferText, userName, bikeType, url);

            var msg = new MailMessage();
            msg.From = new MailAddress(fromAddress);
            msg.To.Add(new MailAddress(user.Email));
            msg.Subject = newOfferSubject;
            msg.Body = body;

            SmtpClient smtp = new SmtpClient();
            smtp.Send(msg);
        }

        public static void SendAcceptedOfferToService(Ajanlat a, HttpRequest request)
        {
            string serviceName = a.Service.Name;
            string userName = a.Bicycle.Owner.UserName;
            string bikeType = a.Bicycle.Type;
            string contactInfo = a.Bicycle.Owner.Email;
            string url = GetAbsoluteUrl(request, "/SetOffer?bicycleID=" + a.Bicycle.Id.ToString());
            string body = string.Format(acceptedOfferText, serviceName, userName, bikeType, contactInfo, url);

            var msg = new MailMessage();
            msg.From = new MailAddress(fromAddress);
            msg.To.Add(new MailAddress(a.Service.Owner.Email));
            msg.Subject = acceptedOfferSubject;
            msg.Body = body;

            SmtpClient smtp = new SmtpClient();
            smtp.Send(msg);
        }

        private static Uri GetBaseUrl(HttpRequest request)
        {
            Uri contextUri = new Uri(request.Url, request.RawUrl);
            UriBuilder realmUri = new UriBuilder(contextUri) { Path = request.ApplicationPath, Query = null, Fragment = null };
            return realmUri.Uri;
        }

        private static string GetAbsoluteUrl(HttpRequest request, string relativeUrl)
        {
            return new Uri(GetBaseUrl(request), VirtualPathUtility.ToAbsolute(relativeUrl)).AbsoluteUri;
        }
    }
}