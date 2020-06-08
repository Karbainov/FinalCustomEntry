using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Util;
using Android.Views;
using Android.Widget;
using FinalCustomEntry;
using FinalCustomEntry.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace FinalCustomEntry.Droid
{
    public class CustomEntryRenderer: EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var view = (CustomEntry)Element;

                var _gradientBackground = new GradientDrawable();
                _gradientBackground.SetShape(ShapeType.Rectangle);
                _gradientBackground.SetColor(view.BackgroundColor.ToAndroid());
                _gradientBackground.SetStroke(view.BorderWidth, view.BorderColor.ToAndroid());
                _gradientBackground.SetCornerRadius(DpToPixels(this.Context, Convert.ToSingle(view.CornerRadius)));  
                Control.SetBackground(_gradientBackground);

                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);

                this.Control.SetPadding(
                    (int)DpToPixels(this.Context, view.LeftPadding),
                     (int)DpToPixels(this.Context, view.TopPadding),
                    (int)DpToPixels(this.Context, view.RightPadding),
                    (int)DpToPixels(this.Context, view.BottomPadding)
                    );

                if (view.IsNumeric)
                {
                    Control.InputType = Android.Text.InputTypes.ClassNumber | Android.Text.InputTypes.NumberFlagSigned | Android.Text.InputTypes.NumberFlagDecimal;
                }
                if (view.IsPasswordK)
                {
                    Control.InputType = Android.Text.InputTypes.TextVariationWebEmailAddress | Android.Text.InputTypes.TextVariationEmailAddress;
                }
                if (view.IsMail)
                {
                    Control.InputType = Android.Text.InputTypes.TextVariationWebPassword; //Android.Text.InputTypes.TextVariationPassword | 
                }
            }
        }
        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}