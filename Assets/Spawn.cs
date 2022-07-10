using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public Text text;
    int score = 0;
    public GameObject pipePrefab;
    float randomHeight;

    void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    void Update()
    {
        randomHeight = Random.Range(-2.5f, 3);
    }

    private IEnumerator SpawnPipe ()
    {
        Instantiate(pipePrefab, new Vector3(15, randomHeight, 0), Quaternion.identity);
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(SpawnPipe());
        score++;
        text.text = score.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
