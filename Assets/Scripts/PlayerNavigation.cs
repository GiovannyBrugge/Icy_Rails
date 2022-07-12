using UnityEngine;

public class PlayerNavigation : MonoBehaviour
{
    private Room room;
    private GameObject playerLocation;
    public Sprite roofSprite;
    public Sprite trainSprite;
    private void Start()
    {
        
        room = GameObject.Find("train").GetComponent<Room>();
        room.SetRoom();
        ChangeLocation(0);
    }
    
    private void DefaultRooms()
    {   
       
        for (int i = 0; i < 5; i++)
        {
            room.roomImages[i].sprite = roofSprite;
            //room.roomSprites[i].color = Color.black;
        }
    }
    private void SetState(int index, Vector3 pos)
    {
        playerLocation.transform.localPosition = pos;
        room.roomImages[index].sprite = trainSprite;
        //room.roomSprites[index].color = Color.white;
        Debug.Log("Player position: " + playerLocation.transform.localPosition);
    } 
    public void ChangeLocation(int currentLocation)
    {
        DefaultRooms();
        playerLocation = GameObject.Find("conductor");
        
        switch (currentLocation){

            case 0:
                SetState(0, new Vector3(18, 0, -1.1f));
                break;

            case 1:
                SetState(1, new Vector3(10, 0, -1.1f));
                break;
            case 2:
                SetState(2, new Vector3(2, 0, -1.1f));
                break;

            case 3:
                SetState(3, new Vector3(-6, 0, -1.1f));
                break;

            case 4:
                SetState(4, new Vector3(-14, 0, -1.1f));
                break;
        }
    }
}
