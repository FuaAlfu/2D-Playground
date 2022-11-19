using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// 2022.11.17
/// </summary>
public class TGamesSession : MonoBehaviour
{
    public static TGamesSession Instance { get; private set; }

    [SerializeField]
    int hits = 0;

    [SerializeField]
    TextMeshProUGUI text;

    [SerializeField]
    AudioClip blob;

    AudioSource audioSource;

     void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        text.text = "track: " + hits.ToString();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //HitCounter();
    }

   public void HitCounter(int hit)
    {
         hits += hit;
        text.text = "track: " + hits.ToString();
        text.text = "track: " + hits.ToString();
    }

    public void BlobSFX()
    {
        audioSource.PlayOneShot(blob);
    }
}
