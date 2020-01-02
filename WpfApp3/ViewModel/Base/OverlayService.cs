using System;

namespace WpfApp3.ViewModel.Base
{
    public class OverlayService:BaseViewModel
    {
        private static OverlayService _Instance = new OverlayService();
        public static OverlayService GetInstance() => _Instance;

        private OverlayService() { }
        private Action<string> _show;

        public Action<string> Show
        {
            get => _show;
            set => SetProperty(ref _show, value);
        }

        private string _text = "";

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public void Close()
        {
            Text = "";
        }
    }
}