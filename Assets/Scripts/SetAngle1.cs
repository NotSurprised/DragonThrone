using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetAngle1 : MonoBehaviour
{	
	public float angle = 100f;					// The player's angle.
	public float repeatDamagePeriod = 2f;		// How frequently the player can be damaged.
	public float hurtForce = 10f;				// The force with which the player is pushed when hurt.
	public float damageAmount = 10f;			// The amount of damage to take when enemies touch the player
	public GameObject angleBar1;
	public bool angleincrease=false;

	public bool Stop=false;
	public GameObject Player;
	private SetAngle SetAngle;

	private float lastHitTime;					// The time at which the player was last hit.
	Slider angleSlider;
	
	void Awake ()
	{

		angleSlider = angleBar1.GetComponent<Slider>();
		SetAngle = Player.GetComponent<SetAngle>();
	}
	
	
	void FixedUpdate ()
	{
		if(Stop==false)
		{
			angle=SetAngle.GetAngle();
			UpdateangleBar ();
		}
	}
	
	
	public void UpdateangleBar ()
	{
		angleSlider.value = angle;
	}
	
	public void Setstate (bool X)
	{
		Stop= X;
	}
}

