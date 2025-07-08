using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VidSigner.Models
{
    public class OtpSignatureRequest
    {
        public string FileName { get; set; }
        public string DocContent { get; set; }
        public string IssuerName { get; set; }
        public bool OrderedSignatures { get; set; }
        public List<Signer> Signers { get; set; }
        public string NotificationURL { get; set; }
        public string ExpirationDate { get; set; }

        public List<RejectedDocumentRecipient> RejectedDocumentRecipients { get; set; }
    }

    public class Signer
    {
        public string SignatureType { get; set; }
        public string LocalSignature { get; set; }
        public string SignerName { get; set; }
        public string TypeOfID { get; set; }
        public string NumberID { get; set; }
        public string Language { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Visible Visible { get; set; }
        public NotificationEmailMessage NotificationEmailMessage { get; set; }
    }

    public class Visible
    {
        public int Page { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public string SignatureField { get; set; }
        public string Anchor { get; set; }
    }

    public class NotificationEmailMessage
    {
        public string eMailBody { get; set; }
        public string eMailSubject { get; set; }
    }

    public class RejectedDocumentRecipient
    {
        public string eMail { get; set; }
        public string Language { get; set; }
    }
}
