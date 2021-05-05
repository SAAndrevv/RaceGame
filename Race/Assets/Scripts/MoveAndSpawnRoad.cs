using UnityEngine;
using UnityEditor;

public class MoveAndSpawnRoad : MonoBehaviour
{
    public float speed;
    public GameObject road;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);

        if (transform.position.y < -10f){
            //EditorApplication.isPaused = true;
            Instantiate(road, new Vector3(0f, 15.75f, 0f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
