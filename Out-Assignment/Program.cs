class temp1
{
    public static int a;

    public void m1(out int a)
    {
        Thread.Sleep(3000);
        a = 10;
        Console.WriteLine("After Assigning the Value in the Method : " + a);
    }

    static void Main(string[] args)
    {
        temp1 obj = new temp1();
        Thread t = new Thread(() => obj.m1(out a));
        t.Start();
        Console.WriteLine("Before Assigning the Value : " + a);
    }

}
