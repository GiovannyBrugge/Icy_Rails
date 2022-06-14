using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public SpriteRenderer[] roomSprites;
    // Start is called before the first frame update
    void Start()
    {
        setRoom();
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
}
