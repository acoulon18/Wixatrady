using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour {

	public Sprite spriteMeteor;
	public Sprite spriteMine;
	public Sprite spriteMissiles;
	public Sprite spriteRoquette;
	public Sprite spriteNitro;
	public Sprite spriteBouclier;
	public Sprite spriteTempo;
	public Sprite spriteRepare;
	Sprite spriteActualItem;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DisplayPlayerItem(int idItem){
		switch (idItem)
		{
			case 0 :
				spriteActualItem = spriteMeteor;
				break;
			case 1 :
				spriteActualItem = spriteMine;
				break;
			case 2 :
				spriteActualItem = spriteMissiles;
				break;
			case 3 :
				spriteActualItem = spriteRoquette;
				break;
			case 4 :
				spriteActualItem = spriteNitro;
				break;
			case 5 :
				spriteActualItem = spriteBouclier;
				break;
			case 6 :
				spriteActualItem = spriteTempo;
				break;
			case 7 :
				spriteActualItem = spriteRepare;
				break;
		}
		GameObject.Find("ItemIcon").GetComponent<Image>().sprite = spriteActualItem;
	}
}
