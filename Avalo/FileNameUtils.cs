using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Avalo {
    public class FileNameUtils {
        public static Dictionary<string, int> sequenceNumbers;

        public static void setSeuquenceNumbers(Dictionary<string, int> sn) {
            sequenceNumbers = sn;
        }

        public static string exchangeFolderName(string folderNameRule) {
            var rule = folderNameRule;
            Regex rx = new Regex(@"<(?<rule>[^<>]+?)>", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var matches = rx.Matches(folderNameRule);

            foreach (Match match in matches) {
                var groups = match.Groups;
                var ruleString = groups["rule"].Value;
                if(ruleString.Equals("sn")) {
                    continue;
                }
                var exchanged = exchangeRule(ruleString, "");
                rule = rule.Replace(match.Value, exchanged);
            }
            return rule;
        }

        public static string exchangeFileName(string fileNameRule, string path) {
            var rule = fileNameRule;
            Regex rx = new Regex(@"<(?<rule>[^<>]+?)>", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var matches = rx.Matches(fileNameRule);

            foreach (Match match in matches) {
                var groups = match.Groups;
                var ruleString = groups["rule"].Value;
                var exchanged = exchangeRule(ruleString, path);
                rule = rule.Replace(match.Value, exchanged);
            }
            return rule;
        }


        private static string exchangeRule(string ruleString, string folderPath) {
            if (ruleString.Equals("host")) {
                return System.Net.Dns.GetHostName();
            } else if (ruleString.Equals("sn")) {
                var fileCount = Directory.GetFiles(folderPath, "*.png", SearchOption.TopDirectoryOnly).Length;
                return (fileCount + 1).ToString();
            } else {
                var now = DateTime.Now;
                return now.ToString(ruleString);
            }
        }
    }
}
