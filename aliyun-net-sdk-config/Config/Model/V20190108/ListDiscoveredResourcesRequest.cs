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
using Aliyun.Acs.Config;
using Aliyun.Acs.Config.Transform;
using Aliyun.Acs.Config.Transform.V20190108;

namespace Aliyun.Acs.Config.Model.V20190108
{
    public class ListDiscoveredResourcesRequest : RpcAcsRequest<ListDiscoveredResourcesResponse>
    {
        public ListDiscoveredResourcesRequest()
            : base("Config", "2019-01-08", "ListDiscoveredResources")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Config.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Config.Endpoint.endpointRegionalType, null);
            }
        }

		private int? resourceDeleted;

		private bool? multiAccount;

		private string regions;

		private int? pageNumber;

		private int? pageSize;

		private string complianceType;

		private string resourceId;

		private string resourceTypes;

		private long? memberId;

		public int? ResourceDeleted
		{
			get
			{
				return resourceDeleted;
			}
			set	
			{
				resourceDeleted = value;
				DictionaryUtil.Add(QueryParameters, "ResourceDeleted", value.ToString());
			}
		}

		public bool? MultiAccount
		{
			get
			{
				return multiAccount;
			}
			set	
			{
				multiAccount = value;
				DictionaryUtil.Add(QueryParameters, "MultiAccount", value.ToString());
			}
		}

		public string Regions
		{
			get
			{
				return regions;
			}
			set	
			{
				regions = value;
				DictionaryUtil.Add(QueryParameters, "Regions", value);
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

		public string ComplianceType
		{
			get
			{
				return complianceType;
			}
			set	
			{
				complianceType = value;
				DictionaryUtil.Add(QueryParameters, "ComplianceType", value);
			}
		}

		public string ResourceId
		{
			get
			{
				return resourceId;
			}
			set	
			{
				resourceId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId", value);
			}
		}

		public string ResourceTypes
		{
			get
			{
				return resourceTypes;
			}
			set	
			{
				resourceTypes = value;
				DictionaryUtil.Add(QueryParameters, "ResourceTypes", value);
			}
		}

		public long? MemberId
		{
			get
			{
				return memberId;
			}
			set	
			{
				memberId = value;
				DictionaryUtil.Add(QueryParameters, "MemberId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListDiscoveredResourcesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDiscoveredResourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
