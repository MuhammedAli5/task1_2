#region 1) 1 - dən M - ədək ədədlər içərisində 21-ə bölünən ədədlərin ədədi ortasını tapan alqoritm

/*int M = int.Parse(Console.ReadLine());
int count = 0;
int sum = 0;
for(int i = 1; i <=M; i++)
{
    if (i % 21 == 0)
    {
        count++;
        sum += i;
    }
}
Console.WriteLine(sum/count);*/
#endregion

#region 2) 2 ədəd verilmişdir. Daxil Edilən Ədədlərdə Daxil Olmaqla Bu Ədədlərin Aralığında Olan Ədədlərin cəmin Tapan Alqoritm Qurun.

/*Console.WriteLine("num-1 ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("num-2 ");
int num1 = int.Parse(Console.ReadLine());
int sum = 0;
for (num = 0; num <= num1; num++)
{
    sum += num;
}
Console.WriteLine(sum);*/
#endregion

#region 3) Verilmiş M-dən N-ədək ədədlər içərisində neçə ədədin rəqəmləri cəminin cüt olduğunu tapan alqoritm

/*Console.WriteLine("1-: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("2-: ");
int num1 = int.Parse(Console.ReadLine());
int cut_cem = 0;
for (num = 0; num <= num1; num++)
{
    if (num % 2 == 0)
    {
        cut_cem += num;
    }
}
Console.WriteLine(cut_cem);*/
#endregion

//*************************************************************************************************************************************

#region 1. Verilmiş 3 ədəddən neçəsinin tək olduğunu tapan alqoritim
/* int[] num = new int[3];

 num [0] = 10;
 num [1] = 11;
 num [2] = 9;


 for (int i = 0; i < num.Length; i++)
 {
     if(!(num[i]%2==0)){
      Console.WriteLine("tek: "+num[i]);
     }
 }*/
#endregion

#region 2. Verilmiş 4 ədəddən tek olanlarının cəmini tapan alqoritm
/*int[] num = new int[4];
int tek_cem = 0;

num[0] = 10;
num[1] = 11;
num[2] = 10;
num[3] = 5;
for (int i = 0; i < num.Length; i++)
{
    if (!(num[i] % 2 == 0))
    {
        tek_cem += num[i];
    }
}
Console.WriteLine(tek_cem);*/
#endregion

#region 3. Verilmiş 3 ədəddən ən böyüyünü tapan alqoritm
int num = int.Parse(Console.ReadLine());
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num > num1 && num > num2)
{
    Console.WriteLine(num);
}
else if (num1 > num2 && num1 > num2)
{
    Console.WriteLine(num1);
}
else
{
 Console.WriteLine(num2);
}
#endregion
