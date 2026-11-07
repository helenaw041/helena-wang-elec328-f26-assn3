using UnityEngine;

public class CheckResolution : MonoBehaviour
{
    void Start()
    {
        Debug.Log($"Game view resolution: {Screen.width} x {Screen.height}");
    }
}