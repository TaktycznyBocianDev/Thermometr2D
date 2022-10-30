using UnityEngine;

public class DragAndDropScript : MonoBehaviour
{
    private Vector3 mouseObjectDragOffset;
    private Camera camMain;

    private void Awake()
    {
        camMain = Camera.main;
    }

    //Poni¿sza funkcja likwiduje "skakanie" obiektu do myszki po naciœniêciu.
    private void OnMouseDown()
    {
        mouseObjectDragOffset = transform.position - GetMousePos();
    }
    //Chwytamy obiekt i przenosimy po ekranie
    private void OnMouseDrag()
    {
        transform.position = GetMousePos() + mouseObjectDragOffset;
    }
    Vector3 GetMousePos()
    {
        Vector3 mousePos = camMain.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
