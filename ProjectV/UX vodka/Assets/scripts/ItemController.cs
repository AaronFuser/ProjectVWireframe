using System.Collections;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public DisplayLogic[] MyDisplays;
    public ScriptableItem[] Possibleitems;

    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < MyDisplays.Length; i++)
        {
            for (int x = 0; x < 3; x++)
            {
                MyDisplays[i]._items.Add(Possibleitems[0]);
            }
            
            MyDisplays[i].SetDisplay();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }



}
