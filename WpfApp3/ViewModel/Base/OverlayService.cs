using System;
using System.Windows;

namespace WpfApp3.ViewModel.Base
{
    public class OverlayService:BaseViewModel
    {
        private static OverlayService _overlayService()
        {
            return _Instance ??= new OverlayService();
        }

        private static OverlayService _Instance;
        public static OverlayService GetInstance() => _overlayService();

        private OverlayService() { }

        private string _text = "";

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        private Visibility _visibility = System.Windows.Visibility.Collapsed;

        public Visibility Visibility
        {
            get => _visibility;
            set => SetProperty(ref _visibility, value);
        }

        public void Close()
        {
            Text = "";
        }
    }
}