﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System.Windows;
using System.Windows.Controls;

using Microsoft.Templates.Core;
using Microsoft.Templates.UI.ViewModels.NewProject;

namespace Microsoft.Templates.UI.TemplateSelectors
{
    public class SummaryItemOptionsTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PageOptionsTemplate { get; set; }
        public DataTemplate FeatureOptionsTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var summaryItem = item as SavedTemplateViewModel;
            if (summaryItem != null)
            {
                if (summaryItem.TemplateType == TemplateType.Page)
                {
                    return PageOptionsTemplate;
                }
                else if (summaryItem.TemplateType == TemplateType.Feature)
                {
                    return FeatureOptionsTemplate;
                }
            }
            return base.SelectTemplate(item, container);
        }
    }
}
