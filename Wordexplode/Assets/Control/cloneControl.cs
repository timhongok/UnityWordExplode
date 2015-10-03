using UnityEngine;
using System.Collections;

public class cloneControl : MonoBehaviour {
	public GameObject[] letters;
	float interval;
	float range;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		interval += Time.deltaTime;
		if (interval > range) {
			interval = 0;
			Instantiate(letters[Random.Range(0,25)],new Vector3(0,0,80),new Quaternion(0,1,0,0));
			range = Random.Range(0.3f,1.0f);
		}
	}
}
