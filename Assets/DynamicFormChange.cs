using UnityEngine;

public class DynamicFormChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    GameObject lightVersion;

    [SerializeField]
    GameObject darkVersion;

    private GameObject currVersion;
    void Start()
    {
        UpdateDynamicContent();
    }

    private void Update()
    {
        UpdateDynamicContent();
    }
    void UpdateDynamicContent()
    {
        int hour = System.DateTime.Now.Hour;

        // Jour : 6h à 18h
        bool isDay = hour >= 6 && hour < 18;

        if (currVersion != null)
            Destroy(currVersion);

        if (isDay)
        {
            currVersion = Instantiate(lightVersion, transform.position, transform.rotation, transform);
        }
        else
        {
            currVersion = Instantiate(darkVersion, transform.position, transform.rotation, transform);
        }
    }
}
