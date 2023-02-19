using System.Globalization;

DateTime dt = DateTime.Now; //現在時間

for (int j = 0; j <= 9; j++)
{
    Random rand = new Random(Guid.NewGuid().GetHashCode()); //亂數設定
    List<int> listLinq = new List<int>(Enumerable.Range(1, 49));//亂數範圍
    listLinq = listLinq.OrderBy(num => rand.Next()).ToList<int>();

    Console.Write("【" + dt.ToString("yyyy-MM-dd dddd", new CultureInfo("zh-TW")) + "】");

    for (int i = 0; i < 6; i++)
    {
        if (listLinq[i] < 10)
        {
            Console.Write("0" + listLinq[i].ToString() + " ");
        }
        else
        {
            Console.Write(listLinq[i].ToString() + " ");
        }
    }
    if (listLinq[6] < 10)
    {
        Console.WriteLine("S:0" + listLinq[6].ToString() + " ");
    }
    else
    {
        Console.WriteLine("S:" + listLinq[6].ToString());
    }
    dt = dt.AddDays(-1);
}