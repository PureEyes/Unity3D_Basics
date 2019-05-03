using UnityEngine;

public class API01_EventFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnApplicationPause()
    {    
        Debug.Log("OnApplicationPause");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
}
