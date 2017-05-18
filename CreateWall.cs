using UnityEngine;
using System.Collections;

public class CreateWall : MonoBehaviour {

	public GameObject zhuankuai;

	// Use this for initialization
	void Start () {
//		GameObject.Instantiate(zhuankuai,new Vector3(0,0,0),Quaternion.identity);
//		GameObject.Instantiate(zhuankuai,new Vector3(-1,0,0),Quaternion.identity);
//		GameObject.Instantiate(zhuankuai,new Vector3(-2,0,0),Quaternion.identity);
//		GameObject.Instantiate(zhuankuai,new Vector3(-3,0,0),Quaternion.identity);
//		GameObject.Instantiate(zhuankuai,new Vector3(-4,0,0),Quaternion.identity);
//		GameObject.Instantiate(zhuankuai,new Vector3(-5,0,0),Quaternion.identity);
		
//		for(int i=0;i>=-5;i--){
//			GameObject.Instantiate(zhuankuai,new Vector3(i,0,0),Quaternion.identity);
//		}
//		for(int i=0;i>=-5;i--){
//			GameObject.Instantiate(zhuankuai,new Vector3(i,1,0),Quaternion.identity);
//		}
//		for(int i=0;i>=-5;i--){
//			GameObject.Instantiate(zhuankuai,new Vector3(i,2,0),Quaternion.identity);
//		}
//		for(int i=0;i>=-5;i--){
//			GameObject.Instantiate(zhuankuai,new Vector3(i,3,0),Quaternion.identity);
//		}
//		for(int i=0;i>=-5;i--){
//			GameObject.Instantiate(zhuankuai,new Vector3(i,4,0),Quaternion.identity);
//		}

//		for(int i=0;i>=-5;i--){
//			for(int j=0;j<=4;j++){
//				GameObject.Instantiate(zhuankuai,new Vector3(i,j,0),Quaternion.identity);
//			}
//		}
		//i=0 j=0 GameObject.Instantiate(zhuankuai,new Vector3(0,0,0),Quaternion.identity);
		//i=0 j=1      	
		//i=0 j=2
		//i=0 j=3
		//i=0 j=4
		// j=5
		//i=-1
		//	j=0 1 2 3 4
		//	j=5

		//GameObject.Instantiate(zhuankuai,new Vector3(x,y,0),Quaternion.identity);
//		int x=0;
//		while(x<=8){
//			GameObject.Instantiate(zhuankuai,new Vector3(x,0,0),Quaternion.identity);
//			x++;
//		}
//
//		int y=0;
//		while(y<=8){
//			GameObject.Instantiate(zhuankuai,new Vector3(0,y,0),Quaternion.identity);
//			y++;
//		}
//		int x=0;
//		int y=0;
//		//int x=0,y=0;
//
//		while(y<=8){
//			x=0;
//			while(x<=8){
//				GameObject.Instantiate(zhuankuai,new Vector3(x,y,0),Quaternion.identity);
//				x++;
//			}
//			y++;
//		}
//		int i=1;
//		while(i<=100){
//			if((i%2)!=1){
//				i++;
//				continue;
//			}
//			print(i);
//			i++;
//		}

		for(int i=0;i>=-8;i--){
			for(int j=0;j<=8;j++){
				if(j==4){
					break;
				}

				if(i<=-1 && i>=-7 &&j>=1 && j<=7){
					continue;
				}
				GameObject.Instantiate(zhuankuai,new Vector3(i,j,0),Quaternion.identity);


			}
//			if(i==-4){
//				break;
//			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
