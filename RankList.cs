using UnityEngine;
using System.Collections;

public class RankList : MonoBehaviour {

	public GUIText guiText;

	// Use this for initialization
	void Start () {
//		int score1 = 33;
//		int score2 = 3;
//		int score3 = 56;
//		int score4 = 98;
//		int score5 = 65;
//		int score6 = 66;
//		int score7 = 36;
//		int score8 = 66;
//		int score9 = 656;
//		int score10 = 96;

		//int[] scores = new int[10];
		//float[] scores = new float[10];
		//string[] scores = new string[10];

		//int[] scores = new int[10];
		// 1, the first method to init array
		int[] scores = {33,3,56,98,65,66,36,66,656,96};
						
		// 2, the 2 method to init array
		//int[] scores = new int[10]{33,3,56,98,65,66,36,66,656,96};
		// 3,the 3 method to init array
//		int[] scores = new int[10];
//		scores[0]=33;
//		scores[1]=3;
//		scores[2]=56;
//		scores[3]=98;
		///.....

//		for(int i=0;i<=9;i++){
//			print (scores[i]);
//		}

		for(int i=0;i<=9;i++  ){
			// score[i]
			for(int j=i+1;j<=9;j++){
				//score[j];
				if(scores[j]<scores[i]){
					int temp = scores[j];
					scores[j]=scores[i];
					scores[i]=temp;
				}
			}

		}

		//print (scores[9]);
		//scores[10]=100;
		string str="Rank List\n\n";


		for(int i=9;i>=0;i--){
			str=str+(10-i)+"."+scores[i]+"\n";
		}
		guiText.text=str;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
