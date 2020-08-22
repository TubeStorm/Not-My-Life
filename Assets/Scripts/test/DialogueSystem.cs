using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
	public static DialogueSystem Instance { get; set; }
	public List<string> dialogueLines = new List<string>();

	// use Awake instaed of Update
	void Awake()
    {
        if(Instance != null && Instance != this)
		{
            Destroy(gameObject);
		}
		else
		{
            Instance = this;
		}
    }

    public void AddNewDialogue(string[] lines)
	{
        //make it empty, with no elements inside
		dialogueLines = new List<string>(lines.Length);
		dialogueLines.AddRange(lines);

        //creates a new string line and puts each string in lines into the line string
        foreach(string line in lines)
		{
			dialogueLines.Add(line);
		}
		Debug.Log(dialogueLines.Count);
	}
}
