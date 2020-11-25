using System;

namespace UIFrame
{
    [Serializable]
    public class UIModulePathModel
    {
        public UIModuleMsg[] UIPanels;
    }

    [Serializable]
    public class UIModuleMsg
    {
        public string PanelName;
        public string PanelPath;
    }
}