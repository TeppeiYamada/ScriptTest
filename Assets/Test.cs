using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss{

	private int hp = 100;
	private int power = 25;
	private int mp = 53;

	public void Attack(){

		Debug.Log (this.power + "のダメージを与えた");

	}

	public void Defence(int damage){

		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;

	}

	public void Magic(){
	
		if (mp >= 5) {
			
			mp = mp - 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);

		} else {
		
			Debug.Log ("MPが足りないため魔法が使えない。");
		
		}
	
	}

}


public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int[] theArray = new int[5];

		theArray [0] = 1;
		theArray [1] = 2;
		theArray [2] = 3;
		theArray [3] = 4;
		theArray [4] = 5;

		for (int i = 0; i < theArray.Length; i++) {
		
			Debug.Log (theArray [i]);
		
		}

		for (int i = theArray.Length - 1; 0 <= i; i--){

			Debug.Log (theArray[i]);

		}

		boss boss = new boss ();

		boss.Attack ();

		boss.Defence (3);

		//boss.Magic ();

		for(int i = 0; i <= 10; i++){

			boss.Magic ();

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
