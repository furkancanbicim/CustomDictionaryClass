using MyDictionary;



MyDictionary<int, string> myDictonary = new MyDictionary<int, string>();
myDictonary.Add(0, "Kerem ÖZER");
myDictonary.Add(1, "Ali RODOPLU");
myDictonary.Add(2, "Okan BİLİR");
myDictonary.Add(3, "Sinan ERTAN");
myDictonary.Add(4, "Fukan BİÇER");
myDictonary.Add(5, "Emirhan DAĞLIOĞLU");

Console.WriteLine("Dizinin genişliği = "+myDictonary.Count);

Console.WriteLine(myDictonary[3]);

MyDictionary<string, string> myDictonary1 = new MyDictionary<string, string>();
myDictonary1.Add("Baba", "Kerem ÖZER");
myDictonary1.Add("Dayı", "Ali RODOPLU");
myDictonary1.Add("Amca", "Okan BİLİR");

Console.WriteLine("Dizinin genişliği = " + myDictonary1.Count);

Console.WriteLine(myDictonary1["Dayı"]);




