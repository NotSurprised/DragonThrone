using UnityEngine;
using System.Collections;

public class MenuButtonControl : MonoBehaviour {

	public void EnterGame()
	{
		Application.LoadLevel("BattleField1");
	}

	public void Exit()
	{
		Application.Quit ();
	}
}
