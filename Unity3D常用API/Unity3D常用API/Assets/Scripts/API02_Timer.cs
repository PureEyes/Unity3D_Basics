using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API02_Timer : MonoBehaviour
{
    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Time.deltaTime." + Time.deltaTime);        //与游戏物体运动相关
        //Debug.Log("Time.fixedDeltaTime." + Time.fixedDeltaTime);
        //Debug.Log("Time.fixedTime." + Time.fixedTime);
        //Debug.Log("Time.fixedUnscaledDeltaTime." + Time.fixedUnscaledDeltaTime);
        //Debug.Log("Time.fixedUnscaledTime." + Time.fixedUnscaledTime);
        //Debug.Log("Time.frameCount." + Time.frameCount);
        //Debug.Log("Time.realtimeSinceStartup." + Time.realtimeSinceStartup);     //可以计算程序性能
        //Debug.Log("Time.smoothDeltaTime." + Time.smoothDeltaTime);
        //Debug.Log("Time.timeScale." + Time.timeScale);
        //Debug.Log("Time.timeSinceLevelLoad." + Time.timeSinceLevelLoad);
        //Debug.Log("Time.unscaledDeltaTime." + Time.unscaledDeltaTime);
        //Debug.Log("Time.unscaledTime." + Time.unscaledTime);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Time.deltaTime." + Time.deltaTime);
        //Debug.Log("Time.fixedDeltaTime." + Time.fixedDeltaTime);
        //Debug.Log("Time.fixedTime." + Time.fixedTime);
        //Debug.Log("Time.fixedUnscaledDeltaTime." + Time.fixedUnscaledDeltaTime);
        //Debug.Log("Time.fixedUnscaledTime." + Time.fixedUnscaledTime);
        //Debug.Log("Time.frameCount." + Time.frameCount);
        //Debug.Log("Time.realtimeSinceStartup." + Time.realtimeSinceStartup);
        //Debug.Log("Time.smoothDeltaTime." + Time.smoothDeltaTime);
        //Debug.Log("Time.timeScale." + Time.timeScale);
        //Debug.Log("Time.timeSinceLevelLoad." + Time.timeSinceLevelLoad);
        //Debug.Log("Time.unscaledDeltaTime." + Time.unscaledDeltaTime);
        //Debug.Log("Time.unscaledTime." + Time.unscaledTime);

        cube.Translate(Vector3.forward * Time.deltaTime);
        Time.timeScale = 0;       //控制deltaTime的大小
    }
}
