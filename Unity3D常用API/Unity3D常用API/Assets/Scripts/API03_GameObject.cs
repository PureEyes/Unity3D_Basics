using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API03_GameObject : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        //创建一个空的游戏物体
        GameObject go = new GameObject("物体");
        //给游戏物体添加组件 可以是内置组件或者自定义脚本
        go.AddComponent<Rigidbody>();

        //实例化一个预制体或者另一个游戏物体
        Instantiate(cube);

        //创建一个原始的游戏物体
        GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
