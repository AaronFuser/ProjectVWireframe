using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLogic : MonoBehaviour
{
    //our output displays
    public Text[] _heading, _itemType, _perk, _cost, _durability;
    public Image[] _images;
    public GameObject[] _panels;
    public shopcontroller _amBuying;
    //our input values
    public List<ScriptableItem> _items = new List<ScriptableItem>();
    public ScriptableTransfer _transfer;

    private void OnEnable()
    {
        SetDisplay();
    }

    public void SetDisplay()
    {
        for (int z = 0; z < 3; z++)
        {
            for (int i = 0; i < _heading.Length; i++)
            {
                if (i < _items.Count)
                {
                    _heading[i].text = _items[i]._name;
                    _images[i].sprite = _items[i]._sprite;
                    _itemType[i].text = _items[i]._type;
                    _cost[i].text = _items[i]._price.ToString();
                }
            }
        }
        
    }

    public void OnClick(ScriptableItem _myitem)
    {
        _transfer._value = _myitem;
        _amBuying.OnBuy();
        
        //scriptableitem(list version) needs to be calleld with an ID from the button. tehn into event.
    }
       
}