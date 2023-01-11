using System;
using StringCryptLibrary;
using StringEncryptionAlgorithmsLibrary;

string text = "abcdefghijklmnopqrstuvwkyz ABCDEFGHIJKLMNOPQRSTUVWXYZ 1234567890";

StringCrypt stringCrypt = new(text);

// Algoritmo de reversión del texto
StringRevert stringRevert = new();

// Algoritmo que recibe funciones mediante inyección
Func<int, int> encryptionFunction = (int asciiCode) => asciiCode < 255 ? asciiCode + 1 : 0;
Func<int, int> decryptionFunction = (int asciiCode) => asciiCode > 0 ? asciiCode - 1 : 255;
CustomAlgorithm customAlgorithm = new CustomAlgorithm(encryptionFunction, decryptionFunction);

// Algoritmo con recursividad y LINQ
MyAlgorithm myAlgorithm = new();

// Test
stringCrypt.Encrypt(stringRevert);
stringCrypt.Encrypt(customAlgorithm);
stringCrypt.Encrypt(myAlgorithm);
Console.WriteLine(stringCrypt.GetText());

stringCrypt.Decrypt();
Console.WriteLine(stringCrypt.GetText());