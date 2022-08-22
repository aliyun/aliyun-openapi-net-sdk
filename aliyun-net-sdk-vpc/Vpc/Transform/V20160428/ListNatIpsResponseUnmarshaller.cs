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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListNatIpsResponseUnmarshaller
    {
        public static ListNatIpsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNatIpsResponse listNatIpsResponse = new ListNatIpsResponse();

			listNatIpsResponse.HttpResponse = _ctx.HttpResponse;
			listNatIpsResponse.NextToken = _ctx.StringValue("ListNatIps.NextToken");
			listNatIpsResponse.RequestId = _ctx.StringValue("ListNatIps.RequestId");
			listNatIpsResponse.TotalCount = _ctx.StringValue("ListNatIps.TotalCount");
			listNatIpsResponse.MaxResults = _ctx.StringValue("ListNatIps.MaxResults");

			List<ListNatIpsResponse.ListNatIps_NatIp> listNatIpsResponse_natIps = new List<ListNatIpsResponse.ListNatIps_NatIp>();
			for (int i = 0; i < _ctx.Length("ListNatIps.NatIps.Length"); i++) {
				ListNatIpsResponse.ListNatIps_NatIp natIp = new ListNatIpsResponse.ListNatIps_NatIp();
				natIp.IsDefault = _ctx.BooleanValue("ListNatIps.NatIps["+ i +"].IsDefault");
				natIp.NatIp = _ctx.StringValue("ListNatIps.NatIps["+ i +"].NatIp");
				natIp.NatIpCidr = _ctx.StringValue("ListNatIps.NatIps["+ i +"].NatIpCidr");
				natIp.NatIpId = _ctx.StringValue("ListNatIps.NatIps["+ i +"].NatIpId");
				natIp.NatIpDescription = _ctx.StringValue("ListNatIps.NatIps["+ i +"].NatIpDescription");
				natIp.NatGatewayId = _ctx.StringValue("ListNatIps.NatIps["+ i +"].NatGatewayId");
				natIp.NatIpName = _ctx.StringValue("ListNatIps.NatIps["+ i +"].NatIpName");
				natIp.NatIpStatus = _ctx.StringValue("ListNatIps.NatIps["+ i +"].NatIpStatus");
				natIp.RegionId = _ctx.StringValue("ListNatIps.NatIps["+ i +"].RegionId");

				listNatIpsResponse_natIps.Add(natIp);
			}
			listNatIpsResponse.NatIps = listNatIpsResponse_natIps;
        
			return listNatIpsResponse;
        }
    }
}
