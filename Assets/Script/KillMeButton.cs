using UnityEngine;
using System.Collections;

public class KillMeButton : MonoBehaviour {

	GestoreEnergia gestoreEnergia;
	void OnStart (){
		gestoreEnergia = GetComponent<GestoreEnergia>();
	}
	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(10,100,70,70), "");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,70,20), "Suicide")) {
			string scene = Application.loadedLevelName;
			Application.LoadLevel(scene);
		}
	}

	/*
	private GUIStyle currentStyle;
	void OnGUI () {
		InitStyles();
		GUI.Box (new Rect ((Screen.width-width)/2, 0, width, 40), energiaStr, currentStyle);
	}

	private void InitStyles()
	{
		if( currentStyle == null )
		{
			currentStyle = new GUIStyle( GUI.skin.box );
			currentStyle.normal.background = MakeTex( 2, 2, new Color( 0.8f, 0f, 0f, 0.2f ) );
		}
	}

	private Texture2D MakeTex( int width, int height, Color col )
	{
		Color[] pix = new Color[width * height];
		for( int i = 0; i < pix.Length; ++i )
			pix[ i ] = col;
		Texture2D result = new Texture2D( width, height );
		result.SetPixels( pix );
		result.Apply();
		return result;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.)
	}*/
}
