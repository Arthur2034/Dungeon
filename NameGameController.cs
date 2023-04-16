using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NameGameController : MonoBehaviour
{
    public GameObject _Arthur_Project;
    public GameObject _Dungeon;

    private void Start()
    {
        StartCoroutine(StartEffect());
    }
    
    void FixedUpdate()
    {
        
        
        if (Input.GetKeyDown(KeyCode.C))
        {

            
        }
    }
    IEnumerator StartEffect()
    {
        yield return new WaitForSeconds(4);
        _Arthur_Project.GetComponent<ParticleSystem>().Stop();
        StartCoroutine(StartEffect_2());
    }
    IEnumerator StartEffect_2()
    {
        yield return new WaitForSeconds(1);
        _Dungeon.SetActive(true);
        StartCoroutine(LastEffect());
    }
    IEnumerator LastEffect()
    {
        yield return new WaitForSeconds(3);
        _Dungeon.GetComponent<ParticleSystem>().Stop();
        StartCoroutine(StartGames());
    }
    IEnumerator StartGames()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(1);
    }

}
