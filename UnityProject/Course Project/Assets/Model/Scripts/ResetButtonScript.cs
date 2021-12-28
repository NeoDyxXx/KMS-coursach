using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResetButtonScript : MonoBehaviour, IPointerClickHandler
{
    InstallSetting main;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (main.turnOn)
        {
            main.runTwoMinutersTimer = false;
            main.interfaceText.text = "0000";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("ModelDevMashine").GetComponent<InstallSetting>();
    }
}
