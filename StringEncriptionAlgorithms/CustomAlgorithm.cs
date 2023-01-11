using System;
using System.Text;

namespace StringEncriptionAlgorithms {
    public class CustomAlgorithm : ISecurityElement {
        private Func<int, int> _encryptionFunction;
        private Func<int, int> _decryptionFunction;
        
        public CustomAlgorithm(Func<int, int> encryptionFunction, Func<int, int> decryptionFunction) {
            _encryptionFunction = encryptionFunction;
            _decryptionFunction = decryptionFunction;
        }

        public string Encrypt(string text) {
            return ApplyFunction(text, _encryptionFunction);
        }

        private string ApplyFunction(string text, Func<int, int> function) {
            int textLength = text.Length;

            char[] encryptedChars = new char[textLength];
            for (int i = 0; i < textLength; i++) {
                int asciiChar = (int) text[i];

                encryptedChars[i] = (char) function(asciiChar);
            }

            return new string(encryptedChars);
        }

        public string Decrypt(string text) {
            return ApplyFunction(text, _decryptionFunction);
        }
    }
}