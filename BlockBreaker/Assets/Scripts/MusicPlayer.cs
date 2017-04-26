using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;

    // Use this for initialization

    private void Awake() {
        if (instance != null) {
            Destroy(gameObject);
            Debug.Log("Duplicate Music Player Destroyed");
        }
        else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    void Start() {

    }
	// Update is called once per frame
	void Update () {
	
	}
}
