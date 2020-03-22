﻿using System.Threading.Tasks;
using WiredBrainCoffee.Storage;
using System;
using System.Collections.ObjectModel;
using WiredBrainCoffee.AdminApp.Service;
using Microsoft.WindowsAzure.Storage.Blob;

namespace WiredBrainCoffee.AdminApp.ViewModel
{
  public interface IMainViewModel
  {
    void StartLoading(string message);
    void StopLoading();
    void RemoveCoffeeVideoViewModel(CoffeeVideoViewModel coffeeVideoViewModel);
  }
  public class MainViewModel : ViewModelBase, IMainViewModel
  {
    private string _prefix;
    private bool _isLoading;
    private string _loadingMessage;
    private readonly ICoffeeVideoStorage _coffeeVideoStorage;
    private readonly IAddCoffeeVideoDialogService _addCoffeeVideoDialogService;
    private readonly IMessageDialogService _messageDialogService;
    private readonly Func<CloudBlockBlob, CoffeeVideoViewModel> _coffeeVideoViewModelCreator;
    private CoffeeVideoViewModel _selectedCoffeeVideoViewModel;

    public MainViewModel(ICoffeeVideoStorage coffeeVideoStorage,
      IAddCoffeeVideoDialogService addCoffeeVideoDialogService,
      IMessageDialogService messageDialogService,
      Func<CloudBlockBlob, CoffeeVideoViewModel> coffeeVideoViewModelCreator)
    {
      _coffeeVideoStorage = coffeeVideoStorage;
      _addCoffeeVideoDialogService = addCoffeeVideoDialogService;
      _messageDialogService = messageDialogService;
      _coffeeVideoViewModelCreator = coffeeVideoViewModelCreator;
      CoffeeVideos = new ObservableCollection<CoffeeVideoViewModel>();
    }

    public bool IsLoading
    {
      get { return _isLoading; }
      set
      {
        _isLoading = value;
        OnPropertyChanged();
      }
    }

    public string LoadingMessage
    {
      get { return _loadingMessage; }
      set
      {
        _loadingMessage = value;
        OnPropertyChanged();
      }
    }

    public string Prefix
    {
      get { return _prefix; }
      set
      {
        _prefix = value;
        OnPropertyChanged();
      }
    }

    public ObservableCollection<CoffeeVideoViewModel> CoffeeVideos { get; }

    public CoffeeVideoViewModel SelectedCoffeeVideo
    {
      get { return _selectedCoffeeVideoViewModel; }
      set
      {
        if (_selectedCoffeeVideoViewModel != value)
        {
          _selectedCoffeeVideoViewModel = value;
          OnPropertyChanged();
          OnPropertyChanged(nameof(IsCoffeeVideoSelected));
        }
      }
    }

    public bool IsCoffeeVideoSelected => SelectedCoffeeVideo != null;

    public async Task LoadCoffeeVideosAsync()
    {
      StartLoading("We're loading the videos for you");
      try
      {
        var cloudBlockBlobs = await _coffeeVideoStorage.ListVideoBlobsAsync(Prefix);
        CoffeeVideos.Clear();
        foreach (var cloudBlockBlob in cloudBlockBlobs)
        {
          CoffeeVideos.Add(_coffeeVideoViewModelCreator(cloudBlockBlob));
        }
      }
      catch (Exception ex)
      {
        await _messageDialogService.ShowInfoDialogAsync(ex.Message, "Error");
      }
      finally
      {
        StopLoading();
      }
    }

    public async Task AddCoffeeVideoAsync()
    {
      try
      {
        var dialogData = await _addCoffeeVideoDialogService.ShowDialogAsync();

        if (dialogData.DialogResultIsOk)
        {
          StartLoading($"Uploading your video {dialogData.BlobName}");

          var cloudBlockBlob = await _coffeeVideoStorage.UploadVideoAsync(
              dialogData.BlobByteArray,
              dialogData.BlobName,
              dialogData.BlobTitle,
              dialogData.BlobDescription);

          var coffeeVideoViewModel = _coffeeVideoViewModelCreator(cloudBlockBlob);
          CoffeeVideos.Add(coffeeVideoViewModel);
          SelectedCoffeeVideo = coffeeVideoViewModel;
        }
      }
      catch (Exception ex)
      {
        await _messageDialogService.ShowInfoDialogAsync(ex.Message, "Error");
      }
      finally
      {
        StopLoading();
      }
    }

    public void RemoveCoffeeVideoViewModel(CoffeeVideoViewModel viewModel)
    {
      if (CoffeeVideos.Contains(viewModel))
      {
        CoffeeVideos.Remove(viewModel);
        if (SelectedCoffeeVideo == viewModel)
        {
          SelectedCoffeeVideo = null;
        }
      }
    }

    public void StartLoading(string message)
    {
      LoadingMessage = message;
      IsLoading = true;
    }

    public void StopLoading()
    {
      IsLoading = false;
      LoadingMessage = null;
    }
  }
}
