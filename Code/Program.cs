﻿// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами


string[] firstArray = new string[4] {"hello", "2", "world", ":-)"};
string[] secondArray = new string[firstArray.Length];

void ResultArray(string[] firstArray, string[] secondArray){
    int result = 0;
    for (int i = 0; i < firstArray.Length; i++){
        if(firstArray[i].Length <= 3){
        secondArray[result] = firstArray[i];
        result++;
        }
    }
}

void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ResultArray(firstArray, secondArray);
PrintArray(secondArray);



