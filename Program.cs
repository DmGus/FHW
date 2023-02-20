
string[] strArray = GetStringArray ("Ввеедите слова через запятую: ", ',');
string[] newStrArray = ChoosingWordsOfLength(strArray, 4);
PrintStringArray(strArray);
Console.Write(" -> ");
PrintStringArray(newStrArray);


// METHODS

// Get String Array 
string[] GetStringArray(string message, char separator)
{
    Console.Write("Ввеедите слова через запятую: ");
    string text = Console.ReadLine();
    string[] newStringArray = text.Split(separator);
    return newStringArray;
}

// Print String Array
void PrintStringArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write(array[i] + ",");
        else System.Console.Write(array[i]);
    }
    System.Console.Write("]");
}

// main method - Choosing Words Of Length
string[] ChoosingWordsOfLength(string[] StringArray, int wordLength)
{
    int count=0;
    for (int i = 0; i < StringArray.Length; i++)
    {
        if (StringArray[i].Length<wordLength)
        {
            count++;
        }
    }
    
    int j=0;
    string[] newStringArray = new string [count];
    for (int i = 0; i < StringArray.Length; i++)
    {
        if (StringArray[i].Length<wordLength)
        {
            newStringArray[j]=StringArray[i];
            j++;
        }
    }
    return newStringArray;
}