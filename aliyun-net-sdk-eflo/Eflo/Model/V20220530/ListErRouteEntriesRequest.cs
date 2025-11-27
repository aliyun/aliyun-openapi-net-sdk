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
using Aliyun.Acs.eflo.Transform;
using Aliyun.Acs.eflo.Transform.V20220530;

namespace Aliyun.Acs.eflo.Model.V20220530
{
    public class ListErRouteEntriesRequest : RpcAcsRequest<ListErRouteEntriesResponse>
    {
        public ListErRouteEntriesRequest()
            : base("eflo", "2022-05-30", "ListErRouteEntries", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private bool? ignoreDetailedRouteEntry;

		private int? pageNumber;

		private string routeType;

		private string resourceGroupId;

		private int? pageSize;

		private string nextHopId;

		private string nextHopType;

		private string destinationCidrBlock;

		private string erId;

		private string instanceId;

		private bool? enablePage;

		private string status;

		public bool? IgnoreDetailedRouteEntry
		{
			get
			{
				return ignoreDetailedRouteEntry;
			}
			set	
			{
				ignoreDetailedRouteEntry = value;
				DictionaryUtil.Add(BodyParameters, "IgnoreDetailedRouteEntry", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public string RouteType
		{
			get
			{
				return routeType;
			}
			set	
			{
				routeType = value;
				DictionaryUtil.Add(BodyParameters, "RouteType", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(BodyParameters, "ResourceGroupId", value);
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
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string NextHopId
		{
			get
			{
				return nextHopId;
			}
			set	
			{
				nextHopId = value;
				DictionaryUtil.Add(BodyParameters, "NextHopId", value);
			}
		}

		public string NextHopType
		{
			get
			{
				return nextHopType;
			}
			set	
			{
				nextHopType = value;
				DictionaryUtil.Add(BodyParameters, "NextHopType", value);
			}
		}

		public string DestinationCidrBlock
		{
			get
			{
				return destinationCidrBlock;
			}
			set	
			{
				destinationCidrBlock = value;
				DictionaryUtil.Add(BodyParameters, "DestinationCidrBlock", value);
			}
		}

		public string ErId
		{
			get
			{
				return erId;
			}
			set	
			{
				erId = value;
				DictionaryUtil.Add(BodyParameters, "ErId", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

		public bool? EnablePage
		{
			get
			{
				return enablePage;
			}
			set	
			{
				enablePage = value;
				DictionaryUtil.Add(BodyParameters, "EnablePage", value.ToString());
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListErRouteEntriesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListErRouteEntriesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
