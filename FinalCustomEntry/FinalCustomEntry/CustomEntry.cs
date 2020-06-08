using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FinalCustomEntry
{
    public class CustomEntry : Entry
    {

        public static readonly BindableProperty IsNumericProperty =
        BindableProperty.Create(
         nameof(IsNumeric),
         typeof(bool),
         typeof(CustomEntry),
         false
         );
        public bool IsNumeric
        {
            get => (bool)GetValue(IsNumericProperty);
            set => SetValue(IsNumericProperty, value);
        }


        public static readonly BindableProperty IsPasswordKProperty =
        BindableProperty.Create(
         nameof(IsPasswordK),
         typeof(bool),
         typeof(CustomEntry),
         false
         );
        public bool IsPasswordK
        {
            get => (bool)GetValue(IsPasswordKProperty);
            set => SetValue(IsPasswordKProperty, value);
        }


        public static readonly BindableProperty IsMailProperty =
       BindableProperty.Create(
        nameof(IsMail),
        typeof(bool),
        typeof(CustomEntry),
        false
        );
        public bool IsMail
        {
            get => (bool)GetValue(IsMailProperty);
            set => SetValue(IsMailProperty, value);
        }


        public static readonly BindableProperty BorderColorProperty =
        BindableProperty.Create(
         nameof(BorderColor),
         typeof(Color),
         typeof(CustomEntry),
         Color.Gray
         );
        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }


        public static readonly BindableProperty BorderWidthProperty =
        BindableProperty.Create(
            nameof(BorderWidth),
            typeof(int),
            typeof(CustomEntry),
            1
            );
        public int BorderWidth
        {
            get => (int)GetValue(BorderWidthProperty);
            set => SetValue(BorderWidthProperty, value);
        }

        public static readonly BindableProperty CornerRadiusProperty =
        BindableProperty.Create(
            nameof(CornerRadius),
            typeof(double),
            typeof(CustomEntry),
            5d
            );
        public double CornerRadius
        {
            get => (double)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public static readonly BindableProperty TopPaddingProperty =
      BindableProperty.Create(
          nameof(TopPadding),
          typeof(int),
          typeof(CustomEntry),
          0
          );
        public int TopPadding
        {
            get => (int)GetValue(TopPaddingProperty);
            set => SetValue(TopPaddingProperty, value);
        }

        public static readonly BindableProperty LeftPaddingProperty =
      BindableProperty.Create(
          nameof(LeftPadding),
          typeof(int),
          typeof(CustomEntry),
          0
          );
        public int LeftPadding
        {
            get => (int)GetValue(LeftPaddingProperty);
            set => SetValue(LeftPaddingProperty, value);
        }

        public static readonly BindableProperty RightPaddingProperty =
     BindableProperty.Create(
         nameof(RightPadding),
         typeof(int),
         typeof(CustomEntry),
         0
         );
        public int RightPadding
        {
            get => (int)GetValue(RightPaddingProperty);
            set => SetValue(RightPaddingProperty, value);
        }


        public static readonly BindableProperty BottomPaddingProperty =
    BindableProperty.Create(
        nameof(BottomPadding),
        typeof(int),
        typeof(CustomEntry),
        0
        );
        public int BottomPadding
        {
            get => (int)GetValue(BottomPaddingProperty);
            set => SetValue(BottomPaddingProperty, value);
        }
    }
}
