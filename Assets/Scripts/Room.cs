using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour
{
    public Image[] roomImages;
    
    public void SetRoom()
    {
        GameObject[] rooms = GameObject.FindGameObjectsWithTag("Room");
        roomImages = new Image[rooms.Length];
        for (int i = 0; i < rooms.Length; i++)
        {
            roomImages[i] = rooms[i].GetComponent<Image>();
        }
    }
}
