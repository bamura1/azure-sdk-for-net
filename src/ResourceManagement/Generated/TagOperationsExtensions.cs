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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.Resources
{
    public static partial class TagOperationsExtensions
    {
        /// <summary>
        /// Create a subscription resource tag.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <param name='tagName'>
        /// Required. The name of the tag.
        /// </param>
        /// <returns>
        /// Tag information.
        /// </returns>
        public static TagCreateResult CreateOrUpdate(this ITagOperations operations, string tagName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITagOperations)s).CreateOrUpdateAsync(tagName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a subscription resource tag.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <param name='tagName'>
        /// Required. The name of the tag.
        /// </param>
        /// <returns>
        /// Tag information.
        /// </returns>
        public static Task<TagCreateResult> CreateOrUpdateAsync(this ITagOperations operations, string tagName)
        {
            return operations.CreateOrUpdateAsync(tagName, CancellationToken.None);
        }
        
        /// <summary>
        /// Create a subscription resource tag value.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <param name='tagName'>
        /// Required. The name of the tag.
        /// </param>
        /// <param name='tagValue'>
        /// Required. The value of the tag.
        /// </param>
        /// <returns>
        /// Tag information.
        /// </returns>
        public static TagCreateValueResult CreateOrUpdateValue(this ITagOperations operations, string tagName, string tagValue)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITagOperations)s).CreateOrUpdateValueAsync(tagName, tagValue);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a subscription resource tag value.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <param name='tagName'>
        /// Required. The name of the tag.
        /// </param>
        /// <param name='tagValue'>
        /// Required. The value of the tag.
        /// </param>
        /// <returns>
        /// Tag information.
        /// </returns>
        public static Task<TagCreateValueResult> CreateOrUpdateValueAsync(this ITagOperations operations, string tagName, string tagValue)
        {
            return operations.CreateOrUpdateValueAsync(tagName, tagValue, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete a subscription resource tag.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <param name='tagName'>
        /// Required. The name of the tag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this ITagOperations operations, string tagName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITagOperations)s).DeleteAsync(tagName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete a subscription resource tag.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <param name='tagName'>
        /// Required. The name of the tag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this ITagOperations operations, string tagName)
        {
            return operations.DeleteAsync(tagName, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete a subscription resource tag value.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <param name='tagName'>
        /// Required. The name of the tag.
        /// </param>
        /// <param name='tagValue'>
        /// Required. The value of the tag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse DeleteValue(this ITagOperations operations, string tagName, string tagValue)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITagOperations)s).DeleteValueAsync(tagName, tagValue);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete a subscription resource tag value.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <param name='tagName'>
        /// Required. The name of the tag.
        /// </param>
        /// <param name='tagValue'>
        /// Required. The value of the tag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteValueAsync(this ITagOperations operations, string tagName, string tagValue)
        {
            return operations.DeleteValueAsync(tagName, tagValue, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a list of subscription resource tags.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <returns>
        /// List of subscription tags.
        /// </returns>
        public static TagsListResult List(this ITagOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITagOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a list of subscription resource tags.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <returns>
        /// List of subscription tags.
        /// </returns>
        public static Task<TagsListResult> ListAsync(this ITagOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Get a list of tags under a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of subscription tags.
        /// </returns>
        public static TagsListResult ListNext(this ITagOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITagOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a list of tags under a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.ITagOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of subscription tags.
        /// </returns>
        public static Task<TagsListResult> ListNextAsync(this ITagOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}
