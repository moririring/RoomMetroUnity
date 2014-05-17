using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	
	// Update is called once per frame
	void Update ()
	{
        if (Input.GetKey("up"))
            transform.Translate(0, 0, 0.1f);
        else if (Input.GetKey("down"))
            transform.Translate(0, 0, -0.1f);
        else if (Input.GetKey("left"))
            transform.Translate(-0.1f, 0, 0);
        else if (Input.GetKey("right"))
            transform.Translate(0.1f, 0, 0);
    }
}
