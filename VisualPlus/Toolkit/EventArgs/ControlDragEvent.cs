﻿namespace VisualPlus.Toolkit.EventArgs
{
    #region Namespace

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    #endregion

    public class ControlDragEventArgs : EventArgs
    {
        #region Variables

        private Rectangle _dragRectangle;
        private Point _point;

        #endregion

        #region Constructors

        public ControlDragEventArgs(Point point)
        {
            _point = point;
            _dragRectangle = new Rectangle(_point, Size.Empty);
            _dragRectangle.Inflate(SystemInformation.DragSize);
        }

        #endregion

        #region Properties

        public Rectangle DragRectangle
        {
            get
            {
                return _dragRectangle;
            }

            set
            {
                _dragRectangle = value;
            }
        }

        public Point Point
        {
            get
            {
                return _point;
            }
        }

        #endregion
    }
}