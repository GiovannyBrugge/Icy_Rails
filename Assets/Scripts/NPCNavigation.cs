using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCNavigation : MonoBehaviour
{
    private Room room;
    private GameObject npcLocation;
    private GameObject travellerTicket;


    private void Start()
    {
        room = GameObject.Find("train").GetComponent<Room>();
        changeLocation(0);
    }
   
    private void setStatenment(Vector3 npos, Vector3 tpos)
    {
        npcLocation.transform.localPosition = npos;
        travellerTicket.transform.localPosition = tpos;
        Debug.Log(npcLocation.transform.localPosition);
    }
    public void changeLocation(int currentLocation)
    {
        npcLocation = GameObject.Find("firstclassman");
        travellerTicket = GameObject.Find("ticket");
        switch (currentLocation)
        {
            case 0:
                setStatenment(new Vector3(-1400, -275, -1), new Vector3(-2000, 0, -1.1f));
                break;

            case 1:
                setStatenment(new Vector3(-450, -275, -1), new Vector3(400, 0, -1.1f));
                break;
        }
    }
}
