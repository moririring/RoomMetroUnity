using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    static public int ScoreCount;
    // Use this for initialization
    void Start()
    {
        ScoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        guiText.text = string.Format("<color=green>SCORE : {0}</color> ", ScoreCount);
    }
}
