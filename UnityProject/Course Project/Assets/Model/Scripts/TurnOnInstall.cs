using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TurnOnInstall : MonoBehaviour, IPointerClickHandler
{
    InstallSetting main;

    void Start()
    {
        main = GameObject.Find("ModelDevMashine").GetComponent<InstallSetting>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        main.TurnOnOrOffInstall();
    }
}
