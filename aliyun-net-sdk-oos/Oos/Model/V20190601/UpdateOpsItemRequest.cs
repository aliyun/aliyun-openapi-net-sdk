/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.oos.Transform;
using Aliyun.Acs.oos.Transform.V20190601;

namespace Aliyun.Acs.oos.Model.V20190601
{
    public class UpdateOpsItemRequest : RpcAcsRequest<UpdateOpsItemResponse>
    {
        public UpdateOpsItemRequest()
            : base("oos", "2019-06-01", "UpdateOpsItem", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string description;

		private string source;

		private string title;

		private string resourceGroupId;

		private string severity;

		private string solutions;

		private string resources;

		private int? priority;

		private string dedupString;

		private string tags;

		private string opsItemId;

		private string category;

		private string status;

		[JsonProperty(PropertyName = "ClientToken")]
		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "Source")]
		public string Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
				DictionaryUtil.Add(QueryParameters, "Source", value);
			}
		}

		[JsonProperty(PropertyName = "Title")]
		public string Title
		{
			get
			{
				return title;
			}
			set	
			{
				title = value;
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceGroupId")]
		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "Severity")]
		public string Severity
		{
			get
			{
				return severity;
			}
			set	
			{
				severity = value;
				DictionaryUtil.Add(QueryParameters, "Severity", value);
			}
		}

		[JsonProperty(PropertyName = "Solutions")]
		public string Solutions
		{
			get
			{
				return solutions;
			}
			set	
			{
				solutions = value;
				DictionaryUtil.Add(QueryParameters, "Solutions", value);
			}
		}

		[JsonProperty(PropertyName = "Resources")]
		public string Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
				DictionaryUtil.Add(QueryParameters, "Resources", value);
			}
		}

		[JsonProperty(PropertyName = "Priority")]
		public int? Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(QueryParameters, "Priority", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DedupString")]
		public string DedupString
		{
			get
			{
				return dedupString;
			}
			set	
			{
				dedupString = value;
				DictionaryUtil.Add(QueryParameters, "DedupString", value);
			}
		}

		[JsonProperty(PropertyName = "Tags")]
		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

		[JsonProperty(PropertyName = "OpsItemId")]
		public string OpsItemId
		{
			get
			{
				return opsItemId;
			}
			set	
			{
				opsItemId = value;
				DictionaryUtil.Add(QueryParameters, "OpsItemId", value);
			}
		}

		[JsonProperty(PropertyName = "Category")]
		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(QueryParameters, "Category", value);
			}
		}

		[JsonProperty(PropertyName = "Status")]
		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateOpsItemResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateOpsItemResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
