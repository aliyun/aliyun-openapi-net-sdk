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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListConnectionsResponseUnmarshaller
    {
        public static ListConnectionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListConnectionsResponse listConnectionsResponse = new ListConnectionsResponse();

			listConnectionsResponse.HttpResponse = context.HttpResponse;
			listConnectionsResponse.HttpStatusCode = context.IntegerValue("ListConnections.HttpStatusCode");
			listConnectionsResponse.Success = context.BooleanValue("ListConnections.Success");
			listConnectionsResponse.RequestId = context.StringValue("ListConnections.RequestId");

			ListConnectionsResponse.ListConnections_Data data = new ListConnectionsResponse.ListConnections_Data();
			data.PageNumber = context.IntegerValue("ListConnections.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListConnections.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListConnections.Data.TotalCount");

			List<ListConnectionsResponse.ListConnections_Data.ListConnections_ConnectionsItem> data_connections = new List<ListConnectionsResponse.ListConnections_Data.ListConnections_ConnectionsItem>();
			for (int i = 0; i < context.Length("ListConnections.Data.Connections.Length"); i++) {
				ListConnectionsResponse.ListConnections_Data.ListConnections_ConnectionsItem connectionsItem = new ListConnectionsResponse.ListConnections_Data.ListConnections_ConnectionsItem();
				connectionsItem.Shared = context.BooleanValue("ListConnections.Data.Connections["+ i +"].Shared");
				connectionsItem.GmtModified = context.StringValue("ListConnections.Data.Connections["+ i +"].GmtModified");
				connectionsItem.ConnectStatus = context.IntegerValue("ListConnections.Data.Connections["+ i +"].ConnectStatus");
				connectionsItem.BindingCalcEngineId = context.IntegerValue("ListConnections.Data.Connections["+ i +"].BindingCalcEngineId");
				connectionsItem.Description = context.StringValue("ListConnections.Data.Connections["+ i +"].Description");
				connectionsItem.ConnectionType = context.StringValue("ListConnections.Data.Connections["+ i +"].ConnectionType");
				connectionsItem.GmtCreate = context.StringValue("ListConnections.Data.Connections["+ i +"].GmtCreate");
				connectionsItem.DefaultEngine = context.BooleanValue("ListConnections.Data.Connections["+ i +"].DefaultEngine");
				connectionsItem._Operator = context.StringValue("ListConnections.Data.Connections["+ i +"].Operator");
				connectionsItem.Sequence = context.IntegerValue("ListConnections.Data.Connections["+ i +"].Sequence");
				connectionsItem.EnvType = context.IntegerValue("ListConnections.Data.Connections["+ i +"].EnvType");
				connectionsItem.TenantId = context.LongValue("ListConnections.Data.Connections["+ i +"].TenantId");
				connectionsItem.Name = context.StringValue("ListConnections.Data.Connections["+ i +"].Name");
				connectionsItem.SubType = context.StringValue("ListConnections.Data.Connections["+ i +"].SubType");
				connectionsItem.Id = context.IntegerValue("ListConnections.Data.Connections["+ i +"].Id");
				connectionsItem.ProjectId = context.IntegerValue("ListConnections.Data.Connections["+ i +"].ProjectId");
				connectionsItem.Status = context.IntegerValue("ListConnections.Data.Connections["+ i +"].Status");
				connectionsItem.Content = context.StringValue("ListConnections.Data.Connections["+ i +"].Content");

				data_connections.Add(connectionsItem);
			}
			data.Connections = data_connections;
			listConnectionsResponse.Data = data;
        
			return listConnectionsResponse;
        }
    }
}
