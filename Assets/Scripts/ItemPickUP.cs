using UnityEngine;
using System.Collections;

public class ItemPickUP : MonoBehaviour {

	public int energyCount;
	public GUIText energyCountDisplay;
	public bool blueEnergyTerminalOn;
	public bool blueKey = false;

	// Use this for initialization
	void Start () {
		energyCount = 0;
		energyCountDisplay.text = "Energy : " + energyCount.ToString();
		blueEnergyTerminalOn = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){

		Debug.Log(other.name);

		//Debug.Log("ItemPickUPs - " + other.name);
		if(other.gameObject.tag == "EnergyCube"){

			energyCount++;
			energyCountDisplay.text = "Energy : " + energyCount.ToString();
			Destroy(other.gameObject);

		}else if (other.gameObject.tag == "BlueKey"){

			Debug.Log("blue key has been picked up");
			blueKey = true;
			Destroy(other.gameObject);

		}
	}

	void OnTriggerStay2D(Collider2D other){
		//Debug.Log("Trigger Stay - " + other.name);
		if (other.name == "BluePowerTerminal" && blueEnergyTerminalOn == false && energyCount >= 3  && Input.GetKey(KeyCode.Q)) {
			// Input.GetButtonDown("Fire2")
			Debug.Log("ItemPickUPs - Its working");
			blueEnergyTerminalOn = true;
			energyCount = energyCount - 3;
			energyCountDisplay.text = "Energy : " + energyCount.ToString();
		}
	}
	

}
