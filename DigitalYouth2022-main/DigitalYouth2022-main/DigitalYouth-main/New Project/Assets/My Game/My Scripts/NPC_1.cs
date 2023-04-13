using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue()
	{
		Speech.AddDialogue("0","Welcome young traveller","1");
		Speech.AddDialogue("1","I am suprised you reached this far","2");
		Speech.AddDialogue("2","You are here to free us from the creatures, are you not?","3");
		Speech.AddDialogue("3","Unfortunaletly you are on the wrong side of the swamp","4");
		Speech.AddDialogue("4","Find a way to the other side if you really do want to free us","5");
		Speech.AddDialogue("5","Good luck... I hope you do not die");
	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other )
	{
		Speech.SetDialogue("0");
	}
}