using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialManager : MonoBehaviour
{
    public TextMeshProUGUI instrucciones;
    public GameObject botonColor, botonRotar, botonEscalar;
    public bool botonColorPresionado, botonRotarPresionado, botonEscalarPresionado;
    // Start is called before the first frame update
    void Start()
    {
        botonColor.SetActive(false);
        botonRotar.SetActive(false);
        botonEscalar.SetActive(false);
        StartCoroutine(Tutorial());
    }

    IEnumerator Tutorial()
    {
        instrucciones.text = "Bienvenido al tutorial.";
        yield return new WaitForSeconds(2);
        instrucciones.text = "Ahora vamos a probar como modificar este cubo.";
        yield return new WaitForSeconds(2);
        instrucciones.text = "Haz click en el botón de cambiar color.";
        yield return new WaitForSeconds(2);
        botonColor.SetActive(true);
        yield return new WaitUntil(() => botonColorPresionado);
        instrucciones.text = "Perfecto, presiona el boton más veces para cambiar a distintos colores.";
        yield return new WaitForSeconds(2);
        instrucciones.text = "Ahora lo hará rotar con el siguiente botón.";
        yield return new WaitForSeconds(2);
        botonRotar.SetActive(true);
        yield return new WaitUntil(() => botonRotarPresionado);
        instrucciones.text = "Ahora nos queda el último.";
        yield return new WaitForSeconds(2);
        instrucciones.text = "Este botón hará que el cubo haga un pequeño movimiento de escala aleatorio.";
        yield return new WaitForSeconds(2);
        botonEscalar.SetActive(true);
        yield return new WaitUntil(() => botonEscalarPresionado);
        instrucciones.text = "Haz terminado el tutorial.";
        yield return new WaitForSeconds(2);
        instrucciones.text = "Felicidades.";
        yield return new WaitForSeconds(2);
        instrucciones.text = "";
        //yield return new wai
        yield break;
    }
    public void SetColorPresiona(bool set)
    {
        botonColorPresionado = set;
    }
    public void SetRotarPresionado(bool set)
    {
        botonRotarPresionado = set;
    }
    public void SetEscalarPresionado(bool set)
    {
        botonEscalarPresionado = set;
    }
}
