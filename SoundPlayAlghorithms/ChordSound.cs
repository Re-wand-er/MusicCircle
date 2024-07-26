using System;
using System.Windows.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows;
using System.Threading;
using System.IO;
using System.Windows.Threading;

namespace MusicCircle
{
    internal class ChordSound
    {
        private static readonly Regex regex = new Regex("[A-Z](b|#)?\\d?", RegexOptions.Compiled);


        private static string uriOfInstrumentalDirectory = AppDomain.CurrentDomain.BaseDirectory.Remove
            (AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "Sound\\";
        public readonly static string musicInstrumentFolder = "Piano_2\\";
        // is should be Non static value 
        static string pathToInstrumentalSound = uriOfInstrumentalDirectory + musicInstrumentFolder;


        // Need to creat path to instrumental sound
        // Идея запускать звуки в потоках а аккорды в тасках
        public static async Task Play(string notesCollection)
        {
            foreach (string notes in RegexNotes(notesCollection))
            {
                // Нет поддержки ogg файлов звучания 
                // Посмотреть возможность их подключения
                // Лучший вариант одновременного произведения звука
                // Но прерывается
                 await StartOneNoteSoundAsync(pathToInstrumentalSound + notes + "3.mp3");
            }
        }

        private static string[] RegexNotes(string notes)
        {
            MatchCollection noteMatchCollection = regex.Matches(notes);
            return noteMatchCollection.Cast<Match>().Select(match => match.Value).ToArray();;
        }

        private static async Task StartOneNoteSoundAsync(string notesPath)
        {
            // Вроде работает и даже чуть приемлемо
            // Надо убрать часть сустейна а то он очень мешает

             await Task.Run(() =>
             {
                 MediaPlayer player = new MediaPlayer();
                 player.MediaFailed += (o, args) => MessageBox.Show(args.ErrorException.ToString());
                 player.Volume = 0.3;
             
                 player.Open(new Uri(notesPath, UriKind.RelativeOrAbsolute));
                 player.Play();
             });

        }

        //TimeSpan.FromSeconds()
        private static async Task StartOneNoteSoundAsync(string notesPath, TimeSpan duration)
        {
            // Создаем MediaPlayer и DispatcherTimer в основном UI-потоке
            await Application.Current.Dispatcher.Invoke(async () =>
            {
                MediaPlayer player = new MediaPlayer();
                player.MediaFailed += (o, args) => MessageBox.Show(args.ErrorException.ToString());
                player.Open(new Uri(notesPath, UriKind.RelativeOrAbsolute));
                player.Volume = 0.3;

                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = duration;
                timer.Tick += (sender, e) =>
                {
                    player.Stop();
                    timer.Stop();
                };

                player.Play();
                timer.Start();

                // Асинхронно ждем окончания воспроизведения
                await Task.Delay(duration);
            });
        }

    }
}
