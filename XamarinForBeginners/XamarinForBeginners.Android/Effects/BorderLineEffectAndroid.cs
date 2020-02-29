using Android.Content.Res;
using Android.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinForBeginners.Effects;

[assembly: ResolutionGroupName("SampleEffects")]
[assembly: ExportEffect(typeof (BorderLineEffectAndroid), "BorderLineEffect")]

namespace XamarinForBeginners.Effects
{
    public class BorderLineEffectAndroid : PlatformEffect
    {
        protected override void OnAttached()
        {
            if(Control is FormsEditText)
            {
                Android.Graphics.Color borderColor = Android.Graphics.Color.Orange;
                Control.BackgroundTintList = ColorStateList.ValueOf(borderColor);
            }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}
