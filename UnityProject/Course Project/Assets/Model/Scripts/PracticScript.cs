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
            taskText.text = "Включите установку";
            counterTask++;
        }
    }

    public void SecondTask()
    {
        if (startPractice && counterTask == 1)
        {
            taskText.text = "Нажмите на кнопку 2 мин., чтобы добавить фоновое значение в установку";
            counterTask++;
        }
    }

    public void ThirdTask()
    {
        if (startPractice && counterTask == 2)
        {
            taskText.text = "Откройте защитную крышку";
            counterTask++;
        }
    }

    public void FourthTask()
    {
        if (startPractice && counterTask == 3)
        {
            taskText.text = "Положите в контейнер радиоактивный элемент и закройте крышку";
            counterTask++;
        }
    }

    public void FivethTask()
    {
        if (startPractice && counterTask == 4)
        {
            taskText.text = "Нажмите на кнопку \"Проба\"";
            counterTask++;
        }
    }

    public void SixthTask()
    {
        if (startPractice && counterTask == 5)
        {
            taskText.text = "Нажмите на кнопку 2 мин.";
            counterTask++;
        }
    }

    public void SeventhTask()
    {
        if (startPractice && counterTask == 6)
        {
            taskText.text = "Запишите получившееся значение в таблицу";
            counterTask++;
        }
    }

    public void EighthTask()
    {
        if (startPractice && counterTask == 7)
        {
            taskText.text = "Откройте защитную крышку";
            onCanvasObject.InputSizeMaterialsInTable();
            counterTask++;
        }
    }

    public void NinethTask()
    {
        if (startPractice && counterTask == 8)
        {
            taskText.text = "Положите под радиактивный элемент одну пластину платины и закройте крышку";
            counterTask++;
        }
    }

    public void TenthTask()
    {
        if (startPractice && counterTask == 9)
        {
            taskText.text = "Нажмите на кнопку 2 мин.";
            counterTask++;
        }
    }

    public void EleventhTask()
    {
        if (startPractice && counterTask == 10)
        {
            taskText.text = "Запишите получившееся значение в таблицу";
            counterTask++;
        }
    }

    public void TwelvethTask()
    {
        if (startPractice && counterTask == 11)
        {
            taskText.text = "Откройте защитную крышку";
            counterTask++;
        }
    }

    public void ThirdthTask()
    {
        if (startPractice && counterTask == 12)
        {
            taskText.text = "Положите под радиактивный элемент две пластины платины и закройте крышку";
            counterTask++;
        }
    }

    public void FourteenthTask()
    {
        if (startPractice && counterTask == 13)
        {
            taskText.text = "Нажмите на кнопку 2 мин.";
            counterTask++;
        }
    }

    public void FiveteenthTask()
    {
        if (startPractice && counterTask == 14)
        {
            taskText.text = "Запишите получившееся значение в таблицу";
            counterTask++;
        }
    }

    public void SixteenthTask()
    {
        if (startPractice && counterTask == 15)
        {
            taskText.text = "Откройте защитную крышку";
            counterTask++;
        }
    }

    public void SeventeenthTask()
    {
        if (startPractice && counterTask == 16)
        {
            taskText.text = "Положите под радиактивный элемент три пластины платины и закройте крышку";
            counterTask++;
        }
    }

    public void EightteenthTask()
    {
        if (startPractice && counterTask == 17)
        {
            taskText.text = "Нажмите на кнопку 2 мин.";
            counterTask++;
        }
    }

    public void NineteenthTask()
    {
        if (startPractice && counterTask == 18)
        {
            taskText.text = "Запишите получившееся значение в таблицу";
            counterTask++;
        }
    }

    public void TwentythTask()
    {
        if (startPractice && counterTask == 19)
        {
            taskText.text = "Откройте защитную крышку";
            counterTask++;
        }
    }

    public void TwentyOnethTask()
    {
        if (startPractice && counterTask == 20)
        {
            taskText.text = "Положите под радиактивный элемент четыри пластины платины и закройте крышку";
            counterTask++;
        }
    }

    public void TwentyTwoTask()
    {
        if (startPractice && counterTask == 21)
        {
            taskText.text = "Нажмите на кнопку 2 мин.";
            counterTask++;
        }
    }

    public void TwentyThreethTask()
    {
        if (startPractice && counterTask == 22)
        {
            taskText.text = "Запишите получившееся значение в таблицу";
            counterTask++;
        }
    }

    public void TwentyFourTask()
    {
        if (startPractice && counterTask == 23)
        {
            taskText.text = "Откройте защитную крышку";
            counterTask++;
        }
    }

    public void TwentyFivethTask()
    {
        if (startPractice && counterTask == 24)
        {
            taskText.text = "Положите под радиактивный элемент одну пластину меди и закройте крышку";
            counterTask++;
        }
    }

    public void TwentySixthTask()
    {
        if (startPractice && counterTask == 25)
        {
            taskText.text = "Нажмите на кнопку 2 мин.";
            counterTask++;
        }
    }

    public void TwentySeventhTask()
    {
        if (startPractice && counterTask == 26)
        {
            taskText.text = "Запишите получившееся значение в таблицу";
            counterTask++;
        }
    }

    public void TwentyEighthTask()
    {
        if (startPractice && counterTask == 27)
        {
            taskText.text = "Откройте защитную крышку";
            counterTask++;
        }
    }

    public void TwentyNinethTask()
    {
        if (startPractice && counterTask == 28)
        {
            taskText.text = "Положите под радиактивный элемент две пластины меди и закройте крышку";
            counterTask++;
        }
    }

    public void ThirtythTask()
    {
        if (startPractice && counterTask == 29)
        {
            taskText.text = "Нажмите на кнопку 2 мин.";
            counterTask++;
        }
    }

    public void ThirtyOnethTask()
    {
        if (startPractice && counterTask == 30)
        {
            taskText.text = "Запишите получившееся значение в таблицу";
            counterTask++;
        }
    }

    public void ThirtyTwothTask()
    {
        if (startPractice && counterTask == 31)
        {
            taskText.text = "Откройте защитную крышку";
            counterTask++;
        }
    }

    public void ThirtyThreethTask()
    {
        if (startPractice && counterTask == 32)
        {
            taskText.text = "Положите под радиактивный элемент три пластины меди и закройте крышку";
            counterTask++;
        }
    }

    public void ThirtyFourthTask()
    {
        if (startPractice && counterTask == 33)
        {
            taskText.text = "Нажмите на кнопку 2 мин.";
            counterTask++;
        }
    }

    public void ThirtyFivethTask()
    {
        if (startPractice && counterTask == 34)
        {
            taskText.text = "Запишите получившееся значение в таблицу";
            counterTask++;
        }
    }

    public void ThirtySixthTask()
    {
        if (startPractice && counterTask == 35)
        {
            taskText.text = "Откройте защитную крышку";
            counterTask++;
        }
    }

    public void ThirtySeventhTask()
    {
        if (startPractice && counterTask == 36)
        {
            taskText.text = "Положите под радиактивный элемент четыри пластины меди и закройте крышку";
            counterTask++;
        }
    }

    public void ThirtyEighthTask()
    {
        if (startPractice && counterTask == 37)
        {
            taskText.text = "Нажмите на кнопку 2 мин.";
            counterTask++;
        }
    }

    public void ThirtyNinethTask()
    {
        if (startPractice && counterTask == 38)
        {
            taskText.text = "Запишите получившееся значение в таблицу";
            counterTask++;
        }
    }

    public void FourtythTask()
    {
        if (startPractice && counterTask == 39)
        {
            taskText.text = "Откройте защитную крышку";
            counterTask++;
        }
    }

    public void FourtyOnethTask()
    {
        if (startPractice && counterTask == 40)
        {
            taskText.text = "Вынимите все материалы из контейнера и закройте защитную крышку";
            counterTask++;
        }
    }

    public void FourtyTwothTask()
    {
        if (startPractice && counterTask == 41)
        {
            taskText.text = "Выключите установку";
            counterTask++;
        }
    }

    public void FourtyThreethTask()
    {
        if (startPractice && counterTask == 42)
        {
            taskText.text = "Откройте таблицу и узрите результаты";
            onCanvasObject.InputFinalTaskValue();
            counterTask++;
            finishPractice = true;
        }
    }
}
