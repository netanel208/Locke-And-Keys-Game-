using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{

	public string name;


	[TextArea(1, 10)]
	public string[] sentences;

	public void Start()
	{
		this.name = "Bode";
	}

	public string[] ChooseSentences(string tag)
	{

		switch (tag)
		{
			case "HelloGameScene2":
				sentences[0] = "Welcome Bode  to the Locke family KeyHouse!";
				sentences[1] = "Listen to the whispering voice and you'll find the first magical key";
				break;
			case "MomInMirrorScene2":
				sentences[0] = "Oh no ! Your mom is stuck in the mirror!";
				sentences[1] = "Take the mirror key and look for another mirror to save your mother!";
				break;
			default:
				break;
		}

		return sentences;
	}


}