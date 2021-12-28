using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KElementButtonScript : MonoBehaviour, IPointerClickHandler
{
    InstallSetting main;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (main.turnOn)
        {
            GameObject.Find("Button6Sphere").GetComponent<Renderer>().material.color = Color.red;
            GameObject.Find("Button7Sphere").GetComponent<Renderer>().material.color = main.defaultSphereColor;

            main.AddToIncludeButton(InstallSetting.IncludeButton.K);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("ModelDevMashine").GetComponent<InstallSetting>();
    }
}
