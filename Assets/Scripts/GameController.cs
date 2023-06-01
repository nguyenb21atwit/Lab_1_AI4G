using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour

{
    public static int score = 0;
    public static int npcscore = 10;

    void OnGUI()
    {
        GUIStyle scoreStyle = new GUIStyle();
        scoreStyle.fontSize = 24;
        scoreStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 10, 200, 50), "Score: " + score, scoreStyle);
        GUI.Label(new Rect(10, 40, 200, 50), "NPC Score: " + npcscore, scoreStyle);
    }


}
