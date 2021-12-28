using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject installButton;
    GameObject practicButton;
    GameObject backButton;

    GameObject headButton;
    GameObject intarfaceButton;
    GameObject materialButton;
    GameObject conteinerButton;

    public GameObject infoEvent;
    public GameObject infoEventText;
    GameObject clearTableButton;
    GameObject typeValueButton;
    GameObject openTableButton;
    public GameObject tableInput;

    public GameObject table;
    public PracticScript practiceObject;

    public GameObject infoEventHover;
    public GameObject infoEventHoverText;

    public GameObject breakTimersButton;

    void Start()
    {
        GameObject.Find("infoButton").GetComponent<Button>().onClick.AddListener(OnClickInfoButton);
        GameObject.Find("infoButton").SetActive(true);
        installButton = GameObject.Find("installButton");
        practicButton = GameObject.Find("practicButton");
        backButton = GameObject.Find("backButton");
        headButton = GameObject.Find("HeadButton");
        conteinerButton = GameObject.Find("ContainerButton"); 
        intarfaceButton = GameObject.Find("PanelDevButton");
        materialButton = GameObject.Find("MaterialsButton");

        infoEvent = GameObject.Find("infoEvent");
        infoEventText = GameObject.Find("infoEventText");
        clearTableButton = GameObject.Find("clearTableButton");
        typeValueButton = GameObject.Find("typeValueButton");
        openTableButton = GameObject.Find("openTableButton");
        tableInput = GameObject.Find("tableInput");

        infoEventHover = GameObject.Find("infoEventHover");
        infoEventHoverText = GameObject.Find("infoEventHoverText");

        table = GameObject.Find("DataTable");
        practiceObject = GameObject.Find("PracticeObject").GetComponent<PracticScript>();

        breakTimersButton = GameObject.Find("breakTimers");

        installButton.GetComponent<Button>().onClick.AddListener(OnClickInstallButton);
        practicButton.GetComponent<Button>().onClick.AddListener(OnClickPracticeButton);
        backButton.GetComponent<Button>().onClick.AddListener(OnClickBackButton);
        breakTimersButton.GetComponent<Button>().onClick.AddListener(OnClickBreakTimersButton);
        typeValueButton.GetComponent<Button>().onClick.AddListener(OnClickTypeValueButton);
        openTableButton.GetComponent<Button>().onClick.AddListener(OnClickOpenTableButton);
        clearTableButton.GetComponent<Button>().onClick.AddListener(OnClickClearTableButton);

        installButton.SetActive(true);
        practicButton.SetActive(true);
        headButton.SetActive(false);
        intarfaceButton.SetActive(false);
        materialButton.SetActive(false);
        backButton.SetActive(false);
        conteinerButton.SetActive(false);
        breakTimersButton.SetActive(false);
        infoEvent.SetActive(false);
        table.SetActive(false);
        infoEventHover.SetActive(false);
    }

    void OnClickInfoButton()
    {
        GameObject.Find("infoText").GetComponent<Text>().enabled = !GameObject.Find("infoText").GetComponent<Text>().enabled;
        GameObject.Find("infoImage").GetComponent<Image>().enabled = !GameObject.Find("infoImage").GetComponent<Image>().enabled;
    }

    void OnClickInstallButton()
    {
        installButton.SetActive(false);
        practicButton.SetActive(false);
        headButton.SetActive(true);
        intarfaceButton.SetActive(true);
        materialButton.SetActive(true);
        backButton.SetActive(true);
        conteinerButton.SetActive(true);
    }

    void OnClickPracticeButton()
    {
        infoEvent.SetActive(true);
        practiceObject.StartPractice();
        practiceObject.FirstTask();
    }

    void OnClickBackButton()
    {
        installButton.SetActive(true);
        practicButton.SetActive(true);
        headButton.SetActive(false);
        intarfaceButton.SetActive(false);
        materialButton.SetActive(false);
        backButton.SetActive(false);
        conteinerButton.SetActive(false);
    }

    void OnClickBreakTimersButton()
    {
        GameObject.Find("ModelDevMashine").GetComponent<InstallSetting>().breakTimers = true;
        breakTimersButton.SetActive(false);
    }

    void OnClickOpenTableButton()
    {
        if (table.active)
        {
            table.SetActive(false);
        }
        else
            table.SetActive(true);
    }

    public void OnClickClearTableButton()
    {
        if (practiceObject.finishPractice || GameObject.Find("ModelDevMashine").GetComponent<InstallSetting>().errorTurnOff)
        {
            table.SetActive(true);
            for (int i = 1; i <= 40; i++)
            {
                GameObject.Find("table_labal" + System.Convert.ToString(i)).GetComponent<Text>().text = "";
            }
            table.SetActive(false);

            infoEvent.SetActive(false);
            practiceObject.ClosePractice();
        }
    }

    void OnClickTypeValueButton()
    {
        if (GameObject.Find("PracticeObject").GetComponent<PracticScript>().counterTask == 7)
        {
            table.SetActive(true);
            GameObject.Find("table_labal1").GetComponent<Text>().text = GameObject.Find("placeholderInputText").GetComponent<Text>().text;
            GameObject.Find("table_labal2").GetComponent<Text>().text = GameObject.Find("placeholderInputText").GetComponent<Text>().text;
            table.SetActive(false);

            GameObject.Find("PracticeObject").GetComponent<PracticScript>().EighthTask();
        }
        else if (GameObject.Find("PracticeObject").GetComponent<PracticScript>().counterTask == 11)
        {
            table.SetActive(true);
            GameObject.Find("table_labal11").GetComponent<Text>().text = GameObject.Find("placeholderInputText").GetComponent<Text>().text;
            table.SetActive(false);

            GameObject.Find("PracticeObject").GetComponent<PracticScript>().TwelvethTask();
        }
        else if (GameObject.Find("PracticeObject").GetComponent<PracticScript>().counterTask == 15)
        {
            table.SetActive(true);
            GameObject.Find("table_labal12").GetComponent<Text>().text = GameObject.Find("placeholderInputText").GetComponent<Text>().text;
            table.SetActive(false);

            GameObject.Find("PracticeObject").GetComponent<PracticScript>().SixteenthTask();
        }
        else if (GameObject.Find("PracticeObject").GetComponent<PracticScript>().counterTask == 19)
        {
            table.SetActive(true);
            GameObject.Find("table_labal13").GetComponent<Text>().text = GameObject.Find("placeholderInputText").GetComponent<Text>().text;
            table.SetActive(false);

            GameObject.Find("PracticeObject").GetComponent<PracticScript>().TwentythTask();
        }
        else if (GameObject.Find("PracticeObject").GetComponent<PracticScript>().counterTask == 23)
        {
            table.SetActive(true);
            GameObject.Find("table_labal14").GetComponent<Text>().text = GameObject.Find("placeholderInputText").GetComponent<Text>().text;
            table.SetActive(false);

            GameObject.Find("PracticeObject").GetComponent<PracticScript>().TwentyFourTask();
        }
        else if (GameObject.Find("PracticeObject").GetComponent<PracticScript>().counterTask == 27)
        {
            table.SetActive(true);
            GameObject.Find("table_labal15").GetComponent<Text>().text = GameObject.Find("placeholderInputText").GetComponent<Text>().text;
            table.SetActive(false);

            GameObject.Find("PracticeObject").GetComponent<PracticScript>().TwentyEighthTask();
        }
        else if (GameObject.Find("PracticeObject").GetComponent<PracticScript>().counterTask == 31)
        {
            table.SetActive(true);
            GameObject.Find("table_labal16").GetComponent<Text>().text = GameObject.Find("placeholderInputText").GetComponent<Text>().text;
            table.SetActive(false);

            GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirtyTwothTask();
        }
        else if (GameObject.Find("PracticeObject").GetComponent<PracticScript>().counterTask == 35)
        {
            table.SetActive(true);
            GameObject.Find("table_labal17").GetComponent<Text>().text = GameObject.Find("placeholderInputText").GetComponent<Text>().text;
            table.SetActive(false);

            GameObject.Find("PracticeObject").GetComponent<PracticScript>().ThirtySixthTask();
        }
        else if (GameObject.Find("PracticeObject").GetComponent<PracticScript>().counterTask == 39)
        {
            table.SetActive(true);
            GameObject.Find("table_labal18").GetComponent<Text>().text = GameObject.Find("placeholderInputText").GetComponent<Text>().text;
            table.SetActive(false);

            GameObject.Find("PracticeObject").GetComponent<PracticScript>().FourtythTask();
        }
    }

    public void InputSizeMaterialsInTable()
    {
        table.SetActive(true);

        GameObject.Find("table_labal3").GetComponent<Text>().text = "0.002";
        GameObject.Find("table_labal4").GetComponent<Text>().text = "0.00425";
        GameObject.Find("table_labal5").GetComponent<Text>().text = "0.00725";
        GameObject.Find("table_labal6").GetComponent<Text>().text = "0.01075";
        GameObject.Find("table_labal7").GetComponent<Text>().text = "0.0015";
        GameObject.Find("table_labal8").GetComponent<Text>().text = "0.003";
        GameObject.Find("table_labal9").GetComponent<Text>().text = "0.0045";
        GameObject.Find("table_labal10").GetComponent<Text>().text = "0.00525";

        table.SetActive(false);
    }

    public void InputFinalTaskValue()
    {
        table.SetActive(true);

        for (int i = 0; i < 8; i++)
        {
            try
            {
                GameObject.Find("table_labal" + System.Convert.ToString(19 + i)).GetComponent<Text>().text = 
                    string.Format("{0:f3}", System.Math.Log10(
                        System.Convert.ToDouble(GameObject.Find("table_labal1").GetComponent<Text>().text) / 
                        System.Convert.ToDouble(GameObject.Find("table_labal" + System.Convert.ToString(11 + i)).GetComponent<Text>().text)
                        ));
            }
            catch
            {
                GameObject.Find("table_labal" + System.Convert.ToString(19 + i)).GetComponent<Text>().text = "nan";
            }
        }

        for (int i = 0; i < 8; i++)
        {
            try
            {
                if (i < 5)
                {
                    GameObject.Find("table_labal" + System.Convert.ToString(27 + i)).GetComponent<Text>().text =
                        string.Format("{0:f3}", System.Math.Log10(
                            System.Convert.ToDouble(GameObject.Find("table_labal" + System.Convert.ToString(3 + i)).GetComponent<Text>().text) * 11340));
                }
                else
                {
                    GameObject.Find("table_labal" + System.Convert.ToString(27 + i)).GetComponent<Text>().text =
                       string.Format("{0:f2}", System.Convert.ToDouble(
                           GameObject.Find("table_labal" + System.Convert.ToString(3 + i)).GetComponent<Text>().text) * 8900);
                }
            }
            catch
            {
                GameObject.Find("table_labal" + System.Convert.ToString(27 + i)).GetComponent<Text>().text = "nan";
            }
        }

        GameObject.Find("table_labal35").GetComponent<Text>().text = "0.0329";
        GameObject.Find("table_labal36").GetComponent<Text>().text = "0.0137";
        GameObject.Find("table_labal37").GetComponent<Text>().text = "373.09";
        GameObject.Find("table_labal38").GetComponent<Text>().text = "186.32";
        GameObject.Find("table_labal39").GetComponent<Text>().text = "0.91";
        GameObject.Find("table_labal40").GetComponent<Text>().text = "4.12";

        table.SetActive(false);
    }

    public void EnableinfoEventHover(string text)
    {
        infoEventHover.SetActive(true);
        infoEventHoverText.GetComponent<Text>().text = text.Trim();
    }

    public void DisableinfoEventHover()
    {
        infoEventHover.SetActive(false);
    }
}
