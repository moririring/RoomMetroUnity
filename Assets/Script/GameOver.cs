using UnityEngine;

public class GameOver : MonoBehaviour
{
    static public bool _GameOver;
    void Start()
    {
        _GameOver = false;
        guiText.enabled = _GameOver;
    }

    void Update()
    {
        guiText.enabled = _GameOver;
    }
    void OnGUI()
    {
        if (_GameOver)
        {
            var l = Screen.width / 2.0f - Screen.width * 0.2f;
            var w = Screen.width * 0.4f;
            var u = Screen.height * 0.8f;
            var h = Screen.height * 0.1f;
            if (GUI.Button(new Rect(l, u, w, h), "Retry"))
            {
                Application.LoadLevel(0);
            }
        }
    }
}