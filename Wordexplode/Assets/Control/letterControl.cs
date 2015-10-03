using UnityEngine;
using System.Collections;

public class letterControl : MonoBehaviour {

	public GameObject particle;
	GameObject camera;
	public float speed;
	public GameObject ascii;
	string name;
	// Use this for initialization
	void Start () {
		camera = GameObject.FindWithTag("MainCamera");
		name = this.gameObject.name;
		speed = Random.Range (0.3f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown(name)) {
			particle.SetActive(true);
			Destroy(this.gameObject,1.0f);
			ascii.SetActive(false);
		}

		transform.position = Vector3.MoveTowards (transform.position, camera.transform.position, speed);
	}
}
