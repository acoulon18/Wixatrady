using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isHitByCar : MonoBehaviour {

	GameObject childObject;
	float timeLeft = 3.0f;
	bool isBoxActive = true;
	// Use this for initialization
	void Start () {
		childObject = this.gameObject.transform.GetChild(0).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isBoxActive)
		{
			timeLeft -= Time.deltaTime;
			if (timeLeft <= 0)
			{
				childObject.SetActive(true);
				isBoxActive = true;
				timeLeft = 3.0f;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "PlayerCar")
		{
			if (isBoxActive)
			{
				BoxTriggered(other);
				other.gameObject.GetComponent<playerGotItem>().GetRandomItem();
			}
		}
	}

	void BoxTriggered(Collider other)
	{
		childObject.SetActive(false);
		isBoxActive = false;
	}

	public bool GetIsBoxActive(){
		return isBoxActive;
	}
}
