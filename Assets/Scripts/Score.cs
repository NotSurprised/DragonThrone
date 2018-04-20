using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
	public int score = 0;					// The player's score.
	public int whoisTurn = 1;

	public GameObject Camera;
	private CameraFollow CameraFollow;

	public GameObject Line;
	private FallInToDark FallInToDark;

	public GameObject Player1;
	public GameObject Gun1;
	private PlayerControl playerCtrl1;
	private Gun gun1;
	private SetAngle SetAngle1;
	private SetPower SetPower1;
	private SetAngle1 SetAngle11;
	private SetPower1 SetPower11;
	private PlayerHealth PlayerHeal1;
	public Text winText;

	public GameObject Player2;
	public GameObject Gun2;
	private PlayerControl playerCtrl2;
	private Gun gun2;
	private SetAngle SetAngle2;
	private SetPower SetPower2;
	private SetAngle1 SetAngle21;
	private SetPower1 SetPower21;
	private PlayerHealth PlayerHeal2;

	//private PlayerControl playerControl;	// Reference to the player control script.
	private int previousScore = 0;			// The score in the previous frame.


	void Awake ()
	{
		CameraFollow = Camera.GetComponent<CameraFollow>();
		CameraFollow.SetState (1);
		FallInToDark = Line.GetComponent<FallInToDark>();
		playerCtrl1 = Player1.GetComponent<PlayerControl>();
		playerCtrl1.Reset (false);
		playerCtrl2 = Player2.GetComponent<PlayerControl>();
		playerCtrl2.Reset (true);
		gun1 = Gun1.GetComponent<Gun>();
		gun2 = Gun2.GetComponent<Gun>();
		SetAngle1 = Player1.GetComponent<SetAngle>();
		SetPower1 = Player1.GetComponent<SetPower>();
		SetAngle11 = Player1.GetComponent<SetAngle1>();
		SetPower11 = Player1.GetComponent<SetPower1>();
		PlayerHeal1 = Player1.GetComponent<PlayerHealth>();
		PlayerHeal2 = Player2.GetComponent<PlayerHealth>();
		SetAngle2 = Player2.GetComponent<SetAngle>();
		SetAngle2.Setstate (true);
		SetPower2 = Player2.GetComponent<SetPower>();
		SetPower2.Setstate (true);
		SetAngle21 = Player2.GetComponent<SetAngle1>();
		SetAngle21.Setstate (true);
		SetPower21 = Player2.GetComponent<SetPower1>();
		SetPower21.Setstate (true);
		// Setting up the reference.
		//playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
	}


	void Update ()
	{
		if (FallInToDark.SomeOneFall () != 0) 
		{
			if(FallInToDark.SomeOneFall ()==1)
			{
				winText.text = "P2 Win!";
			}
			if(FallInToDark.SomeOneFall ()==2)
			{
				winText.text = "P1 Win!";
			}
		}
		if (PlayerHeal1.GetHealth () <= 0 || PlayerHeal2.GetHealth () <= 0) 
		{
			if (PlayerHeal1.GetHealth () <= 0 ) 
			{
				winText.text = "P2 Win!";
			}
			if (PlayerHeal2.GetHealth () <= 0) 
			{
				winText.text = "P1 Win!";
			}
		}
		// Set the score text.
		if(SetPower2.Stop == true && whoisTurn == 2)
		{
			print ("P1 in turn");
			CameraFollow.SetState (1);
			whoisTurn = 1;
			playerCtrl2.Reset (true);
			SetAngle21.Setstate(true);
			SetPower21.Setstate(true);
			playerCtrl1.Reset (false);
			SetAngle1.Setstate(false);
			SetPower1.Setstate(false);
			SetAngle11.Setstate(false);
			SetPower11.Setstate(false);
			gun1.SetState();
			//guiText.text = "Turn to P1";
			//print ("P1 in turn over");
			//print ("P1 stop"+SetPower1.Stop);
			//print ("P2 stop"+SetPower2.Stop);
			//print (whoisTurn);
		}
		if(SetPower1.Stop == true && whoisTurn == 1)
		{
			print ("P2 in turn");
			CameraFollow.SetState (2);
			whoisTurn = 2;
			playerCtrl1.Reset (true);
			SetAngle11.Setstate(true);
			SetPower11.Setstate(true);
			playerCtrl2.Reset (false);
			SetAngle2.Setstate(false);
			SetPower2.Setstate(false);
			SetAngle21.Setstate(false);
			SetPower21.Setstate(false);
			gun2.SetState();
			guiText.text = "Turn to P2";
			//print ("P2 in turn over");
			//print ("P1 stop"+SetPower1.Stop);
			//print ("P2 stop"+SetPower2.Stop);
			//print (whoisTurn);
		}
		// If the score has changed...
		//if(previousScore != score)
			// ... play a taunt.
			//playerControl.StartCoroutine(playerControl.Taunt());

		// Set the previous score to this frame's score.
		//previousScore = score;
	}

}
