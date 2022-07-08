using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public SpriteRenderer[] roomSprites;
    
    public void SetRoom()
    {
        GameObject[] rooms = GameObject.FindGameObjectsWithTag("Room");
        roomSprites = new SpriteRenderer[rooms.Length];
        for (int i = 0; i < rooms.Length; i++)
        {
            roomSprites[i] = rooms[i].GetComponent<SpriteRenderer>();
        }
    }
}
