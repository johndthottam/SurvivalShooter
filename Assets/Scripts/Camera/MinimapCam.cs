using UnityEngine;
public class MinimapCam : MonoBehaviour
{
	public Transform Player;
	public Vector3 Offset;

	void LateUpdate ()
	{
		if (Player != null)
			transform.position = Player.position + Offset;
	}
}