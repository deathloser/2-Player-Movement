using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Canvas canvas;
    public TMP_Text mainDialogueText;
    

    // Start is called before the first frame update
    void Start()
    {
        mainDialogueText.text = "default";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayDescriptionOnClicked (string description) {
        mainDialogueText.text = description;
    }
}
