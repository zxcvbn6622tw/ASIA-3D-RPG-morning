
using UnityEngine;

public class npc : MonoBehaviour
{
    private string _name = "gmaeboy";
    private string content = "help me";

    public dialogsystem ds;
    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "vThirdPersonCamera")
        {
            ds.ShowDialog(_name, content);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        print(other.name);
        if (other.name == "vThirdPersonCamera")
        {
            ds.HideDialog();
        }
        
    }
}
