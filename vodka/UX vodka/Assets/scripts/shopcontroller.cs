using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopcontroller : MonoBehaviour
{

    public int mytreasury;

    public Text treasurytext;

    public ScriptableTransfer transfer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        treasurytext.text = mytreasury.ToString();
        if(transfer._value != null)
        {
            //shit to do



            //set to null so we don't do it every frame
            transfer._value = null;
        }
    }

    public void OnBuy()
    {
        if(mytreasury >= transfer._value._price)
        {
            mytreasury -= transfer._value._price;
        }
        
    }
}
