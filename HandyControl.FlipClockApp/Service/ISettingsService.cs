using HandyControl.FlipClockApp.Model;
using System.IO;
using System.Text.Json;

namespace HandyControl.FlipClockApp.Service
{
    public interface ISettingsService
    {
        WidgetSettings? LoadSettings();
        void SaveSettings(WidgetSettings settings);
    }

    public class JsonSettingsService : ISettingsService
    {
        private const string SettingsPath = "widget_settings.json";
        public WidgetSettings? LoadSettings()
        {
            if (!File.Exists(SettingsPath)) return null;

            var json = File.ReadAllText(SettingsPath);
            return JsonSerializer.Deserialize<WidgetSettings>(json);
        }

        public void SaveSettings(WidgetSettings settings)
        {
            var json = JsonSerializer.Serialize(settings);
            File.WriteAllText(SettingsPath, json);
        }
    }
}
