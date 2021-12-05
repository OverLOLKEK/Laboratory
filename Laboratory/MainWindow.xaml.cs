using Laboratory.db;
using System;
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

namespace Laboratory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // часть кода для импорта
            var connection = DBInstance.Get();
            //connection.Gender.Add(new Gender { Code = "м", Name = "мужской" });
            //connection.Gender.Add(new Gender { Code = "ж", Name = "женский" });
            //connection.SaveChanges();
            string path = @"C:\Users\kuzne\OneDrive\Документы\Учеба\КЗ_РЧ20_21_Основная группа\Session 1\services.csv";
            var rows = File.ReadAllLines(path);
            var clients = connection.Client.ToList();
            var services = connection.Service.ToList();
            for (int i = 1; i < rows.Length; i++)
            {
                var cols = rows[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                connection.Service.Add(new Service
                    {
                    id = i,
                    servicecode = int.Parse(cols[0]),
                    servicename = cols[1],
                    price = double.Parse(cols[2].Replace('.',',')),
            });

        }
           // connection.SaveChanges();
        }
    }
}
