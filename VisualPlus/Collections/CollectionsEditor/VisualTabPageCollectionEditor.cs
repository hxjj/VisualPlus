﻿#region Namespace

using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

using VisualPlus.Toolkit.Child;

#endregion

namespace VisualPlus.Collections.CollectionsEditor
{
    internal class VisualTabPageCollectionEditor : CollectionEditor
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="VisualTabPageCollectionEditor" /> class.</summary>
        /// <param name="type">The type.</param>
        public VisualTabPageCollectionEditor(Type type) : base(type)
        {
        }

        #endregion

        #region Overrides

        protected override Type CreateCollectionItemType()
        {
            return typeof(VisualTabPage);
        }

        protected override Type[] CreateNewItemTypes()
        {
            return new[] { typeof(TabPage), typeof(VisualTabPage) };
        }

        #endregion
    }
}