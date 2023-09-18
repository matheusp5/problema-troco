
using TrocoProblem;

Console.Clear();

Console.Write("Informe o valor do produto: ");
decimal p = decimal.Parse(Console.ReadLine());


Console.Write("Informe o valor que o consumidor lhe deu: ");
decimal c = decimal.Parse(Console.ReadLine());

decimal v = c - p;


Money[] moneyList = {
    new(100),
    new(50),
    new(20),
    new(10),
    new(5),
    new(2)
};
Money[] coinList = {
    new(1),
    new(0.50m),
    new(0.25m),
    new(0.10m),
    new(0.01m)
};

while (v != 0)
{
    for (int k = 0; k < moneyList.Length; k++)
    {
        if (v - moneyList[k].Value >= 0)
        {
            moneyList[k].UsedTimes++;
            v -= moneyList[k].Value;
            k = 0;
        }
    }
    
    for (int k = 0; k < coinList.Length; k++)
    {
        if (v - coinList[k].Value >= 0)
        {
            coinList[k].UsedTimes++;
            v -= coinList[k].Value;
            k = 0;
        }
    }

    Console.WriteLine();
    foreach (var money in moneyList)
    {
        if (money.UsedTimes != 0)
        {
            if(money.UsedTimes == 1)
            {
                Console.WriteLine($"Cédula de {money.Value} reais: uma vez");
            } else
            {
                Console.WriteLine($"Cédula de {money.Value} reais: {money.UsedTimes} vezes");
            }
            
        }
    }
    
    foreach (var coin in coinList)
    {
        if (coin.UsedTimes != 0)
        {
            if(coin.UsedTimes == 1)
            {
                Console.WriteLine($"Moeda de {coin.Value} centavos: uma vez");
            } else
            {
                Console.WriteLine($"Moeda de {coin.Value} centavos: {coin.UsedTimes} vezes");
            }
            
        }
    }
}