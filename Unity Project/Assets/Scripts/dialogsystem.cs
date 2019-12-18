using UnityEngine;
using UnityEngine.UI;

public class dialogsystem : MonoBehaviour
{
    public Text textname;
    public Text textcontent;
    public CanvasGroup uicanvusgroup;
    public void ShowDialog(string getname, string getcontent)

    {
        uicanvusgroup.alpha = 1;
       textname.text = getname;
       textcontent.text = getcontent; 
    }

    public void HideDialog()
    {
        uicanvusgroup.alpha = 0;
    }



}
