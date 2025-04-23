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
    public class DescribeUsersRequest : RpcAcsRequest<DescribeUsersResponse>
    {
        public DescribeUsersRequest()
            : base("eds-user", "2021-03-08", "DescribeUsers", "eds-user", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? isQueryAllSubOrgs;

		private List<string> endUserIdss = new List<string>(){ };

		private List<string> excludeEndUserIdss = new List<string>(){ };

		private string nextToken;

		private string solutionId;

		private string filterWithAssignedResources;

		private string groupId;

		private string orgId;

		private string filterWithAssignedResource;

		private string filter;

		private string bizType;

		private long? maxResults;

		private string showExtras;

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
				DictionaryUtil.Add(BodyParameters, "IsQueryAllSubOrgs", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EndUserIds")]
		public List<string> EndUserIdss
		{
			get
			{
				return endUserIdss;
			}

			set
			{
				endUserIdss = value;
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

		[JsonProperty(PropertyName = "SolutionId")]
		public string SolutionId
		{
			get
			{
				return solutionId;
			}
			set	
			{
				solutionId = value;
				DictionaryUtil.Add(BodyParameters, "SolutionId", value);
			}
		}

		[JsonProperty(PropertyName = "FilterWithAssignedResources")]
		public string FilterWithAssignedResources
		{
			get
			{
				return filterWithAssignedResources;
			}
			set	
			{
				filterWithAssignedResources = value;
				DictionaryUtil.Add(BodyParameters, "FilterWithAssignedResources", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "GroupId")]
		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(BodyParameters, "GroupId", value);
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
				DictionaryUtil.Add(BodyParameters, "OrgId", value);
			}
		}

		[JsonProperty(PropertyName = "FilterWithAssignedResource")]
		public string FilterWithAssignedResource
		{
			get
			{
				return filterWithAssignedResource;
			}
			set	
			{
				filterWithAssignedResource = value;
				DictionaryUtil.Add(QueryParameters, "FilterWithAssignedResource", value.ToString());
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

		[JsonProperty(PropertyName = "BizType")]
		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(BodyParameters, "BizType", value);
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

		[JsonProperty(PropertyName = "ShowExtras")]
		public string ShowExtras
		{
			get
			{
				return showExtras;
			}
			set	
			{
				showExtras = value;
				DictionaryUtil.Add(BodyParameters, "ShowExtras", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeUsersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeUsersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
