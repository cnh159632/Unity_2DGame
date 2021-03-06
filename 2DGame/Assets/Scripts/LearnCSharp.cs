using UnityEngine;

public class LearnCSharp : MonoBehaviour
{
    public int hp = 100;
    public float speed = 1.5f;
    public string skill = "蔥爆氣流斬";
    public bool missoin = false;
    public Color skin = Color.green;
    public Vector3 posStart = new Vector3(30, 1, 20);
    public GameObject trap;
    
    /// <summary>
    ///移動方式 
    /// </summary>
    public void Move()
    {
        print("移動中");
    }

    /// <summary>
    /// 受傷方法
    /// </summary>
    /// <param name="getDamage">接收的傷害值</param>
    public void Hit(float getDamage)
    {
        print("受到傷害：" + getDamage);
    }

    /// <summary>
    /// 跳躍方法
    /// </summary>
    /// <param name="height">跳躍高度</param>
    /// <param name="aniName">跳躍動畫</param>
    public void Jump(float height, string aniName)
    {
        print("跳躍高度：" + height);
        print("跳躍動畫：" + aniName);
    }

    private void Start()
    {
        Move();
        Hit(999.9f);
    }

    private void Update()
    {
        Jump(50f, "跳跳");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
