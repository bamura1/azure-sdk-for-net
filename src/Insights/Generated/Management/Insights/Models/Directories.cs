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
using Microsoft.Azure.Management.Insights.Models;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// Represents an absolute directory path.
    /// </summary>
    public partial class Directories : BasicConfiguration
    {
        private IList<DirectoryConfiguration> _dataSources;
        
        /// <summary>
        /// Optional. A list of directories to monitor.
        /// </summary>
        public IList<DirectoryConfiguration> DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }
        
        private string _failedRequestLogs;
        
        /// <summary>
        /// Optional. Including this element in the configuration enables
        /// collection of logs about failed requests to an IIS site or
        /// application. You must also enable tracing options under
        /// system.WebServer in Web.config.
        /// </summary>
        public string FailedRequestLogs
        {
            get { return this._failedRequestLogs; }
            set { this._failedRequestLogs = value; }
        }
        
        private string _iISLogs;
        
        /// <summary>
        /// Optional. Including this element in the configuration enables the
        /// collection of IIS logs.
        /// </summary>
        public string IISLogs
        {
            get { return this._iISLogs; }
            set { this._iISLogs = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Directories class.
        /// </summary>
        public Directories()
        {
            this.DataSources = new LazyList<DirectoryConfiguration>();
        }
    }
}
