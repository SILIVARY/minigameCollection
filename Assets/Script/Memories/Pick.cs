using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pick : MonoBehaviour
{
    //컴퓨터가 누를 시 이미지 변경
    [SerializeField] Image button1;
    public Sprite button1Sprite;
    public Sprite button1Image2;
    [SerializeField] Image button2;
    public Sprite button2Sprite;
    public Sprite button2Image2;
    [SerializeField] Image button3;
    public Sprite button3Sprite;
    public Sprite button3Image2;
    [SerializeField] Image button4;
    public Sprite button4Sprite;
    public Sprite button4Image2;
    [SerializeField] Image button5;
    public Sprite button5Sprite;
    public Sprite button5Image2;
    [SerializeField] Image button6;
    public Sprite button6Sprite;
    public Sprite button6Image2;
    [SerializeField] Image button7;
    public Sprite button7Sprite;
    public Sprite button7Image2;
    [SerializeField] Image button8;
    public Sprite button8Sprite;
    public Sprite button8Image2;
    [SerializeField] Image button9;
    public Sprite button9Sprite;
    public Sprite button9Image2;
    bool a = true, b = true, c = true, d = true, e = true, f = true, g = true, h = true, i = true;

    //카운트다운
    [SerializeField] float setTime = 5.0f;
    [SerializeField] Text countdownText;

    //텍스트 값 입력
    [SerializeField] Text text_1;
    [SerializeField] Text text_2;
    [SerializeField] Text text_3;
    [SerializeField] Text text_4;
    [SerializeField] Text text_5;
    [SerializeField] int totalcount;

    //딜레이
    double timer;
    double waitingTime;
    int count;

    //스코어
    static int pickcount, totalscore;
    static int IScore_1, IScore_2, IScore_3, IScore_4, IScore_5;
    static int OScore_1, OScore_2, OScore_3, OScore_4, OScore_5;
    [SerializeField] Text Score;

    //레벨
    static int level;
    [SerializeField] Text LevelText;

    public void Start()
    {
        All_reset();
        waitingTime = 1.0;
        level = 1;
    }
    void Update()
    {
        if (level <= 3)
        {
            if (setTime > 0 && count == 6)
                setTime -= Time.deltaTime;
            else if (setTime <= 0)
            {
                Time.timeScale = 0.0f;
                SceneManager.LoadScene("Single_Memories_GameOver");
            }
            countdownText.text = Mathf.Round(setTime).ToString();
        }
        else if (level > 3)
        {
            if (setTime > 0 && count == 8)
                setTime -= Time.deltaTime;
            else if (setTime <= 0)
            {
                Time.timeScale = 0.0f;
                SceneManager.LoadScene("Single_Memories_GameOver");
            }
            countdownText.text = Mathf.Round(setTime).ToString();
        }
        levelPlus();
    }
    public void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (level <= 3)
        {
            if (count < 6)
            {
                if (timer > waitingTime)
                {
                    if (count < 4)
                    {
                        count++;
                        button_pick();
                        timer = 0.0;

                        switch (count)
                        {
                            case 2:
                                text_1.text = totalcount.ToString();
                                break;
                            case 3:
                                text_2.text = totalcount.ToString();
                                break;
                            case 4:
                                text_3.text = totalcount.ToString();
                                break;
                        }
                    }
                    else if (count == 4)
                    {
                        timer = 0.0;
                        count++;
                        totalcount_reset();
                        button_reset();
                    }
                    else if (count == 5)
                    {
                        button_mix();
                        timer = 0.0;
                        count++;
                    }
                }
            }
            if (pickcount == 3)
            {
                button_Position_reset();
                button_reset();
                All_reset();
                level++;
            }
        }
        else if (level > 3)
        {
            if (count < 8)
            {
                if (timer > waitingTime)
                {
                    if (count < 6)
                    {
                        count++;
                        button_pick();
                        timer = 0.0;

                        switch (count)
                        {
                            case 2:
                                text_1.text = totalcount.ToString();
                                break;
                            case 3:
                                text_2.text = totalcount.ToString();
                                break;
                            case 4:
                                text_3.text = totalcount.ToString();
                                break;
                            case 5:
                                text_4.text = totalcount.ToString();
                                break;
                            case 6:
                                text_5.text = totalcount.ToString();
                                break;
                        }
                    }
                    else if (count == 6)
                    {
                        timer = 0.0;
                        count++;
                        totalcount_reset();
                        button_reset();
                    }
                    else if (count == 7)
                    {
                        button_mix();
                        timer = 0.0;
                        count++;
                    }
                }
            }
        }
        if (pickcount == 5)
            {
                button_Position_reset();
                button_reset();
                All_reset();
                level++;
            }
    }
    public void button1_ChangeImage()
    {
        totalcount = 1;

        switch (count)
        {
            case 2:
                IScore_1 = 1; break;
            case 3:
                IScore_2 = 1; break;
            case 4:
                IScore_3 = 1; break;
        }

        if (a)
        {
            button1.sprite = button1Sprite;
            a = false;
        }
        else
        {
            button1.sprite = button1Image2;
            a = true;
        }

    }
    public void button1_Onclick()
    {
        OScore_1 = 1;
        OScore_2 = 1;
        OScore_3 = 1;
        OScore_4 = 1;
        OScore_5 = 1;
        
        if (level <= 3)
        {
        switch (pickcount)
        {   
            case 0:
                if (IScore_1 == OScore_1)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 1:
                if (IScore_2 == OScore_2)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 2:
                if (IScore_3 == OScore_3)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
        }
        }
        if (level > 3)
        {
        switch (pickcount)
        {   
            case 0:
                if (IScore_1 == OScore_1)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 1:
                if (IScore_2 == OScore_2)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 2:
                if (IScore_3 == OScore_3)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 3:
                if (IScore_4 == OScore_4)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 4:
                if (IScore_5 == OScore_5)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
        }
        }
    }
    public void button2_ChangeImage()
    {
        totalcount = 2;

        switch (count)
        {
            case 2:
                IScore_1 = 2; break;
            case 3:
                IScore_2 = 2; break;
            case 4:
                IScore_3 = 2; break;
        }

        if (b)
        {
            button2.sprite = button2Sprite;
            b = false;
        }
        else
        {
            button2.sprite = button2Image2;
            b = true;
        }
    }
    public void button2_Onclick()
    {
        OScore_1 = 2;
        OScore_2 = 2;
        OScore_3 = 2;

        switch (pickcount)
        {
            case 0:
                if (IScore_1 == OScore_1)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 1:
                if (IScore_2 == OScore_2)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 2:
                if (IScore_3 == OScore_3)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
        }
    }
    public void button3_ChangeImage()
    {
        totalcount = 3;

        switch (count)
        {
            case 2:
                IScore_1 = 3; break;
            case 3:
                IScore_2 = 3; break;
            case 4:
                IScore_3 = 3; break;
        }

        if (c)
        {
            button3.sprite = button3Sprite;
            c = false;
        }
        else
        {
            button3.sprite = button3Image2;
            c = true;
        }
    }
    public void button3_Onclick()
    {
        OScore_1 = 3;
        OScore_2 = 3;
        OScore_3 = 3;

        switch (pickcount)
        {
            case 0:
                if (IScore_1 == OScore_1)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 1:
                if (IScore_2 == OScore_2)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 2:
                if (IScore_3 == OScore_3)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
        }
    }
    public void button4_ChangeImage()
    {
        totalcount = 4;

        switch (count)
        {
            case 2:
                IScore_1 = 4; break;
            case 3:
                IScore_2 = 4; break;
            case 4:
                IScore_3 = 4; break;
        }

        if (d)
        {
            button4.sprite = button4Sprite;
            d = false;
        }
        else
        {
            button4.sprite = button4Image2;
            d = true;
        }
    }
    public void button4_Onclick()
    {
        OScore_1 = 4;
        OScore_2 = 4;
        OScore_3 = 4;

        switch (pickcount)
        {
            case 0:
                if (IScore_1 == OScore_1)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 1:
                if (IScore_2 == OScore_2)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 2:
                if (IScore_3 == OScore_3)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
        }
    }
    public void button5_ChangeImage()
    {
        totalcount = 5;

        switch (count)
        {
            case 2:
                IScore_1 = 5; break;
            case 3:
                IScore_2 = 5; break;
            case 4:
                IScore_3 = 5; break;
        }

        if (e)
        {
            button5.sprite = button5Sprite;
            e = false;
        }
        else
        {
            button5.sprite = button5Image2;
            e = true;
        }
    }
    public void button5_Onclick()
    {
        OScore_1 = 5;
        OScore_2 = 5;
        OScore_3 = 5;

        switch (pickcount)
        {
            case 0:
                if (IScore_1 == OScore_1)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 1:
                if (IScore_2 == OScore_2)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 2:
                if (IScore_3 == OScore_3)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
        }
    }
    public void button6_ChangeImage()
    {
        totalcount = 6;

        switch (count)
        {
            case 2:
                IScore_1 = 6; break;
            case 3:
                IScore_2 = 6; break;
            case 4:
                IScore_3 = 6; break;
        }

        if (f)
        {
            button6.sprite = button6Sprite;
            f = false;
        }
        else
        {
            button6.sprite = button6Image2;
            f = true;
        }
    }
    public void button6_Onclick()
    {
        OScore_1 = 6;
        OScore_2 = 6;
        OScore_3 = 6;

        switch (pickcount)
        {
            case 0:
                if (IScore_1 == OScore_1)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 1:
                if (IScore_2 == OScore_2)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 2:
                if (IScore_3 == OScore_3)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
        }
    }
    public void button7_ChangeImage()
    {
        totalcount = 7;

        switch (count)
        {
            case 2:
                IScore_1 = 7; break;
            case 3:
                IScore_2 = 7; break;
            case 4:
                IScore_3 = 7; break;
        }

        if (g)
        {
            button7.sprite = button7Sprite;
            g = false;
        }
        else
        {
            button7.sprite = button7Image2;
            g = true;
        }
    }
    public void button7_Onclick()
    {
        OScore_1 = 7;
        OScore_2 = 7;
        OScore_3 = 7;

        switch (pickcount)
        {
            case 0:
                if (IScore_1 == OScore_1)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 1:
                if (IScore_2 == OScore_2)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 2:
                if (IScore_3 == OScore_3)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
        }
    }
    public void button8_ChangeImage()
    {
        totalcount = 8;

        switch (count)
        {
            case 2:
                IScore_1 = 8; break;
            case 3:
                IScore_2 = 8; break;
            case 4:
                IScore_3 = 8; break;
        }

        if (h)
        {
            button8.sprite = button8Sprite;
            h = false;
        }
        else
        {
            button8.sprite = button8Image2;
            h = true;
        }
    }
    public void button8_Onclick()
    {
        OScore_1 = 8;
        OScore_2 = 8;
        OScore_3 = 8;

        switch (pickcount)
        {
            case 0:
                if (IScore_1 == OScore_1)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 1:
                if (IScore_2 == OScore_2)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 2:
                if (IScore_3 == OScore_3)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
        }
    }
    public void button9_ChangeImage()
    {
        totalcount = 9;

        switch (count)
        {
            case 2:
                IScore_1 = 9; break;
            case 3:
                IScore_2 = 9; break;
            case 4:
                IScore_3 = 9; break;
        }

        if (i)
        {
            button9.sprite = button9Sprite;
            i = false;
        }
        else
        {
            button9.sprite = button9Image2;
            i = true;
        }
    }
    public void button9_Onclick()
    {
        OScore_1 = 9;
        OScore_2 = 9;
        OScore_3 = 9;

        switch (pickcount)
        {
            case 0:
                if (IScore_1 == OScore_1)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 1:
                if (IScore_2 == OScore_2)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
            case 2:
                if (IScore_3 == OScore_3)
                {
                    totalscore += 100;
                    Score.text = totalscore.ToString();
                    pickcount++;
                    break;
                }
                else
                {
                SceneManager.LoadScene("Single_Memories_GameOver");
                    break;
                }
        }
    }

    public void button_reset()
    {
        a = false;
        b = false;
        c = false;
        d = false;
        e = false;
        f = false;
        g = false;
        h = false;
        i = false;
        button1_ChangeImage();
        button2_ChangeImage();
        button3_ChangeImage();
        button4_ChangeImage();
        button5_ChangeImage();
        button6_ChangeImage();
        button7_ChangeImage();
        button8_ChangeImage();
        button9_ChangeImage();
    }

    public void button_pick()
    {
        ArrayList list = new ArrayList();

        for (int i = 1; i <= 9; i++)
            list.Add(i);

        System.Random random = new System.Random();

        while (8 < list.Count)
        {
            int index = random.Next(list.Count);
            int random_number = (int)list[index];
            list.RemoveAt(index);

            switch (random_number)
            {
                case 1: { button1_ChangeImage(); } break;
                case 2: { button2_ChangeImage(); } break;
                case 3: { button3_ChangeImage(); } break;
                case 4: { button4_ChangeImage(); } break;
                case 5: { button5_ChangeImage(); } break;
                case 6: { button6_ChangeImage(); } break;
                case 7: { button7_ChangeImage(); } break;
                case 8: { button8_ChangeImage(); } break;
                case 9: { button9_ChangeImage(); } break;
            }
        }
    }
    public void totalcount_reset()
    {
        totalcount = 0;
        text_1.text = totalcount.ToString();
        text_2.text = totalcount.ToString();
        text_3.text = totalcount.ToString();
        text_4.text = totalcount.ToString();
        text_5.text = totalcount.ToString();
    }
    public void levelPlus()
    {
        if (totalscore >= 300)
        {
            level = 2;
        }
        if (totalscore >= 600)
        {
            level = 3;
        }
        if (totalscore >= 900)
        {
            level = 4;
        }
        if (totalscore >= 1400)
        {
            level = 5;
        }
        if (totalscore >= 1900)
        {
            level = 6;
        }
        if (totalscore >= 2400)
        {
            level = 7;
        }
    }
    //버튼 위치 변경
    public Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
    private Vector3 position1, position2, position3, position4, position5, position6, position7, position8, position9, posi;
    List<Vector3> list_position = new List<Vector3>();
    List<Button> list_btn = new List<Button>();

    public void button_mix()
    {
        list_position.Add(position1);
        list_position.Add(position2);
        list_position.Add(position3);
        list_position.Add(position4);
        list_position.Add(position5);
        list_position.Add(position6);
        list_position.Add(position7);
        list_position.Add(position8);
        list_position.Add(position9);
        
        list_btn.Add(btn1);
        list_btn.Add(btn2);
        list_btn.Add(btn3);
        list_btn.Add(btn4);
        list_btn.Add(btn5);
        list_btn.Add(btn6);
        list_btn.Add(btn7);
        list_btn.Add(btn8);
        list_btn.Add(btn9);

        position1 = btn1.GetComponent<RectTransform>().anchoredPosition;
        position2 = btn2.GetComponent<RectTransform>().anchoredPosition;
        position3 = btn3.GetComponent<RectTransform>().anchoredPosition;
        position4 = btn4.GetComponent<RectTransform>().anchoredPosition;
        position5 = btn5.GetComponent<RectTransform>().anchoredPosition;
        position6 = btn6.GetComponent<RectTransform>().anchoredPosition;
        position7 = btn7.GetComponent<RectTransform>().anchoredPosition;
        position8 = btn8.GetComponent<RectTransform>().anchoredPosition;
        position9 = btn9.GetComponent<RectTransform>().anchoredPosition;


        for(int i = 0; i<9; i++)
        {
            list_position[i] = list_btn[i].GetComponent<RectTransform>().anchoredPosition;   
        }
        
        int posicount = 1;

        ArrayList list = new ArrayList();

        for (int i = 1; i <= 9; i++)
            list.Add(i);

        System.Random random = new System.Random();

        while (0 < list.Count)
        {
            int index = random.Next(list.Count);
            int random_number = (int)list[index];
            list.RemoveAt(index);

            switch (random_number)
            {
                case 1: posi = position1; break;
                case 2: posi = position2; break;
                case 3: posi = position3; break;
                case 4: posi = position4; break;
                case 5: posi = position5; break;
                case 6: posi = position6; break;
                case 7: posi = position7; break;
                case 8: posi = position8; break;
                case 9: posi = position9; break;
            }
            switch (posicount)
            {
                case 1: btn1.GetComponent<RectTransform>().anchoredPosition = posi; posicount++; break;
                case 2: btn2.GetComponent<RectTransform>().anchoredPosition = posi; posicount++; break;
                case 3: btn3.GetComponent<RectTransform>().anchoredPosition = posi; posicount++; break;
                case 4: btn4.GetComponent<RectTransform>().anchoredPosition = posi; posicount++; break;
                case 5: btn5.GetComponent<RectTransform>().anchoredPosition = posi; posicount++; break;
                case 6: btn6.GetComponent<RectTransform>().anchoredPosition = posi; posicount++; break;
                case 7: btn7.GetComponent<RectTransform>().anchoredPosition = posi; posicount++; break;
                case 8: btn8.GetComponent<RectTransform>().anchoredPosition = posi; posicount++; break;
                case 9: btn9.GetComponent<RectTransform>().anchoredPosition = posi; posicount = 1; break;
            }
        }
    }
    public void button_Position_reset()
    {
        for(int i = 0; i<list_btn.Count; i++)
        {   
            list_btn[i].GetComponent<RectTransform>().anchoredPosition = list_position[i];
        }
    }
    public void All_reset()
    {       
        setTime = 10.0f;

        timer = 0.0;

        count = 1;

        countdownText.text = setTime.ToString();

        totalcount = 0;

        pickcount = 0;

        IScore_1 = 0; IScore_2 = 0; IScore_3 = 0; IScore_4 = 0; IScore_5 = 0;
        OScore_1 = 0; OScore_2 = 0; OScore_3 = 0; OScore_4 = 0; OScore_5 = 0;

        if (level <= 3)
        {
            if (setTime > 0 && count == 6)
                setTime -= Time.deltaTime;
            else if (setTime <= 0)
            {
                Time.timeScale = 0.0f;
                SceneManager.LoadScene("Single_Memories_GameOver");
            }
            countdownText.text = Mathf.Round(setTime).ToString();
        }
        else if (level > 3)
        {
            if (setTime > 0 && count == 8)
                setTime -= Time.deltaTime;
            else if (setTime <= 0)
            {
                Time.timeScale = 0.0f;
                SceneManager.LoadScene("Single_Memories_GameOver");
            }
            countdownText.text = Mathf.Round(setTime).ToString();
        }
    }
}