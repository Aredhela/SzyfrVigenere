using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

namespace Szyfrator
{
    /// <summary>
    /// Interaction logic for FromFile.xaml
    /// </summary>
    public partial class FromFile : Window
    {
        public const int AlphabetLength = LastAlphabetCode - FirstAlphabetCode + 1;
        public const int LastAlphabetCode = '~';
        public const int FirstAlphabetCode = ' ';


        public FromFile()
        {
            InitializeComponent();
        }

        private void Button_encrypt_File_Click(object sender, RoutedEventArgs e)
        {
            TextBox_encrypted_File.Text = Encryption(TextBox_decrypted_File.Text, TextBox_Password.Text);
        }

        public static string Encryption(string encrypted, string key)
        {
            var encryptedBytes = new byte[encrypted.Length];
            Encryption(Encoding.ASCII.GetBytes(encrypted), encryptedBytes, new RingKey(key));
            return Encoding.ASCII.GetString(encryptedBytes);
        }

        public static void Encryption(byte[] input, byte[] output, RingKey key)
        {
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '\n' || input[i] == '\r')
                {
                    output[i] = input[i];
                    continue;
                }
                var encryptedChar = (byte)(input[i] - FirstAlphabetCode) + key.Current;
                var decryptedChar = (byte)(encryptedChar < AlphabetLength ? encryptedChar : (encryptedChar - AlphabetLength));
                output[i] = (byte)(decryptedChar + FirstAlphabetCode);
                key.MoveNext();
            }
        } 

        private void Button_BackToMain_File_Click(object sender, RoutedEventArgs e)
        {
            var Wmainwindow = new MainWindow();
            Wmainwindow.Show();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Read(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\Aredhel\\Desktop\\Test.txt"))
                {
                    String line = sr.ReadToEnd();
                    TextBox_decrypted_File.Text = line;
                }
            }
            catch (Exception ex)
            {
                TextBox_decrypted_File.Text = "NIE MOZNA ODCZYTAC PLIKU !";
            }
        }

        private void Button_Read2(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\Aredhel\\Desktop\\Test2.txt"))
                {
                    String line = sr.ReadToEnd();
                    TextBox_encrypted_File.Text = line;
                }
            }
            catch (Exception ex)
            {
                TextBox_encrypted_File.Text = "NIE MOZNA ODCZYTAC PLIKU !";
            }
        }

        private void Button_decrypt_File_Click(object sender, RoutedEventArgs e)
        {
            TextBox_decrypted_File.Text = Encryption(TextBox_encrypted_File.Text, TextBox_Password.Text);
        }

        public static string Decryption(string plain, string key)
        {
            var encryptedBytes = new byte[plain.Length];
            Decryption(Encoding.ASCII.GetBytes(plain), encryptedBytes, new RingKey(key));
            return Encoding.ASCII.GetString(encryptedBytes);
        }

        public static void Decryption(byte[] input, byte[] output, RingKey key)
        {
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '\n' || input[i] == '\r')
                {
                    output[i] = input[i];
                    continue;
                }
                var decryptedChar = (byte)(input[i] - FirstAlphabetCode);
                var encryptedChar = (byte)(decryptedChar > key.Current ? (decryptedChar - key.Current) : (decryptedChar + AlphabetLength - key.Current));
                output[i] = (byte)(encryptedChar + FirstAlphabetCode);
                key.MoveNext();
            }
        }

        private void TextBox_Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
