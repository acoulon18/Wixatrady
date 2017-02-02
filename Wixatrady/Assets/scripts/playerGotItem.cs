using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGotItem : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// void OnTriggerEnter(Collider other)
	// {
	// 	if (other.tag == "Box")
	// 	{
	// 		Debug.Log(other.gameObject.GetComponent<isHitByCar>().GetIsBoxActive());
	// 		if (other.gameObject.GetComponent<isHitByCar>().GetIsBoxActive())
	// 		{
	// 			GetRandomItem((int)Random.Range(0,7));
	// 		}
	// 	}
	// }

	public void GetRandomItem(){
		//Debug.Log(idItem);
		int randomId = Random.Range(0,7);
		GameObject.Find("HUD").BroadcastMessage("DisplayPlayerItem", randomId);
	}
}
