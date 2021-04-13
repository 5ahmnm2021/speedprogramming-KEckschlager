using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSwitch : MonoBehaviour
{
    public Image colorBlock;
    public Color[] color;
    public int currentColor = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchColor();
        }
    }

    public void SwitchColor()
    {
        colorBlock.color = color[currentColor];
        if (currentColor == color.Length -1) //color.Length -1 wird in diesem Fall statt 3 geschrieben, um zB. Farben hinzufügen oder wegnehmen zu können (Modular coding)
        {
            currentColor = 0;
            Debug.Log(currentColor);
        }
        else
        {
            currentColor += 1; 
        }
    }
}
