using AlefLauncher.Classes;
using System.ComponentModel;
using System.Text.Json;
using static System.Windows.Forms.AxHost;

namespace AlefLauncher
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            LoadApp();
        }

        private List<App> appList = new List<App>();
        private App currentApp;
        private Profile currentProfile;

        private void LoadApp()
        {
            appList = App.LoadFromFile(Services.APP_FILENAME);
            currentApp = appList[0];
            currentProfile = currentApp.ProfileList[0];
        }

        private void saveAppSettings()
        {
            App.SaveToFile(Services.APP_FILENAME, appList);
        }


        private void formMain_Load(object sender, EventArgs e)
        {
            InitUI();
        }

        private void InitUI()
        {
            comboBoxApp.DataSource = appList;
            comboBoxApp.DisplayMember = "Name";
            comboBoxApp.ValueMember = "Name";
            comboBoxApp.SelectedIndex = 0;

            setCurrentApp();

            comboBoxProfile.DataSource = currentApp.ProfileList;
            comboBoxProfile.DisplayMember = "Name";
            comboBoxProfile.ValueMember = "Name";
            comboBoxProfile.SelectedIndex = 0;

            setCurrentProfile();

            AddToLog("Приложение стартовало.");

        }

        private void setCurrentApp()
        {
            currentApp = appList[comboBoxApp.SelectedIndex];
            labelAppDescription.Text = currentApp.Description;
        }

        private void setCurrentProfile()
        {
            currentProfile = currentApp.ProfileList[comboBoxProfile.SelectedIndex];
            labelProfileDescription.Text = $"{currentProfile.Description} Версия: {currentProfile.Version}";
        }

        private void comboBoxApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCurrentApp();
            comboBoxProfile.DataSource = currentApp.ProfileList;
            comboBoxProfile.DisplayMember = "Name";
            comboBoxProfile.ValueMember = "Name";
            comboBoxProfile.SelectedIndex = 0;
            setCurrentProfile();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            AddToLog($"Запускаем приложение{currentProfile.Name}...");
            if (Services.RunApp(currentProfile)) AddToLog($"Приложение {currentProfile.Name} успешно запущено."); 
            else AddToLog($"Ошибка запуска приложения {currentProfile.Name}.");
        }
        private void comboBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCurrentProfile();
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            AddToLog($"Сохранение настроек в файл {Services.APP_FILENAME}");
            App.SaveToFile(Services.APP_FILENAME, appList);
            AddToLog("Сохранение завершено");
        }

        private void loadSettingsButton_Click(object sender, EventArgs e)
        {
            AddToLog($"Загрузка настроек из файла {Services.APP_FILENAME}");
            appList = App.LoadFromFile(Services.APP_FILENAME);
            AddToLog("Загрузка завершена");
        }

        private void AddToLog(string message, bool saveToFile = false)
        {
            var line = $"{DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss ")}{message}";
            stateTextBox.AppendText($"{line}\n");
            Services.SaveLog(line);
            Application.DoEvents();
        }
    }
}
