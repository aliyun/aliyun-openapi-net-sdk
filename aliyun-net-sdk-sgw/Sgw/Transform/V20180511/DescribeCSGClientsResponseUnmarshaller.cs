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
    public class DescribeCSGClientsResponseUnmarshaller
    {
        public static DescribeCSGClientsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCSGClientsResponse describeCSGClientsResponse = new DescribeCSGClientsResponse();

			describeCSGClientsResponse.HttpResponse = _ctx.HttpResponse;
			describeCSGClientsResponse.RequestId = _ctx.StringValue("DescribeCSGClients.RequestId");
			describeCSGClientsResponse.Success = _ctx.BooleanValue("DescribeCSGClients.Success");
			describeCSGClientsResponse.Code = _ctx.StringValue("DescribeCSGClients.Code");
			describeCSGClientsResponse.Message = _ctx.StringValue("DescribeCSGClients.Message");
			describeCSGClientsResponse.PageSize = _ctx.IntegerValue("DescribeCSGClients.PageSize");
			describeCSGClientsResponse.PageNumber = _ctx.IntegerValue("DescribeCSGClients.PageNumber");
			describeCSGClientsResponse.TotalCount = _ctx.IntegerValue("DescribeCSGClients.TotalCount");

			List<DescribeCSGClientsResponse.DescribeCSGClients_Client> describeCSGClientsResponse_clients = new List<DescribeCSGClientsResponse.DescribeCSGClients_Client>();
			for (int i = 0; i < _ctx.Length("DescribeCSGClients.Clients.Length"); i++) {
				DescribeCSGClientsResponse.DescribeCSGClients_Client client = new DescribeCSGClientsResponse.DescribeCSGClients_Client();
				client.VpcId = _ctx.StringValue("DescribeCSGClients.Clients["+ i +"].VpcId");
				client.Status = _ctx.StringValue("DescribeCSGClients.Clients["+ i +"].Status");
				client.EcsInstanceId = _ctx.StringValue("DescribeCSGClients.Clients["+ i +"].EcsInstanceId");
				client.LastHeartbeatTime = _ctx.LongValue("DescribeCSGClients.Clients["+ i +"].LastHeartbeatTime");
				client.ClientId = _ctx.StringValue("DescribeCSGClients.Clients["+ i +"].ClientId");
				client.ClientVersion = _ctx.StringValue("DescribeCSGClients.Clients["+ i +"].ClientVersion");
				client.ClientInstallationCommand = _ctx.StringValue("DescribeCSGClients.Clients["+ i +"].ClientInstallationCommand");
				client.ClientDeletionCommand = _ctx.StringValue("DescribeCSGClients.Clients["+ i +"].ClientDeletionCommand");
				client.WorkDirectory = _ctx.StringValue("DescribeCSGClients.Clients["+ i +"].WorkDirectory");

				describeCSGClientsResponse_clients.Add(client);
			}
			describeCSGClientsResponse.Clients = describeCSGClientsResponse_clients;
        
			return describeCSGClientsResponse;
        }
    }
}
