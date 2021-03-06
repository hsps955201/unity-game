﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//[RequireComponent(typeof(Player))]
[RequireComponent(typeof(Audio))]
public class GM : MonoBehaviour
{
    public enum Round
    {
        non,
        player1,
        player2,
        player3,
        player4,
        player5,
        player6,
        player7,
        player8,
    }

    public enum Process
    {
        start,
        waitLogin,
        decidePlayer,
        p1Action,
        p2Action,
        p3Action,
        p4Action,
        p5Action,
        p6Action,
        p7Action,
        p8Action,
        checkWin,
        again,
        end,
    }

    public static List<Player> allPlayer = new List<Player>();
    public Round round = Round.non;
    public Process process = Process.start;
    int roundCount = -1;

    public Image a;
    public Image b;
    public Image c;
    public Image d;
    public Image e;
    public Image f;
    public Image g;
    public Image h;
    public Image s;
    public Image j;
    public Image k;
    public Image l;
    public Image m;
    public Image n;
    public Image o;
    public Image x;

    public Image aaa;
    public Image bbb;
    public Image ccc;
    public Image ddd;
    public Image eee;
    public Image fff;
    public Image ggg;
    public Image hhh;
    public Image iii;
    public Image jjj;

    public Image t1;
    public Image t2;
    public Image t3;
    public Image t4;
    public Image t5;
    public Image t6;
    public Image t7;
    public Image t8;
    public Image f1;
    public Image f2;
    public Image f3;
    public Image f4;
    public Image f5;
    public Image f6;
    public Image f7;
    public Image f8;

    public Image test2;
    public Image test3;
    public Image test4;
    public Image test5;
    public Image test6;
    public Image test7;
    public Image test8;
    
    public Audio audiosync;//music
   

    public int[] aa84 = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };//1
    public int[] bb84 = new int[8] { 0, 0, 0, 1, 1, 1, 1, 0 };//2
    public int[] cc84 = new int[8] { 0, 0, 1, 0, 1, 1, 0, 1 };//3
    public int[] dd84 = new int[8] { 0, 0, 1, 1, 0, 0, 1, 1 };//4
    public int[] ee84 = new int[8] { 0, 1, 0, 0, 1, 0, 1, 1 };//5
    public int[] ff84 = new int[8] { 0, 1, 0, 1, 0, 1, 0, 1 };//6
    public int[] gg84 = new int[8] { 0, 1, 1, 0, 0, 1, 1, 0 };//7
    public int[] hh84 = new int[8] { 0, 1, 1, 1, 1, 0, 0, 0 };//8
    public int[] ii84 = new int[8] { 1, 0, 0, 1, 1, 0, 0, 1 };//9
    public int[] jj84 = new int[8] { 1, 0, 0, 0, 0, 1, 1, 1 };//10
    public int[] kk84 = new int[8] { 1, 0, 1, 0, 1, 0, 1, 0 };//11
    public int[] ll84 = new int[8] { 1, 0, 1, 1, 0, 1, 0, 0 };//12
    public int[] mm84 = new int[8] { 1, 1, 0, 0, 1, 1, 0, 0 };//13
    public int[] nn84 = new int[8] { 1, 1, 0, 1, 0, 0, 1, 0 };//14
    public int[] oo84 = new int[8] { 1, 1, 1, 0, 0, 0, 0, 1 };//15
    public int[] pp84 = new int[8] { 1, 1, 1, 1, 1, 1, 1, 1 };//16

    public void Login(Player player)
    {
        allPlayer.Add(player);
        player.RpcSetPlayer(allPlayer.Count);
        if (allPlayer.Count == 8)
            process = Process.decidePlayer;
    }

    public int edata;
    //public int z;
    public int w ;
    // public int[] encoded = new int[8];
    public int[] wencoded = new int[8];
    //public int[] syndrome = new int[4];
    public int[] ssyndrome = new int[4];
    public int[,] hhmatrix = new int[4, 8] { { 0, 1, 1, 1, 1, 0, 0, 0 },
                                            { 1, 0, 1, 1, 0, 1, 0, 0 },
                                            { 1, 1, 0, 1, 0, 0, 1, 0 },
                                            { 1, 1, 1, 1, 1, 1, 1, 1 } };
    // public static int[,] gmatrix = new int[4, 7] { { 1, 0, 0, 0, 0, 1, 1 }, { 0, 1, 0, 0, 1, 0, 1 }, { 0, 0, 1, 0, 1, 1, 0 }, { 0, 0, 0, 1, 1, 1, 1 } };
    public int pic1;
    public int pic2;
    public int pic3;
    public int pic4;
    public int pic5;
    public int pic6;
    public int pic7;
    public int pic8;
    //public int[] picture = new int[8];
    //public int[] pic1 = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };


   

    public void Change(int choose)
    {
        if (process == Process.p1Action)
        {
           pic1=choose;           
            
        }

        else if (process == Process.p2Action)
        {

            pic2 = choose;
            if (pic2!=pic1)
                test2.gameObject.SetActive(true);
            else 
                test2.gameObject.SetActive(false);
        }

        else if (process == Process.p3Action)
        {
            pic3 = choose;
            if (pic3 != pic2)
                test3.gameObject.SetActive(true);
            else
                test3.gameObject.SetActive(false);

        }
        else if (process == Process.p4Action)
        {
            pic4 = choose;
            if (pic4 != pic3)
                test4.gameObject.SetActive(true);
            else
                test4.gameObject.SetActive(false);

        }
        else if (process == Process.p5Action)
        {
            pic5 = choose;
            if (pic5 != pic4)
                test5.gameObject.SetActive(true);
            else
                test5.gameObject.SetActive(false);

        }
        else if (process == Process.p6Action)
        {
            pic6 = choose;
            if (pic6 != pic5)
                test6.gameObject.SetActive(true);
            else
                test6.gameObject.SetActive(false);

        }
        else if (process == Process.p7Action)
        {
            pic7 = choose;
            if (pic7 != pic6)
                test7.gameObject.SetActive(true);
            else
                test7.gameObject.SetActive(false);


        }
        else if (process == Process.p8Action)
        {
            pic8 = choose;
            if (pic8 != pic7)
                test8.gameObject.SetActive(true);
            else
                test8.gameObject.SetActive(false);
        }

    }

    public void AddMatrix(int edata)
    {
        /*int qq;

        for(int ooo=0;ooo<wencoded.Length;ooo++)
        {
            wencoded[ooo] = edata;
            
        }
        for (qq = 0; qq < ssyndrome.Length; qq++)
        {
            for (int j = 0; j < wencoded.Length; j++)
            {
                ssyndrome[qq] += (wencoded[j] * hmatrix[qq, j]);
                ssyndrome[qq] = ssyndrome[qq] % 2;
            }
            Debug.Log(ssyndrome[qq]);
        }
        for (int ooo = 0; ooo < encoded.Length; ooo++)
        {
            Debug.Log(encoded[ooo]);
        }*/
        if (process == Process.p1Action)
        {
            wencoded[0] = edata;
            // Debug.Log(encoded[1]);
            if(edata==0)
                t1.gameObject.SetActive(true);
            else if(edata==1)
                f1.gameObject.SetActive(true);
        }

        else if (process == Process.p2Action)
        {
            wencoded[1] = edata;
            // Debug.Log(encoded[1]);
            if (edata == 0)
                t2.gameObject.SetActive(true);
            else if (edata == 1)
                f2.gameObject.SetActive(true);
        }

        else if (process == Process.p3Action)
        {
            wencoded[2] = edata;
            if (edata == 0)
                t3.gameObject.SetActive(true);
            else if (edata == 1)
                f3.gameObject.SetActive(true);

        }
        else if (process == Process.p4Action)
        {
            wencoded[3] = edata;
            if (edata == 0)
                t4.gameObject.SetActive(true);
            else if (edata == 1)
                f4.gameObject.SetActive(true);

        }
        else if (process == Process.p5Action)
        {
            wencoded[4] = edata;
            if (edata == 0)
                t5.gameObject.SetActive(true);
            else if (edata == 1)
                f5.gameObject.SetActive(true);

        }
        else if (process == Process.p6Action)
        {
            wencoded[5] = edata;
            if (edata == 0)
                t6.gameObject.SetActive(true);
            else if (edata == 1)
                f6.gameObject.SetActive(true);

        }
        else if (process == Process.p7Action)
        {
            wencoded[6] = edata;
            if (edata == 0)
                t7.gameObject.SetActive(true);
            else if (edata == 1)
                f7.gameObject.SetActive(true);


        }
        else if (process == Process.p8Action)
        {
            wencoded[7] = edata;
            if (edata == 0)
                t8.gameObject.SetActive(true);
            else if (edata == 1)
                f8.gameObject.SetActive(true);

        }

        if (process == Process.p8Action)
        {
            int q;
            for (q = 0; q < 4; q++)
            {
                for (int j = 0; j < 8; j++)
                {
                    ssyndrome[q] += (wencoded[j] * hhmatrix[q, j]);
                    ssyndrome[q] = ssyndrome[q] % 2;
                }
            }


            int z = 0;
            for (z = 0; z < 8; z++)
            {

                if ((ssyndrome[0] == hhmatrix[0, z]) && (ssyndrome[1] == hhmatrix[1, z]) && (ssyndrome[2] == hhmatrix[2, z]) && (ssyndrome[3] == hhmatrix[3, z]))

                    break;
            }

            w = z + 1;


            if (w == 1)
            {
                
                aaa.gameObject.SetActive(true);
            }
            else if (w == 2)
            {
                
                bbb.gameObject.SetActive(true);
            }
            else if (w == 3)
            {
                
                ccc.gameObject.SetActive(true);
            }
            else if (w == 4)
            {
                
                ddd.gameObject.SetActive(true);
            }
            else if (w == 5)
            {
                
                eee.gameObject.SetActive(true);
            }
            else if (w == 6)
            {
               
                fff.gameObject.SetActive(true);
            }
            else if (w == 7)
            {
                
                ggg.gameObject.SetActive(true);
            }
            else if (w == 8)
            {
                
                iii.gameObject.SetActive(true);
            }

             if (w == 9)
             {
                
                if ((ssyndrome[0] == 0) && (ssyndrome[1] == 0) && (ssyndrome[2] == 0) && (ssyndrome[3] == 0))
                {
                    jjj.gameObject.SetActive(true);
                }

                else
                    hhh.gameObject.SetActive(true);//two error

             }

            else {
                if (wencoded[z] == 0)
                {
                    wencoded[z] = 1;
                }
                else if (wencoded[z] == 1)
                {
                    wencoded[z] = 0;
                }
            }          
            

               
            



            

            if (wencoded.Length == aa84.Length)
            {

                int i = 0;
                while ((i < wencoded.Length) && (wencoded[i] == aa84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {

                    a.gameObject.SetActive(true);
                }


                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == bb84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {


                    b.gameObject.SetActive(true);
                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == cc84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {


                    c.gameObject.SetActive(true);

                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == dd84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {


                    d.gameObject.SetActive(true);

                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == ee84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {

                    e.gameObject.SetActive(true);

                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == ff84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {


                    f.gameObject.SetActive(true);

                }

                i = 0;


                while ((i < wencoded.Length) && (wencoded[i] == gg84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {

                    g.gameObject.SetActive(true);

                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == hh84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {


                    h.gameObject.SetActive(true);

                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == ii84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {


                    s.gameObject.SetActive(true);

                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == jj84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {


                    j.gameObject.SetActive(true);


                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == kk84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {



                    k.gameObject.SetActive(true);
                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == ll84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {


                    l.gameObject.SetActive(true);

                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == mm84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {


                    m.gameObject.SetActive(true);

                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == nn84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {


                    n.gameObject.SetActive(true);

                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == oo84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {


                    o.gameObject.SetActive(true);

                }

                i = 0;

                while ((i < wencoded.Length) && (wencoded[i] == pp84[i]))
                {
                    i += 1;
                }
                if (i == wencoded.Length)
                {

                    x.gameObject.SetActive(true);
                }



            }

            process = Process.checkWin;
        }
        else

            process = Process.decidePlayer;
    }
    /*public void PlaySound(int id)
    {
        if (id >= 0 && id < clips.Length)
        {
            v1.PlayOneShot(clips[id]);
        }
    }*/
    public Button home;
    void Start()
    {
       
        // Button button = GameObject.Find("home").GetComponent<Button>();
        /* button.onClick.AddListener(() =>
         {
             SceneManager.LoadScene("lob");
         });*/
        audiosync = this.GetComponent<Audio>();
        //v1= this.GetComponent<AudioSource>();
        /* v2 = this.GetComponent<AudioSource>();
         v3 = this.GetComponent<AudioSource>();
         v4 = this.GetComponent<AudioSource>();
         v5 = this.GetComponent<AudioSource>();
         v6 = this.GetComponent<AudioSource>();
         v7 = this.GetComponent<AudioSource>();
         v8 = this.GetComponent<AudioSource>();
         again = this.GetComponent<AudioSource>();
         lie = this.GetComponent<AudioSource>();*/
        process = Process.waitLogin;
    }
   
    void Update()
    {
      
        switch (process)
        {
            case Process.waitLogin:
                foreach (Player pl in allPlayer)
                    pl.SysMsg = "等待玩家連線...";
                break;

            case Process.decidePlayer:
                roundCount++;
                if (roundCount % 8 == 0)//p1回合
                {
                    round = Round.player1;
                    process = Process.p1Action;
                }

                else if (roundCount % 8 == 1)
                {
                    round = Round.player2;
                    process = Process.p2Action;
                }
                else if (roundCount % 8 == 2)
                {
                    round = Round.player3;
                    process = Process.p3Action;
                }
                else if (roundCount % 8 == 3)
                {
                    round = Round.player4;
                    process = Process.p4Action;
                }
                else if (roundCount % 8 == 4)
                {
                    round = Round.player5;
                    process = Process.p5Action;
                }
                else if (roundCount % 8 == 5)
                {
                    round = Round.player6;
                    process = Process.p6Action;
                }
                else if (roundCount % 8 == 6)
                {
                    round = Round.player7;
                    process = Process.p7Action;
                }
                else if (roundCount % 8 == 7)
                {
                    round = Round.player8;
                    process = Process.p8Action;
                }
                break;

            case Process.p1Action:
                allPlayer[0].SysMsg = "Q1.你有看到太陽嗎?";
                allPlayer[0].SetProcess(Player.Process.action);
                allPlayer[1].SysMsg = "等待對方...";
                allPlayer[1].SetProcess(Player.Process.wait);
                allPlayer[2].SysMsg = "等待對方...";
                allPlayer[2].SetProcess(Player.Process.wait);
                allPlayer[3].SysMsg = "等待對方...";
                allPlayer[3].SetProcess(Player.Process.wait);
                allPlayer[4].SysMsg = "等待對方...";
                allPlayer[4].SetProcess(Player.Process.wait);
                allPlayer[5].SysMsg = "等待對方...";
                allPlayer[5].SetProcess(Player.Process.wait);
                allPlayer[6].SysMsg = "等待對方...";
                allPlayer[6].SetProcess(Player.Process.wait);
                allPlayer[7].SysMsg = "等待對方...";
                allPlayer[7].SetProcess(Player.Process.wait);
                break;

            case Process.p2Action:
                allPlayer[1].SysMsg = "Q2.你有看到槍枝嗎?";
                allPlayer[1].SetProcess(Player.Process.action);
                allPlayer[0].SysMsg = "等待對方...";
                allPlayer[0].SetProcess(Player.Process.wait);
                allPlayer[2].SysMsg = "等待對方...";
                allPlayer[2].SetProcess(Player.Process.wait);
                allPlayer[3].SysMsg = "等待對方...";
                allPlayer[3].SetProcess(Player.Process.wait);
                allPlayer[4].SysMsg = "等待對方...";
                allPlayer[4].SetProcess(Player.Process.wait);
                allPlayer[5].SysMsg = "等待對方...";
                allPlayer[5].SetProcess(Player.Process.wait);
                allPlayer[6].SysMsg = "等待對方...";
                allPlayer[6].SetProcess(Player.Process.wait);
                allPlayer[7].SysMsg = "等待對方...";
                allPlayer[7].SetProcess(Player.Process.wait);
                break;

            case Process.p3Action:
                allPlayer[2].SysMsg = "Q3.圖中是否有打火機?";
                allPlayer[2].SetProcess(Player.Process.action);
                allPlayer[0].SysMsg = "等待對方...";
                allPlayer[0].SetProcess(Player.Process.wait);
                allPlayer[1].SysMsg = "等待對方...";
                allPlayer[1].SetProcess(Player.Process.wait);
                allPlayer[3].SysMsg = "等待對方...";
                allPlayer[3].SetProcess(Player.Process.wait);
                allPlayer[4].SysMsg = "等待對方...";
                allPlayer[4].SetProcess(Player.Process.wait);
                allPlayer[5].SysMsg = "等待對方...";
                allPlayer[5].SetProcess(Player.Process.wait);
                allPlayer[6].SysMsg = "等待對方...";
                allPlayer[6].SetProcess(Player.Process.wait);
                allPlayer[7].SysMsg = "等待對方...";
                allPlayer[7].SetProcess(Player.Process.wait);
                break;

            case Process.p4Action:
                allPlayer[3].SysMsg = "Q4.有在圖裡看到人嗎?";
                allPlayer[3].SetProcess(Player.Process.action);
                allPlayer[0].SysMsg = "等待對方...";
                allPlayer[0].SetProcess(Player.Process.wait);
                allPlayer[1].SysMsg = "等待對方...";
                allPlayer[1].SetProcess(Player.Process.wait);
                allPlayer[2].SysMsg = "等待對方...";
                allPlayer[2].SetProcess(Player.Process.wait);
                allPlayer[4].SysMsg = "等待對方...";
                allPlayer[4].SetProcess(Player.Process.wait);
                allPlayer[5].SysMsg = "等待對方...";
                allPlayer[5].SetProcess(Player.Process.wait);
                allPlayer[6].SysMsg = "等待對方...";
                allPlayer[6].SetProcess(Player.Process.wait);
                allPlayer[7].SysMsg = "等待對方...";
                allPlayer[7].SetProcess(Player.Process.wait);
                break;

            case Process.p5Action:
                allPlayer[4].SysMsg = "Q5.是否有警車經過?";
                allPlayer[4].SetProcess(Player.Process.action);
                allPlayer[0].SysMsg = "等待對方...";
                allPlayer[0].SetProcess(Player.Process.wait);
                allPlayer[1].SysMsg = "等待對方...";
                allPlayer[1].SetProcess(Player.Process.wait);
                allPlayer[2].SysMsg = "等待對方...";
                allPlayer[2].SetProcess(Player.Process.wait);
                allPlayer[3].SysMsg = "等待對方...";
                allPlayer[3].SetProcess(Player.Process.wait);
                allPlayer[5].SysMsg = "等待對方...";
                allPlayer[5].SetProcess(Player.Process.wait);
                allPlayer[6].SysMsg = "等待對方...";
                allPlayer[6].SetProcess(Player.Process.wait);
                allPlayer[7].SysMsg = "等待對方...";
                allPlayer[7].SetProcess(Player.Process.wait);
                break;

            case Process.p6Action:
                allPlayer[5].SysMsg = "Q6.圖片中有手銬嗎?";
                allPlayer[5].SetProcess(Player.Process.action);
                allPlayer[0].SysMsg = "等待對方...";
                allPlayer[0].SetProcess(Player.Process.wait);
                allPlayer[1].SysMsg = "等待對方...";
                allPlayer[1].SetProcess(Player.Process.wait);
                allPlayer[2].SysMsg = "等待對方...";
                allPlayer[2].SetProcess(Player.Process.wait);
                allPlayer[3].SysMsg = "等待對方...";
                allPlayer[3].SetProcess(Player.Process.wait);
                allPlayer[4].SysMsg = "等待對方...";
                allPlayer[4].SetProcess(Player.Process.wait);
                allPlayer[6].SysMsg = "等待對方...";
                allPlayer[6].SetProcess(Player.Process.wait);
                allPlayer[7].SysMsg = "等待對方...";
                allPlayer[7].SetProcess(Player.Process.wait);
                break;

            case Process.p7Action:
                allPlayer[6].SysMsg = "Q7.你有看到樹嗎?";
                allPlayer[6].SetProcess(Player.Process.action);
                allPlayer[0].SysMsg = "等待對方...";
                allPlayer[0].SetProcess(Player.Process.wait);
                allPlayer[1].SysMsg = "等待對方...";
                allPlayer[1].SetProcess(Player.Process.wait);
                allPlayer[2].SysMsg = "等待對方...";
                allPlayer[2].SetProcess(Player.Process.wait);
                allPlayer[3].SysMsg = "等待對方...";
                allPlayer[3].SetProcess(Player.Process.wait);
                allPlayer[4].SysMsg = "等待對方...";
                allPlayer[4].SetProcess(Player.Process.wait);
                allPlayer[5].SysMsg = "等待對方...";
                allPlayer[5].SetProcess(Player.Process.wait);
                allPlayer[7].SysMsg = "等待對方...";
                allPlayer[7].SetProcess(Player.Process.wait);
                break;

            case Process.p8Action:
                allPlayer[7].SysMsg = "Q8.圖中是否有醫院?";
                allPlayer[7].SetProcess(Player.Process.action);
                allPlayer[0].SysMsg = "等待對方...";
                allPlayer[0].SetProcess(Player.Process.wait);
                allPlayer[1].SysMsg = "等待對方...";
                allPlayer[1].SetProcess(Player.Process.wait);
                allPlayer[2].SysMsg = "等待對方...";
                allPlayer[2].SetProcess(Player.Process.wait);
                allPlayer[3].SysMsg = "等待對方...";
                allPlayer[3].SetProcess(Player.Process.wait);
                allPlayer[4].SysMsg = "等待對方...";
                allPlayer[4].SetProcess(Player.Process.wait);
                allPlayer[5].SysMsg = "等待對方...";
                allPlayer[5].SetProcess(Player.Process.wait);
                allPlayer[6].SysMsg = "等待對方...";
                allPlayer[6].SetProcess(Player.Process.wait);
                break;


            case Process.checkWin:
                if (w == 1)
                {
                    audiosync.PlaySound(0);
                    //allPlayer[0].audiosync.PlaySound(0);
                   
                    allPlayer[0].SysMsg = "Spy";
                    allPlayer[1].SysMsg = "Safe";
                    allPlayer[2].SysMsg = "Safe";
                    allPlayer[3].SysMsg = "Safe";
                    allPlayer[4].SysMsg = "Safe";
                    allPlayer[5].SysMsg = "Safe";
                    allPlayer[6].SysMsg = "Safe";
                    allPlayer[7].SysMsg = "Safe";
                    // audioSource.PlayOneShot(voice);
                    //allPlayer[0].voice = audioSource.PlayOneShot(voice);
                    ///audioSource.PlayOneShot((AudioClip)Resources.Load("videoplayback"));

                    break;
                }

                else if (w == 2)
                {
                    audiosync.PlaySound(1);
                    //allPlayer[1].audiosync.PlaySound(1);

                    allPlayer[1].SysMsg = "Spy";
                    allPlayer[0].SysMsg = "Safe";
                    allPlayer[2].SysMsg = "Safe";
                    allPlayer[3].SysMsg = "Safe";
                    allPlayer[4].SysMsg = "Safe";
                    allPlayer[5].SysMsg = "Safe";
                    allPlayer[6].SysMsg = "Safe";
                    allPlayer[7].SysMsg = "Safe";
                    break;
                }
                else if (w == 3)
                {
                    audiosync.PlaySound(2);
                    //allPlayer[2].audiosync.PlaySound(2);

                    allPlayer[2].SysMsg = "Spy";
                    allPlayer[0].SysMsg = "Safe";
                    allPlayer[1].SysMsg = "Safe";
                    allPlayer[3].SysMsg = "Safe";
                    allPlayer[4].SysMsg = "Safe";
                    allPlayer[5].SysMsg = "Safe";
                    allPlayer[6].SysMsg = "Safe";
                    allPlayer[7].SysMsg = "Safe";
                    break;
                }
                else if (w == 4)
                {
                    audiosync.PlaySound(3);
                    //allPlayer[3].audiosync.PlaySound(3);

                    allPlayer[3].SysMsg = "Spy";
                    allPlayer[0].SysMsg = "Safe";
                    allPlayer[1].SysMsg = "Safe";
                    allPlayer[2].SysMsg = "Safe";
                    allPlayer[4].SysMsg = "Safe";
                    allPlayer[5].SysMsg = "Safe";
                    allPlayer[6].SysMsg = "Safe";
                    allPlayer[7].SysMsg = "Safe";
                    break;
                }

                else if (w == 5)
                {
                    audiosync.PlaySound(4);
                    //allPlayer[4].audiosync.PlaySound(4);

                    allPlayer[4].SysMsg = "Spy";
                    allPlayer[0].SysMsg = "Safe";
                    allPlayer[1].SysMsg = "Safe";
                    allPlayer[2].SysMsg = "Safe";
                    allPlayer[3].SysMsg = "Safe";
                    allPlayer[5].SysMsg = "Safe";
                    allPlayer[6].SysMsg = "Safe";
                    allPlayer[7].SysMsg = "Safe";
                    break;

                }
                else if (w == 6)
                {
                    audiosync.PlaySound(5);
                    //allPlayer[5].audiosync.PlaySound(5);

                    allPlayer[5].SysMsg = "Spy";
                    allPlayer[0].SysMsg = "Safe";
                    allPlayer[1].SysMsg = "Safe";
                    allPlayer[2].SysMsg = "Safe";
                    allPlayer[3].SysMsg = "Safe";
                    allPlayer[4].SysMsg = "Safe";
                    allPlayer[6].SysMsg = "Safe";
                    allPlayer[7].SysMsg = "Safe";
                    break;
                }

                else if (w == 7)
                {
                    audiosync.PlaySound(6);
                    //allPlayer[6].audiosync.PlaySound(6);

                    allPlayer[6].SysMsg = "Spy";
                    allPlayer[0].SysMsg = "Safe";
                    allPlayer[1].SysMsg = "Safe";
                    allPlayer[2].SysMsg = "Safe";
                    allPlayer[3].SysMsg = "Safe";
                    allPlayer[4].SysMsg = "Safe";
                    allPlayer[5].SysMsg = "Safe";
                    allPlayer[7].SysMsg = "Safe";
                    break;
                }
                else if (w == 8)
                {
                    audiosync.PlaySound(7);
                    //allPlayer[7].audiosync.PlaySound(7);

                    allPlayer[7].SysMsg = "Spy";
                    allPlayer[0].SysMsg = "Safe";
                    allPlayer[1].SysMsg = "Safe";
                    allPlayer[2].SysMsg = "Safe";
                    allPlayer[3].SysMsg = "Safe";
                    allPlayer[4].SysMsg = "Safe";
                    allPlayer[5].SysMsg = "Safe";
                    allPlayer[6].SysMsg = "Safe";
                    break;
                }
                else if ((w == 9 && ((ssyndrome[0] == 0) && (ssyndrome[1] == 0) && (ssyndrome[2] == 1) && (ssyndrome[3] == 0))) ||
                         (w == 9 && ((ssyndrome[0] == 0) && (ssyndrome[1] == 1) && (ssyndrome[2] == 0) && (ssyndrome[3] == 0))) ||
                         (w == 9 && ((ssyndrome[0] == 0) && (ssyndrome[1] == 1) && (ssyndrome[2] == 1) && (ssyndrome[3] == 0))) ||
                         (w == 9 && ((ssyndrome[0] == 1) && (ssyndrome[1] == 0) && (ssyndrome[2] == 0) && (ssyndrome[3] == 0))) ||
                         (w == 9 && ((ssyndrome[0] == 1) && (ssyndrome[1] == 0) && (ssyndrome[2] == 0) && (ssyndrome[3] == 1))) ||
                         (w == 9 && ((ssyndrome[0] == 1) && (ssyndrome[1] == 0) && (ssyndrome[2] == 1) && (ssyndrome[3] == 0))) ||
                         (w == 9 && ((ssyndrome[0] == 1) && (ssyndrome[1] == 1) && (ssyndrome[2] == 0) && (ssyndrome[3] == 0))) ||
                         (w == 9 && ((ssyndrome[0] == 1) && (ssyndrome[1] == 1) && (ssyndrome[2] == 1) && (ssyndrome[3] == 0)))
                         )
                {
                    audiosync.PlaySound(9);
                    //allPlayer[0].audiosync.PlaySound(0);

                    allPlayer[6].SysMsg = "lie";
                    allPlayer[0].SysMsg = "lie";
                    allPlayer[1].SysMsg = "lie";
                    allPlayer[2].SysMsg = "lie";
                    allPlayer[3].SysMsg = "lie";
                    allPlayer[4].SysMsg = "lie";
                    allPlayer[5].SysMsg = "lie";
                    allPlayer[7].SysMsg = "lie";
                    break;
                }

                else if (w == 9 && ((ssyndrome[0] == 0) && (ssyndrome[1] == 0) && (ssyndrome[2] == 0) && (ssyndrome[3] == 0)))
                {
                    //allPlayer[0].audiosync.PlaySound(0);

                    audiosync.PlaySound(8);
                    allPlayer[0].SysMsg = "again";
                    allPlayer[1].SysMsg = "again";
                    allPlayer[2].SysMsg = "again";
                    allPlayer[3].SysMsg = "again";
                    allPlayer[4].SysMsg = "again";
                    allPlayer[5].SysMsg = "again";
                    allPlayer[6].SysMsg = "again";
                    allPlayer[7].SysMsg = "again";
                    break;
                }

                allPlayer[0].SetProcess(Player.Process.end);
                allPlayer[1].SetProcess(Player.Process.end);
                allPlayer[2].SetProcess(Player.Process.end);
                allPlayer[3].SetProcess(Player.Process.end);
                allPlayer[4].SetProcess(Player.Process.end);
                allPlayer[5].SetProcess(Player.Process.end);
                allPlayer[6].SetProcess(Player.Process.end);
                allPlayer[7].SetProcess(Player.Process.end);
                process = Process.end;
                break;
        }
    }


}