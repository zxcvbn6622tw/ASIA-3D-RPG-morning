
using UnityEngine;

public class player : MonoBehaviour

{
    [Header("玩家")]
    public string run = "跑步開關";
    public string jump = "跳躍開關";
    public string attack = "攻擊觸發";
    public string hit = "受傷觸發";
    public string dead = "死亡";

    [Header("需要道具")]
    public int demand = 10;
    [Header("現有道具")]
    public int have = 0;
    [Header("數值")]
    public bool die=false;
    [Range(0,200)]
    public float hp = 100;


    



}

