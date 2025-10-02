using UnityEngine;

public class ForcePassthroughOn : MonoBehaviour
{
    void Awake()
    {
        var layer = FindObjectOfType<OVRPassthroughLayer>();
        if (layer != null)
        {
            layer.hidden = false;     // ensure it’s visible
            layer.textureOpacity = 1; // fully visible passthrough
        }
    }
}
