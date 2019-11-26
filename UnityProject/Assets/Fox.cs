using UnityEngine;

public class Fox : MonoBehaviour
{
    // Start is called before the first frame update
    //保存RB2D預置物
    public Rigidbody2D Rig;
    //保存圖片渲染器SR預置物
    public SpriteRenderer Sr;
    /// <summary>
    /// 移動方法
    /// </summary>
    private void Move()
    {
        //去抓水平控制器
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        //Rig預置物 AddForce 推力語法 Vector2 =方向  speed = 速度方向 
        Rig.AddForce(new Vector2(1, 0) * speed * 60, ForceMode2D.Impulse);
        if (speed < 0)
        {
            Sr.flipX = true;
        }
        else if (speed > 0)
        {
            Sr.flipX = false;
        }
        if (Input.GetKeyDown("w"))
        {
            print("w");
            Rig.AddForce(new Vector2(0, 1) * 1200);
        }

    }

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
