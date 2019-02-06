using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawned;

    public void SpawnClick() {
        Instantiate(spawned, spawnPos.position, spawnPos.rotation);
    }
}
