using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Nueva bestia",menuName="Bestia")]

public class Bestia : ScriptableObject
{
    // Start is called before the first frame update
    public string nomberBestia;
    public int tipoBestia;
    public Sprite imagenBestia;
    public string descripcionBestia;
    public string estadisticasBestia;
    
}
