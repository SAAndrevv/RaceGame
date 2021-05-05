using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float speed = 3f;
    public Text scoreGT;
    private float scoref = 0;

    void Start(){
        GameObject scoreGO = GameObject.Find("Score");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    void Update() {

        float hor = Input.GetAxisRaw("Horizontal");
        Vector3 dir = new Vector3(hor, 0, 0);

        transform.Translate(dir.normalized * Time.deltaTime * speed);

        scoref += 1.0f / 100;
        int scorei = (int)scoref;
        
        scoreGT.text = scorei.ToString();

    }

    private void OnCollisionStay(Collision collision) {
        if(collision.gameObject.CompareTag("Car")) {
            Destroy(gameObject);
        }
    }

}
