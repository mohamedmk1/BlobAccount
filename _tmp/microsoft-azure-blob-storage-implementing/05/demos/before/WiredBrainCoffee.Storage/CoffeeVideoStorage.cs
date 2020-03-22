using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WiredBrainCoffee.Storage
{
  public class CoffeeVideoStorage : ICoffeeVideoStorage
  {
    private readonly string _containerNameVideos = "coffeevideos";
    private readonly string _connectionString;

    public CoffeeVideoStorage(string connectionString)
    {
      _connectionString = connectionString;
    }

    public async Task<CloudBlockBlob> UploadVideoAsync(byte[] videoByteArray, string blobName)
    {
      var cloudBlobContainer = await GetCoffeeVideosContainerAsync();

      var cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(blobName);

      cloudBlockBlob.Properties.ContentType = "video/mp4";

      await cloudBlockBlob.UploadFromByteArrayAsync(videoByteArray, 0, videoByteArray.Length);

      return cloudBlockBlob;
    }

    public async Task<bool> CheckIfBlobExistsAsync(string blobName)
    {
      var cloudBlobContainer = await GetCoffeeVideosContainerAsync();

      var cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(blobName);

      return await cloudBlockBlob.ExistsAsync();
    }

    public async Task<IEnumerable<CloudBlockBlob>> ListVideoBlobsAsync(string prefix = null)
    {
      var cloudBlockBlobs = new List<CloudBlockBlob>();
      var cloudBlobContainer = await GetCoffeeVideosContainerAsync();

      BlobContinuationToken token = null;
      do
      {
        var blobResultSegment =
          await cloudBlobContainer.ListBlobsSegmentedAsync(prefix, token);
        token = blobResultSegment.ContinuationToken;
        cloudBlockBlobs.AddRange(blobResultSegment.Results.OfType<CloudBlockBlob>());
      }
      while (token != null);

      return cloudBlockBlobs;
    }

    public async Task DownloadVideoAsync(CloudBlockBlob cloudBlockBlob, Stream targetStream)
    {
      // TODO: Download the Blob and write it to the targetStream
    }

    public async Task DeleteVideoAsync(CloudBlockBlob cloudBlockBlob)
    {
      // TODO: Delete the Blob from Blob Storage
    }

    private async Task<CloudBlobContainer> GetCoffeeVideosContainerAsync()
    {
      var cloudStorageAccount = CloudStorageAccount.Parse(_connectionString);

      var cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();

      var cloudBlobContainer = cloudBlobClient.GetContainerReference(_containerNameVideos);
      await cloudBlobContainer.CreateIfNotExistsAsync(
        BlobContainerPublicAccessType.Blob, null, null);
      return cloudBlobContainer;
    }
  }
}
