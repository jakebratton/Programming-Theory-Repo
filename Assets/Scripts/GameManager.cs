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

    // Encapsulation
    private GameObject[] currentAnimals { get; } 

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

        Vector3 position;
        switch (platform)
        {
            case 0:
                position = new Vector3(firstX, yPos, zPos);
                break;
            case 1:
                position = new Vector3(secondX, yPos, zPos);
                break;
            default:
                position = new Vector3(thirdX, yPos, zPos);
                break;
        }

        // Spawn Random Animal at position
        int index = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[index], position, animalPrefabs[index].transform.rotation);
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
}
