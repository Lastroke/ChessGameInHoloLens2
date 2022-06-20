using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeQueen : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("White Pawn"))
        {
            Destroy(other.gameObject);
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Turn.isWhiteTurn = false;
        }
        if (other.name.Contains("Black Pawn"))
        {
            Destroy(other.gameObject);
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Turn.isWhiteTurn = true;
        }
    }
}
