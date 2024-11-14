using UnityEngine;
using System.Collections.Generic;

public class InfiniteFloor : MonoBehaviour
{
    public GameObject Floor; // 바닥 타일 프리팹
    public int numTiles = 5; // 초기에 생성할 타일 개수
    public float tileLength = 3f; // 타일의 길이
    private List<GameObject> activeTiles = new List<GameObject>();
    private float spawnZ = 0f; // 다음 타일 생성 위치
    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < numTiles; i++)
        {
            SpawnTile();
        }
    }

    void Update()
    {
        if (playerTransform.position.z > (spawnZ - numTiles * tileLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }

    private void SpawnTile()
    {
        GameObject go = Instantiate(Floor, Vector3.forward * spawnZ, Quaternion.identity);
        activeTiles.Add(go);
        spawnZ += tileLength;
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
