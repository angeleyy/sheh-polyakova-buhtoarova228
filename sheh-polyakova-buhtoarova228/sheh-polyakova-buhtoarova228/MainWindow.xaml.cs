using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
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
using Microsoft.Win32;

namespace sheh_polyakova_buhtoarova228
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SelectFile_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePathTextBox.Text = openFileDialog.FileName;
            }
        }
        private void SendFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var fileBytes = File.ReadAllBytes(FilePathTextBox.Text);
                var totalBytes = fileBytes.Length;
                var sentBytes = 0;
                using (var client = new TcpClient("192.168.0.100", 12345))
                using (var stream = client.GetStream())
                {
                    while (sentBytes < totalBytes)
                    {
                        var bytesToSend = Math.Min(1024, totalBytes - sentBytes); // Отправляем по 1 КБ
                        stream.Write(fileBytes, sentBytes, bytesToSend);
                        sentBytes += bytesToSend;
                        // Обновляем прогресс-бар
                        FileTransferProgressBar.Value = (double)sentBytes / totalBytes * 100;
                    }
                    FileTransferProgressBar.Value = 100; // Завершение передачи
                    MessageBox.Show("File sent successfully!");
                    FileTransferHistory.Items.Add($"Sent: {System.IO.Path.GetFileName(FilePathTextBox.Text)}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending file: {ex.Message}");
            }
        }

        private void ReceiveFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var listener = new TcpListener(IPAddress.Any, 12345);
                listener.Start();
                using (var client = listener.AcceptTcpClient())
                using (var stream = client.GetStream())
                using (var fileStream = File.Create("received_file.txt"))
                {
                    var buffer = new byte[1024];
                    int bytesRead;
                    long totalBytesRead = 0;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;
                        // Обновляем прогресс-бар
                        FileTransferProgressBar.Value = (double)totalBytesRead / (totalBytesRead + bytesRead) * 100;
                    }
                    FileTransferProgressBar.Value = 100; // Завершение приема
                    MessageBox.Show("File received successfully!");
                    FileTransferHistory.Items.Add($"Received: received_file.txt");
                }
                listener.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error receiving file: {ex.Message}");
            }
        }
    }
}