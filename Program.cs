// See https://aka.ms/new-console-template for more information

using System;

double p, q, a, b, cond; //dusturdaki deyishenler
a = 0;//xarici dorbucaqlinin boyuk terefi
b = 0;//xarici dordbucaqlinin kicik terefi
p = 0;//daxili dordbucaqlinin boyuk terefi
q = 0;//daxili dordbucaqlinin kicik terefi

double sideP1,sideP2, sideP3;//Paralelpipedin terefleri
sideP1 = 3;
sideP2 = 17;
sideP3 = 30;

double doorSide1, doorSide2;//Qapinin terefleri
doorSide1 = 12;
doorSide2 = 16;

//Paralelpipedin en kicik tereflerini p ve q deyishkenlerine menimsedilir
if (sideP1 >= sideP2 && sideP1 >= sideP3)
{
    p = sideP2;
    q = sideP3;
}else if (sideP2 >= sideP1 && sideP2 >= sideP3)
{
    p = sideP1;
    q = sideP3;
}else if (sideP3 >= sideP1 && sideP3 >= sideP2)
{
    p = sideP1;
    q = sideP2;
}

//p deyishkenin deyeri q den kicikdirse, q nun deyeri ile p nin deyerini deyishdiririk
double keepP = 0;
if (p < q)
{
    keepP = p;
    p = q;
    q = keepP;
}

//qapinin boyuk terefi a deyiskenine kicik terefi b deyishkenine menimsedilir
if (doorSide1 >= doorSide2)
{
    a = doorSide1;
    b = doorSide2;
}
else if (doorSide1 <= doorSide2)
{
    b = doorSide1;
    a = doorSide2;
}


//Console.Writeline(Math.Sqrt(9)); // kok alma
//Console.writeline(Math.Pow(3, 2)); // kvadrata yukseltme

double pS, qS, aS;// p,q,a deyishkenlerinin kvadratlari
pS = Math.Pow(p, 2);
qS = Math.Pow(q, 2);
aS = Math.Pow(a, 2);

//bir duzbucaqlinin diger duzbucaqlinin ichinden kechme sherti https://www.jstor.org/stable/2691523 
cond = (2 * p * q * a + (pS - qS) * (Math.Sqrt(pS + qS -aS))) / (pS + qS);// linkdeki shert (dustur)
//Console.WriteLine(cond);

if (p <= a && q <= b)
{
    Console.WriteLine("Qapidan kecir");
}
else if (p > a && b >= cond)
{
    Console.WriteLine("Qapidan kecir");
}
else
{
    Console.WriteLine("Qapidan kechmir");
}
