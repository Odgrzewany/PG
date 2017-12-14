using UnityEngine;


[CreateAssetMenu(menuName = "Moba/Item")]
public class Item : ScriptableObject {

    public string itemName;
    [TextArea] public string desc;
    public float damage;
}
