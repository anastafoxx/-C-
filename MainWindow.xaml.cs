using Microsoft.Win32;
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
using System.IO;

namespace Window25
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new AppContext();

            loadusers();
        }

        private void loadusers()
        {
            List<User> users = db.Users.ToList();
            listusers.ItemsSource = users;
        }

        private void opennewfile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            bool? res = ofd.ShowDialog();

            if (res != false) {

                Stream myStream;
                if ((myStream = ofd.OpenFile()) != null)
                {
                    string filename = ofd.FileName;
                    string filetext = File.ReadAllText(filename);
                    texBox.Text = filetext;
                }
            }
        }

        private void savenewfile_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void timesnesroman_Click(object sender, RoutedEventArgs e)
        {
            texBox.FontFamily = new FontFamily("Times new Roman");
            verdana.IsChecked = false;
        }

        private void verdana_Click(object sender, RoutedEventArgs e)
        {
            texBox.FontFamily = new FontFamily("Verdana");
            timesnesroman.IsChecked = false;
        }

        private void selectfontsize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontsize = selectfontsize.SelectedItem.ToString();
            fontsize = fontsize.Substring(fontsize.Length - 2);
            switch (fontsize)
            {
                case "10":
                    texBox.FontSize = 10;
                    break;
                case "14":
                    texBox.FontSize = 14;
                    break;
                case "16":
                    texBox.FontSize = 16;
                    break;
                case "20":
                    texBox.FontSize = 20;
                    break;
                case "30":
                    texBox.FontSize = 30;
                    break;

            }
        }

        private void createnewfile_Click(object sender, RoutedEventArgs e)
        {
            if (texBox.Text != "")
            {
                SaveFile();
            }
            texBox.Text = "";
        }

        private void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            bool? res = sfd.ShowDialog();

            if (res != false) {
                using (Stream s = File.Open(sfd.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(texBox.Text);
                    }
                }
            }
        }

        private void regbtn_Click(object sender, RoutedEventArgs e)
        {
            string login1 = login.Text;
            string password1 = password.Password;

            if (login1.Length < 4)
            {
                login.Background = Brushes.Red;
                login.ToolTip = "error";
            } else if (password1.Length < 4)
            {
                password.Background = Brushes.Red;
                password.ToolTip = "error";
            }
            else
            {
                password.Background = Brushes.Transparent;
                login.Background = Brushes.Transparent;

                /*User user = new User(login1, password1);
                db.Users.Add(user);
                db.SaveChanges();*/

                User user = null;
                user = db.Users.Where(b => b.Login == login1 && b.Password == password1).FirstOrDefault();

                if (user != null)
                {
                    MessageBox.Show("user loggit in");
                }
                else
                {
                    user = db.Users.Where(b => b.Login == login1).FirstOrDefault();
                    if (user != null)
                    {
                        MessageBox.Show("login is busy");
                    } else
                    {
                        user = new User(login1, password1);
                        db.Users.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("User added");
                        loadusers();
                    }
                }


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int user_id = Convert.ToInt32(((Button)sender).Tag);
            User user = db.Users.Find(user_id);
            db.Users.Remove(user);
            db.SaveChanges();
            loadusers();
        }
        

    }
}

