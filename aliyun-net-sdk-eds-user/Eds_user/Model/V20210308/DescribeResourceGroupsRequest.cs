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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.eds_user.Transform;
using Aliyun.Acs.eds_user.Transform.V20210308;

namespace Aliyun.Acs.eds_user.Model.V20210308
{
    public class DescribeResourceGroupsRequest : RpcAcsRequest<DescribeResourceGroupsResponse>
    {
        public DescribeResourceGroupsRequest()
            : base("eds-user", "2021-03-08", "DescribeResourceGroups", "eds-user", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resourceGroupName;

		private long? needContainResourceGroupWithOfficeSite;

		private int? pageNumber;

		private string platform;

		private List<string> resourceGroupIds = new List<string>(){ };

		private int? pageSize;

		public string ResourceGroupName
		{
			get
			{
				return resourceGroupName;
			}
			set	
			{
				resourceGroupName = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupName", value);
			}
		}

		public long? NeedContainResourceGroupWithOfficeSite
		{
			get
			{
				return needContainResourceGroupWithOfficeSite;
			}
			set	
			{
				needContainResourceGroupWithOfficeSite = value;
				DictionaryUtil.Add(QueryParameters, "NeedContainResourceGroupWithOfficeSite", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(QueryParameters, "Platform", value);
			}
		}

		public List<string> ResourceGroupIds
		{
			get
			{
				return resourceGroupIds;
			}

			set
			{
				resourceGroupIds = value;
				if(resourceGroupIds != null)
				{
					for (int depth1 = 0; depth1 < resourceGroupIds.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"ResourceGroupIds." + (depth1 + 1), resourceGroupIds[depth1]);
					}
				}
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeResourceGroupsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeResourceGroupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
