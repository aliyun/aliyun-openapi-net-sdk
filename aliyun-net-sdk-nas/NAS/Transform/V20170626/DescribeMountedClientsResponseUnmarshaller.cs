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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeMountedClientsResponseUnmarshaller
    {
        public static DescribeMountedClientsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMountedClientsResponse describeMountedClientsResponse = new DescribeMountedClientsResponse();

			describeMountedClientsResponse.HttpResponse = _ctx.HttpResponse;
			describeMountedClientsResponse.RequestId = _ctx.StringValue("DescribeMountedClients.RequestId");
			describeMountedClientsResponse.TotalCount = _ctx.IntegerValue("DescribeMountedClients.TotalCount");
			describeMountedClientsResponse.PageSize = _ctx.IntegerValue("DescribeMountedClients.PageSize");
			describeMountedClientsResponse.PageNumber = _ctx.IntegerValue("DescribeMountedClients.PageNumber");

			List<DescribeMountedClientsResponse.DescribeMountedClients_Client> describeMountedClientsResponse_clients = new List<DescribeMountedClientsResponse.DescribeMountedClients_Client>();
			for (int i = 0; i < _ctx.Length("DescribeMountedClients.Clients.Length"); i++) {
				DescribeMountedClientsResponse.DescribeMountedClients_Client client = new DescribeMountedClientsResponse.DescribeMountedClients_Client();
				client.ClientIP = _ctx.StringValue("DescribeMountedClients.Clients["+ i +"].ClientIP");

				describeMountedClientsResponse_clients.Add(client);
			}
			describeMountedClientsResponse.Clients = describeMountedClientsResponse_clients;
        
			return describeMountedClientsResponse;
        }
    }
}
