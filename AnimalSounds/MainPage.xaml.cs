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
        public Command PlayRam { get; set; }
        public Command PlayCamel { get; set; }
        public Command PlayGorilla { get; set; }
        public Command PlayDolphin { get; set; }
        //Пресмыкающиеся
        public Command PlayAlligator { get; set; }
        public Command PlayFrog { get; set; }
        public Command PlayLizard { get; set; }
        public Command PlaySnake { get; set; }
        //Насекомые
        public Command PlayCricket { get; set; }
        public Command PlayCicada { get; set; }
        public Command PlayFly { get; set; }
        public Command PlayMosquito { get; set; }

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
                MessageBox.Show("*Адские звуки Сатаны*");
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
                MessageBox.Show("*Звуки игрушечного автомата на батарейках*");
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

            PlayRam = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Ram);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Ram);
                MessageBox.Show("Бееее");
            });

            PlayCamel = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Camel);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Camel);
                MessageBox.Show("*Очередные звуки смерти*");
            });

            PlayGorilla = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Gorilla);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Gorilla);
                MessageBox.Show("*Что-то на африканском*");
            });

            PlayDolphin = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Dolphin);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Dolphin);
                MessageBox.Show("*Зацензуренные матюки*");
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

            PlayFrog = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Frog);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Frog);
                MessageBox.Show("Ква-ква");
            });

            PlayLizard = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Lizard);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Lizard);
                MessageBox.Show("Хшшшш");
            });

            PlaySnake = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Snake);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Snake);
                MessageBox.Show("Фшшш");
            });
            //Насекомые
            PlayCricket = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Cricket);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Alligator);
                MessageBox.Show("*Звуки тишины*");
            });

            PlayCicada = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Cicada);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Cicada);
                MessageBox.Show("*Звуки тишины*");
            });

            PlayFly = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Fly);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Fly);
                MessageBox.Show("Звук существа любящего попсу");
            });

            PlayMosquito = new Command(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Mosquito);// soundPlayer может воспроизводить только аудио в формате WAV
                sp.PlayLooping();// цикл воспроизведения
                sp.Play();// Играем один раз
                sp = new SoundPlayer(Properties.Resources.Mosquito);
                MessageBox.Show("Бззззззззззз");
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
                new Card {Id=2, ImagePath="/AnimalSounds;component/Image/Ram.jpg", Name="Баран", Command = PlayRam},
                new Card {Id=3, ImagePath="/AnimalSounds;component/Image/Camel.jpg", Name="Верблюд", Command = PlayCamel},
                new Card {Id=4, ImagePath="/AnimalSounds;component/Image/Gorilla.jpg", Name="Горилла", Command = PlayGorilla},
                new Card {Id=5, ImagePath="/AnimalSounds;component/Image/Dolphin.jpg", Name="Дельфин", Command = PlayDolphin},
            };
            
            Reptiles = new ObservableCollection<Card>
            {
                new Card {Id=1, ImagePath="/AnimalSounds;component/Image/Alligator.jpg", Name="Аллигатор", Command = PlayAlligator},
                new Card {Id=2, ImagePath="/AnimalSounds;component/Image/Frog.jpg", Name="Лягушка", Command = PlayFrog},
                new Card {Id=3, ImagePath="/AnimalSounds;component/Image/Lizard.jpg", Name="Ящерица", Command = PlayLizard},
                new Card {Id=4, ImagePath="/AnimalSounds;component/Image/Snake.jpg", Name="Змея", Command = PlaySnake},
            };
            
            Insects = new ObservableCollection<Card>
            {
                new Card {Id=1, ImagePath="/AnimalSounds;component/Image/Cricket.jpg", Name="Сверчок", Command = PlayCricket},
                new Card {Id=2, ImagePath="/AnimalSounds;component/Image/Cicada.jpg", Name="Цикада", Command = PlayCicada},
                new Card {Id=3, ImagePath="/AnimalSounds;component/Image/Fly.jpg", Name="Муха", Command = PlayFly},
                new Card {Id=4, ImagePath="/AnimalSounds;component/Image/Mosquito.jpg", Name="Комар", Command = PlayMosquito},
            };

            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Birds)));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Mammals)));

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        //private void animalsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Card p = (Card)animalsList.SelectedItem;
        //    MessageBox.Show(p.Name);
        //}
    }
}
