
using UnityEngine;

public class learnif : MonoBehaviour
{
    //if(布林值){陳述式或演算式}

    public bool opendoor;
    public int combo = 0;
    public int attack = 10;
    private void Start()
    {
        if (true)
        {
            print("測試");
        }

    }

    private void Update()
    {
        /** if (opendoor)
         {
             print("開門");
         }

         else
             print("關門");
     **/
        if (combo >= 150)
        {
            print("攻擊增加10倍");
        }
        else if (combo >= 100)
            print("攻擊增加5倍");
        else if (combo >= 50)
            print("攻擊增加2倍");
        else
            print("攻擊沒增加");
    }





}
