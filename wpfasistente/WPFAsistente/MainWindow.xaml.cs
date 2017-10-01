using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;

namespace WPFAsistente
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SpeechRecognitionEngine reconocedor = new SpeechRecognitionEngine(); // RECONOCE VOZ
        SpeechSynthesizer vozdoris = new SpeechSynthesizer(); // HABLA ASISTENTE
        String speech;// Almacena lo que logro reconocer
        bool HabilitaReconocimiento = true;

        

        public MainWindow()
        {
            InitializeComponent();
            vozdoris.SpeakAsync("Iniciando");
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            CargaGramatica();
        }


        void CargaGramatica()
        {
            reconocedor.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines("ComandosDefecto.txt")))));
            reconocedor.RequestRecognizerUpdate();
            reconocedor.SpeechRecognized += Reconocedor_SpeechRecognized; // Cuando reconozca algo va a ir a su función  Reconocedor_SpeechRecognized
            vozdoris.SpeakStarted += Vozdoris_SpeakStarted; // Cuando comience a hablar va a hacer el evento Vozdoris_SpeakStarted
            vozdoris.SpeakCompleted += Vozdoris_SpeakCompleted; // Cuando termine de hablar que haga  el evento Vozdoris_SpeakCompleted
            reconocedor.AudioLevelUpdated += Reconocedor_AudioLevelUpdated; // TOMA EL VALOR DE LA VOZ Y LO ENVIA A Reconocedor_AudioLevelUpdated
            reconocedor.SetInputToDefaultAudioDevice(); // Carga microfono por defecto
            reconocedor.RecognizeAsync(RecognizeMode.Multiple);// Activa reconocimiento de voz

        }

        private void Reconocedor_AudioLevelUpdated(object sender, AudioLevelUpdatedEventArgs e)
        {
            int nivel_voz_entrada = e.AudioLevel;
            bar_voz.Value = nivel_voz_entrada;
        }

        private void Vozdoris_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            HabilitaReconocimiento = true; // se habilita el reconocimiento
        }

        private void Vozdoris_SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            HabilitaReconocimiento = false; // cuando empieze a hablar desactive el reconocimiento
        }

        private void Reconocedor_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            speech = e.Result.Text;

            if (HabilitaReconocimiento == true)
            {



                switch (speech)
                {
                    case "Buenos dias":
                        //vozdoris.Speak("Buenos dias marvin" + ". . . ."); // Primero habla y despues ejecuta
                        vozdoris.SpeakAsync("Buenos dias marvin" + ". . . . ."); // Mientras habla el esta ejecutando
                        lbl_reconocimiento.Content = "";
                        lbl_reconocimiento.Content = speech; break;

                    case "Abrir navegador":
                        vozdoris.SpeakAsync("Abriendo el navegador" + ". . . . ."); // Mientras habla el esta ejecutando
                        System.Diagnostics.Process.Start("https://www.google.com.gt/");
                        lbl_reconocimiento.Content = "";
                        lbl_reconocimiento.Content = speech; break;

                    case "Adios doris":
                        vozdoris.Speak("Adios marvin" + ". . . ."); // Primero habla y despues ejecuta
                        App.Current.Shutdown(); break; // CIERRA LA APLICACIÓN SIN DEJAR ABIERTO PROCESOS
                        //Close(); break;

                    default:
                        break;
                }
            }
        }

        private void window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove(); // ARRASTRA LA VENTANA POR EL MOUSE, CLIC IZQUIERDO
        }
    }
}
