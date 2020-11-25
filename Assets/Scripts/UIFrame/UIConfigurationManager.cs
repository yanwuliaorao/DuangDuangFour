using System.Collections.Generic;
using UnityEngine;
using Utilty;

namespace UIFrame
{
    public class UIConfigurationManager : Singleton<UIConfigurationManager> {

        private UIConfigurationManager()
        {
            panelsNamePath = new Dictionary<string, string>();
        }

        /// <summary>
        /// 所有模块的名字和路径
        /// </summary>
        private Dictionary<string, string> panelsNamePath;

        /// <summary>
        /// 加载模块的配置，将数据存储到字典
        /// </summary>
        private void LoadPanelConfig()
        {
            //通过配置文件路径，加载Resource中的配置文件(.json)
            string configJsonText = AssetsManager.GetInstance().
                GetAssets<TextAsset>(SystemDefine.UIPanelConfigPath).text;
            //Json解析
            var moduleConfig = JsonUtility.FromJson<UIModulePathModel>(configJsonText);
            //先清空字典
            panelsNamePath.Clear();
            //将解析后的对象，转换到字典
            for (int i = 0; i < moduleConfig.UIPanels.Length; i++)
            {
                //将名字作为Key，路径作为Value，添加到字典
                panelsNamePath.Add(moduleConfig.UIPanels[i].PanelName,
                    moduleConfig.UIPanels[i].PanelPath);
            }
        }

        /// <summary>
        /// 通过名称获取路径
        /// </summary>
        /// <param name="panelName"></param>
        /// <returns></returns>
        public string GetPanelPrefabPathByName(string panelName)
        {
            if (panelsNamePath.Count == 0)
            {
                //加载
                LoadPanelConfig();
            }

            if (panelsNamePath.ContainsKey(panelName))
            {
                //返回
                return panelsNamePath[panelName];
            }
            Debug.LogError("没有找到" + panelName + "对应的模块路径...");
            return null;
        }
    }
}