using UnityEngine;

public class Ingredient : MonoBehaviour
{
    [SerializeField] private float _dailyValuePercent;
    [SerializeField] private float _growSpeed;
    [SerializeField] private GameObject _text;
    
    private bool _startGrow;
    private Vector3 _initialScale;
    private float _growProgress;

    private void OnEnable() 
    {
        _initialScale = new Vector3(transform.localScale.x, 0.0f, transform.localScale.z);
        _text.SetActive(false);
        StartGrowing();
    }

    private void Update() 
    {
        if (_startGrow) 
        {
           
            _growProgress += _growSpeed * Time.deltaTime;
            float newYScale = Mathf.Lerp(_initialScale.y, _dailyValuePercent, _growProgress);
            transform.localScale = new Vector3(_initialScale.x, newYScale, _initialScale.z);

            if (transform.localScale.y >= _dailyValuePercent) 
            {
                _startGrow = false;
                transform.localScale = new Vector3(_initialScale.x, _dailyValuePercent, _initialScale.z);
                _growProgress = _dailyValuePercent;
                _text.SetActive(true);
            }
        }
    }

    public void StartGrowing() 
    {
        _startGrow = true;
        _growProgress = 0f;
    }
}
