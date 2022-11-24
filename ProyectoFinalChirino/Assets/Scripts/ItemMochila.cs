using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Nuevo Item",menuName="Item")]

public class ItemMochila : ScriptableObject
{
    // Start is called before the first frame update
    public string nomberItem;
    public int cantidadItem;
    public Sprite imagenItem;
    public string descripcionItem;
}
