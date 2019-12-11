
using UnityEngine;

public class learnAPIstate : MonoBehaviour
{
    //使用靜態成員
    //成員：屬性 properties (類似欄位 fields)
    //成員：方法 methods
    //取得靜態屬性語法:類別.屬性
    //設定靜態屬性語法:類別.屬性=值

    /**private void Start()
    {
        print(Random.value);

        print( Random. Range (1 , 11));

        print(Mathf.PI);

        print(Mathf.Abs(-10));
    }
    **/
    private void Update()
    {
        print(Input.mousePosition);
        print(Input.anyKeyDown);
        print(Input.GetKeyDown(KeyCode.Mouse0));

    }

}
