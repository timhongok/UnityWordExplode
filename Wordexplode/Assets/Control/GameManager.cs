using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
	public GameObject gamecontrol;
	public GameObject lives;
	public GameObject play;
	public GameObject gameover;

	// Use this for initialization
	void Start () {
		lives = GameObject.Find("LivesText");

	}
	
	// Update is called once per frame
	void Update () {
		if (gameover.activeSelf == false) {
			if (int.Parse (lives.GetComponent<Text> ().text) == 0) {
				gamecontrol.SetActive (false);
				play.SetActive (true);
				gameover.SetActive (true);
			}
		}
	}

}
