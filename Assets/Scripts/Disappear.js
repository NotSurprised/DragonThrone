#pragma strict

function Start () {

}

function Update () {

}

function OnTriggerEnter (other:Collider)
{
 	if(other.tag=="Bullet")
	{
		Destroy (gameObject);
	}
	
} 