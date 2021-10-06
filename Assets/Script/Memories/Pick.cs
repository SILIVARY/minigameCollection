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
    [SerializeField] float setTime = 10.0f;
    [SerializeField] Text countdounText;

    //텍스트 값 입력
    [SerializeField] Text text_1;
    [SerializeField] Text text_2;
    [SerializeField] Text text_3;
    [SerializeField] int totalcount;

    //딜레이
    double timer;
    double waitingTime;
    int count;

    //스코어
    static int pickcount, totalscore;
    static int IScore_1, IScore_2, IScore_3;
    static int OScore_1, OScore_2, OScore_3;
    [SerializeField] Text Score;

    public void Start()
    {
        timer = 0.0;

        waitingTime = 1.0;

        count = 1;

        countdounText.text = setTime.ToString();

        totalcount = 0;

        pickcount = 0;

        totalscore = 0;
        
        IScore_1 = 0; IScore_2 = 0; IScore_3 = 0;
        OScore_1 = 0; OScore_2 = 0; OScore_3 = 0;
    }
    void Update()
    {
        if (setTime > 0 && count == 5)
            setTime -= Time.deltaTime;
        else if (setTime <= 0)
            {
                Time.timeScale = 0.0f;
                //SceneManager.LoadScene("Single_Memories_GameOver");
            }
        countdounText.text = Mathf.Round(setTime).ToString();
    }
    public void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > waitingTime)
        {
            if (count < 4)
            {
                Debug.Log("업데이트");
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
                waitingTime = 50;
            }
        }
    }
    public void button1_ChangeImage()
    {
        totalcount = 1;
        
        switch(count)
        {
            case 2:
            IScore_1 = 1; break;
            case 3:
            IScore_2 = 1; break;
            case 4:
            IScore_3 = 1; break;
        }
     
        Debug.Log("1번 들어옴");
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
    public void button2_ChangeImage()
    {
        totalcount = 2;
        
        switch(count)
            {
                case 2:
                IScore_1 = 2; break;
                case 3:
                IScore_2 = 2; break;
                case 4:
                IScore_3 = 2; break;
            }        

        Debug.Log("2번 들어옴");
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
 
        switch(count)
            {
                case 2:
                IScore_1 = 3; break;
                case 3:
                IScore_2 = 3; break;
                case 4:
                IScore_3 = 3; break;
            }        

        Debug.Log("3번 들어옴");
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
 
        switch(count)
            {
                case 2:
                IScore_1 = 4; break;
                case 3:
                IScore_2 = 4; break;
                case 4:
                IScore_3 = 4; break;
            }        
    
        Debug.Log("4번 들어옴");
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
 
        switch(count)
            {
                case 2:
                IScore_1 = 5; break;
                case 3:
                IScore_2 = 5; break;
                case 4:
                IScore_3 = 5; break;
            }        

        Debug.Log("5번 들어옴");
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
 
        switch(count)
            {
                case 2:
                IScore_1 = 6; break;
                case 3:
                IScore_2 = 6; break;
                case 4:
                IScore_3 = 6; break;
            }        

        Debug.Log("6번 들어옴");
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
 
        switch(count)
            {
                case 2:
                IScore_1 = 7; break;
                case 3:
                IScore_2 = 7; break;
                case 4:
                IScore_3 = 7; break;
            }        
        
        Debug.Log("7번 들어옴");
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
 
        switch(count)
            {
                case 2:
                IScore_1 = 8; break;
                case 3:
                IScore_2 = 8; break;
                case 4:
                IScore_3 = 8; break;
            }        

        Debug.Log("8번 들어옴");
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
 
        switch(count)
            {
                case 2:
                IScore_1 = 9; break;
                case 3:
                IScore_2 = 9; break;
                case 4:
                IScore_3 = 9; break;
            }        

        Debug.Log("9번 들어옴");
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
        if (!a)
            button1_ChangeImage();
        if (!b)
            button2_ChangeImage();
        if (!c)
            button3_ChangeImage();
        if (!d)
            button4_ChangeImage();
        if (!e)
            button5_ChangeImage();
        if (!f)
            button6_ChangeImage();
        if (!g)
            button7_ChangeImage();
        if (!h)
            button8_ChangeImage();
        if (!i)
            button9_ChangeImage();
    }
    public void button_pick()
    {
        System.Random rand = new System.Random();
        int num;
        bool[] chk = new bool[10];

        Debug.Log("버튼 픽");
        while (true)
        {
            num = rand.Next(1, 9);
            if (!chk[num])
            {
                chk[num] = true;
                break;
            }
        }
        Debug.Log(num);
        switch (num)
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
    public void totalcount_reset()
    {
        totalcount = 0;
        text_1.text = totalcount.ToString();
        text_2.text = totalcount.ToString();
        text_3.text = totalcount.ToString();
    }
}

