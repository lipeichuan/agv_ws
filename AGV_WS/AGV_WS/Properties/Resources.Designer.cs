﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AGV_WS.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AGV_WS.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 AGV ID 的本地化字符串。
        /// </summary>
        public static string IDS_AGV_ID {
            get {
                return ResourceManager.GetString("IDS_AGV_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 当前位置 的本地化字符串。
        /// </summary>
        public static string IDS_AGV_POSITION {
            get {
                return ResourceManager.GetString("IDS_AGV_POSITION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 电量 的本地化字符串。
        /// </summary>
        public static string IDS_AGV_POWER {
            get {
                return ResourceManager.GetString("IDS_AGV_POWER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 启动 的本地化字符串。
        /// </summary>
        public static string IDS_AGV_START {
            get {
                return ResourceManager.GetString("IDS_AGV_START", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 当前状态 的本地化字符串。
        /// </summary>
        public static string IDS_AGV_STATUS {
            get {
                return ResourceManager.GetString("IDS_AGV_STATUS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 停止 的本地化字符串。
        /// </summary>
        public static string IDS_AGV_STOP {
            get {
                return ResourceManager.GetString("IDS_AGV_STOP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 AGV工作站 的本地化字符串。
        /// </summary>
        public static string IDS_MAIN_TITLE {
            get {
                return ResourceManager.GetString("IDS_MAIN_TITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 地图编辑 的本地化字符串。
        /// </summary>
        public static string IDS_MAP_EDIT {
            get {
                return ResourceManager.GetString("IDS_MAP_EDIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 路径规划 的本地化字符串。
        /// </summary>
        public static string IDS_PATH_EDIT {
            get {
                return ResourceManager.GetString("IDS_PATH_EDIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 历史回放 的本地化字符串。
        /// </summary>
        public static string IDS_PLAYBACK {
            get {
                return ResourceManager.GetString("IDS_PLAYBACK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 START 的本地化字符串。
        /// </summary>
        public static string IDS_TOOLBAR_START {
            get {
                return ResourceManager.GetString("IDS_TOOLBAR_START", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 STOP 的本地化字符串。
        /// </summary>
        public static string IDS_TOOLBAR_STOP {
            get {
                return ResourceManager.GetString("IDS_TOOLBAR_STOP", resourceCulture);
            }
        }
    }
}
