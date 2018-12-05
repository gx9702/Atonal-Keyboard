using UnityEngine;

public class NoteIndicatorGroup : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        for (var i = 0; i < 49; i++)
        {
            var go = Instantiate<GameObject>(prefab);
            go.transform.position = new Vector3((float)(i/3.5)-1, 3, 0);
            go.GetComponent<NoteIndicator>().noteNumber = i+36;
        }
    }
}
