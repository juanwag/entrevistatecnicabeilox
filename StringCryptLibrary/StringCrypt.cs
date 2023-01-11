using System.Collections.Generic;
using System.Linq;
using StringEncryptionAlgorithmsLibrary;

namespace StringCryptLibrary {
    public class StringCrypt {
        private readonly Stack<ISecurityElement> _algorithms = new();
        private string _text;

        public StringCrypt(string text) {
            _text = text;
        }

        public void Encrypt(ISecurityElement algorithm) {
            _algorithms.Push(algorithm);
            _text = algorithm.Encrypt(_text);
        }

        public void Decrypt() {
            while (_algorithms.Any()) {
                ISecurityElement algorithm = _algorithms.Pop();
                _text = algorithm.Decrypt(_text);    
            }
        }

        public string GetText() {
            return _text;
        }
    }    
}