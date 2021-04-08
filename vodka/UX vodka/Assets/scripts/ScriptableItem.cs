using UnityEngine;

[CreateAssetMenu(fileName = "newItem", menuName = "ScriptableObject/Item")]
public class ScriptableItem : ScriptableObject
{
    public string _name;
    public int _price;
    public Sprite _sprite;
    public string _type;
    public string _perk;

}
