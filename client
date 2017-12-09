using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : NetworkBehaviour { 
    public enum Process
    {
        start,
        action,
        wait,
        end
    }

    public Image ImgPlayer1;
    public Image ImgPlayer2;
    public Image ImgPlayer3;
    public Image ImgPlayer4;
    public Image ImgPlayer5;
    public Image ImgPlayer6;
    public Image ImgPlayer7;
    public Image ImgPlayer8;

    public Image aa;
    public Image bb;
    public Image cc;
    public Image dd;
    public Image ee;
    public Image ff;
    public Image gg;
    public Image hh;
    public Image ii;
    public Image jj;
    public Image kk;
    public Image ll;
    public Image mm;
    public Image nn;
    public Image oo;
    public Image pp;
    public Image tips;
    GM gm;



    public Button btnAddOne;
    public Button btnAddZero;
    public Button a1;
    public Button a2;
    public Button a3;
    public Button a4;
    public Button a5;
    public Button a6;
    public Button a7;
    public Button a8;
    public Button a9;
    public Button a10;
    public Button a11;
    public Button a12;
    public Button a13;
    public Button a14;
    public Button a15;
    public Button a16;
    public Button cancel;
    public Button tip;

   

    [SyncVar]
    public Process process = Process.start;

    [SyncVar]
    public string SysMsg;      
   

    
    public Text txtSysMsg;   

  
    
    void Start()
    {

       

        if (isServer)
        {
            gm = GameObject.Find("GM").GetComponent<GM>();
            gm.Login(this);
        } 
        if (isLocalPlayer)
        {                          
            txtSysMsg = GameObject.Find("txtSysMsg").GetComponent<Text>();
            btnAddOne = GameObject.Find("no").GetComponent<Button>();
            btnAddZero = GameObject.Find("yes").GetComponent<Button>();
            btnAddOne.onClick.AddListener(() => CmdAddMatrix(1));
            btnAddZero.onClick.AddListener(() => CmdAddMatrix(0));

            cancel = GameObject.Find("cancel").GetComponent<Button>();
            tip = GameObject.Find("tip").GetComponent<Button>();
            a1 = GameObject.Find("a1").GetComponent<Button>();
            a2 = GameObject.Find("a2").GetComponent<Button>();
            a3 = GameObject.Find("a3").GetComponent<Button>();
            //a1.onClick.AddListener(() => {SceneManager.LoadScene("1");});
            //a2.onClick.AddListener(() => { SceneManager.LoadScene("1"); });
            //a3.onClick.AddListener(() => { SceneManager.LoadScene("1"); });
            //a1.onClick.AddListener(() => Showpicture(1));
            //a2.onClick.AddListener(() => Showpicture(2));
            //a3.onClick.AddListener(() => CmdShowpicture(3));
            cancel.onClick.AddListener(() => Restart());
            tip.onClick.AddListener(() => RpcChange(17));
            a1.onClick.AddListener(() => CmdChange(1));
            a2.onClick.AddListener(() => CmdChange(2));
            a3.onClick.AddListener(() => CmdChange(3));
            a1.onClick.AddListener(() => RpcChange(1));
            a2.onClick.AddListener(() => RpcChange(2));
            a3.onClick.AddListener(() => RpcChange(3));

            a4 = GameObject.Find("a4").GetComponent<Button>();
            a5 = GameObject.Find("a5").GetComponent<Button>();
            a6 = GameObject.Find("a6").GetComponent<Button>();
            
            a4.onClick.AddListener(() => CmdChange(4));
            a5.onClick.AddListener(() => CmdChange(5));
            a6.onClick.AddListener(() => CmdChange(6));
            a4.onClick.AddListener(() => RpcChange(4));
            a5.onClick.AddListener(() => RpcChange(5));
            a6.onClick.AddListener(() => RpcChange(6));

            a7 = GameObject.Find("a7").GetComponent<Button>();
            a8 = GameObject.Find("a8").GetComponent<Button>();
            a9 = GameObject.Find("a9").GetComponent<Button>();
            //a7.onClick.AddListener(() => Showpicture(7));
            //a8.onClick.AddListener(() => CmdShowpicture(8));
            //a9.onClick.AddListener(() => CmdShowpicture(9));
            a7.onClick.AddListener(() => CmdChange(7));
            a8.onClick.AddListener(() => CmdChange(8));
            a9.onClick.AddListener(() => CmdChange(9));
            a7.onClick.AddListener(() => RpcChange(7));
            a8.onClick.AddListener(() => RpcChange(8));
            a9.onClick.AddListener(() => RpcChange(9));

            a10 = GameObject.Find("a10").GetComponent<Button>();
            a11 = GameObject.Find("a11").GetComponent<Button>();
            a12 = GameObject.Find("a12").GetComponent<Button>();
            //a10.onClick.AddListener(() => CmdShowpicture(10));
            //a11.onClick.AddListener(() => CmdShowpicture(11));
            //a12.onClick.AddListener(() => CmdShowpicture(12));
            a10.onClick.AddListener(() => CmdChange(10));
            a11.onClick.AddListener(() => CmdChange(11));
            a12.onClick.AddListener(() => CmdChange(12));
            a10.onClick.AddListener(() => RpcChange(10));
            a11.onClick.AddListener(() => RpcChange(11));
            a12.onClick.AddListener(() => RpcChange(12));

            a13 = GameObject.Find("a13").GetComponent<Button>();
            a14 = GameObject.Find("a14").GetComponent<Button>();
            a15 = GameObject.Find("a15").GetComponent<Button>();
            // a13.onClick.AddListener(() => CmdShowpicture(13));
            // a14.onClick.AddListener(() => CmdShowpicture(14));
            // a15.onClick.AddListener(() => CmdShowpicture(15));
            a13.onClick.AddListener(() => CmdChange(13));
            a14.onClick.AddListener(() => CmdChange(14));
            a15.onClick.AddListener(() => CmdChange(15));
            a13.onClick.AddListener(() => RpcChange(13));
            a14.onClick.AddListener(() => RpcChange(14));
            a15.onClick.AddListener(() => RpcChange(15));

            a16 = GameObject.Find("a16").GetComponent<Button>();
            a16.onClick.AddListener(() => RpcChange(16));
            //a16.onClick.AddListener(() => CmdShowpicture(16));



        }
    }
    
    void Update()
    {
        if (isServer)
            edata = gm.edata;
            //choose = gm.choose;

        if (isLocalPlayer)
        {
            txtSysMsg.text = SysMsg;          

        }
        
    }

    


    [SyncVar]
    public int edata;
    

    [Command]
    public void CmdAddMatrix(int edata)
    {
        if (process == Process.action)
        gm.AddMatrix(edata);
    }

    [SyncVar]
    public int choose;


    [Command]
    public void CmdChange(int choose)
    {
        if (process == Process.action)
            gm.Change(choose);
    }

    public void SetProcess(Process process)
    {
        this.process = process;
    }

    public void Restart()
    {
        
            aa.gameObject.SetActive(false);
            bb.gameObject.SetActive(false);
            cc.gameObject.SetActive(false);
            dd.gameObject.SetActive(false);
            ee.gameObject.SetActive(false);
            ff.gameObject.SetActive(false);
            gg.gameObject.SetActive(false);
            hh.gameObject.SetActive(false);
            ii.gameObject.SetActive(false);
            jj.gameObject.SetActive(false);
            kk.gameObject.SetActive(false);
            ll.gameObject.SetActive(false);
            mm.gameObject.SetActive(false);
            nn.gameObject.SetActive(false);
            oo.gameObject.SetActive(false);
            pp.gameObject.SetActive(false);
            tips.gameObject.SetActive(false);

    }

 
    public void RpcChange(int choose)
    {
      
            if (choose == 1)
            {
                aa.gameObject.SetActive(true);
            }
            else if (choose == 2)
            {
                bb.gameObject.SetActive(true);

            }
            else if (choose == 3)
            {
                cc.gameObject.SetActive(true);
            }
            else if (choose == 4)
            {
                dd.gameObject.SetActive(true);

            }
            else if (choose == 5)
            {
                ee.gameObject.SetActive(true);
            }
            else if (choose == 6)
            {
                ff.gameObject.SetActive(true);

            }
            else if (choose == 7)
            {
                gg.gameObject.SetActive(true);
            }
            else if (choose == 8)
            {
                hh.gameObject.SetActive(true);

            }
            else if (choose == 9)
            {
                ii.gameObject.SetActive(true);
            }
            else if (choose == 10)
            {
                jj.gameObject.SetActive(true);

            }
            else if (choose == 11)
            {
                kk.gameObject.SetActive(true);
            }
            else if (choose == 12)
            {
                ll.gameObject.SetActive(true);

            }
            else if (choose == 13)
            {
                mm.gameObject.SetActive(true);
            }
            else if (choose == 14)
            {
                nn.gameObject.SetActive(true);

            }
            else if (choose == 15)
            {
                oo.gameObject.SetActive(true);
            }
            else if (choose == 16)
            {
                pp.gameObject.SetActive(true);
            }
            else if (choose == 17)
            {
                tips.gameObject.SetActive(true);
            }

    }

   

[ClientRpc]
        public void RpcSetPlayer(int id)
        {
            if (isLocalPlayer)
            {
            
                switch (id)
                {
                case 1:                   
                    ImgPlayer1.gameObject.SetActive(true);
                    break;

                case 2:                    
                   ImgPlayer2.gameObject.SetActive(true);
                    break;

                case 3:                   
                   ImgPlayer3.gameObject.SetActive(true);
                    break;

                case 4:                    
                   ImgPlayer4.gameObject.SetActive(true);
                    break;

                case 5:                    
                   ImgPlayer5.gameObject.SetActive(true);
                    break;

                case 6:                   
                    ImgPlayer6.gameObject.SetActive(true);
                    break;

                case 7:                  
                   ImgPlayer7.gameObject.SetActive(true);
                    break;

                case 8:                    
                    ImgPlayer8.gameObject.SetActive(true);
                    break;



                }
            }
        }
}
