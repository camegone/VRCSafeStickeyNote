// https://camegone-gc.booth.pm/items/6490046
// This Script is distributed under CC0 by camegone - 2023, free to redestribute. 自由に再配布できます。
// https://creativecommons.org/publicdomain/zero/1.0/

using UnityEngine;

namespace camegone.VRCSafeUtils {
    // Implement VRC.SDKBase.IEditorOnly to pass the component validation
    // cf. https://creators.vrchat.com/sdk/build-pipeline-callbacks-and-interfaces/#ieditoronly
    public class VRCSafeStickyNote : MonoBehaviour
    #if VRCSDK3
    , VRC.SDKBase.IEditorOnly
    #endif
    {
        // Text area to writedown something
        [TextArea][SerializeField] private string Note;
    }
}