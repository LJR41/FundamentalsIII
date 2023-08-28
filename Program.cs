//--------------------------------------------------------------------------------------
static void PrintList(List<string> MyList)
{
    foreach (string name in MyList)
    {
        Console.WriteLine(name);
    }
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);


//--------------------------------------------------------------------------------------
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    for (int i = 0; i<IntList.Count;i++)
    {
        sum += IntList[i];
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
SumOfNumbers(TestIntList);


//--------------------------------------------------------------------------------------
static int FindMax(List<int> IntList)
{
    int max = 0;

    foreach (int item in IntList)
    {
        if(item > max)
        {
            max = item;
        }
    }

    return max;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));

//--------------------------------------------------------------------------------------
static List<int> SquareValues(List<int> IntList)
{
    for (int i = 0; i < IntList.Count; i ++)
    {
        IntList[i] = IntList[i] * IntList[i];
    }
    
    foreach (int value in IntList)
    {
        Console.WriteLine(value);
    }

    return IntList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);

//--------------------------------------------------------------------------------------
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if(IntArray[i]<0)
        {
            IntArray[i] = 0;
        }
    }
    foreach (int value in IntArray)
    {
        Console.WriteLine(value);
    }

    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);

//--------------------------------------------------------------------------------------

static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach (KeyValuePair<string,string> info in MyDictionary)
    {
        Console.WriteLine($"{info.Key} - {info.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

//--------------------------------------------------------------------------------------
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    foreach (KeyValuePair<string,string> info in MyDictionary)
    {
        if(info.Key == SearchTerm){
            return true;
        }
    }
    return false;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));


//--------------------------------------------------------------------------------------

// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string,int> NewDictionary =  new();
    for(int i = 0; i < Names.Count; i++)
    {
        NewDictionary.Add($"{Names[i]}", Numbers[i]);
    }

    foreach (KeyValuePair<string,int> pair in NewDictionary)
    {
        Console.WriteLine($"{pair.Key} : {pair.Value}");
    }

    return NewDictionary;
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here

List<string> MyPeople = new(){"Julie", "Harold", "James", "Monica"};
List<int> FavoriteNumber = new(){6,12,7,10};

GenerateDictionary(MyPeople,FavoriteNumber);