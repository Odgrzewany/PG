using UnityEngine;

public class SkyboxInMenu : MonoBehaviour {

    public float rotateSpeed;
    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);       
    }
}
