﻿#pragma checksum "C:\Users\admon\Documents\Visual Studio 2015\Projects\App4\App4\MapPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "29F469243527160F0843C3B3FEFE36D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App4
{
    partial class MapPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        private class MapPage_obj17_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMapPage_Bindings
        {
            private global::App4.Models.Comment dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj18;

            public MapPage_obj17_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 18:
                        this.obj18 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::App4.Models.Comment data = args.NewValue as global::App4.Models.Comment;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::App4.Models.Comment was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::App4.Models.Comment);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.StackPanel)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::App4.Models.Comment) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IMapPage_Bindings

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
            }

            // MapPage_obj17_Bindings

            public void SetDataRoot(global::App4.Models.Comment newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::App4.Models.Comment obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_CommentImg(obj.CommentImg, phase);
                    }
                }
            }
            private void Update_CommentImg(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj18, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
        }

        private class MapPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMapPage_Bindings
        {
            private global::App4.MapPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj16;

            public MapPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 16:
                        this.obj16 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IMapPage_Bindings

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
            }

            // MapPage_obj1_Bindings

            public void SetDataRoot(global::App4.MapPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::App4.MapPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Comments(obj.Comments, phase);
                    }
                }
            }
            private void Update_Comments(global::System.Collections.Generic.List<global::App4.Models.Comment> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj16, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.DrawerOpner = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DrawerOpner).Click += this.HamburgerButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Homebtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Homebtn).Click += this.Homebtn_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.UserHeaderImg = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.UserHeaderImg).Click += this.UserHeaderImg_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.UserNameHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.UserPrenameHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.Country = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.UserTown = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.NbrNotif = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.ProducerIMG = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 11:
                {
                    this.UserName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.UserDescription = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.Map = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                }
                break;
            case 14:
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 15:
                {
                    this.NotifPannel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 16:
                {
                    this.NotifLIst = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 19:
                {
                    this.IconsListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 67 "..\..\..\MapPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.IconsListBox).SelectionChanged += this.IconsListBox_SelectionChanged;
                    #line default
                }
                break;
            case 20:
                {
                    this.ShareListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 21:
                {
                    this.FavoritesListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 22:
                {
                    this.ServiceListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 23:
                {
                    this.MultimediaListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 24:
                {
                    this.ImmobilierListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 25:
                {
                    this.VettementListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 26:
                {
                    this.VehiculeListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 27:
                {
                    this.SearchListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 28:
                {
                    this.SettingListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 29:
                {
                    this.LogoutListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 30:
                {
                    this.vehoox = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 31:
                {
                    this.Titlepox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 32:
                {
                    this.Titlepax = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 33:
                {
                    this.vehoop = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 34:
                {
                    this.Titlepop = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 35:
                {
                    this.Titlepai = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 36:
                {
                    this.veho = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 37:
                {
                    this.Titlepoo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 38:
                {
                    this.Titlepaa = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 39:
                {
                    this.veh = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 40:
                {
                    this.Titlepo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 41:
                {
                    this.Titlepa = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 42:
                {
                    this.vet = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 43:
                {
                    this.TitleU = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 44:
                {
                    this.TitleT = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 45:
                {
                    this.imob = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 46:
                {
                    this.TitleY = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 47:
                {
                    this.Titlep = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 48:
                {
                    this.multi = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 49:
                {
                    this.TitleH = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 50:
                {
                    this.TitleI = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 51:
                {
                    this.Serv = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 52:
                {
                    this.TitleC = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 53:
                {
                    this.TitleF = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 54:
                {
                    this.Artis = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 55:
                {
                    this.TitleA = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 56:
                {
                    this.TitleB = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 57:
                {
                    this.Nouri = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 58:
                {
                    this.TitleG = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 59:
                {
                    this.TitleD = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 60:
                {
                    this.ResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MapPage_obj1_Bindings bindings = new MapPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 17:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element17 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    MapPage_obj17_Bindings bindings = new MapPage_obj17_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::App4.Models.Comment) element17.DataContext);
                    element17.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element17, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

