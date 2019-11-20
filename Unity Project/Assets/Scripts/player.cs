
using UnityEngine;

public class player : MonoBehaviour

{
    [Header("玩家") ]
    public string run;
    public string jump;
    public string attack;
    public string hit;
    [Header("HP") , Range(0,100) ]
    public int hp;

    [Header("道具"), Range(0,10)]
    public int demand ;



    }

