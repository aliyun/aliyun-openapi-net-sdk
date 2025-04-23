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
using Aliyun.Acs.eds_user.Transform;
using Aliyun.Acs.eds_user.Transform.V20210308;

namespace Aliyun.Acs.eds_user.Model.V20210308
{
    public class FilterUsersRequest : RpcAcsRequest<FilterUsersResponse>
    {
        public FilterUsersRequest()
            : base("eds-user", "2021-03-08", "FilterUsers", "eds-user", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? isQueryAllSubOrgs;

		private OrderParam orderParam_;

		private List<string> excludeEndUserIdss = new List<string>(){ };

		private string nextToken;

		private bool? includeDesktopCount;

		private bool? includeSupportIdps;

		private List<long?> propertyFilterParams = new List<long?>(){ };

		private bool? includeOrgInfo;

		private bool? includeDesktopGroupCount;

		private string orgId;

		private string filter;

		private List<string> propertyKeyValueFilterParams = new List<string>(){ };

		private string ownerType;

		private long? maxResults;

		private int? status;

		[JsonProperty(PropertyName = "IsQueryAllSubOrgs")]
		public bool? IsQueryAllSubOrgs
		{
			get
			{
				return isQueryAllSubOrgs;
			}
			set	
			{
				isQueryAllSubOrgs = value;
				DictionaryUtil.Add(QueryParameters, "IsQueryAllSubOrgs", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OrderParam")]
		public OrderParam OrderParam_
		{
			get
			{
				return orderParam_;
			}

			set
			{
				orderParam_ = value;
				DictionaryUtil.Add(QueryParameters, "OrderParam", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "ExcludeEndUserIds")]
		public List<string> ExcludeEndUserIdss
		{
			get
			{
				return excludeEndUserIdss;
			}

			set
			{
				excludeEndUserIdss = value;
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

		[JsonProperty(PropertyName = "IncludeDesktopCount")]
		public bool? IncludeDesktopCount
		{
			get
			{
				return includeDesktopCount;
			}
			set	
			{
				includeDesktopCount = value;
				DictionaryUtil.Add(QueryParameters, "IncludeDesktopCount", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "IncludeSupportIdps")]
		public bool? IncludeSupportIdps
		{
			get
			{
				return includeSupportIdps;
			}
			set	
			{
				includeSupportIdps = value;
				DictionaryUtil.Add(QueryParameters, "IncludeSupportIdps", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "PropertyFilterParam")]
		public List<long?> PropertyFilterParams
		{
			get
			{
				return propertyFilterParams;
			}

			set
			{
				propertyFilterParams = value;
				if(propertyFilterParams != null)
				{
					for (int depth1 = 0; depth1 < propertyFilterParams.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"PropertyFilterParam." + (depth1 + 1), propertyFilterParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"PropertyFilterParam." + (depth1 + 1), propertyFilterParams[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "IncludeOrgInfo")]
		public bool? IncludeOrgInfo
		{
			get
			{
				return includeOrgInfo;
			}
			set	
			{
				includeOrgInfo = value;
				DictionaryUtil.Add(QueryParameters, "IncludeOrgInfo", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "IncludeDesktopGroupCount")]
		public bool? IncludeDesktopGroupCount
		{
			get
			{
				return includeDesktopGroupCount;
			}
			set	
			{
				includeDesktopGroupCount = value;
				DictionaryUtil.Add(QueryParameters, "IncludeDesktopGroupCount", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OrgId")]
		public string OrgId
		{
			get
			{
				return orgId;
			}
			set	
			{
				orgId = value;
				DictionaryUtil.Add(QueryParameters, "OrgId", value);
			}
		}

		[JsonProperty(PropertyName = "Filter")]
		public string Filter
		{
			get
			{
				return filter;
			}
			set	
			{
				filter = value;
				DictionaryUtil.Add(QueryParameters, "Filter", value);
			}
		}

		[JsonProperty(PropertyName = "PropertyKeyValueFilterParam")]
		public List<string> PropertyKeyValueFilterParams
		{
			get
			{
				return propertyKeyValueFilterParams;
			}

			set
			{
				propertyKeyValueFilterParams = value;
				if(propertyKeyValueFilterParams != null)
				{
					for (int depth1 = 0; depth1 < propertyKeyValueFilterParams.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"PropertyKeyValueFilterParam." + (depth1 + 1), propertyKeyValueFilterParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"PropertyKeyValueFilterParam." + (depth1 + 1), propertyKeyValueFilterParams[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "OwnerType")]
		public string OwnerType
		{
			get
			{
				return ownerType;
			}
			set	
			{
				ownerType = value;
				DictionaryUtil.Add(QueryParameters, "OwnerType", value);
			}
		}

		[JsonProperty(PropertyName = "MaxResults")]
		public long? MaxResults
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

		[JsonProperty(PropertyName = "Status")]
		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

		public class OrderParam
		{

			private string orderField;

			private string orderType;

			[JsonProperty(PropertyName = "OrderField")]
			public string OrderField
			{
				get
				{
					return orderField;
				}
				set	
				{
					orderField = value;
				}
			}

			[JsonProperty(PropertyName = "OrderType")]
			public string OrderType
			{
				get
				{
					return orderType;
				}
				set	
				{
					orderType = value;
				}
			}
		}

		public class PropertyFilterParam
		{

			private long? propertyId;

			private string propertyValueIds;

			[JsonProperty(PropertyName = "PropertyId")]
			public long? PropertyId
			{
				get
				{
					return propertyId;
				}
				set	
				{
					propertyId = value;
				}
			}

			[JsonProperty(PropertyName = "PropertyValueIds")]
			public string PropertyValueIds
			{
				get
				{
					return propertyValueIds;
				}
				set	
				{
					propertyValueIds = value;
				}
			}
		}

		public class PropertyKeyValueFilterParam
		{

			private string propertyKey;

			private string propertyValues;

			[JsonProperty(PropertyName = "PropertyKey")]
			public string PropertyKey
			{
				get
				{
					return propertyKey;
				}
				set	
				{
					propertyKey = value;
				}
			}

			[JsonProperty(PropertyName = "PropertyValues")]
			public string PropertyValues
			{
				get
				{
					return propertyValues;
				}
				set	
				{
					propertyValues = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override FilterUsersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return FilterUsersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
