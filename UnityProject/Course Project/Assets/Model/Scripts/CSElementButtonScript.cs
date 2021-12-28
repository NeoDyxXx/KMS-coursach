using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CSElementButtonScript : MonoBehaviour, IPointerClickHandler
{
    InstallSetting main;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (main.turnOn)
        {
            GameObject.Find("Button7Sphere").GetComponent<Renderer>().material.color = Color.red;
            GameObject.Find("Button6Sphere").GetComponent<Renderer>().material.color = main.defaultSphereColor;

            main.AddToIncludeButton(InstallSetting.IncludeButton.CS);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("ModelDevMashine").GetComponent<InstallSetting>();
    }
}
