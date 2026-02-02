using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BookStoreProblem : MonoBehaviour
{
    public int neededBookCopies = 1000;
    public float bookCoverPrice = 5.3f;

    void Start()
    {
        CaluculateProfit(neededBookCopies);
    }

    private float CalculateShipping(int amountShipped)
    {
        return amountShipped * .75f + 2.25f;
    }

    private void CaluculateProfit(int amountOrdered)
    {
        //pricing
        float fullPrice = amountOrdered * bookCoverPrice;
        float discountedPrice = fullPrice * .6f;

        //shipping
        float shippingCost = CalculateShipping(amountOrdered);

        //totals
        float totalCost = shippingCost + discountedPrice;
        float profit = fullPrice - discountedPrice - shippingCost;

        // rounding
        fullPrice = (float)Math.Round(fullPrice, 2);
        discountedPrice = (float)Math.Round(discountedPrice, 2);
        shippingCost = (float)Math.Round(shippingCost, 2);
        totalCost = (float)Math.Round(totalCost, 2);
        profit = (float)Math.Round(profit, 2);

        Debug.Log($"bought {amountOrdered} books at a discounted ${discountedPrice}, 40 % off of ${fullPrice} \n paid ${totalCost}, potentially yielding a profit of ${profit}");
    }
}