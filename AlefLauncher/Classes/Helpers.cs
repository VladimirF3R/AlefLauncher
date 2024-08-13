using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;

namespace AlefLauncher.Classes.Helpers
{

    public class FSHelper
    {
        public static string CreateDirectoryInUserFolder(string folderName)
        {
            // Получаем путь к папке текущего пользователя
            string userFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            // Создаем полный путь к новой директории
            string newFolderPath = Path.Combine(userFolderPath, folderName);

            // Создаем директорию, если она не существует
            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);
            }

            // Возвращаем абсолютный путь до созданной папки
            return newFolderPath;
        }

        public static List<string> CopyNewOrUpdatedFiles(string destFolder, string srcFolder)
        {
            List<string> copiedFiles = new List<string>();

            // Получаем список файлов в папках
            var filesInDestination = Directory.GetFiles(destFolder);
            var filesInSource = Directory.GetFiles(srcFolder);

            foreach (var fileSource in filesInSource)
            {
                var fileName = Path.GetFileName(fileSource);
                var destinationFile = Path.Combine(destFolder, fileName);

                // Проверяем, существует ли файл в папке destFolder и является ли он более старым, чем файл в папке srcFolder
                //if (!File.Exists(destinationFile) || File.GetLastWriteTime(fileSource) > File.GetLastWriteTime(destinationFile))
                if (!File.Exists(destinationFile) || CalculateFileHash(fileSource) != CalculateFileHash(destinationFile))
                {
                    // Копируем файл из папки srcFolder в папку destFolder
                    File.Copy(fileSource, destinationFile, true);
                    copiedFiles.Add(destinationFile);
                }
            }

            return copiedFiles;
        }

        public static string CalculateFileHash(string filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var fileStream = File.OpenRead(filePath))
                {
                    var hashBytes = sha256.ComputeHash(fileStream);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        public static string RunExternalProcess(string filePath)
        {
            try
            {
                // Создаем новый процесс
                Process process = new Process();
                process.StartInfo.FileName = filePath;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;

                // Запускаем процесс
                process.Start();
                //process.WaitForExit();

                // Проверяем код завершения процесса
                /*
                if (process.ExitCode == 0)
                {
                    return filePath;
                }
                else
                {
                    return $"Процесс завершился с ошибкой. Код завершения: {process.ExitCode}";
                }
                */
                return filePath;
            }
            catch (Exception ex)
            {
                return $"Ошибка при запуске процесса: {ex.Message}";
            }
        }
    }

}
