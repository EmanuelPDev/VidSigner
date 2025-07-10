using System.ComponentModel.Design;
using VidSigner.Infrastructure.VidSignerProvider;
using VidSigner.Models;

var httpClient = new HttpClient();
var VidSignerProvider = new VidSignerProvider(httpClient);

#region Authentication

//AuthResponse? authResponse = await VidSignerProvider.AuthenticateAsync();

//if (VidSignerProvider.TryGetToken(authResponse, out string token))
//{
//    Console.WriteLine("Auth ok.");
//}
//else
//{
//    Console.WriteLine("Authentication failed...");
//}

#endregion  Authentication

#region DocumentOtpSignature


OtpSignatureResponse DocumentOtpSignatureResult = await VidSignerProvider.RequestDocumentOtpSignatureAsync();

if (DocumentOtpSignatureResult != null)
{
    Console.WriteLine($"Otp document signature created. Document id: {DocumentOtpSignatureResult.DocGUI}");
}
else
{
    Console.WriteLine("Error creting otp document signature.");
}

#endregion DocumentOtpSignature

#region DocumentReport

//var reportHtml = await VidSignerProvider.GetDocumentReportAsync(Guid.Parse("b616251f-29ed-417f-b432-2b28dbd2a590"), "es");

//if (reportHtml != null)
//{
//    Console.WriteLine($"Success: {reportHtml}");
//}
//else
//{
//    Console.WriteLine("Erro ao obter relatório.");
//}

#endregion DocumentReport

#region GetDocument

//var status = await VidSignerProvider.GetDocumentInfoAsync(Guid.Parse(" 1bb662e7-fbe9-42ce-a510-8bd38310496f"));
//Console.WriteLine($"Status: {status ?? "NA"}");

#endregion GetDocument

#region DeleteUnsignedDocument

//var deleted = await VidSignerProvider.DeleteUnsignedDocumentAsync(Guid.Parse("e5ed7d32-d633-4387-9d4a-722d7610e567"));

//if (deleted)
//{
//    Console.WriteLine("Document deleted.");
//}
//else
//{
//    Console.WriteLine("Error deliting document.");
//}

#endregion DelUnsignedDocument

#region CreateDocumentBatch

//string? Batch = await VidSignerProvider.CreateDocumentBatchAsync();
//if (Guid.TryParse(Batch, out Guid BatchId))
//{
//    Console.WriteLine($"Batch cretated id: {BatchId}");

//    bool AddDocumentToBatchSuccess = false;

//    for (int i = 0; i < 2; i++)
//    {
//        string document = await VidSignerProvider.AddDocumentToBatchAsync(BatchId);
//        if (Guid.TryParse(document, out Guid DocID))
//        {
//            Console.WriteLine($"Doc cretated id: {DocID}");
//            AddDocumentToBatchSuccess = true;
//            continue;
//        }
//        else
//        {
//            Console.WriteLine($"Create dov batch aborted. One or more document failed when add to batch. Doc id: {DocID}.");
//            AddDocumentToBatchSuccess = false;
//            break;
//        }
//    }
//    if (AddDocumentToBatchSuccess)
//    {
//        bool result = await VidSignerProvider.SendBatchToSignAsync(BatchId);

//        if (result)
//        {
//            Console.WriteLine($"Batch: {BatchId} created and sent to sign.");
//        }
//        else
//        {
//            Console.WriteLine($"Error changing batch status: {BatchId}.");
//        }

//    }
//}
//else
//{
//    Console.WriteLine("Error creting batch document.");
//}
#endregion CreateDocumentBatch

#region DownloadDocumentAsync


//string? signedDocBase64 = await VidSignerProvider.GetSignedDocumentInfoAsync(Guid.Parse("dcdbcc85-9c7d-4b58-ab63-88a6336d5afe"));

//if (!string.IsNullOrEmpty(signedDocBase64))
//{
//    Console.WriteLine($"Documento: {signedDocBase64} | Estado: {signedDocBase64}");
//}
#endregion DownloadDocumentAsync

