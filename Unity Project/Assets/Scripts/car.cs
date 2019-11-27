using UnityEngine;

public class car : MonoBehaviour
{
    [Header("CC數"), Range(2000, 2500), Tooltip("拉")]
    public int CC = 2500 ;
    [Header("重量"), Range(1, 300)]
    public float Weight = 300;
   public string fac = "toyota";
   public bool music = false ;


    private void Start()
    {
        print("是在哈囉");
        print(CC);
        print(Weight);
        print(fac);

        CC = 2000;
    }
    private void Update()
    {
        Drive(100,"左",effect:"火花");
        int t = tax();
        print("稅金:" + t);
       
    }

    public void Drive (int speed,string direction,string sound="耶耶耶",string effect="速度線 ")
    {
        print("開車，時數:" + speed) ;
        print("目前方向:" + direction);
        print("聲音:"+sound);
        print("特效:" + effect);
    }

    public int tax()
    {
        return CC * 100;
    }




}


