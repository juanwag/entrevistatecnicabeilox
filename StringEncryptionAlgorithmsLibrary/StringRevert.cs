using System.Linq;

namespace StringEncryptionAlgorithmsLibrary {
    public class StringRevert : ISecurityElement {
        public string Encrypt(string text) {
            return RevertString(text);
        }

        private static string RevertString(string text) {
            int textLength = text.Length;

            if (textLength <= 1) {
                return text;
            }

            char[] characters = new char[text.Length];

            int lastIndex = textLength - 1;

            for (int i = textLength - 1; i >= 0; i--) {
                int j = lastIndex - i;
                characters[j] = text[i];
            }

            return new string(characters);
        }

        public string Decrypt(string text) {
            return RevertString(text);
        }
    }
}