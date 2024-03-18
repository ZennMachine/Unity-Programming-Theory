using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;
    public GameManager gm;
    public Vector3 cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        player = gm.player;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}
