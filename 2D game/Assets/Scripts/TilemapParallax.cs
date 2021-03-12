using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilePar : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 0.3f;
    [SerializeField] GameObject viewTarget; //cam

    Tilemap tileMap;

    // Start is called before the first frame update
    void Start()
    {
        tileMap = GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        float newXPos = viewTarget.transform.position.x * scrollSpeed;
        float newYPos = viewTarget.transform.position.y * scrollSpeed;

        tileMap.transform.position = new Vector3(newXPos, newYPos, tileMap.transform.position.z);
    }
}
