using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	  public int coins;

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start() {
		coins=0;
			Abilities.doubleJumpEnabled=false;
			Abilities.spinAttackEnabled=false;
	}

	// OnTriggerEnter is called when the Collider "collided" enters the trigger.
	protected void OnTriggerEnter(Collider collided) {

		// Check for collision with coins
		if (collided.gameObject.tag == "Coin") {  
			
			Destroy(collided.gameObject);
			coins++;
			HUD.Message("You got a coin!");
			HUD.UpdateCoinCount(coins);

		}

		if (collided.gameObject.name == "Powerup1") {  
			
			Destroy(collided.gameObject);
			HUD.Message("You got a powerup to jump higher!");
			Abilities.doubleJumpEnabled=true;

		}

		if (collided.gameObject.name == "Powerup2" && coins==15) {  
			
			Destroy(collided.gameObject);
			HUD.Message("You got a powerup to spin attack!");
			Abilities.spinAttackEnabled=true;

		}

	}
}