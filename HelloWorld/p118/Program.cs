﻿/*
[해시테이블 정렬 예제]
HashTable은 입력한 순서대로 또는 정렬되어 값이 출력되지 않도록 설계되었다.
그래서 키값으로 정렬을 하려면 SortedList를 이용하면 된다.
*/

using System;
using System.Collections;
class Example
{
    public static void Main()
    {
        Hashtable onj = new Hashtable();
        onj.Add("김길동", "서울");
        onj.Add("홍길동", "광주");
        onj.Add("박길동", "부산");
        try
        {
            onj.Add("김길동", "서울");
        }
        catch
        {
            Console.WriteLine("키값 중복...");
        }
        Console.WriteLine("For key = \"name\", value = {0}.", onj["홍길동"]);
        onj["박길동"] = "제주";
        Console.WriteLine("For key = \"name\", value = {0}.", onj["박길동"]);
        if (!onj.ContainsKey("최길동"))
        {
            onj.Add("최길동", "하와이");
            Console.WriteLine("Value added for key = \"who\": {0}", onj["최길동"]);
        }
        Console.WriteLine();
        //출력순서를 확인하자.(입력된 순서로 나오는 것은 아님)
        foreach (DictionaryEntry d in onj)
        {
            Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
        }
        SortedList s = new SortedList(onj); //해시테이블 정렬하기위해 SoretedList에 넣음

        foreach (DictionaryEntry d in s) //키값이 정렬된 형식으로 출력
        {
            Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
        }
    }
}