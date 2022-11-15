using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public static CheckpointController instance;
    public CheckpointSystem[] checkpoints;
    public Vector3 spawnPoint;

    private void Awake()
    {
        instance = this; 

    }
    // Start is called before the first frame update
    void Start()
    {
        checkpoints = FindObjectsOfType<CheckpointSystem>();

        spawnPoint = PlayerController.instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactiveCheckpoints()
    {
        for(int i = 0; i < checkpoints.Length; i++)
        {
            checkpoints[i].ResetCheckpoint();
        }
    }

    public void SetSpawnPoint(Vector3 newSpawnPoint)
    {
        spawnPoint = newSpawnPoint;
    }
}