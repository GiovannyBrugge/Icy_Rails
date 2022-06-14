using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCNavigation : MonoBehaviour
{
   
    public GameObject[] npcsLocation;
  

    private void Start()
    {
        changeLocation(0);
    }
   

    public void changeLocation(int currentLocation)
    {
        npcsLocation[] = new GameObject.Find("");
        
        switch (currentLocation){

            case 0:
                npcLocation.transform.localPosition = new Vector3(16,0,-1);
                Debug.Log(npcLocation.transform.localPosition);
                break;

            case 1:
                npcLocation.transform.localPosition = new Vector3(8, 0, -1);
                Debug.Log(npcLocation.transform.localPosition);
                break;
            case 2:
                npcLocation.transform.localPosition = new Vector3(0, 0, -1);
                Debug.Log(npcLocation.transform.localPosition);
                break;

            case 3:
                npcLocation.transform.localPosition = new Vector3(-8, 0, -1);
                Debug.Log(npcLocation.transform.localPosition);
                break;

            case 4:
                npcLocation.transform.localPosition = new Vector3(-16, 0, -1);
                Debug.Log(npcLocation.transform.localPosition);
                break;


        }
    }
}
