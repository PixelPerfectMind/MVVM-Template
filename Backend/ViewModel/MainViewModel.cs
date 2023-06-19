using GalaSoft.MvvmLight;

namespace Backend.ViewModel {

    public class MainViewModel : ViewModelBase {

        public string WindowTitle { get; set; }
        public MainViewModel() {
            if (IsInDesignMode) {
                WindowTitle = "Anwendung (Designer-Ansicht)";
            } else {
                WindowTitle = "Anwendung";
            }
        }
    }
}