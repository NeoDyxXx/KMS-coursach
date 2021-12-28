using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PracticScript : MonoBehaviour
{
    public bool startPractice { get; private set; }
    public int counterTask { get; private set; } = 0;
    public bool finishPractice { get; private set; } = false;
    OnCanvas onCanvasObject;
    Text taskText;


    // Start is called before the first frame update
    void Start()
    {
        onCanvasObject = GameObject.Find("Canvas").GetComponent<OnCanvas>();
    }

    public void StartPractice()
    {
        startPractice = true;
    }

    public void ClosePractice()
    {
        startPractice = false;
        finishPractice = false;
        counterTask = 0;
    }

    public void FirstTask()
    {
        taskText = GameObject.Find("infoEventText").GetComponent<Text>();

        if (startPractice && counterTask == 0)
        {
            taskText.text = "�������� ���������";
            counterTask++;
        }
    }

    public void SecondTask()
    {
        if (startPractice && counterTask == 1)
        {
            taskText.text = "������� �� ������ 2 ���., ����� �������� ������� �������� � ���������";
            counterTask++;
        }
    }

    public void ThirdTask()
    {
        if (startPractice && counterTask == 2)
        {
            taskText.text = "�������� �������� ������";
            counterTask++;
        }
    }

    public void FourthTask()
    {
        if (startPractice && counterTask == 3)
        {
            taskText.text = "�������� � ��������� ������������� ������� � �������� ������";
            counterTask++;
        }
    }

    public void FivethTask()
    {
        if (startPractice && counterTask == 4)
        {
            taskText.text = "������� �� ������ \"�����\"";
            counterTask++;
        }
    }

    public void SixthTask()
    {
        if (startPractice && counterTask == 5)
        {
            taskText.text = "������� �� ������ 2 ���.";
            counterTask++;
        }
    }

    public void SeventhTask()
    {
        if (startPractice && counterTask == 6)
        {
            taskText.text = "�������� ������������ �������� � �������";
            counterTask++;
        }
    }

    public void EighthTask()
    {
        if (startPractice && counterTask == 7)
        {
            taskText.text = "�������� �������� ������";
            onCanvasObject.InputSizeMaterialsInTable();
            counterTask++;
        }
    }

    public void NinethTask()
    {
        if (startPractice && counterTask == 8)
        {
            taskText.text = "�������� ��� ������������ ������� ���� �������� ������� � �������� ������";
            counterTask++;
        }
    }

    public void TenthTask()
    {
        if (startPractice && counterTask == 9)
        {
            taskText.text = "������� �� ������ 2 ���.";
            counterTask++;
        }
    }

    public void EleventhTask()
    {
        if (startPractice && counterTask == 10)
        {
            taskText.text = "�������� ������������ �������� � �������";
            counterTask++;
        }
    }

    public void TwelvethTask()
    {
        if (startPractice && counterTask == 11)
        {
            taskText.text = "�������� �������� ������";
            counterTask++;
        }
    }

    public void ThirdthTask()
    {
        if (startPractice && counterTask == 12)
        {
            taskText.text = "�������� ��� ������������ ������� ��� �������� ������� � �������� ������";
            counterTask++;
        }
    }

    public void FourteenthTask()
    {
        if (startPractice && counterTask == 13)
        {
            taskText.text = "������� �� ������ 2 ���.";
            counterTask++;
        }
    }

    public void FiveteenthTask()
    {
        if (startPractice && counterTask == 14)
        {
            taskText.text = "�������� ������������ �������� � �������";
            counterTask++;
        }
    }

    public void SixteenthTask()
    {
        if (startPractice && counterTask == 15)
        {
            taskText.text = "�������� �������� ������";
            counterTask++;
        }
    }

    public void SeventeenthTask()
    {
        if (startPractice && counterTask == 16)
        {
            taskText.text = "�������� ��� ������������ ������� ��� �������� ������� � �������� ������";
            counterTask++;
        }
    }

    public void EightteenthTask()
    {
        if (startPractice && counterTask == 17)
        {
            taskText.text = "������� �� ������ 2 ���.";
            counterTask++;
        }
    }

    public void NineteenthTask()
    {
        if (startPractice && counterTask == 18)
        {
            taskText.text = "�������� ������������ �������� � �������";
            counterTask++;
        }
    }

    public void TwentythTask()
    {
        if (startPractice && counterTask == 19)
        {
            taskText.text = "�������� �������� ������";
            counterTask++;
        }
    }

    public void TwentyOnethTask()
    {
        if (startPractice && counterTask == 20)
        {
            taskText.text = "�������� ��� ������������ ������� ������ �������� ������� � �������� ������";
            counterTask++;
        }
    }

    public void TwentyTwoTask()
    {
        if (startPractice && counterTask == 21)
        {
            taskText.text = "������� �� ������ 2 ���.";
            counterTask++;
        }
    }

    public void TwentyThreethTask()
    {
        if (startPractice && counterTask == 22)
        {
            taskText.text = "�������� ������������ �������� � �������";
            counterTask++;
        }
    }

    public void TwentyFourTask()
    {
        if (startPractice && counterTask == 23)
        {
            taskText.text = "�������� �������� ������";
            counterTask++;
        }
    }

    public void TwentyFivethTask()
    {
        if (startPractice && counterTask == 24)
        {
            taskText.text = "�������� ��� ������������ ������� ���� �������� ���� � �������� ������";
            counterTask++;
        }
    }

    public void TwentySixthTask()
    {
        if (startPractice && counterTask == 25)
        {
            taskText.text = "������� �� ������ 2 ���.";
            counterTask++;
        }
    }

    public void TwentySeventhTask()
    {
        if (startPractice && counterTask == 26)
        {
            taskText.text = "�������� ������������ �������� � �������";
            counterTask++;
        }
    }

    public void TwentyEighthTask()
    {
        if (startPractice && counterTask == 27)
        {
            taskText.text = "�������� �������� ������";
            counterTask++;
        }
    }

    public void TwentyNinethTask()
    {
        if (startPractice && counterTask == 28)
        {
            taskText.text = "�������� ��� ������������ ������� ��� �������� ���� � �������� ������";
            counterTask++;
        }
    }

    public void ThirtythTask()
    {
        if (startPractice && counterTask == 29)
        {
            taskText.text = "������� �� ������ 2 ���.";
            counterTask++;
        }
    }

    public void ThirtyOnethTask()
    {
        if (startPractice && counterTask == 30)
        {
            taskText.text = "�������� ������������ �������� � �������";
            counterTask++;
        }
    }

    public void ThirtyTwothTask()
    {
        if (startPractice && counterTask == 31)
        {
            taskText.text = "�������� �������� ������";
            counterTask++;
        }
    }

    public void ThirtyThreethTask()
    {
        if (startPractice && counterTask == 32)
        {
            taskText.text = "�������� ��� ������������ ������� ��� �������� ���� � �������� ������";
            counterTask++;
        }
    }

    public void ThirtyFourthTask()
    {
        if (startPractice && counterTask == 33)
        {
            taskText.text = "������� �� ������ 2 ���.";
            counterTask++;
        }
    }

    public void ThirtyFivethTask()
    {
        if (startPractice && counterTask == 34)
        {
            taskText.text = "�������� ������������ �������� � �������";
            counterTask++;
        }
    }

    public void ThirtySixthTask()
    {
        if (startPractice && counterTask == 35)
        {
            taskText.text = "�������� �������� ������";
            counterTask++;
        }
    }

    public void ThirtySeventhTask()
    {
        if (startPractice && counterTask == 36)
        {
            taskText.text = "�������� ��� ������������ ������� ������ �������� ���� � �������� ������";
            counterTask++;
        }
    }

    public void ThirtyEighthTask()
    {
        if (startPractice && counterTask == 37)
        {
            taskText.text = "������� �� ������ 2 ���.";
            counterTask++;
        }
    }

    public void ThirtyNinethTask()
    {
        if (startPractice && counterTask == 38)
        {
            taskText.text = "�������� ������������ �������� � �������";
            counterTask++;
        }
    }

    public void FourtythTask()
    {
        if (startPractice && counterTask == 39)
        {
            taskText.text = "�������� �������� ������";
            counterTask++;
        }
    }

    public void FourtyOnethTask()
    {
        if (startPractice && counterTask == 40)
        {
            taskText.text = "�������� ��� ��������� �� ���������� � �������� �������� ������";
            counterTask++;
        }
    }

    public void FourtyTwothTask()
    {
        if (startPractice && counterTask == 41)
        {
            taskText.text = "��������� ���������";
            counterTask++;
        }
    }

    public void FourtyThreethTask()
    {
        if (startPractice && counterTask == 42)
        {
            taskText.text = "�������� ������� � ������ ����������";
            onCanvasObject.InputFinalTaskValue();
            counterTask++;
            finishPractice = true;
        }
    }
}
