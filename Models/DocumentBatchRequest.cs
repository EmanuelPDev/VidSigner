using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VidSigner.Models
{
    public class DocumentBatchRequest
    {
        [JsonPropertyName("OrderedSignatures")]
        public bool OrderedSignatures { get; set; }

        [JsonPropertyName("IssuerName")]
        public string IssuerName { get; set; }

        [JsonPropertyName("Signers")]
        public List<DocumentBatchSigner> Signers { get; set; }
    }

    public class DocumentBatchSigner
    {
        [JsonPropertyName("SignatureType")]
        public string SignatureType { get; set; }

        [JsonPropertyName("LocalSignature")]
        public string LocalSignature { get; set; }

        [JsonPropertyName("SignerName")]
        public string SignerName { get; set; }

        [JsonPropertyName("TypeOfID")]
        public string TypeOfID { get; set; }

        [JsonPropertyName("NumberID")]
        public string NumberID { get; set; }

        [JsonPropertyName("DeviceName")]
        public string? DeviceName { get; set; }

        [JsonPropertyName("DocusignSigner")]
        public bool DocusignSigner { get; set; }

        [JsonPropertyName("VerifyeMail")]
        public bool VerifyeMail { get; set; }

        [JsonPropertyName("isDigitalIdUser")]
        public bool IsDigitalIdUser { get; set; }

        [JsonPropertyName("Language")]
        public string Language { get; set; }

        [JsonPropertyName("sendSignedDoc")]
        public bool SendSignedDoc { get; set; }

        [JsonPropertyName("SkipSignatureEmail")]
        public bool SkipSignatureEmail { get; set; }

        [JsonPropertyName("SendCentralizedSignerEmailNotification")]
        public bool SendCentralizedSignerEmailNotification { get; set; }

        [JsonPropertyName("AllowEmptyPhoneNumber")]
        public bool AllowEmptyPhoneNumber { get; set; }

        [JsonPropertyName("eMail")]
        public string eMail { get; set; }

        [JsonPropertyName("AllowSignatureDelegation")]
        public bool AllowSignatureDelegation { get; set; }

        [JsonPropertyName("NotificationEmailMessage")]
        public NotificationEmailMessage NotificationEmailMessage { get; set; }

    }
}
