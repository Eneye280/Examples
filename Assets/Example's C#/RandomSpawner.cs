using UnityEngine;
using System.Collections;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float seconds;
    
    #region Corrutina
    IEnumerator Spawn(float min, float max)
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(seconds);
            var box = Instantiate<GameObject>(prefab);
        }
    }
    #endregion
    void Start()
    {
        StartCoroutine(Spawn(0,seconds));
    }
}