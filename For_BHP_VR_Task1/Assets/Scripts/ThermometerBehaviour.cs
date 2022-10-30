using TMPro;
using UnityEngine;

public class ThermometerBehaviour : MonoBehaviour
{
    [Header("Tekst wy�wietlnany na sprite")]
    [SerializeField] TextMeshProUGUI text;

    //Zmieniamy temperatur� na termometrze
    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.SetText(collision.gameObject.GetComponent<TemperatureFieldScript>().temperature.ToString());
    }
}
