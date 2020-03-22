using Microsoft.Azure.Storage.Blob;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace WiredBrainCoffee.Storage
{
  public interface ICoffeeVideoStorage
  {
    Task<CloudBlockBlob> UploadVideoAsync(byte[] videoByteArray, string blobname,
      string title, string description);
    Task<bool> CheckIfBlobExistsAsync(string blobName);

    Task<IEnumerable<CloudBlockBlob>> ListVideoBlobsAsync(string prefix = null);

    Task DownloadVideoAsync(CloudBlockBlob cloudBlockBlob, Stream targetStream);
    Task OverwriteVideoAsync(CloudBlockBlob cloudBlockBlob, byte[] videoByteArray);
    Task DeleteVideoAsync(CloudBlockBlob cloudBlockBlob);

    Task UpdateMetadataAsync(CloudBlockBlob cloudBlockBlob, string title, string description);
    Task ReloadMetadataAsync(CloudBlockBlob cloudBlockBlob);
    (string title, string description) GetBlobMetadata(CloudBlockBlob cloudBlockBlob);

    string GetBlobUriWithSasToken(CloudBlockBlob cloudBlockBlob);

    Task<string> AcquireOneMinuteLeaseAsync(CloudBlockBlob cloudBlockBlob);
    Task RenewLeaseAsync(CloudBlockBlob cloudBlockBlob, string leaseId);
    Task ReleaseLeaseAsync(CloudBlockBlob cloudBlockBlob, string leaseId);

    Task<string> LoadLeaseInfoAsync(CloudBlockBlob cloudBlockBlob);
  }
}