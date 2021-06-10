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
    public class GetDhcpOptionsSetResponseUnmarshaller
    {
        public static GetDhcpOptionsSetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDhcpOptionsSetResponse getDhcpOptionsSetResponse = new GetDhcpOptionsSetResponse();

			getDhcpOptionsSetResponse.HttpResponse = _ctx.HttpResponse;
			getDhcpOptionsSetResponse.RequestId = _ctx.StringValue("GetDhcpOptionsSet.RequestId");
			getDhcpOptionsSetResponse.DhcpOptionsSetName = _ctx.StringValue("GetDhcpOptionsSet.DhcpOptionsSetName");
			getDhcpOptionsSetResponse.DhcpOptionsSetDescription = _ctx.StringValue("GetDhcpOptionsSet.DhcpOptionsSetDescription");
			getDhcpOptionsSetResponse.DhcpOptionsSetId = _ctx.StringValue("GetDhcpOptionsSet.DhcpOptionsSetId");
			getDhcpOptionsSetResponse.OwnerId = _ctx.LongValue("GetDhcpOptionsSet.OwnerId");
			getDhcpOptionsSetResponse.Status = _ctx.StringValue("GetDhcpOptionsSet.Status");

			GetDhcpOptionsSetResponse.GetDhcpOptionsSet_DhcpOptions dhcpOptions = new GetDhcpOptionsSetResponse.GetDhcpOptionsSet_DhcpOptions();
			dhcpOptions.DomainNameServers = _ctx.StringValue("GetDhcpOptionsSet.DhcpOptions.DomainNameServers");
			dhcpOptions.DomainName = _ctx.StringValue("GetDhcpOptionsSet.DhcpOptions.DomainName");
			dhcpOptions.TFTPServerName = _ctx.StringValue("GetDhcpOptionsSet.DhcpOptions.TFTPServerName");
			dhcpOptions.BootFileName = _ctx.StringValue("GetDhcpOptionsSet.DhcpOptions.BootFileName");
			getDhcpOptionsSetResponse.DhcpOptions = dhcpOptions;

			List<GetDhcpOptionsSetResponse.GetDhcpOptionsSet_AssociateVpc> getDhcpOptionsSetResponse_associateVpcs = new List<GetDhcpOptionsSetResponse.GetDhcpOptionsSet_AssociateVpc>();
			for (int i = 0; i < _ctx.Length("GetDhcpOptionsSet.AssociateVpcs.Length"); i++) {
				GetDhcpOptionsSetResponse.GetDhcpOptionsSet_AssociateVpc associateVpc = new GetDhcpOptionsSetResponse.GetDhcpOptionsSet_AssociateVpc();
				associateVpc.VpcId = _ctx.StringValue("GetDhcpOptionsSet.AssociateVpcs["+ i +"].VpcId");
				associateVpc.AssociateStatus = _ctx.StringValue("GetDhcpOptionsSet.AssociateVpcs["+ i +"].AssociateStatus");

				getDhcpOptionsSetResponse_associateVpcs.Add(associateVpc);
			}
			getDhcpOptionsSetResponse.AssociateVpcs = getDhcpOptionsSetResponse_associateVpcs;
        
			return getDhcpOptionsSetResponse;
        }
    }
}
