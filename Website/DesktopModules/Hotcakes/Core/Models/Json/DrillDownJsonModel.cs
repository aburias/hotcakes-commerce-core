﻿#region License

// Distributed under the MIT License
// ============================================================
// Copyright (c) 2019 Hotcakes Commerce, LLC
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
// and associated documentation files (the "Software"), to deal in the Software without restriction, 
// including without limitation the rights to use, copy, modify, merge, publish, distribute, 
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or 
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
// THE SOFTWARE.

#endregion

using System;
using System.Collections.Generic;
using Hotcakes.Commerce.Catalog;
using Hotcakes.Commerce.Search;

namespace Hotcakes.Modules.Core.Models.Json
{
    [Serializable]
    public class DrillDownJsonModel
    {
        private List<SelectedFacetItem> _SelectedManufacturers;

        public DrillDownJsonModel()
        {
            PagerData = new PagerViewModel();
        }

        public CategorySortOrder SortOrder { get; set; }

        public PagerViewModel PagerData { get; set; }

        public List<CategoryMenuItemViewModel> SubCategories { get; set; }

        // TODO: PBI 33323 Depreciate and replace this with the correctly spelled variant
        public List<CheckboxFacetItem> Manufactures { get; set; }

        public List<CheckboxFacetItem> Vendors { get; set; }

        public List<CheckboxFacetItem> Types { get; set; }

        public List<PropertyFacetItem> Properties { get; set; }

        public List<SingleProductJsonModel> Products { get; set; }

        public int TotalCount { get; set; }

        public decimal MinPrice { get; set; }

        public decimal MaxPrice { get; set; }

        public decimal SelectedMinPrice { get; set; }

        public decimal SelectedMaxPrice { get; set; }

        [Obsolete("Use the SelectedManufacturers property instead. This will be depreciated in HCC 2.0.")]
        public List<SelectedFacetItem> SelectedManufactures
        {
            get { return _SelectedManufacturers; }
            set { _SelectedManufacturers = value; }
        }

        public List<SelectedFacetItem> SelectedManufacturers
        {
            get { return _SelectedManufacturers; }
            set { _SelectedManufacturers = value; }
        }

        public List<SelectedFacetItem> SelectedVendors { get; set; }

        public List<SelectedFacetItem> SelectedTypes { get; set; }

        public List<SelectedPropertyFacetItem> SelectedProperties { get; set; }
    }
}