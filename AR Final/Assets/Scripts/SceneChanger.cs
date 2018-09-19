using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

	public static SceneChanger instance;
	// Use this for initialization

	void Start () {
		/*if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			Destroy(gameObject);
		}*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadScene(string scene)
	{
		SceneManager.LoadScene(scene);
	}	
	
}
