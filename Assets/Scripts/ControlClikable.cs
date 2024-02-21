using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlClikable : MonoBehaviour
{
    public int x, y;
    public TextMeshProUGUI text;

    private void OnMouseDown()
    {
        // si pulso una bomba com la etiqueta bomb esta casilla se ponga en roja y si no es bomba y es piece con else if este me genere instancie alrededor con getcellsaround piezas en x, y
    }
}
