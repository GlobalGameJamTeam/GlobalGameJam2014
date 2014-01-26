using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	public GameObject fade;
	public GUISkin skin;
	//private float gldepth = -0.5f;
	private float startTime = 8f;
	public Material mat;
	private float savedTimeScale;
	private bool showfps;
	private bool showtris;
	private bool showvtx;
	//private bool showfpsgraph;
	public Color lowFPSColor = Color.red;
	public Color highFPSColor = Color.green;
	public SpriteRenderer creditScreen;
	public SpriteRenderer controlScreen;
	public SpriteRenderer backgroundScreen;
	public int lowFPS = 30;
	public int highFPS = 50;
	public GameObject start;
	public string url = "unity.html";
	public Color statColor = Color.yellow;
	public Texture[] crediticons;
	
	public enum Page
	{
		None,
		Main,
	}
	
	private Page currentPage;
	
	void Start()
	{
		currentPage = Page.Main;	
	}
	
	static bool IsDashboard()
	{
		return Application.platform == RuntimePlatform.OSXDashboardPlayer;
	}
	
	static bool IsBrowser()
	{
		return (Application.platform == RuntimePlatform.WindowsWebPlayer ||
		        Application.platform == RuntimePlatform.OSXWebPlayer);
	}
	
	
	void OnGUI()
	{
		if (skin != null) {
			GUI.skin = skin;
		}
			switch (currentPage) {
			case Page.Main:
				MainPauseMenu();
				break;
			}   
	}
	
	IEnumerator Wait()
	{
		yield return new WaitForSeconds(35.0f);
		currentPage = Page.Main;
	}

	void BeginPage(int width, int height)
	{
		GUILayout.BeginArea(new Rect((Screen.width - width) / 2 - Screen.width / 18f, (Screen.height - height) - Screen.height / 6, width, height));
	}
	
	void EndPage()
	{
		GUILayout.EndArea();
	}
	
	void MainPauseMenu()
	{
		BeginPage(400, 300);
		if (GUILayout.Button("Start")) {
			Application.LoadLevel("Livello1");
		}
		EndPage();
	}
}

