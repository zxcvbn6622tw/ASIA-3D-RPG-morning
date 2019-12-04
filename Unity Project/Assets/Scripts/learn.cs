
using UnityEngine;

public class learn : MonoBehaviour
{
    public int A = 50, B = 5;
    public int C = 1;
    public int prop = 1;
    public int D = 3;
    public float E = 56.3f, F = 84.3f;

    public float hp = 100;
    public bool key;
    public int enemy;


    private void Start()
    {
        #region 基礎運算子
        //加減乘除
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);
        //指派:先運算指派符號右邊再傳回左邊
        C = 10 + 10;
        print("C的運算結果" + C);
        //道具=道具+1
        print(prop++);//後置遞增:會先運算再輸出
        print(++prop);//前置遞增:會輸出後再運算
        //道具=道具-1
        print(prop--);//後置遞減:會先運算再輸出
        print(--prop);//前置遞減:會輸出後再運算
        #endregion
        #region 比較運算子
        //結果會是布林值
        print(E > F);
        print(E < F);
        print(E >= F);
        print(E <= F);
        print(E == F);
        print(E != F);
        #endregion
        #region 邏輯運算子
        //並且&&:一個false結果就是false
        print(true && false); //false
        print(false && false); //false
        print(true && true); //ture
        print(false && true); //false
        //或者||:一個true結果就是true
        print(true || false); //ture
        print(false || false); //false
        print(true || true); //true
        print(false || true); //true
        //相反!
        print(!true);//false
        print(!false);//true
        #endregion

        

    }
    private void Update()
    {
        print("死亡:" + (hp <= 0));
        print("過關判定:" + (key && enemy >= 6));
    }
    
}
