using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void resetGame()
    {
        Turn.isWhiteTurn = true;
        Turn.counter = 1;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        TasYeme.piecesBlack.Clear();
        TasYeme.piecesWhite.Clear();
    }
}
