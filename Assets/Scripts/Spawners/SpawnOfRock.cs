using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOfRock : MonoBehaviour
{
    public GameObject RockPref;
    public float MaxYPosRock, MinYPosRock;

    private float ToSpawnFish, TimerFish;

    private void Start()
    {
        ToSpawnFish = RandomTime();
    }

    private void Update()
    {
        if (TimerFish <= 0)
        {
            ToSpawnFish = RandomTime();
            TimerFish = ToSpawnFish;
            GameObject Rock = Instantiate(RockPref, transform.position, Quaternion.identity);
            float rand = Random.Range(MinYPosRock, MaxYPosRock);
            Rock.transform.position = new Vector3(transform.position.x, rand, 0);
        }
        else
        {
            TimerFish -= Time.deltaTime;
        }
    }
    private float RandomTime()
    {
        return Random.Range(8, 12);
    }
}
