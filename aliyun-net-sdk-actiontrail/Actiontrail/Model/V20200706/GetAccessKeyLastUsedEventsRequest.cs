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
using Aliyun.Acs.Actiontrail;
using Aliyun.Acs.Actiontrail.Transform;
using Aliyun.Acs.Actiontrail.Transform.V20200706;

namespace Aliyun.Acs.Actiontrail.Model.V20200706
{
    public class GetAccessKeyLastUsedEventsRequest : RpcAcsRequest<GetAccessKeyLastUsedEventsResponse>
    {
        public GetAccessKeyLastUsedEventsRequest()
            : base("Actiontrail", "2020-07-06", "GetAccessKeyLastUsedEvents")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Actiontrail.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Actiontrail.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string accessKey;

		private string nextToken;

		private string pageSize;

		private string serviceName;

		public string AccessKey
		{
			get
			{
				return accessKey;
			}
			set	
			{
				accessKey = value;
				DictionaryUtil.Add(QueryParameters, "AccessKey", value);
			}
		}

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

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value);
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetAccessKeyLastUsedEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetAccessKeyLastUsedEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
