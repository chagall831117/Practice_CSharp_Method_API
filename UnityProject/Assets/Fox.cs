using UnityEngine;

public class Fox : MonoBehaviour
{
    // Start is called before the first frame update
    //保存RB2D預置物
    public Rigidbody2D Rig;
    //保存圖片渲染器SR預置物
    public SpriteRenderer Sr;
    //推力
    private float thrust = 1f;

    /// <summary>
    /// 移動方法
    /// </summary>
    private void Move()
    {

    }

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //去抓水平控制器
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        //位置移動 原位置+=新位置
        transform.position = transform.position + new Vector3(speed * 250 * Time.deltaTime,0,0);

        //if (speed>0)
        //{ 
        //Rig.AddForce(transform.right * thrust, ForceMode2D.Impulse);
        //}
        //else if (speed < 0)
        //{
        //Rig.AddForce(transform.left * thrust, ForceMode2D.Impulse);
        //}
    }
}
