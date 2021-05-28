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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeGatewayNFSClientsResponseUnmarshaller
    {
        public static DescribeGatewayNFSClientsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayNFSClientsResponse describeGatewayNFSClientsResponse = new DescribeGatewayNFSClientsResponse();

			describeGatewayNFSClientsResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayNFSClientsResponse.RequestId = _ctx.StringValue("DescribeGatewayNFSClients.RequestId");
			describeGatewayNFSClientsResponse.Success = _ctx.BooleanValue("DescribeGatewayNFSClients.Success");
			describeGatewayNFSClientsResponse.Code = _ctx.StringValue("DescribeGatewayNFSClients.Code");
			describeGatewayNFSClientsResponse.Message = _ctx.StringValue("DescribeGatewayNFSClients.Message");
			describeGatewayNFSClientsResponse.TotalCount = _ctx.IntegerValue("DescribeGatewayNFSClients.TotalCount");
			describeGatewayNFSClientsResponse.PageNumber = _ctx.IntegerValue("DescribeGatewayNFSClients.PageNumber");
			describeGatewayNFSClientsResponse.PageSize = _ctx.IntegerValue("DescribeGatewayNFSClients.PageSize");
			describeGatewayNFSClientsResponse.Version3Enabled = _ctx.BooleanValue("DescribeGatewayNFSClients.Version3Enabled");
			describeGatewayNFSClientsResponse.Version40Enabled = _ctx.BooleanValue("DescribeGatewayNFSClients.Version40Enabled");
			describeGatewayNFSClientsResponse.Version41Enabled = _ctx.BooleanValue("DescribeGatewayNFSClients.Version41Enabled");

			List<DescribeGatewayNFSClientsResponse.DescribeGatewayNFSClients_ClientInfo> describeGatewayNFSClientsResponse_clientInfoList = new List<DescribeGatewayNFSClientsResponse.DescribeGatewayNFSClients_ClientInfo>();
			for (int i = 0; i < _ctx.Length("DescribeGatewayNFSClients.ClientInfoList.Length"); i++) {
				DescribeGatewayNFSClientsResponse.DescribeGatewayNFSClients_ClientInfo clientInfo = new DescribeGatewayNFSClientsResponse.DescribeGatewayNFSClients_ClientInfo();
				clientInfo.ClientIpAddr = _ctx.StringValue("DescribeGatewayNFSClients.ClientInfoList["+ i +"].ClientIpAddr");
				clientInfo.HasNFSv3 = _ctx.BooleanValue("DescribeGatewayNFSClients.ClientInfoList["+ i +"].HasNFSv3");
				clientInfo.HasNFSv40 = _ctx.BooleanValue("DescribeGatewayNFSClients.ClientInfoList["+ i +"].HasNFSv40");
				clientInfo.HasNFSv41 = _ctx.BooleanValue("DescribeGatewayNFSClients.ClientInfoList["+ i +"].HasNFSv41");

				describeGatewayNFSClientsResponse_clientInfoList.Add(clientInfo);
			}
			describeGatewayNFSClientsResponse.ClientInfoList = describeGatewayNFSClientsResponse_clientInfoList;
        
			return describeGatewayNFSClientsResponse;
        }
    }
}
