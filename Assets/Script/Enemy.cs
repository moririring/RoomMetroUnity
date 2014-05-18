using UnityEngine;

public class Enemy : MonoBehaviour {
    private GameObject target;
    public float power = 1.0f;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
	}
	void Update () {
        var direction = target.transform.position - transform.position;
        rigidbody.AddForce(direction * power);
	}
}
