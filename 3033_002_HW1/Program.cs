// MIS 3033 HW1
// Task 1
// Braden Fisher 113492081

const double cogPriceDbl = 79.99;
const double gearPriceDbl = 250.00;
const double normalMarkupDbl = 015;
const double discountMarkupDbl = 0125;
const double salesTaxRateDbl = 0.089;

int numOfCogs;
int numOfGears;

double normalSubtotalDbl;

double actualsubTotalDBL;
double discountAmountDbl;
double salesTaxAmountDbl;
double grandTotal;

double actualMarkupDbl;

string outMesStr = "Please input the number of cogs";
Console.WriteLine(outMesStr);
string inputStr = Console.ReadLine();
numOfCogs = Convert.ToInt32(inputStr);

outMesStr = "Please input the number of gears";
Console.WriteLine(outMesStr);
inputStr = Console.ReadLine();
numOfGears = Convert.ToInt32(inputStr);

if (numOfCogs > 10 || numOfGears > 10 || numOfCogs + numOfGears > 16)
{
    actualMarkupDbl = 0.125;
}
else
{
    actualMarkupDbl = 0.15;
}

normalSubtotalDbl = (numOfCogs * cogPriceDbl + numOfGears * gearPriceDbl) * (1 + normalMarkupDbl);
actualsubTotalDBL = (numOfCogs * cogPriceDbl + numOfGears * gearPriceDbl) * (1 + actualMarkupDbl);

discountAmountDbl = normalSubtotalDbl - actualsubTotalDBL;
salesTaxAmountDbl = actualsubTotalDBL * salesTaxRateDbl;
grandTotal = actualsubTotalDBL + salesTaxAmountDbl;

outMesStr = "Receipt:";
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Num. of Cogs: {numOfCogs}");
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Num. of Gears: {numOfGears}");
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Subtotal: {actualsubTotalDBL:C2}");
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Discount: {discountAmountDbl:C2}");
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Sales Tax: {salesTaxAmountDbl:C2}");
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Grand Total: {grandTotal:C2}");
Console.WriteLine(outMesStr);

Console.ReadLine();
