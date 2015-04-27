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
using Microsoft.Azure.Management.DataFactories.Models;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// The top level DataPipeline resource container.
    /// </summary>
    public partial class DataFactory
    {
        private string _id;
        
        /// <summary>
        /// Optional. Resource id of the data factory.  The Id property is set
        /// by the server and readonly on the client side.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Required. Data center location of the data factory.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Name of the data factory.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private DataFactoryProperties _properties;
        
        /// <summary>
        /// Optional. Properties of the data factory.
        /// </summary>
        public DataFactoryProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private IDictionary<string, string> _tags;
        
        /// <summary>
        /// Optional. Tags of the data factory.
        /// </summary>
        public IDictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataFactory class.
        /// </summary>
        public DataFactory()
        {
            this.Tags = new LazyDictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the DataFactory class with required
        /// arguments.
        /// </summary>
        public DataFactory(string name, string location)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Name = name;
            this.Location = location;
        }
    }
}
