using UnityEngine;

public class PlayerNavigation : MonoBehaviour
{
    private Room room;
    private GameObject playerLocation;
  

    private void Start()
    {
        room = GameObject.Find("train").GetComponent<Room>();
        ChangeLocation(0);
    }
    
    private void DefaultRooms()
    {   
       
        for (int i = 0; i < 5; i++)
        {
            //roomSprites[0].sprite = (texturename);      When art received replace this!!!
            room.roomSprites[i].color = Color.black;
        }
    }
    private void SetState(int index, Vector3 pos)
    {
        playerLocation.transform.localPosition = pos;
        room.roomSprites[index].color = Color.white;
        Debug.Log(playerLocation.transform.localPosition);
    } 
    public void ChangeLocation(int currentLocation)
    {
        DefaultRooms();
        playerLocation = GameObject.Find("conductor");
        
        switch (currentLocation){

            case 0:
                SetState(0, new Vector3(16, 0, -1));
                break;

            case 1:
                SetState(1, new Vector3(8, 0, -1));
                break;
            case 2:
                SetState(2, new Vector3(0, 0, -1));
                break;

            case 3:
                SetState(3, new Vector3(-8, 0, -1));
                break;

            case 4:
                SetState(4, new Vector3(-16, 0, -1));
                break;
        }
    }
}
