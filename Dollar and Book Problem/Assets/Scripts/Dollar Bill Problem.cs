using UnityEngine;

public class DollarBillProblem : MonoBehaviour
{
    public int startingPay = 100;
    private int[] bills = { 100, 50, 20, 10, 5, 1 };
    private string[] names = { "Hundreds", "Fifties", "Twenties", "Tens", "Fives", "Ones" };

    void Start()
    {
        GetPaid(startingPay);
    }

    private void GetPaid(int payAmount)
    {
        if (payAmount <= 0)
        {
            Debug.Log("Did not receive funds. 0 dollars paid.");
            return;
        }

        int payCalculation = payAmount;

        for (int i = 0; i < bills.Length; i++)
        {
            int billValue = bills[i];

            if (payCalculation >= billValue)
            {
                int count = payCalculation / billValue;
                payCalculation %= billValue;

                Debug.Log($"{count} {names[i]}");
            }
        }
    }
}