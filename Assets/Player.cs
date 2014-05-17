using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour {

    public float _speed = 1.0f;
    public float _force = 1.0f;
    public float _velocity = 30.0f;
    [Range(4,360)]public int  _hanas = 20;
    public GameObject _bulletPrefab;

    private bool _jump;
	void Start () {
	}
	void Update ()
	{
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(x, 0, z) * _speed);
        if (!_jump && Input.GetButtonDown("Jump"))
        {
            _jump = true;
            rigidbody.AddForce(transform.up * _force, ForceMode.Impulse);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                var bullet = Instantiate(_bulletPrefab, transform.position, transform.rotation) as GameObject;
                bullet.rigidbody.velocity = (hit.point - new Vector3(transform.position.x, 0, transform.position.z)).normalized * _velocity;
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            foreach (var hana in Enumerable.Range(0, _hanas).Select(r => r * (360 / _hanas) * Mathf.Deg2Rad))
            {
                var bullet = Instantiate(_bulletPrefab, transform.position, transform.rotation) as GameObject;
                bullet.rigidbody.velocity = new Vector3(Mathf.Cos(hana), 0, Mathf.Sin(hana)).normalized * _velocity;
                
            }
            
//            for (int i = 0; i < 360; i += 20)
//            {
//                var rad = i * Mathf.Deg2Rad;
//                var bullet = Instantiate(_bulletPrefab, transform.position, transform.rotation) as GameObject;
//                bullet.rigidbody.velocity = new Vector3(Mathf.Cos(rad), 0, Mathf.Sin(rad)).normalized * _velocity;
//            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            _jump = false;
        }
    }

}
