using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetPower1 : MonoBehaviour
{	
	public float Power = 100f;					// The player's Power.
	public float repeatDamagePeriod = 2f;		// How frequently the player can be damaged.
	public float hurtForce = 10f;				// The force with which the player is pushed when hurt.
	public float damageAmount = 10f;			// The amount of damage to take when enemies touch the player
	public GameObject PowerBar1;
	public bool Powerincrease=false;
	
	public bool Stop=false;
	public GameObject Player;
	private SetAngle SetAngle;
	private SetPower SetPower;

	private float lastHitTime;					// The time at which the player was last hit.
	Slider PowerSlider;
	
	void Awake ()
	{
		
		PowerSlider = PowerBar1.GetComponent<Slider>();

		SetAngle = Player.GetComponent<SetAngle>();
		SetPower = Player.GetComponent<SetPower>();
	}
	
	
	void FixedUpdate ()
	{
		if(SetAngle.Stop==true && Stop==false)
		{
			Power=SetPower.GetPower();
			UpdatePowerBar ();
		}
	}
	
	
	public void UpdatePowerBar ()
	{
		PowerSlider.value = Power;
	}
	
	public void Setstate (bool X)
	{
		Stop= X;
	}
}

