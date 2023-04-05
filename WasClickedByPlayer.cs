using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasClickedByPlayer : MonoBehaviour
{
    public string displayTextOnClick;
    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("GameManager")) {
            gameManager = GameObject.Find("GameManager");
            Debug.Log(gameManager);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WasClicked() {
        Debug.Log(displayTextOnClick);
        gameManager.GetComponent<GameManager>().DisplayDescriptionOnClicked(displayTextOnClick);
    }
    
}
