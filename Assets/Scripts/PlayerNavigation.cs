using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNavigation : MonoBehaviour
{
    private Room room;
    private GameObject playerLocation;
  

    private void Start()
    {
        room = GameObject.Find("train").GetComponent<Room>();
        changeLocation(0);
    }
    
    private void defaultRooms()
    {   
       
        for (int i = 0; i < 5; i++)
        {
            //roomSprites[0].sprite = (texturename);      When art received replace this!!!
            room.roomSprites[i].color = Color.black;
        }
    }
    private void setStatenment(int index, Vector3 pos)
    {
        playerLocation.transform.localPosition = pos;
        room.roomSprites[index].color = Color.white;
        Debug.Log(playerLocation.transform.localPosition);
    } 
    public void changeLocation(int currentLocation)
    {
        defaultRooms();
        playerLocation = GameObject.Find("conductor");
        
        switch (currentLocation){

            case 0:
                setStatenment(0, new Vector3(16, 0, -1));
                break;

            case 1:
                setStatenment(1, new Vector3(8, 0, -1));
                break;
            case 2:
                setStatenment(2, new Vector3(0, 0, -1));
                break;

            case 3:
                setStatenment(3, new Vector3(-8, 0, -1));
                break;

            case 4:
                setStatenment(4, new Vector3(-16, 0, -1));
                break;
        }
    }
}
