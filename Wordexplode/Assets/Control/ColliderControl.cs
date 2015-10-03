using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColliderControl : MonoBehaviour {
	int count;
	public int lives;
	GameObject Life;
	public Camera camera; // set this via inspector
	public float shake = 0;
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;
	public GameObject scoretext;

	// Use this for initialization
	void Start () {
		Life = GameObject.Find("LivesText");
		scoretext = GameObject.Find("ScoreText");
	}
	
	// Update is called once per frame
	void Update () {
		Life.GetComponent<Text> ().text = lives.ToString ();
		
		if (shake > 0) {
			camera.transform.localPosition = Random.insideUnitSphere * shakeAmount;
			shake -= Time.deltaTime * decreaseFactor;
		} else {
			shake = 0.0f;
		}

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Letters") {
			count++;
			lives--;
			shake = 0.5f;
			if(lives <= 0)
				lives = 0;
		}
	}

	public void reset(){
		lives = 20;
		scoretext.GetComponent<Text>().text = "0";
	}
}
