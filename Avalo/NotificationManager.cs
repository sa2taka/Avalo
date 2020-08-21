using Windows.UI.Notifications;

namespace Avalo {
    class NotificationManager {
        public static void notificate(string title, string text, string imagePath) {
            var tmpl = ToastTemplateType.ToastImageAndText02;
            var xml = ToastNotificationManager.GetTemplateContent(tmpl);

            var images = xml.GetElementsByTagName("image");
            var src = images[0].Attributes.GetNamedItem("src");
            src.InnerText = "file:///" + imagePath;

            var texts = xml.GetElementsByTagName("text");
            texts[0].AppendChild(xml.CreateTextNode(title));
            texts[1].AppendChild(xml.CreateTextNode(text));

            var toast = new ToastNotification(xml);

            ToastNotificationManager.CreateToastNotifier("Avalo").Show(toast);
        }
    }
}
