﻿#pragma checksum "C:\Tutos\C#\Pluralight\BlobAccount.WiredBrainCoffee\WiredBrainCoffee.AdminApp\View\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B917CF19A48ED43448499CC7A6841895"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WiredBrainCoffee.AdminApp
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_WiredBrainCoffee_AdminApp_View_CoffeeVideoView_ViewModel(global::WiredBrainCoffee.AdminApp.View.CoffeeVideoView obj, global::WiredBrainCoffee.AdminApp.ViewModel.CoffeeVideoViewModel value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::WiredBrainCoffee.AdminApp.ViewModel.CoffeeVideoViewModel) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::WiredBrainCoffee.AdminApp.ViewModel.CoffeeVideoViewModel), targetNullValue);
                }
                obj.ViewModel = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::WiredBrainCoffee.AdminApp.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::WiredBrainCoffee.AdminApp.View.CoffeeVideoView obj2;
            private global::Windows.UI.Xaml.Controls.Grid obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;
            private global::Windows.UI.Xaml.Controls.ListView obj5;
            private global::Windows.UI.Xaml.Controls.Button obj6;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\MainPage.xaml line 52
                        this.obj2 = (global::WiredBrainCoffee.AdminApp.View.CoffeeVideoView)target;
                        break;
                    case 3: // View\MainPage.xaml line 57
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    case 4: // View\MainPage.xaml line 60
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5: // View\MainPage.xaml line 43
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        this.bindingsTracking.RegisterTwoWayListener_5(this.obj5);
                        break;
                    case 6: // View\MainPage.xaml line 26
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModel.AddCoffeeVideoAsync();
                        };
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::WiredBrainCoffee.AdminApp.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            private delegate void InvokeFunctionDelegate(int phase);
            private global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate> PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();

            private void Invoke_ViewModel_IsLoading_M_Equals_3875955625(int phase)
            {
                global::System.Boolean obj = false;
                global::System.Boolean result = this.dataRoot.ViewModel.IsLoading.Equals(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\MainPage.xaml line 26
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj6, result);
                }
            }

            private void CompleteUpdate(int phase)
            {
                foreach(var function in this.PendingFunctionBindings)
                {
                    function.Value.Invoke(phase);
                }
                this.PendingFunctionBindings.Clear();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::WiredBrainCoffee.AdminApp.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
                this.CompleteUpdate(phase);
            }
            private void Update_ViewModel(global::WiredBrainCoffee.AdminApp.ViewModel.MainViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_SelectedCoffeeVideo(obj.SelectedCoffeeVideo, phase);
                        this.Update_ViewModel_IsCoffeeVideoSelected(obj.IsCoffeeVideoSelected, phase);
                        this.Update_ViewModel_IsLoading(obj.IsLoading, phase);
                        this.Update_ViewModel_LoadingMessage(obj.LoadingMessage, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_CoffeeVideos(obj.CoffeeVideos, phase);
                    }
                }
            }
            private void Update_ViewModel_SelectedCoffeeVideo(global::WiredBrainCoffee.AdminApp.ViewModel.CoffeeVideoViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_SelectedCoffeeVideo(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\MainPage.xaml line 52
                    XamlBindingSetters.Set_WiredBrainCoffee_AdminApp_View_CoffeeVideoView_ViewModel(this.obj2, obj, null);
                    // View\MainPage.xaml line 43
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(this.obj5, obj, null);
                }
            }
            private void Update_ViewModel_IsCoffeeVideoSelected(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_ViewModel_IsCoffeeVideoSelected_Cast_IsCoffeeVideoSelected_To_Visibility(obj ? global::Windows.UI.Xaml.Visibility.Visible : global::Windows.UI.Xaml.Visibility.Collapsed, phase);
                }
            }
            private void Update_ViewModel_IsCoffeeVideoSelected_Cast_IsCoffeeVideoSelected_To_Visibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\MainPage.xaml line 52
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj2, obj);
                }
            }
            private void Update_ViewModel_IsLoading(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_ViewModel_IsLoading_Cast_IsLoading_To_Visibility(obj ? global::Windows.UI.Xaml.Visibility.Visible : global::Windows.UI.Xaml.Visibility.Collapsed, phase);
                    this.Update_ViewModel_IsLoading_M_Equals_3875955625(phase);
                }
            }
            private void Update_ViewModel_IsLoading_Cast_IsLoading_To_Visibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\MainPage.xaml line 57
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj3, obj);
                }
            }
            private void Update_ViewModel_LoadingMessage(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\MainPage.xaml line 60
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                }
            }
            private void Update_ViewModel_CoffeeVideos(global::System.Collections.ObjectModel.ObservableCollection<global::WiredBrainCoffee.AdminApp.ViewModel.CoffeeVideoViewModel> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\MainPage.xaml line 43
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj5, obj, null);
                }
            }
            private void Update_ViewModel_IsLoading_M_Equals_3875955625(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    this.PendingFunctionBindings["ViewModel_IsLoading_M_Equals_3875955625"] = new InvokeFunctionDelegate(this.Invoke_ViewModel_IsLoading_M_Equals_3875955625);
                }
            }
            private void UpdateTwoWay_5_SelectedItem()
            {
                if (this.initialized)
                {
                    this.dataRoot.ViewModel.SelectedCoffeeVideo = (global::WiredBrainCoffee.AdminApp.ViewModel.CoffeeVideoViewModel)this.obj5.SelectedItem;
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj1_Bindings> weakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public MainPage_obj1_Bindings TryGetBindingObject()
                {
                    MainPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_SelectedCoffeeVideo(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::WiredBrainCoffee.AdminApp.ViewModel.MainViewModel obj = sender as global::WiredBrainCoffee.AdminApp.ViewModel.MainViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_SelectedCoffeeVideo(obj.SelectedCoffeeVideo, DATA_CHANGED);
                                bindings.Update_ViewModel_IsCoffeeVideoSelected(obj.IsCoffeeVideoSelected, DATA_CHANGED);
                                bindings.Update_ViewModel_IsLoading(obj.IsLoading, DATA_CHANGED);
                                bindings.Update_ViewModel_LoadingMessage(obj.LoadingMessage, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "SelectedCoffeeVideo":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_SelectedCoffeeVideo(obj.SelectedCoffeeVideo, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsCoffeeVideoSelected":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsCoffeeVideoSelected(obj.IsCoffeeVideoSelected, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsLoading":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsLoading(obj.IsLoading, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "LoadingMessage":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_LoadingMessage(obj.LoadingMessage, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                        bindings.CompleteUpdate(DATA_CHANGED);
                    }
                }
                private global::WiredBrainCoffee.AdminApp.ViewModel.MainViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::WiredBrainCoffee.AdminApp.ViewModel.MainViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_SelectedCoffeeVideo(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::WiredBrainCoffee.AdminApp.ViewModel.CoffeeVideoViewModel obj = sender as global::WiredBrainCoffee.AdminApp.ViewModel.CoffeeVideoViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                        bindings.CompleteUpdate(DATA_CHANGED);
                    }
                }
                private global::WiredBrainCoffee.AdminApp.ViewModel.CoffeeVideoViewModel cache_ViewModel_SelectedCoffeeVideo = null;
                public void UpdateChildListeners_ViewModel_SelectedCoffeeVideo(global::WiredBrainCoffee.AdminApp.ViewModel.CoffeeVideoViewModel obj)
                {
                    if (obj != cache_ViewModel_SelectedCoffeeVideo)
                    {
                        if (cache_ViewModel_SelectedCoffeeVideo != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_SelectedCoffeeVideo).PropertyChanged -= PropertyChanged_ViewModel_SelectedCoffeeVideo;
                            cache_ViewModel_SelectedCoffeeVideo = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_SelectedCoffeeVideo = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_SelectedCoffeeVideo;
                        }
                    }
                }
                public void RegisterTwoWayListener_5(global::Windows.UI.Xaml.Controls.ListView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedItemProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_5_SelectedItem();
                        }
                    });
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // View\MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

