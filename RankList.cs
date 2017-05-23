using UnityEngine;
using System.Collections;

public class RankList : MonoBehaviour {

	public GUIText guiText;

	// Use this for initialization
	void Start () {
//		int score1 = 33;
//		int score2 = 34;
//		int score3 = 35;
//		int score4 = 36;
//		int score5 = 37;
//		int score6 = 38;
//		int score7 = 39;
//		int score8 = 40;
//		int score9 = 31;
//
//		guiText.text = "Rank list\n 1." + score1 + "\n2." + score2;

		//1 method init array
//		int[] scores = new int[10];
//		scores [0] = 22;
//		scores [1] = 34;
//		scores [2] = 3;
//		......
//		//2 method init array
//		int[] scores = new int[10]{33,3,45,56,76,87,345,556,45};

		int[] scores = {33,3,45,56,76,87,345,556,45};

		for (int i = 0; i <= 8; i++) {
			for (int j = i+1; j <= 8; j++) {
				if (scores [j] > scores [i]) {
					int temp = scores [j];
					scores [j] = scores [i];
					scores [i] = temp;
				}
			}
		}
		//print (scores[8]);
		string str = "Rank List\n\n";

		for(int i=0;i<=8;i++){
			str = str + (i+1) + ":"+scores[i]+"\n";

		
		}

		guiText.text = str;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
