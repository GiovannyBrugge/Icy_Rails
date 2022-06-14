using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNavigation : MonoBehaviour
{
    public SpriteRenderer[] roomSprites;
    private GameObject playerLocation;
  

    private void Start()
    {
        setRoom();
        changeLocation(0);
    }

    private void setRoom()
    {
        GameObject[] rooms = GameObject.FindGameObjectsWithTag("Room");
        roomSprites = new SpriteRenderer[rooms.Length];
        Debug.Log(rooms.Length);
        for (int i = 0; i < rooms.Length; i++)
        {   
            roomSprites[i] = rooms[i].GetComponent<SpriteRenderer>();
        }
    }

    private void defaultRooms()
    {   
       
        for (int i = 0; i < 5; i++)
        {
            //roomSprites[0].sprite = (texturename);      When art received replace this!!!
            roomSprites[i].color = Color.black;
        }
    }

    public void changeLocation(int currentLocation)
    {
        defaultRooms();
        playerLocation = GameObject.Find("conductor");
        
        switch (currentLocation){

            case 0:
                playerLocation.transform.localPosition = new Vector3(16,0,-1);
                roomSprites[0].color = Color.white;
                Debug.Log(playerLocation.transform.localPosition);
                break;

            case 1:
                playerLocation.transform.localPosition = new Vector3(8, 0, -1);
                roomSprites[1].color = Color.white;
                Debug.Log(playerLocation.transform.localPosition);
                break;
            case 2:
                playerLocation.transform.localPosition = new Vector3(0, 0, -1);
                roomSprites[2].color = Color.white;
                Debug.Log(playerLocation.transform.localPosition);
                break;

            case 3:
                playerLocation.transform.localPosition = new Vector3(-8, 0, -1);
                roomSprites[3].color = Color.white;
                Debug.Log(playerLocation.transform.localPosition);
                break;

            case 4:
                playerLocation.transform.localPosition = new Vector3(-16, 0, -1);
                roomSprites[4].color = Color.white;
                Debug.Log(playerLocation.transform.localPosition);
                break;


        }
    }
}
