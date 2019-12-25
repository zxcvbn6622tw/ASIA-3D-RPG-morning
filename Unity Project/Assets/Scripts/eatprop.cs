
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class eatprop : MonoBehaviour
{
    [Header("寶相數量介面")]
    public Text textcount;
    [Header("提示畫面")]
    public GameObject objTip;

    public int propCount;
    public int propTotal = 5;
    public bool finish;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "寶箱")
        {
            Destroy(collision.gameObject);


            propCount++;
            textcount.text = "寶箱:" + propCount + "/5";

            if (propCount == propTotal)
            {
                finish = true;
                objTip.SetActive(true);
            }
        }
       
        }

    private void Update()
    {
        Gameover();
    }

    private void Gameover()
    {
        if (finish)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            { Application.Quit(); }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("場景");
            }
        }

    }
}
