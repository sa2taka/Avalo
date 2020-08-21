using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Avalo {
    class CaptureManager {
        private static Boolean isMainPushed = false;
        private static string configFilePath = Directory.GetCurrentDirectory() + "\\config.json";
        public static string path = "";
        public static string directoryNameRule = "<host>-<yyyyMMdd>";
        public static string fileNameRule = "<sn>.png";

        public static void start() {
            initialize();
            setKeyLoggerTimer();
        }

        public static void save() {
            var config = new Config(path, directoryNameRule, fileNameRule);
            var text = JsonSerializer.Serialize(config);
            File.WriteAllText(configFilePath, text);
        }

        private static void initialize() {
            if (File.Exists(configFilePath)) {
                var text = File.ReadAllText(configFilePath);
                var config = JsonSerializer.Deserialize<Config>(text);
                path = config.path;
                directoryNameRule = config.directoryNameRule;
                fileNameRule = config.fileNameRule;
            }
            var savePath = path;
            if (path.Equals(String.Empty)) {
                savePath = Directory.GetCurrentDirectory();
            }
            var dir = FileNameUtils.exchangeFolderName(directoryNameRule);
            if (!dir.Equals(String.Empty)) {
                savePath += "\\" + dir;
            }
            if (!Directory.Exists(savePath)) {
                Directory.CreateDirectory(savePath);
            }
        }

        private static void setKeyLoggerTimer() {
            var timer = new System.Timers.Timer(33);
            timer.Elapsed += keyLoggerTick;
            timer.Start();
        }

        private static void keyLoggerTick(object sender, EventArgs e) {
            var mainState = KeyLogger.IsKeyLocked(Keys.Q);
            var ctrlState = KeyLogger.IsKeyLocked(Keys.ControlKey);
            var shiftState = KeyLogger.IsKeyLocked(Keys.ShiftKey);

            if (mainState) {
                if (!isMainPushed) {
                    if (ctrlState && shiftState) {
                        isMainPushed = true;
                        var bmp = Capture.CaptureScreen();
                        savePng(bmp);
                    } else if(ctrlState) {
                        isMainPushed = true;
                        var bmp = Capture.CaptureActiveWindow();
                        savePng(bmp);
                    }
                   
                }
            } else {
                isMainPushed = false;
            }
        }

        private static void savePng(Bitmap bmp) {
            var savePath = path;
            if (path.Equals(String.Empty)) {
                savePath = Directory.GetCurrentDirectory();
            }
            var dir = FileNameUtils.exchangeFolderName(directoryNameRule);
            if(!dir.Equals(String.Empty)) {
                savePath += "\\" + dir;
            }
            if(!Directory.Exists(savePath)) {
                Directory.CreateDirectory(savePath);
            }
            var filename = FileNameUtils.exchangeFileName(fileNameRule, savePath);
            savePath += "\\" + filename;
            bmp.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
            NotificationManager.notificate("Avalo", filename + "を保存しました", savePath);
        }
    }

    class Config {
        public string path { get; set; }
        public string directoryNameRule { get; set; }
        public string fileNameRule { get; set; }

        public Config() {

        }

        public Config(string path, string directoryNameRule, string fileNameRule) {
            this.path = path;
            this.directoryNameRule = directoryNameRule;
            this.fileNameRule = fileNameRule;
        }
    }
}
