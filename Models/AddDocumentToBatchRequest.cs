using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VidSigner.Models
{
    public class AddDocumentToBatchRequest
    {
        public List<BatchSignature> Signatures { get; set; } = new();
        public string FileName { get; set; } = string.Empty;
        public string DocContent { get; set; } = string.Empty;
        public bool ConvertFormToReadOnly { get; set; }
        public string NotificationURL { get; set; }
        public string ExpirationDate { get; set; }
    }

    public class BatchSignature
    {
        public BatchVisible Visible { get; set; } = new();
    }

    public class BatchVisible
    {
        public string? Anchor { get; set; }
        public int Page { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double SizeX { get; set; }
        public double SizeY { get; set; }
        public string? SignatureField { get; set; }
    }
}
