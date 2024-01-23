namespace SharedLib;

public class QDataService
{
    public string GiveRandomNumber()
    {
        int randomValue = Random.Shared.Next(1,100);
        return $"The value is {randomValue}";
    }







    
}