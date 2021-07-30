// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    /// <summary>
    /// Dependency properties for the <see cref="ConstrainedBox"/> class.
    /// </summary>
    public partial class ConstrainedBox
    {
        /// <summary>
        /// Gets or sets the scale for the width of the panel. Should be a value between 0-1.0. Default is 1.0.
        /// </summary>
        public double ScaleX
        {
            get { return (double)GetValue(ScaleXProperty); }
            set { SetValue(ScaleXProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="ScaleX"/> property.
        /// </summary>
        public static readonly DependencyProperty ScaleXProperty =
            DependencyProperty.Register(nameof(ScaleX), typeof(double), typeof(ConstrainedBox), new PropertyMetadata(1.0, ConstraintPropertyChanged));

        /// <summary>
        /// Gets or sets the scale for the height of the panel. Should be a value between 0-1.0. Default is 1.0.
        /// </summary>
        public double ScaleY
        {
            get { return (double)GetValue(ScaleYProperty); }
            set { SetValue(ScaleYProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="ScaleY"/> property.
        /// </summary>
        public static readonly DependencyProperty ScaleYProperty =
            DependencyProperty.Register(nameof(ScaleY), typeof(double), typeof(ConstrainedBox), new PropertyMetadata(1.0, ConstraintPropertyChanged));

        /// <summary>
        /// Gets or sets the integer multiple that the width of the panel should be floored to. Default is null (no snap).
        /// </summary>
        public int MultipleX
        {
            get { return (int)GetValue(MultipleXProperty); }
            set { SetValue(MultipleXProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="MultipleX"/> property.
        /// </summary>
        public static readonly DependencyProperty MultipleXProperty =
            DependencyProperty.Register(nameof(MultipleX), typeof(int), typeof(ConstrainedBox), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the integer multiple that the height of the panel should be floored to. Default is null (no snap).
        /// </summary>
        public int MultipleY
        {
            get { return (int)GetValue(MultipleYProperty); }
            set { SetValue(MultipleYProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="MultipleY"/> property.
        /// </summary>
        public static readonly DependencyProperty MultipleYProperty =
            DependencyProperty.Register(nameof(MultipleY), typeof(int), typeof(ConstrainedBox), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets aspect Ratio to use for the contents of the Panel (after scaling).
        /// </summary>
        public AspectRatio AspectRatio
        {
            get { return (AspectRatio)GetValue(AspectRatioProperty); }
            set { SetValue(AspectRatioProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="AspectRatio"/> property.
        /// </summary>
        public static readonly DependencyProperty AspectRatioProperty =
            DependencyProperty.Register(nameof(AspectRatio), typeof(AspectRatio), typeof(ConstrainedBox), new PropertyMetadata(null, ConstraintPropertyChanged));

        private static void ConstraintPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ConstrainedBox panel)
            {
                panel.InvalidateMeasure();
            }
        }
    }
}
