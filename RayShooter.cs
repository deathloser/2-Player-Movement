using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private bool IsFiring;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        CheckIfMouseClicked();

    }
    void CreateRaycastFromPlayerToClickedGameObject() {
        Vector3 point = new Vector3(GetComponent<Camera>().pixelWidth/2, GetComponent<Camera>().pixelHeight/2,0);
        Ray ray = GetComponent<Camera>().ScreenPointToRay(point);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            GameObject hitObject = hit.transform.gameObject;
            Debug.Log("The object was hit" + hitObject);
            if (hitObject.GetComponent<WasClickedByPlayer>()) {
                string displaytext = hitObject.GetComponent<WasClickedByPlayer>().displayTextOnClick;
                hitObject.GetComponent<WasClickedByPlayer>().WasClicked();
                Debug.Log("This object is clickable.");
                Debug.Log(displaytext);
            } else {
                Debug.Log("This object is NOT clickable.");
            }
        }

    }
    void CheckIfMouseClicked() {
        if (Input.GetMouseButtonDown(0)) {
            IsFiring = true;
            CreateRaycastFromPlayerToClickedGameObject();
        }
        if(Input.GetMouseButtonUp(0)) { 
            IsFiring = false;  
        }
    }
    void OnGUI() {
    int size = 12;
    float posX = GetComponent<Camera>().pixelWidth/2 - size/4;
    float posY = GetComponent<Camera>().pixelHeight/2 - size/2;
    GUI.Label(new Rect(posX,posY,size,size), "*");

    }
}
