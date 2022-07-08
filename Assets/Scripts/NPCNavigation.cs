using UnityEngine;


public class NPCNavigation : MonoBehaviour
{
    //private Room room;
    private GameObject npcLocation;
    private GameObject travellerTicket;


    private void Start()
    {
        //room = GameObject.Find("train").GetComponent<Room>();
        ChangeLocation(0);
    }
   
    private void SetState(Vector3 npos, Vector3 tpos)
    {
        npcLocation.transform.localPosition = npos;
        travellerTicket.transform.localPosition = tpos;
        Debug.Log("NPC Location: " + npcLocation.transform.localPosition);
    }
    public void ChangeLocation(int currentLocation)
    {
        npcLocation = GameObject.Find("firstclassman");
        travellerTicket = GameObject.Find("ticket");
        switch (currentLocation)
        {
            case 0:
                SetState(new Vector3(-1400, -275, -1), new Vector3(-2000, 0, -1.1f));
                break;

            case 1:
                SetState(new Vector3(-450, -275, -1), new Vector3(400, 0, -1.1f));
                break;
        }
    }
}
