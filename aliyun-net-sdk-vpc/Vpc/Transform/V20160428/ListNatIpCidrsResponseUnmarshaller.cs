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
    public class ListNatIpCidrsResponseUnmarshaller
    {
        public static ListNatIpCidrsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNatIpCidrsResponse listNatIpCidrsResponse = new ListNatIpCidrsResponse();

			listNatIpCidrsResponse.HttpResponse = _ctx.HttpResponse;
			listNatIpCidrsResponse.NextToken = _ctx.StringValue("ListNatIpCidrs.NextToken");
			listNatIpCidrsResponse.RequestId = _ctx.StringValue("ListNatIpCidrs.RequestId");
			listNatIpCidrsResponse.TotalCount = _ctx.StringValue("ListNatIpCidrs.TotalCount");
			listNatIpCidrsResponse.MaxResults = _ctx.StringValue("ListNatIpCidrs.MaxResults");

			List<ListNatIpCidrsResponse.ListNatIpCidrs_NatIpCidr> listNatIpCidrsResponse_natIpCidrs = new List<ListNatIpCidrsResponse.ListNatIpCidrs_NatIpCidr>();
			for (int i = 0; i < _ctx.Length("ListNatIpCidrs.NatIpCidrs.Length"); i++) {
				ListNatIpCidrsResponse.ListNatIpCidrs_NatIpCidr natIpCidr = new ListNatIpCidrsResponse.ListNatIpCidrs_NatIpCidr();
				natIpCidr.CreationTime = _ctx.StringValue("ListNatIpCidrs.NatIpCidrs["+ i +"].CreationTime");
				natIpCidr.NatIpCidrId = _ctx.StringValue("ListNatIpCidrs.NatIpCidrs["+ i +"].NatIpCidrId");
				natIpCidr.IsDefault = _ctx.BooleanValue("ListNatIpCidrs.NatIpCidrs["+ i +"].IsDefault");
				natIpCidr.NatIpCidrStatus = _ctx.StringValue("ListNatIpCidrs.NatIpCidrs["+ i +"].NatIpCidrStatus");
				natIpCidr.NatIpCidrName = _ctx.StringValue("ListNatIpCidrs.NatIpCidrs["+ i +"].NatIpCidrName");
				natIpCidr.NatIpCidr = _ctx.StringValue("ListNatIpCidrs.NatIpCidrs["+ i +"].NatIpCidr");
				natIpCidr.NatGatewayId = _ctx.StringValue("ListNatIpCidrs.NatIpCidrs["+ i +"].NatGatewayId");
				natIpCidr.NatIpCidrDescription = _ctx.StringValue("ListNatIpCidrs.NatIpCidrs["+ i +"].NatIpCidrDescription");
				natIpCidr.RegionId = _ctx.StringValue("ListNatIpCidrs.NatIpCidrs["+ i +"].RegionId");

				listNatIpCidrsResponse_natIpCidrs.Add(natIpCidr);
			}
			listNatIpCidrsResponse.NatIpCidrs = listNatIpCidrsResponse_natIpCidrs;
        
			return listNatIpCidrsResponse;
        }
    }
}
