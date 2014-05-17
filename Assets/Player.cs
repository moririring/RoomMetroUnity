using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float _speed = 1.0f;
    public float _force = 1.0f;
    public bool jump;
    // Use this for initialization
	void Start () {
	}

	
	// Update is called once per frame
	void Update ()
	{
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(x, 0, z) * _speed);
        if (!jump && Input.GetButtonDown("Jump"))
        {
            jump = true;
            rigidbody.AddForce(transform.up * _force, ForceMode.Impulse);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            jump = false;
        }
    }

}
