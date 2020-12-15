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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class GetDBInstanceTopologyResponseUnmarshaller
    {
        public static GetDBInstanceTopologyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDBInstanceTopologyResponse getDBInstanceTopologyResponse = new GetDBInstanceTopologyResponse();

			getDBInstanceTopologyResponse.HttpResponse = _ctx.HttpResponse;
			getDBInstanceTopologyResponse.RequestId = _ctx.StringValue("GetDBInstanceTopology.RequestId");
			getDBInstanceTopologyResponse.Code = _ctx.StringValue("GetDBInstanceTopology.Code");
			getDBInstanceTopologyResponse.Message = _ctx.StringValue("GetDBInstanceTopology.Message");

			GetDBInstanceTopologyResponse.GetDBInstanceTopology_Data data = new GetDBInstanceTopologyResponse.GetDBInstanceTopology_Data();
			data.DBInstanceName = _ctx.StringValue("GetDBInstanceTopology.Data.DBInstanceName");

			List<GetDBInstanceTopologyResponse.GetDBInstanceTopology_Data.GetDBInstanceTopology_Connection> data_connections = new List<GetDBInstanceTopologyResponse.GetDBInstanceTopology_Data.GetDBInstanceTopology_Connection>();
			for (int i = 0; i < _ctx.Length("GetDBInstanceTopology.Data.Connections.Length"); i++) {
				GetDBInstanceTopologyResponse.GetDBInstanceTopology_Data.GetDBInstanceTopology_Connection connection = new GetDBInstanceTopologyResponse.GetDBInstanceTopology_Data.GetDBInstanceTopology_Connection();
				connection.NetType = _ctx.StringValue("GetDBInstanceTopology.Data.Connections["+ i +"].NetType");
				connection.ConnectionString = _ctx.StringValue("GetDBInstanceTopology.Data.Connections["+ i +"].ConnectionString");
				connection.ZoneId = _ctx.StringValue("GetDBInstanceTopology.Data.Connections["+ i +"].ZoneId");

				data_connections.Add(connection);
			}
			data.Connections = data_connections;

			List<GetDBInstanceTopologyResponse.GetDBInstanceTopology_Data.GetDBInstanceTopology_Node> data_nodes = new List<GetDBInstanceTopologyResponse.GetDBInstanceTopology_Data.GetDBInstanceTopology_Node>();
			for (int i = 0; i < _ctx.Length("GetDBInstanceTopology.Data.Nodes.Length"); i++) {
				GetDBInstanceTopologyResponse.GetDBInstanceTopology_Data.GetDBInstanceTopology_Node node = new GetDBInstanceTopologyResponse.GetDBInstanceTopology_Data.GetDBInstanceTopology_Node();
				node.Role = _ctx.StringValue("GetDBInstanceTopology.Data.Nodes["+ i +"].Role");
				node.DedicatedHostId = _ctx.StringValue("GetDBInstanceTopology.Data.Nodes["+ i +"].DedicatedHostId");
				node.ZoneId = _ctx.StringValue("GetDBInstanceTopology.Data.Nodes["+ i +"].ZoneId");
				node.DedicatedHostGroupId = _ctx.StringValue("GetDBInstanceTopology.Data.Nodes["+ i +"].DedicatedHostGroupId");

				data_nodes.Add(node);
			}
			data.Nodes = data_nodes;
			getDBInstanceTopologyResponse.Data = data;
        
			return getDBInstanceTopologyResponse;
        }
    }
}
