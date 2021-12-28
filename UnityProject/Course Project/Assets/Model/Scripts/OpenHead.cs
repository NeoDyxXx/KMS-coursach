using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpenHead : MonoBehaviour, IPointerClickHandler
{
    float speed = 0.04f;
    float offset = 0;
    bool move = false;
    public Transform closeHeadTransform;
    public Transform openHeadTransform;
    public Transform HeadObjectTransform;
    InstallSetting main;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!main.runTwoMinutersTimer)
        {
            move = true;
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().FourthTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().NinethTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirdthTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().SeventeenthTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().TwentyOnethTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().TwentyFivethTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().TwentyNinethTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirtyThreethTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirtySeventhTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().FourtyOnethTask();

            if (main.materials.Count == 1 && main.materials.Contains(InstallSetting.Materials.RADIACTIVE))
                GameObject.Find("PracticeObject").GetComponent<PracticScript>().FivethTask();
            else if (main.materials.Count == 2 && main.materials.Contains(InstallSetting.Materials.RADIACTIVE)
                && main.materials.Contains(InstallSetting.Materials.LEAK))
                GameObject.Find("PracticeObject").GetComponent<PracticScript>().TenthTask();
            else if (main.materials.Count == 3 && main.materials.Contains(InstallSetting.Materials.RADIACTIVE)
                && main.materials.Contains(InstallSetting.Materials.LEAK) && !main.materials.Contains(InstallSetting.Materials.COOPER))
            {
                GameObject.Find("PracticeObject").GetComponent<PracticScript>().FourteenthTask();
            }
            else if (main.materials.Count == 4 && main.materials.Contains(InstallSetting.Materials.RADIACTIVE)
                && main.materials.Contains(InstallSetting.Materials.LEAK) && !main.materials.Contains(InstallSetting.Materials.COOPER))
            {
                GameObject.Find("PracticeObject").GetComponent<PracticScript>().EightteenthTask();
            }
            else if (main.materials.Count == 5 && main.materials.Contains(InstallSetting.Materials.RADIACTIVE)
                && main.materials.Contains(InstallSetting.Materials.LEAK) && !main.materials.Contains(InstallSetting.Materials.COOPER))
            {
                GameObject.Find("PracticeObject").GetComponent<PracticScript>().TwentyTwoTask();
            }
            else if (main.materials.Count == 2 && main.materials.Contains(InstallSetting.Materials.RADIACTIVE)
                && main.materials.Contains(InstallSetting.Materials.COOPER))
            {
                GameObject.Find("PracticeObject").GetComponent<PracticScript>().TwentySixthTask();
            }
            else if (main.materials.Count == 3 && main.materials.Contains(InstallSetting.Materials.RADIACTIVE)
                && main.materials.Contains(InstallSetting.Materials.COOPER) && !main.materials.Contains(InstallSetting.Materials.LEAK))
            {
                GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirtythTask();
            }
            else if (main.materials.Count == 4 && main.materials.Contains(InstallSetting.Materials.RADIACTIVE)
                && main.materials.Contains(InstallSetting.Materials.COOPER) && !main.materials.Contains(InstallSetting.Materials.LEAK))
            {
                GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirtyFourthTask();
            }
            else if (main.materials.Count == 5 && main.materials.Contains(InstallSetting.Materials.RADIACTIVE)
                && main.materials.Contains(InstallSetting.Materials.COOPER) && !main.materials.Contains(InstallSetting.Materials.LEAK))
            {
                GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirtyEighthTask();
            }
            else if (main.materials.Count == 0)
            {
                GameObject.Find("PracticeObject").GetComponent<PracticScript>().FourtyTwothTask();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("ModelDevMashine").GetComponent<InstallSetting>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!main.openHead)
        {
            if (move)
            {
                offset += speed;
                HeadObjectTransform.transform.position = Vector3.Lerp(HeadObjectTransform.transform.position, openHeadTransform.position, offset);
                HeadObjectTransform.transform.rotation = Quaternion.Lerp(HeadObjectTransform.transform.rotation, openHeadTransform.rotation, offset);

                if (offset >= 1)
                {
                    move = false;
                    offset = 0;
                    main.openHead = true;
                }
            }
        }
        else
        {
            if (move)
            {
                offset += speed;
                HeadObjectTransform.transform.position = Vector3.Lerp(HeadObjectTransform.transform.position, closeHeadTransform.position, offset);
                HeadObjectTransform.transform.rotation = Quaternion.Lerp(HeadObjectTransform.transform.rotation, closeHeadTransform.rotation, offset);

                if (offset >= 1)
                {
                    move = false;
                    offset = 0;
                    main.openHead = false;
                }
            }
        }
    }
}
