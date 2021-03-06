#pragma checksum "..\..\..\..\Views\ReviewsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A3F7EC1FD346E40D09862BAC293EA218B403AEA9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BookReview;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BookReview {
    
    
    /// <summary>
    /// ReviewsWindow
    /// </summary>
    public partial class ReviewsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Views\ReviewsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CommentsBtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\ReviewsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\ReviewsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\ReviewsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Views\ReviewsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\ReviewsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReviewTB;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\ReviewsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ReviewsLB;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Views\ReviewsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RatingCB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BookReview;component/views/reviewswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ReviewsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\..\Views\ReviewsWindow.xaml"
            ((BookReview.ReviewsWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ReviewsWindow_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CommentsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Views\ReviewsWindow.xaml"
            this.CommentsBtn.Click += new System.Windows.RoutedEventHandler(this.CommentsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Views\ReviewsWindow.xaml"
            this.ExitBtn.Click += new System.Windows.RoutedEventHandler(this.ExitBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.InsertBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Views\ReviewsWindow.xaml"
            this.InsertBtn.Click += new System.Windows.RoutedEventHandler(this.InsertBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UpdateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Views\ReviewsWindow.xaml"
            this.UpdateBtn.Click += new System.Windows.RoutedEventHandler(this.UpdateBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DeleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Views\ReviewsWindow.xaml"
            this.DeleteBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ReviewTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ReviewsLB = ((System.Windows.Controls.ListBox)(target));
            
            #line 53 "..\..\..\..\Views\ReviewsWindow.xaml"
            this.ReviewsLB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ReviewsLB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.RatingCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

