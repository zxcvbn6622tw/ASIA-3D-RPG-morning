using UnityEngine;

public class car : MonoBehaviour
{
    [Header("CC數"), Range(2000, 2500), Tooltip("拉")]
    public int CC = 2500 ;
    [Header("重量"), Range(1, 300)]
    public float Weight = 300;
   public string fac = "toyota";
   public bool music = false ;

}

