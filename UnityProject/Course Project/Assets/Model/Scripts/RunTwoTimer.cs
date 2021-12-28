using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Threading;

public class RunTwoTimer : MonoBehaviour, IPointerClickHandler
{
    InstallSetting main;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        if (main.turnOn)
        {
            GameObject.Find("Button4Sphere").GetComponent<Renderer>().material.color = Color.red;
            main.AddToIncludeButton(InstallSetting.IncludeButton.TWO);

            main.StartTwoMinutesTimer();

            Thread.Sleep(1000);
            GameObject.Find("Button4Sphere").GetComponent<Renderer>().material.color = main.defaultSphereColor;
            main.DelInIncludeButton(InstallSetting.IncludeButton.TWO);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("ModelDevMashine").GetComponent<InstallSetting>();
    }
}
