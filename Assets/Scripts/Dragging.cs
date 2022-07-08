using UnityEngine;

public class Dragging : MonoBehaviour
{
    /*//private bool isDragging;
    public void OnMouseDown()
    {
        //isDragging = true;
    }
    public void OnMouseUp()
    {
        //isDragging = false;
    }*/
    public void OnMouseDrag()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.Translate(mousePosition);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collision " + other.name);
    }
}
