using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] private AudioSource _objectAudio;
    private GameObject _currentObject;

    public void SpawnObject()
    {
        if (_currentObject == null)
        {
            _objectAudio.Play();
            _currentObject = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            _currentObject.transform.parent = this.transform; 
        }
    }

    public void DestroyObject()
    {
        if (_currentObject != null)
        {
            _objectAudio.Stop();
            Destroy(_currentObject);
            _currentObject = null;
        }
    }
}
