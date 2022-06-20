using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TasYeme : MonoBehaviour
{
    public GameManager gm;
    public Text lostPiecesWhite;
    public Text lostPiecesBlack;
    public static List<string> piecesWhite = new List<string>();
    public static List<string> piecesBlack = new List<string>();
    private void Start()
    {
        if(!piecesWhite.Contains("Lost White Pieces"))
        {
            piecesWhite.Add("Lost White Pieces");
        }
        if (!piecesBlack.Contains("Lost Black Pieces"))
        {
            piecesBlack.Add("Lost Black Pieces");
        } 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (Turn.isWhiteTurn && collision.gameObject.tag == "Black")
        {
            var temp = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            transform.position = temp;
            if(collision.gameObject.name == "Black King")
            {
                gm.resetGame();
            }
            piecesBlack.Add(collision.gameObject.name);
            lostPiecesBlack.text = ListToText(piecesBlack);
        }
        if(!Turn.isWhiteTurn && collision.gameObject.tag == "White")
        {
            var temp = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            transform.position = temp;
            if (collision.gameObject.name == "White King")
            {
                gm.resetGame();
            }
            piecesWhite.Add(collision.gameObject.name);
            lostPiecesWhite.text = ListToText(piecesWhite);
            
        }
    }
    private string ListToText(List<string> list)
    {
        string result = "";
        foreach (var listMember in list)
        {
            result += listMember.ToString() + "\n";
        }
        return result;
    }
}
