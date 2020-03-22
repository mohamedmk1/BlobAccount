using Microsoft.Azure.Storage.Blob;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WiredBrainCoffee.Storage
{
  public interface ICoffeeVideoStorage
  {
    Task<CloudBlockBlob> UploadVideoAsync(byte[] videoByteArray, string blobname);
    Task<bool> CheckIfBlobExistsAsync(string blobName);

    Task<IEnumerable<CloudBlockBlob>> ListVideoBlobsAsync(string prefix = null);
  }
}