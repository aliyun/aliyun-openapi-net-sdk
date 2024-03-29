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
    public class ListTemplatesRequest : RpcAcsRequest<ListTemplatesResponse>
    {
        public ListTemplatesRequest()
            : base("oos", "2019-06-01", "ListTemplates", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resourceGroupId;

		private string createdDateBefore;

		private string createdBy;

		private string nextToken;

		private string templateType;

		private string templateName;

		private string sortOrder;

		private string shareType;

		private bool? hasTrigger;

		private string createdDateAfter;

		private Dictionary<object,object> tags;

		private int? maxResults;

		private string templateFormat;

		private string sortField;

		private string category;

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

		[JsonProperty(PropertyName = "CreatedDateBefore")]
		public string CreatedDateBefore
		{
			get
			{
				return createdDateBefore;
			}
			set	
			{
				createdDateBefore = value;
				DictionaryUtil.Add(QueryParameters, "CreatedDateBefore", value);
			}
		}

		[JsonProperty(PropertyName = "CreatedBy")]
		public string CreatedBy
		{
			get
			{
				return createdBy;
			}
			set	
			{
				createdBy = value;
				DictionaryUtil.Add(QueryParameters, "CreatedBy", value);
			}
		}

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		[JsonProperty(PropertyName = "TemplateType")]
		public string TemplateType
		{
			get
			{
				return templateType;
			}
			set	
			{
				templateType = value;
				DictionaryUtil.Add(QueryParameters, "TemplateType", value);
			}
		}

		[JsonProperty(PropertyName = "TemplateName")]
		public string TemplateName
		{
			get
			{
				return templateName;
			}
			set	
			{
				templateName = value;
				DictionaryUtil.Add(QueryParameters, "TemplateName", value);
			}
		}

		[JsonProperty(PropertyName = "SortOrder")]
		public string SortOrder
		{
			get
			{
				return sortOrder;
			}
			set	
			{
				sortOrder = value;
				DictionaryUtil.Add(QueryParameters, "SortOrder", value);
			}
		}

		[JsonProperty(PropertyName = "ShareType")]
		public string ShareType
		{
			get
			{
				return shareType;
			}
			set	
			{
				shareType = value;
				DictionaryUtil.Add(QueryParameters, "ShareType", value);
			}
		}

		[JsonProperty(PropertyName = "HasTrigger")]
		public bool? HasTrigger
		{
			get
			{
				return hasTrigger;
			}
			set	
			{
				hasTrigger = value;
				DictionaryUtil.Add(QueryParameters, "HasTrigger", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "CreatedDateAfter")]
		public string CreatedDateAfter
		{
			get
			{
				return createdDateAfter;
			}
			set	
			{
				createdDateAfter = value;
				DictionaryUtil.Add(QueryParameters, "CreatedDateAfter", value);
			}
		}

		[JsonProperty(PropertyName = "Tags")]
		public Dictionary<object,object> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", JsonConvert.SerializeObject(value));
			}
		}

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TemplateFormat")]
		public string TemplateFormat
		{
			get
			{
				return templateFormat;
			}
			set	
			{
				templateFormat = value;
				DictionaryUtil.Add(QueryParameters, "TemplateFormat", value);
			}
		}

		[JsonProperty(PropertyName = "SortField")]
		public string SortField
		{
			get
			{
				return sortField;
			}
			set	
			{
				sortField = value;
				DictionaryUtil.Add(QueryParameters, "SortField", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListTemplatesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListTemplatesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
