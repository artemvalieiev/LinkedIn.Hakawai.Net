﻿// This file has been autogenerated from a class added in the UI designer.

using System;
using Foundation;
using UIKit;

namespace LinkedIn.Hakawai.Sample;

public partial class BasicDemoViewController : UIViewController
{
    public BasicDemoViewController(IntPtr handle) : base(handle)
    {
    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();
        ROT13Button.TouchUpInside += ROT13ButtonOnTouchUpInside;
        PalindromButton.TouchUpInside += PalindromButtonOnTouchUpInside;
    }

    private void PalindromButtonOnTouchUpInside(object? sender, EventArgs e)
    {
        if (MainTextView.SelectedRange.Length == 0) return;

        MainTextView.TransformSelectedTextWithTransformer(input =>
        {
            var rawInput = input.Value;
            var palindrome = string.Empty;
            foreach (var s in rawInput!.Reverse()) palindrome += s;

            return new NSAttributedString(palindrome);
        });
    }

    private void ROT13ButtonOnTouchUpInside(object? sender, EventArgs e)
    {
        return;
        throw new NotImplementedException();
    }
}