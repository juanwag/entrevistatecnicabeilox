using System;
using StringEncriptionAlgorithms;

string text = "abcdefghijklmnopqrstuvwkyz1234567890";

// StringRevert stringRevert = new();

/*Func<int, int> encryptionFunction = (int asciiCode) => asciiCode < 127 ? asciiCode + 1 : 0;
Func<int, int> decryptionFunction = (int asciiCode) => asciiCode > 0 ? asciiCode - 1 : 127;

CustomAlgorithm customAlgorithm = new CustomAlgorithm(encryptionFunction, decryptionFunction);*/

MyAlgorithm algo = new();
string encrypted = algo.Encrypt(text);
Console.WriteLine(encrypted);
string decrypted = algo.Decrypt(encrypted);
Console.WriteLine(decrypted);