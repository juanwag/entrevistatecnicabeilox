using System.Linq;
using System.Text;

namespace StringEncryptionAlgorithmsLibrary {
    public class MyAlgorithm : ISecurityElement {
        public string Encrypt(string text) {
            string firstEncryption = EncryptHelper(text, 0);
            char[] secondEncryption = firstEncryption.Select(x => ++x).ToArray();
            return new string(secondEncryption);
        }

        private string EncryptHelper(string text, int index) {
            int textLength = text.Length;

            if (index > textLength - 1) {
                return text;
            }

            StringBuilder sb = new(text);
            sb[index]++;

            int newIndex = index + 1;
            
            return EncryptHelper(sb.ToString(), newIndex);
        }

        public string Decrypt(string text) {
            char[] firstDecryption = text.Select(x => --x).ToArray();
            string newText = new string(firstDecryption);
            return DecryptHelper(newText, newText.Length - 1);
        }
        
        private string DecryptHelper(string text, int index) {
            if (index < 0) {
                return text;
            }

            StringBuilder sb = new(text);
            sb[index]--;

            int newIndex = index - 1;
            
            return DecryptHelper(sb.ToString(), newIndex);
        }
    }
}