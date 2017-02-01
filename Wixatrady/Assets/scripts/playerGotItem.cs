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

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Box")
		{
			if (other.gameObject.GetComponent<isHitByCar>().GetIsBoxActive())
			{
				GetRandomItem((int)Random.Range(0,7));
			}
		}
	}

	void GetRandomItem(int idItem){
		Debug.Log(idItem);
		//Faut faire appel au HUD Manager pour afficher l'objet
	}
}
