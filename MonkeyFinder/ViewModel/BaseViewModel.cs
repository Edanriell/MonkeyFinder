namespace MonkeyFinder.ViewModel;

// public class BaseViewModel : INotifyPropertyChanged
// [INotifyPropertyChanged]
// public partial class BaseViewModel
/*public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {
        // SetProperty(ref isBusy, true);
    }

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !isBusy;

    */
/*    public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (isBusy == value)
                    return;
    
                isBusy = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy));
            }
        }
    
        public string Title
        {
            get => title;
            set
            {
                if (title == value)
                    return;
    
                title = value;
                OnPropertyChanged();
            }
        }
    */
/*
    // public bool IsNotBusy => !isBusy;

    */
/*    public event PropertyChangedEventHandler PropertyChanged;
    
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }*/
/*
}*/

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;
}
