using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class letterControl : MonoBehaviour {

	public GameObject particle;
	GameObject camera;
	public float speed;
	public GameObject ascii;
	public GameObject scoretext;
	string name;
	Vector3 offset;
	// Use this for initialization
	void Start () {
		camera = GameObject.FindWithTag("MainCamera");
		name = this.gameObject.name;
		speed = Random.Range (0.1f, 1.0f);
		offset = new Vector3 (Random.Range (-10, 10), Random.Range (-10, 10), Random.Range (-1, 1));
		scoretext = GameObject.Find("ScoreText");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown(name)) {
			particle.SetActive(true);
			Destroy(this.gameObject,1.0f);
			ascii.SetActive(false);
			scoretext.GetComponent<Text>().text = (int.Parse(scoretext.GetComponent<Text>().text) + (int)(speed * 10)).ToString();
			this.gameObject.GetComponent<BoxCollider>().enabled = false;
		}

		transform.position = Vector3.MoveTowards (transform.position, camera.transform.position + offset, speed);
		if ((transform.position.z - camera.transform.position.z) <= 5) {
			particle.SetActive(true);
			Destroy(this.gameObject,1.0f);
			ascii.SetActive(false);
		}
	}
}
