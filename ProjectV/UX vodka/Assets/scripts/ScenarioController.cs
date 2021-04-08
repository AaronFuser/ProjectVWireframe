using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioController : MonoBehaviour
{
    //public GameObject[] _scenarioNum;
    public int _currentActiveScenario = 1;
    public shopcontroller _treasurytracka;
    public GameObject _Scena1;
    public GameObject _Scena2;
    public GameObject _Scena3;

    public GameObject _button1;
    public GameObject _button2;
    public GameObject _button3;
    // Start is called before the first frame update
    void Start()
    {
        //_activeScena = _scenarioNum.GetValue(_currentActiveScenario);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScenarioCompleted(int toBeActive)
    {
        if (toBeActive == 1)
        {
            _Scena1.SetActive(false);
            _Scena2.SetActive(true);
            _Scena3.SetActive(false);

            _button1.SetActive(false);
            _button2.SetActive(true);
            _button3.SetActive(false);

            _treasurytracka.mytreasury += 100;
        }
        if (toBeActive == 2)
        {
            _Scena1.SetActive(false);
            _Scena2.SetActive(false);
            _Scena3.SetActive(true);

            _button1.SetActive(false);
            _button2.SetActive(false);
            _button3.SetActive(true);

            _treasurytracka.mytreasury += 100;
        }
        if (toBeActive == 3)
        {
            _Scena1.SetActive(true);
            _Scena2.SetActive(false);
            _Scena3.SetActive(false);

            _button1.SetActive(true);
            _button2.SetActive(false);
            _button3.SetActive(false);

            _treasurytracka.mytreasury += 100;
        }
    }
}
