// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Gallery;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Gallery
{
    public partial class GalleryItem
    {
        private IList<string> _categoryIds;
        
        /// <summary>
        /// Optional. Gets or sets gallery item category Ids.
        /// </summary>
        public IList<string> CategoryIds
        {
            get { return this._categoryIds; }
            set { this._categoryIds = value; }
        }
        
        private DefinitionTemplates _definitionTemplates;
        
        /// <summary>
        /// Optional. Gets or sets gallery item definition templates.
        /// </summary>
        public DefinitionTemplates DefinitionTemplates
        {
            get { return this._definitionTemplates; }
            set { this._definitionTemplates = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets gallery item description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _displayName;
        
        /// <summary>
        /// Optional. Gets or sets gallery item display name.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private IDictionary<string, string> _iconFileUrls;
        
        /// <summary>
        /// Optional. Gets or sets gallery item screenshot Urls
        /// </summary>
        public IDictionary<string, string> IconFileUrls
        {
            get { return this._iconFileUrls; }
            set { this._iconFileUrls = value; }
        }
        
        private string _identity;
        
        /// <summary>
        /// Optional. Gets or sets gallery item identity.
        /// </summary>
        public string Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets gallery item name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _publisher;
        
        /// <summary>
        /// Optional. Gets or sets gallery item publisher.
        /// </summary>
        public string Publisher
        {
            get { return this._publisher; }
            set { this._publisher = value; }
        }
        
        private string _publisherDisplayName;
        
        /// <summary>
        /// Optional. Gets or sets gallery item publisherdisplay name.
        /// </summary>
        public string PublisherDisplayName
        {
            get { return this._publisherDisplayName; }
            set { this._publisherDisplayName = value; }
        }
        
        private string _resourceGroupName;
        
        /// <summary>
        /// Optional. Gets or sets gallery item resource group name.
        /// </summary>
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }
        
        private IList<string> _screenshotUrls;
        
        /// <summary>
        /// Optional. Gets or sets gallery item screenshot Urls
        /// </summary>
        public IList<string> ScreenshotUrls
        {
            get { return this._screenshotUrls; }
            set { this._screenshotUrls = value; }
        }
        
        private string _summary;
        
        /// <summary>
        /// Optional. Gets or sets gallery item summary.
        /// </summary>
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }
        
        private string _version;
        
        /// <summary>
        /// Optional. Gets or sets gallery item version.
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GalleryItem class.
        /// </summary>
        public GalleryItem()
        {
            this.CategoryIds = new LazyList<string>();
            this.IconFileUrls = new LazyDictionary<string, string>();
            this.ScreenshotUrls = new LazyList<string>();
        }
    }
}
