
class List {
  public static int Sum(List<int> myList)
  {
    HashSet<int> uniqueInt = new HashSet<int>();
    int sum = 0;
    foreach (int num in myList)
    {
      if (!uniqueInt.Contains(num))
      {
        unique.Add(num);
        sum += num;
      }
    }
    return sum;
  }
}

