using System.Collections;
using System.Text.Json;
using System.IO;

// HEX DUMP PRACTICE ///////////////////

int intValue = 48769414;
string stringValue = "Hello!";
byte[] byteArray = { 47, 129, 0, 116 };
float floatValue = 491.695F;
char charValue = 'E';

using (var output = File.Create("binarydata.dat"))
using (var writer = new BinaryWriter(output))
{
    writer.Write(intValue);
    writer.Write(stringValue);
    writer.Write(byteArray);
    writer.Write(floatValue);
    writer.Write(charValue);
}
//File.WriteAllText("textdata.txt", "Elementary, my dear Watson!");

using (Stream input = File.OpenRead("binarydata.dat"))
{
    var position = 0;
    var buffer = new byte[16];
    while (true)
    {
        
        var bytesRead = input.Read(buffer, 0, buffer.Length);
        if (bytesRead == 0) return;

        Console.Write("{0:x4}: ", position);
        position += bytesRead;

        for (var i = 0; i < 16; i++)
        {
            if (i < bytesRead)
            {
                Console.Write("{0:x2} ", (byte)buffer[i]);
            } else
            {
                Console.Write("   ");
            }
            if (i == 7) Console.Write("-- ");
        }

        for (int i = 0; i < bytesRead; i++)
        {
            Console.Write((char)buffer[i]);
        }
        Console.WriteLine();
    }
}



// WRITE AND READ BINARY DATA ///////////////////
//using (var input = File.OpenRead("binarydata.dat"))
//using (var reader = new BinaryReader(input))
//{
//    int intRead = reader.ReadInt32();
//    string stringRead = reader.ReadString();
//    byte[] byteArrayRead = reader.ReadBytes(4);
//    float floatRead = reader.ReadSingle();
//    char charRead = reader.ReadChar();

//    Console.Write("int: {0} string: {1} bytes: ", intRead, stringRead);
//    foreach (byte b in byteArrayRead)
//        Console.Write("{0} ", b);
//    Console.Write(" float: {0} char: {1} ", floatRead, charRead);
//}
//int intValue = 48769414;
//string stringValue = "Hello!";
//byte[] byteArray = { 47, 129, 0, 116 };
//float floatValue = 491.695F;
//char charValue = 'E';

//using (var output = File.Create("binarydata.dat"))
//using (var writer = new BinaryWriter(output))
//{
//    writer.Write(intValue);
//    writer.Write(stringValue);
//    writer.Write(byteArray);
//    writer.Write(floatValue);
//    writer.Write(charValue);
//}

//byte[] dataWritten = File.ReadAllBytes("binarydata.dat");
//foreach (byte b in dataWritten)
//    Console.Write("{0:x2} ", b);
// WRITE AND READ BINARY DATA ///////////////////




//Console.WriteLine(" - {0} bytes", dataWritten.Length);
//IEnumerable<string> SimpleEnumerable()
//{
//    yield return "apples";
//    yield return "oranges";
//    yield return "bananas";
//    yield return "unicorns";
//}

//foreach (var s in SimpleEnumerable()) Console.WriteLine(s);


//var sports = new ManualSportSequence();
//foreach (var sport in sports)
//    Console.WriteLine(sport);



//enum Sport {  Football, Basketball, Baseball, Hockey, Boxing, Rugby, Fencing }


//class ManualSportSequence : IEnumerable<Sport>
//{
//    public IEnumerator<Sport> GetEnumerator()
//    {
//        return new ManualSportEnumerator();
//    }

//    IEnumerator<Sport> IEnumerable<Sport>.GetEnumerator()
//    {
//        throw new NotImplementedException();
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }
//}

//class ManualSportEnumerator : IEnumerator<Sport>
//{
//    int current = -1;
//    public Sport Current => (Sport)current;

//    public void Dispose() { }
//    object IEnumerator.Current => Current;

//    public bool MoveNext()
//    {
//        var maxEnumValue = Enum.GetValues(typeof(Sport)).Length;
//        if ((int)current >= maxEnumValue - 1)
//            return false;
//        current++;
//        return true;
//    }
//    public void Reset() => current = 0;
//}

