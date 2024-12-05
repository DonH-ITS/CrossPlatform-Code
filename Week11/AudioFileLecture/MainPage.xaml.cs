using Plugin.Maui.Audio;

namespace AudioFileLecture
{
    public partial class MainPage : ContentPage
    {
        private IAudioPlayer audioplayer, openedAudio;

        public double Volume
        {
            get
            {
                return audioplayer.Volume;
            }
            set
            {
                audioplayer.Volume = value;
            }
        }
        public MainPage() {
            InitializeComponent();
            
        }

        protected override async void OnAppearing() {
            base.OnAppearing();
            audioplayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("dicerolling.mp3"));
            audioplayer.PlaybackEnded += EndPlayback;
            audioplayer.Loop = true;
            BindingContext = this;
        }

        private void EndPlayback(object? sender, EventArgs e) {
            Dispatcher.Dispatch(() =>
            {
                AudioState.Text = "stopped";
            });
        }

        private void OnCounterClicked(object sender, EventArgs e) {
            audioplayer.Play();
            AudioState.Text = "playing";

            

        }
        private async void PickImgButton_Clicked(object sender, EventArgs e) {
            try {
                PickOptions options = new()
                {
                    PickerTitle = "Please select an image file",
                    FileTypes = FilePickerFileType.Images,
                };
                var result = await FilePicker.Default.PickAsync(options);
                if (result != null) {
                    if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                        result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase)) {
                        Image image1 = new()
                        {
                            Source = result.FullPath
                        };
                        MainLayout.Add(image1);
                    }
                }
            }
            catch (Exception ex) {
                // The user canceled or something went wrong
            }

        }

        private void Button_Clicked(object sender, EventArgs e) {
            audioplayer.Loop = false;
        }

        /*                */

          private async void PickButton_Clicked(object sender, EventArgs e) {
             var customFileType = new FilePickerFileType(
                 new Dictionary<DevicePlatform, IEnumerable<string>>
                 {
                     { DevicePlatform.Android, new[] { "audio/mpeg", "audio/ogg", "audio/flac" } }, // MIME type
                     { DevicePlatform.WinUI, new[] { ".mp3", ".ogg", "flac" } }, // file extension

                 });
             PickOptions options = new()
             {
                 PickerTitle = "Please select a music file",
                 FileTypes = customFileType,
             };
             FileResult fileResult = await FilePicker.Default.PickAsync(options);
             if (fileResult != null) {
                 if (fileResult.FileName.EndsWith("mp3")) {
                     //fileResult.FileName
                     using var stream = await fileResult.OpenReadAsync();
                     openedAudio = AudioManager.Current.CreatePlayer(stream);
                     openedAudio.Play();
                 }
             }
         }
    }

}
