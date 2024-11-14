using UnityEngine;
using System.Collections.Generic;

public class InfiniteFloor : MonoBehaviour
{
    public GameObject Floor; // �ٴ� Ÿ�� ������
    public int numTiles = 5; // �ʱ⿡ ������ Ÿ�� ����
    public float tileLength = 3f; // Ÿ���� ����
    private List<GameObject> activeTiles = new List<GameObject>();
    private float spawnZ = 0f; // ���� Ÿ�� ���� ��ġ
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
