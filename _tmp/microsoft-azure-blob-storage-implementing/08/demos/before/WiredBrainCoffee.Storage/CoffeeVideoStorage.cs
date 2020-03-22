using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using System;
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
    private readonly string _metadataKeyTitle = "title";
    private readonly string _metadataKeyDescription = "description";

    public CoffeeVideoStorage(string connectionString)
    {
      _connectionString = connectionString;
    }

    public async Task<CloudBlockBlob> UploadVideoAsync(
      byte[] videoByteArray, string blobName, string title, string description)
    {
      var cloudBlobContainer = await GetCoffeeVideosContainerAsync();

      var cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(blobName);

      cloudBlockBlob.Properties.ContentType = "video/mp4";

      SetMetadata(cloudBlockBlob, _metadataKeyTitle, title);
      SetMetadata(cloudBlockBlob, _metadataKeyDescription, description);

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
          await cloudBlobContainer.ListBlobsSegmentedAsync(prefix, true,
            BlobListingDetails.Metadata, null, token, null, null);
        token = blobResultSegment.ContinuationToken;
        cloudBlockBlobs.AddRange(blobResultSegment.Results.OfType<CloudBlockBlob>());
      }
      while (token != null);

      return cloudBlockBlobs;
    }

    public async Task DownloadVideoAsync(CloudBlockBlob cloudBlockBlob, Stream targetStream)
    {
      await cloudBlockBlob.DownloadToStreamAsync(targetStream);
    }

    public async Task OverwriteVideoAsync(CloudBlockBlob cloudBlockBlob, byte[] videoByteArray)
    {
      // TODO: Overwrite the Blob and manage concurrency when overwriting the Blob
    }

    public async Task DeleteVideoAsync(CloudBlockBlob cloudBlockBlob)
    {
      await cloudBlockBlob.DeleteAsync();
    }

    public async Task UpdateMetadataAsync(
      CloudBlockBlob cloudBlockBlob, string title, string description)
    {
      SetMetadata(cloudBlockBlob, _metadataKeyTitle, title);
      SetMetadata(cloudBlockBlob, _metadataKeyDescription, description);

      // TODO: Manage concurrency when updating the Blob's metadata

      await cloudBlockBlob.SetMetadataAsync();
    }

    public async Task ReloadMetadataAsync(CloudBlockBlob cloudBlockBlob)
    {
      await cloudBlockBlob.FetchAttributesAsync();
    }

    public (string title, string description) GetBlobMetadata(CloudBlockBlob cloudBlockBlob)
    {
      return (cloudBlockBlob.Metadata.ContainsKey(_metadataKeyTitle)
               ? cloudBlockBlob.Metadata[_metadataKeyTitle]
               : ""
            , cloudBlockBlob.Metadata.ContainsKey(_metadataKeyDescription)
               ? cloudBlockBlob.Metadata[_metadataKeyDescription]
               : "");
    }

    public string GetBlobUriWithSasToken(CloudBlockBlob cloudBlockBlob)
    {
      var sharedAccessBlobPolicy = new SharedAccessBlobPolicy
      {
        Permissions = SharedAccessBlobPermissions.Read,
        SharedAccessExpiryTime = DateTime.Now.AddDays(1)
      };

      var sasToken = cloudBlockBlob.GetSharedAccessSignature(sharedAccessBlobPolicy);

      return cloudBlockBlob.Uri + sasToken;
    }

    public async Task<string> AcquireOneMinuteLeaseAsync(CloudBlockBlob cloudBlockBlob)
    {
      // TODO: Acquire a Lease for the Blob for 1 minute
      return null;
    }
    
    public async Task RenewLeaseAsync(CloudBlockBlob cloudBlockBlob, string leaseId)
    {
      // TODO: Renew the Lease for the Blob
    }

    public async Task ReleaseLeaseAsync(CloudBlockBlob cloudBlockBlob, string leaseId)
    {
      // TODO: Release the Lease for the Blob
    }

    public async Task<string> LoadLeaseInfoAsync(CloudBlockBlob cloudBlockBlob)
    {
      // TODO: Load the Lease state, status and duration for the Blob
      //       and return the string below with that information
      return $"Lease state: \n" +
        $"Lease status: \n" +
        $"Lease duration: ";
    }

    private async Task<CloudBlobContainer> GetCoffeeVideosContainerAsync()
    {
      var cloudStorageAccount = CloudStorageAccount.Parse(_connectionString);

      var cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();

      var cloudBlobContainer = cloudBlobClient.GetContainerReference(_containerNameVideos);
      await cloudBlobContainer.CreateIfNotExistsAsync();
      return cloudBlobContainer;
    }

    private static void SetMetadata(CloudBlockBlob cloudBlockBlob, string key, string value)
    {
      if (string.IsNullOrWhiteSpace(value))
      {
        if (cloudBlockBlob.Metadata.ContainsKey(key))
        {
          cloudBlockBlob.Metadata.Remove(key);
        }
      }
      else
      {
        cloudBlockBlob.Metadata[key] = value;
      }
    }
  }
}
