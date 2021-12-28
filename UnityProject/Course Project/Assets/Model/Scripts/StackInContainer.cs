using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;

public class StackInContainer : MonoBehaviour, IPointerClickHandler
{
    float speed = 0.04f;
    float offset = 0;
    bool moveOne = false;
    bool moveTwo = false;
    bool moveThree = false;
    Transform upperBagContainer;
    Transform bagContainer;
    Transform baseLocation;
    InstallSetting main;

    bool stacked = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!main.inProcessStacked && main.openHead)
        {
            main.inProcessStacked = true;

            if (!stacked)
            {
                if (!main.openHead || main.materials.Count > 4)
                {
                }
                else
                {
                    if (this.tag == "Leak")
                        main.AddToMaterials(InstallSetting.Materials.LEAK);
                    else if (this.tag == "Cooper")
                        main.AddToMaterials(InstallSetting.Materials.COOPER);
                    else
                        main.AddToMaterials(InstallSetting.Materials.RADIACTIVE);

                    moveOne = true;
                }
            }
            else
            {
                if (main.openHead)
                {
                    if (this.tag == "Leak")
                        main.PopToMaterials(InstallSetting.Materials.LEAK);
                    else if (this.tag == "Cooper")
                        main.PopToMaterials(InstallSetting.Materials.COOPER);
                    else
                        main.PopToMaterials(InstallSetting.Materials.RADIACTIVE);
                    moveOne = true;
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("ModelDevMashine").GetComponent<InstallSetting>();
        upperBagContainer = GameObject.Find("UpperBagPos").GetComponent<Transform>();
        bagContainer = GameObject.Find("BagPos").GetComponent<Transform>();

        baseLocation = GameObject.Find("baseLoc" + this.tag).GetComponent<Transform>();
    }

    int GetCountSameMaterialInStack(InstallSetting.Materials material)
    {
        return main.materials.Select(el => el == material).Count();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (moveOne)
        {
            offset += speed;
            this.transform.position = Vector3.Lerp(this.transform.position, upperBagContainer.position, offset);

            if (offset >= 1)
            {
                moveOne = false;
                if (!stacked)
                    moveTwo = true;
                else
                    moveThree = true;

                offset = 0;
            }
        }

        if (moveTwo)
        {
            offset += speed;
            Debug.Log(main.materials.Count);
            this.transform.position = Vector3.Lerp(this.transform.position, bagContainer.position + main.materials.Count * new Vector3(0, 0.070f, 0), offset);

            if (offset >= 1)
            {
                moveOne = false;
                moveTwo = false;
                offset = 0;
                stacked = true;
                main.inProcessStacked = false;
            }
        }

        if (moveThree)
        {
            offset += speed;
            if (this.tag == "Radiactive")
                this.transform.position = Vector3.Lerp(this.transform.position, baseLocation.position, offset);
            else
            {
                Debug.Log(GetCountSameMaterialInStack(InstallSetting.Materials.COOPER));
                if (this.tag == "Leak")
                    this.transform.position = Vector3.Lerp(this.transform.position, baseLocation.position 
                        + (3 - GetCountSameMaterialInStack(InstallSetting.Materials.LEAK)) * new Vector3(0, 0.059f, 0), offset);
                else
                    this.transform.position = Vector3.Lerp(this.transform.position, baseLocation.position
                       + (3 - GetCountSameMaterialInStack(InstallSetting.Materials.COOPER)) * new Vector3(0, 0.059f, 0), offset);
            }

            if (offset >= 1)
            {
                moveThree = false;
                offset = 0;
                stacked = false;
                main.inProcessStacked = false;
            }
        }
    }
}
