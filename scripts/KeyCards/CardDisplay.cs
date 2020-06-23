using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

	public Card card;
	public Button close_btn;

	public Text nameText;
	public Text descriptionText;

	public Image artworkImage;


	public GameObject currentKey;
	public GameObject currentCard;

	// Use this for initialization
	void Start () 
	{
		nameText.text = card.name;
		descriptionText.text = card.description;

		artworkImage.sprite = card.artwork;

		//currentCard = GameObject.FindGameObjectWithTag("mirror card");
		currentCard = this.gameObject;

		close_btn.onClick.AddListener(TaskOnClick);

	}

	private void TaskOnClick()
	{
	  currentCard.SetActive(false);
	}

	public void DisplayCards()
	{
		
		currentCard.SetActive(true);

	}


}
