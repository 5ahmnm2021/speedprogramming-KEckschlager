using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public Text sum;
    public Text errorInput1;
    public Text errorInput2;
    private bool num1 = true;
    private bool num2 = true;

    public void Addition()
    {
        int input1Int = 0;
        int input2Int = 0;
        string errorMsg = "enter number";

        try
        {
            input1Int = int.Parse(input1.text);
            input1.image.color = Color.white;
            num1 = true;
        }
        catch (System.Exception)
        {
            input1.image.color = Color.red;
            input1.text = "";
            errorInput1.text = errorMsg;
            num1 = false;
        }
        try
        {
            input2Int = int.Parse(input2.text);
            input2.image.color = Color.white;
            num2 = true;
        }
        catch (System.Exception)
        {
            input2.image.color = Color.red;
            input2.text = "";
            errorInput2.text = errorMsg;
            num2 = false;
        }

        Debug.Log(num1 + "," + num2);
        Debug.Log(input1Int + "," + input2Int);

        if (num1 && num2)
        {
            int sumInt = input1Int + input2Int;
            sum.text = sumInt.ToString();
            Debug.Log("Die Addition ergibt: " + sum.text);
        }
    }
}