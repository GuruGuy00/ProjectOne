using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	[System.Serializable]
	public class PlayerStats{

		public int Health = 100;
		public int blueKeys = 0;

	}

	public PlayerStats playerStats = new PlayerStats();
	public GUIText healthDisplay;

	void Start(){
		healthDisplay.text = "Health : " + playerStats.Health.ToString();
	}

	public void DamagePlayer (int damageAmt){
		playerStats.Health -= damageAmt;
		healthDisplay.text = "Health : " + playerStats.Health.ToString();
		if (playerStats.Health <= 0){
			//Kill the player if health is less then 0
			GameMaster.KillPlayer(this);
			//healthDisplay.text = "Energy : " + healthDisplay.ToString();

		}
	}

	public void BlueKeyPickup (int keyCount){
		playerStats.blueKeys = keyCount;

	}

//	void OnTriggerEnter2D(Collider2D other){
//		if (other.tag  == "GivesDamage")
//			DamagePlayer(5);
//	}

	void OnTriggerStay2D(Collider2D other){
		//Debug.Log("Trigger Stay - " + other.name);
		if (other.tag  == "GivesDamage")
			DamagePlayer(5);
	}

}
