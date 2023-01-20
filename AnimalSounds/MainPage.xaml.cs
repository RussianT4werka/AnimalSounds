using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimalSounds
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page, INotifyPropertyChanged
    {
        public ObservableCollection<Card> Birds { get; set; }
        public ObservableCollection<Card> Mammals { get; set; }
        public ObservableCollection<Card> Reptiles { get; set; }
        public ObservableCollection<Card> Insects { get; set; } 

        //Пернатые
        public Command PlayStork { get; set; }
        public Command PlaySparrow { get; set; }
        public Command PlayCrow { get; set; }
        public Command PlayPigeon { get; set; }
        public Command PlayGoose { get; set; }
        public Command PlayMagpie { get; set; }
        public Command PlayPheasant { get; set; }
        //Млекопитающие
        public Command PlayAntilope { get; set; }
        //Пресмыкающиеся
        public Command PlayAlligator { get; set; }
        //Насекомые


        public MainPage()
        {
            InitializeComponent();
            DataContext = this;

            // Пернатые
            PlayStork = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Stork);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Stork);
                MessageBox.Show("Курлык-курлык");
            });

            PlaySparrow = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Sparrow);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Sparrow);
                MessageBox.Show("Чирик-чирик");
            });

            PlayCrow = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Crow);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Crow);
                MessageBox.Show("Кар-кар");
            });

            PlayPigeon = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Pigeon);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Pigeon);
                MessageBox.Show("Url-url");
            });

            PlayGoose = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Goose);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Goose);
                MessageBox.Show("Га-га");
            });

            PlayMagpie = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Magpie);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Magpie);
                MessageBox.Show("*Звуки скрежета металла*");
            });

            PlayPheasant = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Pheasant);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Pheasant);
                MessageBox.Show("*Звуки дикого петуха*");
            });

            //Млекопитающие
            PlayAntilope = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Antelope);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Antelope);
                MessageBox.Show("*Звуки слишком быстрой коровы?*");
            });

            //Пресмыкающиеся
            PlayAlligator = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Alligator);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Alligator);
                MessageBox.Show("*Звуки приближающейся смерти*");
            });

            Birds = new ObservableCollection<Card>
            {
                new Card {Id=1, ImagePath="/AnimalSounds;component/Image/Stork.jpg", Name="Аист", Command = PlayStork},
                new Card {Id=2, ImagePath="/AnimalSounds;component/Image/Sparrow.jpg", Name="Воробей", Command=PlaySparrow},
                new Card {Id=3, ImagePath="/AnimalSounds;component/Image/Crow.jpg", Name="Ворона", Command=PlayCrow},
                new Card {Id=4, ImagePath="/AnimalSounds;component/Image/Pigeon.jpg", Name="Голубь", Command=PlayPigeon},
                new Card {Id=5, ImagePath="/AnimalSounds;component/Image/Goose.jpg", Name="Гусь", Command=PlayGoose},
                new Card {Id=6, ImagePath="/AnimalSounds;component/Image/Magpie.jpeg", Name="Сорока", Command=PlayMagpie},
                new Card {Id=7, ImagePath="/AnimalSounds;component/Image/Pheasant.jpg", Name="Фазан", Command=PlayPheasant}
            };

            Mammals = new ObservableCollection<Card>
            {
                new Card {Id=1, ImagePath="/AnimalSounds;component/Image/Antelope.jpg", Name="Антилопа", Command = PlayAntilope},
                
            };
            
            Reptiles = new ObservableCollection<Card>
            {
                new Card {Id=1, ImagePath="/AnimalSounds;component/Image/Alligator.jpg", Name="Аллигатор", Command = PlayAlligator},
            };
            
            Insects = new ObservableCollection<Card>
            {
                new Card {Id=1, ImagePath="/AnimalSounds;component/Image/Flea.jpg", Name="Блоха", Command = PlayFlea},
            };

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Birds)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Mammals)));

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        //private void animalsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Card p = (Card)animalsList.SelectedItem;
        //    MessageBox.Show(p.Name);
        //}
    }
}
