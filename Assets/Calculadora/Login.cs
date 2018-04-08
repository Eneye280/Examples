using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class Login : MonoBehaviour 
{
	#region Variables
	[Header("Login")]
	[Space(5)]
	public int 				posicionX;				private Camera 		camaraMain;					
	public int 				posicionY;				private int 		numeImagenes;
	public int				largoBoton;				private int			numCaracterPosibleNombre = 20;
	public int				anchoBoton;				private int			numCaracterPosibleContraseña = 8;
	public Font[]			fuenteLetra1;			public string 		nombre = "";	
	public Texture[] 		imagenLogin;			public string		contraseña = "";
	public GameObject 		textoError;				private char		cubrirContraseña;							
	public bool 			cambioDeEscena;

	[Header("Cambiar El Mouse")]
	[Space(5)]
	public Texture2D 		textureMouse;
	private Vector2 		vectorDos = Vector2.zero;
	private CursorMode 		cursorMode = CursorMode.Auto;
	#endregion

	[MenuItem("ColorLogin/Color")]
	public static void ColorLogin()
	{
		GUI.contentColor = Color.green;
	}
	private void Start()
	{
		textoError.SetActive(false);
	}
	private void OnGUI()
	{	
		GUI.skin.font = fuenteLetra1[0];
		GUI.contentColor = Color.white;

		if(GUI.Button(new Rect(525,330,137,38), "Iniciar Juego"))
		{
/*Realizar un player pref para que el id de usuario quede en el sistema */
			if(nombre == "Euclides" && contraseña == "Martinez")
			{
				cambioDeEscena = true;
				SceneManager.LoadScene("SceneGames");
			}
			else if(nombre == "Maura" && contraseña == "Sofia")
			{
				cambioDeEscena = true;
				SceneManager.LoadScene("SceneGames");
				Resources.UnloadUnusedAssets();
			}
			else
			{
				textoError.SetActive(true);
			}
	}
		
		GUI.skin.font = fuenteLetra1[1];
		GUI.contentColor = Color.white;
		
		GUI.Label(new Rect(178,100,70,38),"Nombre");
		nombre = GUI.TextField(new Rect(253,100,200,38),nombre, numCaracterPosibleNombre);

		GUI.Label(new Rect(165,194,83,38),"Password");
		contraseña = GUI.PasswordField(new Rect(253,194,200,38),contraseña,cubrirContraseña,numCaracterPosibleContraseña);

		GUI.DrawTexture(new Rect(477,90,150,150),imagenLogin[numeImagenes]);
	}

	private void Update()
	{
		VerificarCambioEscena();
	}
	[SerializeField] private void VerificarCambioEscena()
	{
		if(cambioDeEscena)
		{
			Cursor.SetCursor(textureMouse,vectorDos,cursorMode);
		}
	}
	private void Awake()
	{
		cambioDeEscena = false;
		numeImagenes = Random.Range(0,3);
		cubrirContraseña = '*';
		camaraMain = GetComponent<Camera>();
		camaraMain.clearFlags = CameraClearFlags.SolidColor;
		camaraMain.backgroundColor = Color.black;
	}


}

