using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class MainManager : MonoBehaviour
{
    // For data persistence:
    public static MainManager Instance;

    public TextMeshProUGUI nameText;

    private string currentName { get; set; }

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SaveName()
    {
        currentName = nameText.text;
    }
}
