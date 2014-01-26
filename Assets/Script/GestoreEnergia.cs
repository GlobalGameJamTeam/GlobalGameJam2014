using UnityEngine;
using System.Collections;

public class GestoreEnergia : MonoBehaviour {
	private const float MAX_ENERGIA = 100;
	private float energia = MAX_ENERGIA;
	private string energiaStr = "Energia: ";
	private GUIStyle currentStyle;
	public bool cheat;


	public float getEnergia(){
		return energia;
	}

	public void setEnergia(float ene){
		energia = ene;
		if (energia > 100)
			energia = 100;
	}

	public bool subEnergia(float value){
		//Debug.Log ("Tolgo: "+value);
		bool outVal = true;
		if(energia>value){
			energia -= value;
		} else {
			energia = 0;
			return outVal;
		}
		return outVal;
	}

	void OnGUI () {
		//GUI.TextField(new Rect (25, 25, 100, 30), energiaStr);
		float width = Mathf.Clamp01 (energia / MAX_ENERGIA) * (Screen.width - 140);
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
			
		{
			
			pix[ i ] = col;
			
		}
		
		Texture2D result = new Texture2D( width, height );
		
		result.SetPixels( pix );
		
		result.Apply();
		
		return result;
		
	}

	// Use this for initialization
	void Start () {
		if (cheat)
						energia = 999999999;
	}
	
	// Update is called once per frame
	void Update () {

		energiaStr = "Energia: " + (int)energia;
		if (energia < 0.4f) { Application.LoadLevel("GameOver");} 
	}
}
