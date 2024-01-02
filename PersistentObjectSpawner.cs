using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentObjectSpawner : MonoBehaviour
{
    //configure data

    [Tooltip("This prefab will only be spawed once and persisted between" + "scenes.")]
    [SerializeField] GameObject persistentObjectPrefab = null;

    //Private State

    static bool hasSpawned = false;

    //Private
    private void Awake()
    {
        if (hasSpawend) return;
        SpawnPersistentObject();
        hasSpawend = true;
    }

    private void SpawnPersistentObject()
    {
        GameObject persistentObject = Instantiate(persistentObjectPrefab);
        DontDestroyOnLoad(persistentObject);
    }
}
