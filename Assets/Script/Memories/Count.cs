using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    [SerializeField] static int[] nineButtons = new int[10];
    [SerializeField] static bool[] fiveButtons = new bool[6];
    [SerializeField] int totalcount;
    [SerializeField] Text text_1;
    [SerializeField] Text text_2;
    [SerializeField] Text text_3;
    [SerializeField] Text text_4;
    [SerializeField] Text text_5;
    [SerializeField] Text text_6;
    [SerializeField] Text text_7;
    [SerializeField] Text text_8;
    [SerializeField] Text text_9;


    void Start()
    {
        totalcount = 0;
        Initialization();
    }

    public void Initialization()
    {
        for (int i = 0; i < 10; i++) nineButtons[i] = 0;
    }

    public int emptySearch()
    {
        for (int i = 1; i <= 5; i++)
            if (!fiveButtons[i]) return i;
        return -1;
    }

    public void count_1()
    {
        if (nineButtons[1] != 0)
        {
            totalcount = 0;
            switch (nineButtons[1])
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = false;
                    nineButtons[1] = 0;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = false;
                    nineButtons[1] = 0;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = false;
                    nineButtons[1] = 0;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = false;
                    nineButtons[1] = 0;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = false;
                    nineButtons[1] = 0;
                    break;
            }
        }

        else
        {
            totalcount = 1;

            int idx;
            idx = emptySearch();

            switch (idx)
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = true;
                    nineButtons[1] = 1;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = true;
                    nineButtons[1] = 2;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = true;
                    nineButtons[1] = 3;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = true;
                    nineButtons[1] = 4;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = true;
                    nineButtons[1] = 5;
                    break;
            }
        }
    }

    public void count_2()
    {
        if (nineButtons[2] != 0)
        {
            totalcount = 0;
            switch (nineButtons[2])
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = false;
                    nineButtons[2] = 0;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = false;
                    nineButtons[2] = 0;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = false;
                    nineButtons[2] = 0;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = false;
                    nineButtons[2] = 0;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = false;
                    nineButtons[2] = 0;
                    break;
            }
        }

        else
        {
            totalcount = 2;

            int idx;
            idx = emptySearch();

            switch (idx)
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = true;
                    nineButtons[2] = 1;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = true;
                    nineButtons[2] = 2;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = true;
                    nineButtons[2] = 3;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = true;
                    nineButtons[2] = 4;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = true;
                    nineButtons[2] = 5;
                    break;
            }
        }
    }

    public void count_3()
    {
        if (nineButtons[3] != 0)
        {
            totalcount = 0;
            switch (nineButtons[3])
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = false;
                    nineButtons[3] = 0;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = false;
                    nineButtons[3] = 0;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = false;
                    nineButtons[3] = 0;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = false;
                    nineButtons[3] = 0;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = false;
                    nineButtons[3] = 0;
                    break;
            }
        }

        else
        {
            totalcount = 3;

            int idx;
            idx = emptySearch();

            switch (idx)
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = true;
                    nineButtons[3] = 1;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = true;
                    nineButtons[3] = 2;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = true;
                    nineButtons[3] = 3;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = true;
                    nineButtons[3] = 4;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = true;
                    nineButtons[3] = 5;
                    break;
            }
        }
    }

    public void count_4()
    {
        if (nineButtons[4] != 0)
        {
            totalcount = 0;
            switch (nineButtons[4])
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = false;
                    nineButtons[4] = 0;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = false;
                    nineButtons[4] = 0;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = false;
                    nineButtons[4] = 0;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = false;
                    nineButtons[4] = 0;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = false;
                    nineButtons[4] = 0;
                    break;
            }
        }

        else
        {
            totalcount = 4;

            int idx;
            idx = emptySearch();

            switch (idx)
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = true;
                    nineButtons[4] = 1;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = true;
                    nineButtons[4] = 2;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = true;
                    nineButtons[4] = 3;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = true;
                    nineButtons[4] = 4;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = true;
                    nineButtons[4] = 5;
                    break;
            }
        }
    }

    public void count_5()
    {
        if (nineButtons[5] != 0)
        {
            totalcount = 0;
            switch (nineButtons[5])
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = false;
                    nineButtons[5] = 0;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = false;
                    nineButtons[5] = 0;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = false;
                    nineButtons[5] = 0;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = false;
                    nineButtons[5] = 0;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = false;
                    nineButtons[5] = 0;
                    break;
            }
        }

        else
        {
            totalcount = 5;

            int idx;
            idx = emptySearch();

            switch (idx)
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = true;
                    nineButtons[5] = 1;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = true;
                    nineButtons[5] = 2;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = true;
                    nineButtons[5] = 3;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = true;
                    nineButtons[5] = 4;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = true;
                    nineButtons[5] = 5;
                    break;
            }
        }
    }

    public void count_6()
    {
        if (nineButtons[6] != 0)
        {
            totalcount = 0;
            switch (nineButtons[6])
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = false;
                    nineButtons[6] = 0;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = false;
                    nineButtons[6] = 0;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = false;
                    nineButtons[6] = 0;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = false;
                    nineButtons[6] = 0;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = false;
                    nineButtons[6] = 0;
                    break;
            }
        }

        else
        {
            totalcount = 6;

            int idx;
            idx = emptySearch();

            switch (idx)
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = true;
                    nineButtons[6] = 1;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = true;
                    nineButtons[6] = 2;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = true;
                    nineButtons[6] = 3;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = true;
                    nineButtons[6] = 4;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = true;
                    nineButtons[6] = 5;
                    break;
            }
        }
    }

    public void count_7()
    {
        if (nineButtons[7] != 0)
        {
            totalcount = 0;
            switch (nineButtons[7])
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = false;
                    nineButtons[7] = 0;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = false;
                    nineButtons[7] = 0;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = false;
                    nineButtons[7] = 0;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = false;
                    nineButtons[7] = 0;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = false;
                    nineButtons[7] = 0;
                    break;
            }
        }

        else
        {
            totalcount = 7;

            int idx;
            idx = emptySearch();

            switch (idx)
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = true;
                    nineButtons[7] = 1;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = true;
                    nineButtons[7] = 2;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = true;
                    nineButtons[7] = 3;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = true;
                    nineButtons[7] = 4;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = true;
                    nineButtons[7] = 5;
                    break;
            }
        }
    }

    public void count_8()
    {
        if (nineButtons[8] != 0)
        {
            totalcount = 0;
            switch (nineButtons[8])
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = false;
                    nineButtons[8] = 0;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = false;
                    nineButtons[8] = 0;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = false;
                    nineButtons[8] = 0;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = false;
                    nineButtons[8] = 0;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = false;
                    nineButtons[8] = 0;
                    break;
            }
        }

        else
        {
            totalcount = 8;

            int idx;
            idx = emptySearch();

            switch (idx)
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = true;
                    nineButtons[8] = 1;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = true;
                    nineButtons[8] = 2;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = true;
                    nineButtons[8] = 3;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = true;
                    nineButtons[8] = 4;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = true;
                    nineButtons[8] = 5;
                    break;
            }
        }
    }

    public void count_9()
    {
        if (nineButtons[9] != 0)
        {
            totalcount = 0;
            switch (nineButtons[9])
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = false;
                    nineButtons[9] = 0;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = false;
                    nineButtons[9] = 0;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = false;
                    nineButtons[9] = 0;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = false;
                    nineButtons[9] = 0;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = false;
                    nineButtons[9] = 0;
                    break;
            }
        }

        else
        {
            totalcount = 9;

            int idx;
            idx = emptySearch();

            switch (idx)
            {
                case 1:
                    text_1.text = totalcount.ToString();
                    fiveButtons[1] = true;
                    nineButtons[9] = 1;
                    break;
                case 2:
                    text_2.text = totalcount.ToString();
                    fiveButtons[2] = true;
                    nineButtons[9] = 2;
                    break;
                case 3:
                    text_3.text = totalcount.ToString();
                    fiveButtons[3] = true;
                    nineButtons[9] = 3;
                    break;
                case 4:
                    text_4.text = totalcount.ToString();
                    fiveButtons[4] = true;
                    nineButtons[9] = 4;
                    break;
                case 5:
                    text_5.text = totalcount.ToString();
                    fiveButtons[5] = true;
                    nineButtons[9] = 5;
                    break;
            }
        }
    }
}