using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn : MonoBehaviour
{
    public static bool isWhiteTurn = true;
    public static int counter = 1;
    public Text turnText;
    public void printTurn()
    {
        counter++;
        if (gameObject.tag == "White")
        {
            isWhiteTurn = false;
            turnText.text = "Turn "+counter+ ": Black";
        }
        if(gameObject.tag == "Black")
        {
            isWhiteTurn = true;
            turnText.text = "Turn " + counter + ": White";
        }   
    }

}
