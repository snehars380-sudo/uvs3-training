namespace StudentManagementApp

    public partial class App : Application
    
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell(); // ✅ Important line
        }
    
