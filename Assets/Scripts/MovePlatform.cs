using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour {

	public float maxVertPos = 1;
	public float minVertPos = 0;
	public int moveSpeed = 1;
	bool moveUp = true;
	public bool isPowered = false;

	GameObject player;


	// Use this for initialization
	void Start () {

		//player = GameObject.Find("Player");
		//Debug.Log(GameObject.Find("Player").GetComponent<ItemPickUP>().blueEnergyTerminalOn);

	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(GameObject.Find("Player").GetComponent<ItemPickUP>().blueEnergyTerminalOn);

//		if (player.GetComponent<ItemPickUP>().blueEnergyTerminalOn){
//			if (transform.position.y <= maxVertPos && moveUp){
//				transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
//			} else if (transform.position.y >= minVertPos) {
//				moveUp = false;
//				transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
//				if(transform.position.y <= minVertPos){
//					moveUp = true;
//				}
//			}
//		}
	}
}
