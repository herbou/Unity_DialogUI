using UnityEngine;
using EasyUI.Dialogs;

public class Demo : MonoBehaviour {

	void Start ( ) {

		// First Dialog -----------------------------
		DialogUI.Instance
		.SetTitle ( "Message 1" )
		.SetMessage ( "Hello!" )
		.SetButtonColor ( DialogButtonColor.Blue )
		.OnClose ( ( ) => Debug.Log ( "Closed 1" ) )
		.Show ( );


		// Second Dialog ----------------------------
		DialogUI.Instance
		.SetTitle ( "Message 2" )
		.SetMessage ( "Hello Again :)" )
		.SetButtonColor ( DialogButtonColor.Magenta )
		.SetButtonText ( "ok" )
		.OnClose ( ( ) => Debug.Log ( "Closed 2" ) )
		.Show ( );


		// Third Dialog -----------------------------
		DialogUI.Instance
		.SetTitle ( "Message 3" )
		.SetMessage ( "Bye!" )
		.SetFadeInDuration ( 1f )
		.SetButtonColor ( DialogButtonColor.Red )
		.OnClose ( ( ) => Debug.Log ( "Closed 3" ) )
		.Show ( );

	}

}
