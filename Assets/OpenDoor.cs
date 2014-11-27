using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	GameObject player;
	bool isNearDoor = false;
	public float maxVertPos = 1;
	float startPos;
	float endPos;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		startPos = transform.position.y;
		endPos = transform.position.y + maxVertPos;


	}
	
	// Update is called once per frame
	void Update () {


		if(isNearDoor == true && player.GetComponent<ItemPickUP>().blueKey == true && player.GetComponent<ItemPickUP>().blueEnergyTerminalOn == true){
			if (transform.position.y <= endPos){
				transform.Translate(Vector3.up * Time.deltaTime * 1);
			}
		}

		if(isNearDoor == false){
			if (transform.position.y >= startPos)
				transform.Translate(Vector3.down * Time.deltaTime * 1);
		}

	}

	//void OnTriggerEnter2D(Collider2D other){
	void OnTriggerStay2D(Collider2D other){	

		if(other.gameObject.tag == "Player" ){
			isNearDoor = true;
		}
	}

	void OnTriggerExit2D(Collider2D other){	

		if(other.gameObject.tag == "Player" ){
			isNearDoor = false;
		}
	}


}
