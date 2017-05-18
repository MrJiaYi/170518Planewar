using UnityEngine;
using System.Collections;

public class RankList : MonoBehaviour {

	public GUIText guiText;

	// Use this for initialization
	void Start () {
		int score1 = 33;
		int score2 = 34;
		int score3 = 35;
		int score4 = 36;
		int score5 = 37;
		int score6 = 38;
		int score7 = 39;
		int score8 = 40;
		int score9 = 31;

		guiText.text = "Rank list\n 1." + score1 + "\n2." + score2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
