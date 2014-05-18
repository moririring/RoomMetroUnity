using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {

    public GameObject GameObject;
    public float Power = 1.0f;
    public float LimitX = 5.0f;
    public float LimitZ = 5.0f;
    public float Y = 5.0f;
    public int Interval = 100;

    private int _time;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
_time = (_time + 1) % Interval;
if (_time == 0)
{
    var x = Random.Range(-LimitX, LimitX);
    var z = Random.Range(-LimitZ, LimitZ);
    Instantiate(GameObject, new Vector3(x, Y, z), transform.rotation);
}
	}
}
