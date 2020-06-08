using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using FinalCustomEntry;
using FinalCustomEntry.iOS;
using Xamarin.Forms;
using CoreGraphics;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace FinalCustomEntry.iOS
{
    class CustomEntryRenderer:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var view = (CustomEntry)Element;

                // Create a custom border with square corners
                Control.BorderStyle = UITextBorderStyle.None;
                Control.Layer.CornerRadius = new nfloat(view.CornerRadius);
                Control.Layer.BorderWidth = new nfloat(view.BorderWidth);
                Control.Layer.BorderColor = view.BorderColor.ToCGColor();

                // Invisible views create padding at the beginning and end
                Control.LeftView = new UIView(new CGRect(view.LeftPadding, view.TopPadding, view.RightPadding, view.BottomPadding));
                Control.RightView = new UIView(new CGRect(view.LeftPadding, view.TopPadding, view.RightPadding, view.BottomPadding));
                Control.LeftViewMode = UITextFieldViewMode.Always;
                Control.RightViewMode = UITextFieldViewMode.Always;

                // Fixed height creates padding at top and bottom
                Element.HeightRequest = 30;
            }
        }
    }
}