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
            currentApp = new App();
            currentProfile = currentApp.ProfileList[0];
            LoadApp();
        }

        private BindingList<App> apps = new BindingList<App>();
        private App currentApp;
        private Profile currentProfile;

        private void LoadApp()
        {
            currentApp = App.LoadFromFile(Services.APP_FILENAME);
        }

        private void saveAppSettings()
        {
            currentApp.SaveToFile(Services.APP_FILENAME);
        }


        private void formMain_Load(object sender, EventArgs e)
        {
            InitUI();
        }

        private void InitUI()
        {
            comboBoxApp.DataSource = apps;
            comboBoxApp.DisplayMember = "Name";
            comboBoxApp.ValueMember = "Name";
            comboBoxApp.SelectedIndex = 0;

            setCurrentApp();

            comboBoxProfile.DataSource = currentApp.ProfileList;
            comboBoxProfile.DisplayMember = "Name";
            comboBoxProfile.ValueMember = "Name";
            comboBoxProfile.SelectedIndex = 0;

            setCurrentProfile();

        }

        private void setCurrentApp()
        {
            currentApp = apps[comboBoxApp.SelectedIndex];
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
            var state = $"Запускаем приложение{currentProfile.Name}...\n";
            stateTextBox.AppendText(state);
            Application.DoEvents();
            if (Services.RunApp(currentProfile)) state = $"Приложение {currentProfile.Name} успешно запущено.\n"; else state = $"Ошибка запуска приложения {currentProfile.Name}.\n";
            stateTextBox.AppendText(state);
            state = "Готов к работе.\n";
            stateTextBox.AppendText(state);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            //var settings = new Settings();
            //settings.Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveAppSettings();
        }

        private void comboBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCurrentProfile();
        }
    }
}
