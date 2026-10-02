using System; using System.Windows.Forms; using AshkanLMS.Core; using AshkanLMS.UI;
namespace AshkanLMS { static class Program { [STAThread] static void Main(){Application.EnableVisualStyles();Application.SetCompatibleTextRenderingDefault(false);Localization.Load();Application.Run(new LoginForm());} } }
