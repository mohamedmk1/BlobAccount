﻿#pragma checksum "C:\Tutos\C#\Pluralight\BlobAccount.WiredBrainCoffee\WiredBrainCoffee.AdminApp\View\AddCoffeeVideoDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5F72A51FBDE30600C16C87EE6E18303F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WiredBrainCoffee.AdminApp.View
{
    partial class AddCoffeeVideoDialog : 
        global::Windows.UI.Xaml.Controls.ContentDialog, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ContentDialog_IsPrimaryButtonEnabled(global::Windows.UI.Xaml.Controls.ContentDialog obj, global::System.Boolean value)
            {
                obj.IsPrimaryButtonEnabled = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class AddCoffeeVideoDialog_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAddCoffeeVideoDialog_Bindings
        {
            private global::WiredBrainCoffee.AdminApp.View.AddCoffeeVideoDialog dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::System.WeakReference obj1;
            private global::Windows.UI.Xaml.Controls.Button obj2;
            private global::Windows.UI.Xaml.Controls.TextBox obj3;

            private AddCoffeeVideoDialog_obj1_BindingsTracking bindingsTracking;

            public AddCoffeeVideoDialog_obj1_Bindings()
            {
                this.bindingsTracking = new AddCoffeeVideoDialog_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 1: // View\AddCoffeeVideoDialog.xaml line 1
                        this.obj1 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.ContentDialog)target);
                        ((global::Windows.UI.Xaml.Controls.ContentDialog)target).PrimaryButtonClick += (global::Windows.UI.Xaml.Controls.ContentDialog sender, global::Windows.UI.Xaml.Controls.ContentDialogButtonClickEventArgs args) =>
                        {
                            this.dataRoot.ViewModel.PrimaryButtonClick(sender, args);
                        };
                        break;
                    case 2: // View\AddCoffeeVideoDialog.xaml line 22
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModel.SelectVideoAsync();
                        };
                        break;
                    case 3: // View\AddCoffeeVideoDialog.xaml line 24
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_3(this.obj3);
                        break;
                    default:
                        break;
                }
            }

            // IAddCoffeeVideoDialog_Bindings

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
                    this.dataRoot = (global::WiredBrainCoffee.AdminApp.View.AddCoffeeVideoDialog)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::WiredBrainCoffee.AdminApp.View.AddCoffeeVideoDialog obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::WiredBrainCoffee.AdminApp.ViewModel.AddCoffeeVideoDialogViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_IsPrimaryButtonEnabled(obj.IsPrimaryButtonEnabled, phase);
                        this.Update_ViewModel_BlobNameWithoutExtension(obj.BlobNameWithoutExtension, phase);
                    }
                }
            }
            private void Update_ViewModel_IsPrimaryButtonEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\AddCoffeeVideoDialog.xaml line 1
                    if ((this.obj1.Target as global::Windows.UI.Xaml.Controls.ContentDialog) != null)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentDialog_IsPrimaryButtonEnabled((this.obj1.Target as global::Windows.UI.Xaml.Controls.ContentDialog), obj);
                    }
                }
            }
            private void Update_ViewModel_BlobNameWithoutExtension(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\AddCoffeeVideoDialog.xaml line 24
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj3, obj, null);
                }
            }
            private void UpdateTwoWay_3_Text()
            {
                if (this.initialized)
                {
                    this.dataRoot.ViewModel.BlobNameWithoutExtension = this.obj3.Text;
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class AddCoffeeVideoDialog_obj1_BindingsTracking
            {
                private global::System.WeakReference<AddCoffeeVideoDialog_obj1_Bindings> weakRefToBindingObj; 

                public AddCoffeeVideoDialog_obj1_BindingsTracking(AddCoffeeVideoDialog_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<AddCoffeeVideoDialog_obj1_Bindings>(obj);
                }

                public AddCoffeeVideoDialog_obj1_Bindings TryGetBindingObject()
                {
                    AddCoffeeVideoDialog_obj1_Bindings bindingObject = null;
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
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AddCoffeeVideoDialog_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::WiredBrainCoffee.AdminApp.ViewModel.AddCoffeeVideoDialogViewModel obj = sender as global::WiredBrainCoffee.AdminApp.ViewModel.AddCoffeeVideoDialogViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_IsPrimaryButtonEnabled(obj.IsPrimaryButtonEnabled, DATA_CHANGED);
                                bindings.Update_ViewModel_BlobNameWithoutExtension(obj.BlobNameWithoutExtension, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsPrimaryButtonEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsPrimaryButtonEnabled(obj.IsPrimaryButtonEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "BlobNameWithoutExtension":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_BlobNameWithoutExtension(obj.BlobNameWithoutExtension, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::WiredBrainCoffee.AdminApp.ViewModel.AddCoffeeVideoDialogViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::WiredBrainCoffee.AdminApp.ViewModel.AddCoffeeVideoDialogViewModel obj)
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
                public void RegisterTwoWayListener_3(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.TextBox.TextProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_3_Text();
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
            case 1: // View\AddCoffeeVideoDialog.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.ContentDialog element1 = (global::Windows.UI.Xaml.Controls.ContentDialog)target;
                    AddCoffeeVideoDialog_obj1_Bindings bindings = new AddCoffeeVideoDialog_obj1_Bindings();
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

