﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using MW5.Plugins.Concrete;
using MW5.Plugins.Interfaces;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Tools.Toolbox
{
    /// <summary>
    /// A tool that can be added to the GIS toolbox.
    /// </summary>
    public class ToolNode : IGisTool
    {
        private readonly TreeNodeAdv _node;
        private readonly PluginIdentity _identity;
        private string _name;

        /// <summary>
        /// Creates a new instance of GIS tool class
        /// </summary>
        internal ToolNode(string name, string key, PluginIdentity identity)
        {
            if (identity == null) throw new ArgumentNullException("identity");

            _identity = identity;
            _name = name;
            _node = new TreeNodeAdv { Text = _name, LeftImageIndices = new int []{ToolboxControl.IconTool}, Tag = this };

            Key = key;
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        [DefaultValue("")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the tag associated with tool
        /// </summary>
        public object Tag { get; set; }

        /// <summary>
        /// Gets or sets the key of the tool
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the name of tool
        /// </summary>
        public string Name
        {
            get { return _name; }

            set 
            { 
                _name = value;
                if (_node != null)
                {
                    _node.Text = _name;
                }
            }
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public PluginIdentity PluginIdentity
        {
            get { return _identity; }
        }

        internal TreeNodeAdv Node
        {
            get { return _node; }
        }
    }
}
