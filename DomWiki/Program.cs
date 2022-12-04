﻿// See https://aka.ms/new-console-template for more information
using System.Text;
using DomWiki;
using static DomWik.Handex;

print("Hello, World!");
Handex storage = new Handex(8);
print(storage.BitWidth + ", " + storage.Count);
list<ulong> addr = new List<ulong>();
for each (string s {"hello", "world", "string"}){
    addr.Add(storage.Add(s));
}
print("count: " + storage.Count);

for each (ulong a in addr){
    print (a);
};

print("addr of 'world': " + storage.Find("world"));
print("addr of 'name': " + storage.Find("name"));

// uint[] hash(object o) => ComputeHash(o);

void print(object s){
    Console.WriteLine((s is null) ? "null" : s.ToString());
}