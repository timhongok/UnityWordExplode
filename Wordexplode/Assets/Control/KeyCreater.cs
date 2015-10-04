using UnityEngine;
using System.Collections;

public class KeyCreater : MonoBehaviour {

	public bool key_flag;
	public string outkey;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GUIKeyUp(){
		key_flag = false;
	}

	public void GUIKeyDown(string key)
	{
		switch (key) {
		case "A":
			outkey = "Letter_A(Clone)";
			break;
		case "B":
			outkey = "Letter_B(Clone)";
			break;
		case "C":
			outkey = "Letter_C(Clone)";
			break;
		case "D":
			outkey = "Letter_D(Clone)";
			break;
		case "E":
			outkey = "Letter_E(Clone)";
			break;
		case "F":
			outkey = "Letter_F(Clone)";
			break;
		case "G":
			outkey = "Letter_G(Clone)";
			break;
		case "H":
			outkey = "Letter_H(Clone)";
			break;
		case "I":
			outkey = "Letter_I(Clone)";
			break;
		case "J":
			outkey = "Letter_J(Clone)";
			break;
		case "K":
			outkey = "Letter_K(Clone)";
			break;
		case "L":
			outkey = "Letter_L(Clone)";
			break;
		case "M":
			outkey = "Letter_M(Clone)";
			break;
		case "N":
			outkey = "Letter_N(Clone)";
			break;
		case "O":
			outkey = "Letter_O(Clone)";
			break;
		case "P":
			outkey = "Letter_P(Clone)";
			break;
		case "Q":
			outkey = "Letter_Q(Clone)";
			break;
		case "R":
			outkey = "Letter_R(Clone)";
			break;
		case "S":
			outkey = "Letter_S(Clone)";
			break;
		case "T":
			outkey = "Letter_T(Clone)";
			break;
		case "U":
			outkey = "Letter_U(Clone)";
			break;
		case "V":
			outkey = "Letter_V(Clone)";
			break;
		case "W":
			outkey = "Letter_W(Clone)";
			break;
		case "X":
			outkey = "Letter_X(Clone)";
			break;
		case "Y":
			outkey = "Letter_Y(Clone)";
			break;
		case "Z":
			outkey = "Letter_Z(Clone)";
			break;
		}
		key_flag = true;

	}

	
}
