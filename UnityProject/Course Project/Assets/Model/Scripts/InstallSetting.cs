using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using UnityEngine.UI;

public class InstallSetting : MonoBehaviour
{
    public enum IncludeButton
    {
        PHONE,
        PROBA,
        TWO,
        TWENTY,
        K,
        CS
    }
    public enum Materials
    {
        LEAK,
        COOPER,
        RADIACTIVE
    }
    public bool turnOn { get; private set; }
    public bool openHead { get; set; }
    public bool isPhone { get; set; }
    public TextMeshPro interfaceText { get; private set; }
    public Color defaultSphereColor;
    public List<IncludeButton> includesButton { get; private set; }
    public List<Materials> materials { get; private set; }
    public bool runTwoMinutersTimer { get; set; } = false;
    public bool runTwentyMinutersTimer { get; set; } = false;

    public bool breakTimers { get; set; } = false;
    public bool addedToFone { get; private set; }
    public bool inProcessStacked { get; set; } = false;
    public bool errorTurnOff { get; set; } = false;
    

    // Start is called before the first frame update
    void Start()
    {
        turnOn = false;
        openHead = false;
        interfaceText = GameObject.Find("InterfaceText").GetComponent<TextMeshPro>();
        defaultSphereColor = GameObject.Find("Button2Sphere").GetComponent<Renderer>().material.color;

        includesButton = new List<IncludeButton>();
        materials = new List<Materials>();
    }

    public void TurnOnOrOffInstall()
    {
        if (!turnOn)
        {
            turnOn = true;
            isPhone = true;
            interfaceText.text = "0000";

            GameObject.Find("Button2Sphere").GetComponent<Renderer>().material.color = Color.red;
            GameObject.Find("Button6Sphere").GetComponent<Renderer>().material.color = Color.red;

            AddToIncludeButton(IncludeButton.PHONE);
            AddToIncludeButton(IncludeButton.K);
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().SecondTask();
        }
        else
        {
            turnOn = false;
            interfaceText.text = "";
            runTwoMinutersTimer = false;

            GameObject.Find("Button1Sphere").GetComponent<Renderer>().material.color = defaultSphereColor;
            GameObject.Find("Button2Sphere").GetComponent<Renderer>().material.color = defaultSphereColor;
            GameObject.Find("Button3Sphere").GetComponent<Renderer>().material.color = defaultSphereColor;
            GameObject.Find("Button4Sphere").GetComponent<Renderer>().material.color = defaultSphereColor;
            GameObject.Find("Button5Sphere").GetComponent<Renderer>().material.color = defaultSphereColor;
            GameObject.Find("Button6Sphere").GetComponent<Renderer>().material.color = defaultSphereColor;

            includesButton.Clear();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().FourtyThreethTask();

            if (GameObject.Find("PracticeObject").GetComponent<PracticScript>().counterTask < 40)
            {
                errorTurnOff = true;
                GameObject.Find("Canvas").GetComponent<OnCanvas>().OnClickClearTableButton();
                errorTurnOff = false;
            }
        }
    }

    public void OpenOrCloseHead() => openHead = !openHead;

    public void AddToIncludeButton(IncludeButton includeButton)
    {
        if (includesButton.Contains(includeButton)) return;
        if (includeButton == IncludeButton.K) includesButton.Remove(IncludeButton.CS);
        else includesButton.Remove(IncludeButton.K);
        if (includeButton == IncludeButton.PHONE) includesButton.Remove(IncludeButton.PROBA);
        else includesButton.Remove(IncludeButton.PHONE);
        if (includeButton == IncludeButton.TWO) includesButton.Remove(IncludeButton.TWENTY);
        else includesButton.Remove(IncludeButton.TWO);

        includesButton.Add(includeButton);
    }

    public void DelInIncludeButton(IncludeButton includeButton)
    {
        includesButton.Remove(includeButton);
    }

    public void AddToMaterials(Materials material)
    {
        if (materials.Count <= 4)
            materials.Add(material);
    }

    public void PopToMaterials(Materials material)
    {
        materials.Remove(material);
    }

    public void StartTwoMinutesTimer()
    {
        if (!runTwoMinutersTimer && !runTwentyMinutersTimer)
        {
            IEnumerator corutine = RunTwoMinuteTimer(1.0f);
            runTwoMinutersTimer = true;

            if (!isPhone && !addedToFone)
            { }
            else
            {
                GameObject.Find("Canvas").GetComponent<OnCanvas>().breakTimersButton.SetActive(true);
            }

            StartCoroutine(BlinkSphere(1f, "Button4Sphere"));
            StartCoroutine(corutine);
        }
    }

    public void StartTwentyMinutesTimer()
    {
        if (!runTwoMinutersTimer && !runTwentyMinutersTimer)
        {
            IEnumerator corutine = RunTwentyMinuteTimer(1.0f);
            runTwentyMinutersTimer = true;

            if (!isPhone && !addedToFone)
            { }
            else
            {
                GameObject.Find("Canvas").GetComponent<OnCanvas>().breakTimersButton.SetActive(true);
            }

            StartCoroutine(corutine);
        }
    }

    public IEnumerator RunTwoMinuteTimer(float waitTime)
    {
        for (int i = 0; i < 120; i++)
        {
            if (!isPhone && !addedToFone) break;
            if (!turnOn || !runTwoMinutersTimer || breakTimers) break;

            interfaceText.text = string.Format("{0:d4}", 120 - i);
            yield return new WaitForSeconds(waitTime);
        }

        if (runTwoMinutersTimer) interfaceText.text = GetValueInInstall();
        runTwoMinutersTimer = false;
        breakTimers = false;

        if (isPhone)
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirdTask();
        else
        {
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().SeventhTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().EleventhTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().FiveteenthTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().NineteenthTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().TwentyThreethTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().TwentySeventhTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirtyOnethTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirtyFivethTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirtyNinethTask();
            GameObject.Find("PracticeObject").GetComponent<PracticScript>().FourtyOnethTask();
        }
    }

    public IEnumerator RunTwentyMinuteTimer(float waitTime)
    {
        for (int i = 0; i < 1200; i++)
        {
            if (!isPhone && !addedToFone) break;
            if (!turnOn || !runTwentyMinutersTimer || breakTimers) break;

            interfaceText.text = string.Format("{0:d4}", 1200 - i);
            yield return new WaitForSeconds(waitTime);
        }

        if (runTwentyMinutersTimer) interfaceText.text = GetValueInInstall();
        runTwentyMinutersTimer = false;
        breakTimers = false;
    }

    public IEnumerator BlinkSphere(float waitTime, string element)
    {
        GameObject.Find(element).GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(waitTime);
        GameObject.Find(element).GetComponent<Renderer>().material.color = defaultSphereColor;
    }

    public string GetValueInInstall()
    {
        if (isPhone)
        {
            addedToFone = true;
            return "0000";
        }
        else
        {
            if (runTwentyMinutersTimer)
            {
                if (!addedToFone)
                {
                    return "Err";
                }
                if (materials.Count == 0) return "0000";

                Stack<Materials> tempMaterials = new Stack<Materials>(materials);

                int count_materials = -1;
                Materials material = Materials.RADIACTIVE;

                try
                {
                    for (int i = 0; i < tempMaterials.Count; i++)
                    {
                        if (count_materials == 0)
                        {
                            return "22.50";
                        }

                        if (tempMaterials.Pop() == Materials.RADIACTIVE)
                        {
                            try
                            {
                                count_materials = tempMaterials.Count;
                                material = tempMaterials.Pop();
                            }
                            catch { return "22.50"; }

                            break;
                        }
                    }

                    if (count_materials == 0)
                    {
                        return "22.50";
                    }

                    if (material == Materials.COOPER)
                    {
                        if (count_materials == 1) return "19.00";
                        if (count_materials == 2) return "15.50";
                        if (count_materials == 3) return "13.00";
                        if (count_materials == 4) return "9.500";
                    }

                    if (material == Materials.LEAK)
                    {
                        if (count_materials == 1) return "8.500";
                        if (count_materials == 2) return "5.750";
                        if (count_materials == 3) return "2.310";
                        if (count_materials == 4) return "1.140";
                    }

                    return "0000";
                }
                catch
                {
                    return "0000";
                }
            }
            else
            {
                if (!addedToFone)
                {
                    return "Err";
                }
                if (materials.Count == 0) return "0000";

                Stack<Materials> tempMaterials = new Stack<Materials>(materials);

                int count_materials = -1;
                Materials material = Materials.RADIACTIVE;

                try
                {
                    for (int i = 0; i < tempMaterials.Count; i++)
                    {
                        if (count_materials == 0)
                        {
                            return "2.250";
                        }

                        if (tempMaterials.Pop() == Materials.RADIACTIVE)
                        {
                            try
                            {
                                count_materials = tempMaterials.Count;
                                material = tempMaterials.Pop();
                            }
                            catch { return "2.250"; }

                            break;
                        }
                    }

                    if (count_materials == 0)
                    {
                        return "2.250";
                    }

                    if (material == Materials.COOPER)
                    {
                        if (count_materials == 1) return "1.900";
                        if (count_materials == 2) return "1.550";
                        if (count_materials == 3) return "1.300";
                        if (count_materials == 4) return "0.950";
                    }

                    if (material == Materials.LEAK)
                    {
                        if (count_materials == 1) return "0.850";
                        if (count_materials == 2) return "0.575";
                        if (count_materials == 3) return "0.231";
                        if (count_materials == 4) return "0.114";
                    }

                    return "0000";
                }
                catch
                {
                    return "0000";
                }
            }
        }
    }
}