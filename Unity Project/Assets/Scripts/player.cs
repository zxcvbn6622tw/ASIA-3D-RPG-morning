
using UnityEngine;

public class player : MonoBehaviour

{
    #region 欄位區域
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
    #endregion

    #region 方法區域
    /// <summary>
    /// 跑步
    /// </summary>
    private void running()
    {
        

    }
    /// <summary>
    /// 跳躍
    /// </summary>
    private void jumpping()
    {
    
    }
    /// <summary>
    /// 攻擊
    /// </summary>
    private void attacking()
    {
        
    }
    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damge">被傷害值</param>
    private void damging(float damge)
    {

    }
  /// <summary>
  /// 死亡
  /// </summary>
  /// <param name="deading">有沒有死亡</param>
    private void deadind(bool deading)
    {

    }
    /// <summary>
    /// 吃道具
    /// </summary>
    private void eatprop()
    {

    }
    /// <summary>
    /// 過關
    /// </summary>
    private void pass()
    {

    }
    #endregion
}

