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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Actiontrail.Model.V20200706;

namespace Aliyun.Acs.Actiontrail.Transform.V20200706
{
    public class GetAccessKeyLastUsedIpsResponseUnmarshaller
    {
        public static GetAccessKeyLastUsedIpsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAccessKeyLastUsedIpsResponse getAccessKeyLastUsedIpsResponse = new GetAccessKeyLastUsedIpsResponse();

			getAccessKeyLastUsedIpsResponse.HttpResponse = _ctx.HttpResponse;
			getAccessKeyLastUsedIpsResponse.RequestId = _ctx.StringValue("GetAccessKeyLastUsedIps.RequestId");
			getAccessKeyLastUsedIpsResponse.NextToken = _ctx.StringValue("GetAccessKeyLastUsedIps.NextToken");

			List<GetAccessKeyLastUsedIpsResponse.GetAccessKeyLastUsedIps_IpsItem> getAccessKeyLastUsedIpsResponse_ips = new List<GetAccessKeyLastUsedIpsResponse.GetAccessKeyLastUsedIps_IpsItem>();
			for (int i = 0; i < _ctx.Length("GetAccessKeyLastUsedIps.Ips.Length"); i++) {
				GetAccessKeyLastUsedIpsResponse.GetAccessKeyLastUsedIps_IpsItem ipsItem = new GetAccessKeyLastUsedIpsResponse.GetAccessKeyLastUsedIps_IpsItem();
				ipsItem.UsedTimestamp = _ctx.LongValue("GetAccessKeyLastUsedIps.Ips["+ i +"].UsedTimestamp");
				ipsItem.Detail = _ctx.StringValue("GetAccessKeyLastUsedIps.Ips["+ i +"].Detail");
				ipsItem.Source = _ctx.StringValue("GetAccessKeyLastUsedIps.Ips["+ i +"].Source");
				ipsItem.Ip = _ctx.StringValue("GetAccessKeyLastUsedIps.Ips["+ i +"].Ip");

				getAccessKeyLastUsedIpsResponse_ips.Add(ipsItem);
			}
			getAccessKeyLastUsedIpsResponse.Ips = getAccessKeyLastUsedIpsResponse_ips;
        
			return getAccessKeyLastUsedIpsResponse;
        }
    }
}
