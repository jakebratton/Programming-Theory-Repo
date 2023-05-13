using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float firstX;
    [SerializeField] float secondX;
    [SerializeField] float thirdX;
    [SerializeField] float yPos;
    [SerializeField] float zPos;

    private GameObject[] currentAnimals = new GameObject[3];

    [SerializeField] GameObject[] animalPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        currentAnimals[0] = null;
        currentAnimals[1] = null;
        currentAnimals[2] = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnAnimal(int platform)
    {
        // Abstraction
        CheckForExisting(platform);

        // Abstraction
        Vector3 position = CreateRandomPosition(platform);

        // Turn 180 degrees
        Quaternion rotation = new Quaternion(0, 180, 0, 0);

        // Spawn Random Animal at position
        int index = Random.Range(0, animalPrefabs.Length);
        currentAnimals[platform] = Instantiate(animalPrefabs[index], position, rotation);
    }

    // Get rid of animal if there is already one on the given platform
    private void CheckForExisting(int index)
    {
        if (currentAnimals[index] != null)
        {
            Destroy(currentAnimals[index].gameObject);
        }
        else
        {
            Debug.Log("Empty Platform!");
        }
    }

    private Vector3 CreateRandomPosition(int platform)
    {
        switch (platform)
        {
            case 0:
                return new Vector3(firstX, yPos, zPos);
            case 1:
                return new Vector3(secondX, yPos, zPos);
            default:
                return new Vector3(thirdX, yPos, zPos);
        }
      
    }
}
