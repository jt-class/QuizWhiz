﻿using Android.App;
using Android.Content.Res;
using Android.Runtime;

namespace QuizWhiz
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
            // Removes underline in entry
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
                if (view is Entry)
                {
                    // Remove underline
                    handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);

                    // Change placeholder text color
                    handler.PlatformView.SetHintTextColor(ColorStateList.ValueOf(Android.Graphics.Color.Gray));
                }
            });

            // Removes underline in editor
            Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping(nameof(Editor), (handler, view) =>
            {
                if (view is Editor)
                {
                    // Remove underline
                    handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);

                    // Change placeholder text color (if applicable)
                    handler.PlatformView.SetHintTextColor(ColorStateList.ValueOf(Android.Graphics.Color.Gray));
                }
            });
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
