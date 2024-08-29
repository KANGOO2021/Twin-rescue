using UnityEngine;

public class PersistentData : MonoBehaviour
{

    private void Awake()
    {
        GameObject[] persistedDataObjects = GameObject.FindGameObjectsWithTag("PersistentData");

        if(persistedDataObjects.Length > 1 )
        {

            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);  
    }

  
}
