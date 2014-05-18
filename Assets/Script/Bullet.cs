using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    private float _timeNow = 0;
    public float TimeDel = 0.5f;
    public GameObject _gameObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        _timeNow += Time.deltaTime;
        if (TimeDel < _timeNow)
        {
            Destroy(gameObject);
            _timeNow = 0;
        }

	}
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            var particle = Instantiate(_gameObject, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Destroy(particle, 2.0f);
            Score.ScoreCount++;
        }

    }
}
