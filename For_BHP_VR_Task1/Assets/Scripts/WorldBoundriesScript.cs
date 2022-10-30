using UnityEngine;

public class WorldBoundriesScript : MonoBehaviour
{
    /* 
     * Skrypt ten pozwoli zablokowaæ ruch termometru do granic wyœwietlanych przez ekran.
     * Wykorzystujemy tu granice okreœlone przez sprzêt, nie ustawione na sztywno, aby program
     * dzia³a³ na ka¿dej rozdzielczoœci.
     */

    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    private Camera camMain;

    private void Awake()
    {
        camMain = Camera.main;
    }

    private void Start()
    {
        screenBounds = camMain.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        //Poni¿ej mno¿ymy screenBounds.x/y razy -1 gdy¿ wartoœæ podawana jest domyœlnie ujemna. 
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight);
        transform.position = viewPos;
    }

}
