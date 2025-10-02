using UnityEngine;

public class EnableOVRPassthrough : MonoBehaviour
{
    void Awake()
    {
        // Find the Passthrough layer in the scene
        var layer = FindObjectOfType<OVRPassthroughLayer>();
        if (layer != null)
        {
            // Make sure it is visible and fully on
            layer.hidden = false;      // keep it showing
            layer.textureOpacity = 1f; // full opacity (some SDKs call this 'textureOpacity')
            // Placement must be set in the Inspector to Underlay
        }
    }
}
