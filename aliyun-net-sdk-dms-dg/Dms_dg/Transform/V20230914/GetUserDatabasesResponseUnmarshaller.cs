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
using Aliyun.Acs.dms_dg.Model.V20230914;

namespace Aliyun.Acs.dms_dg.Transform.V20230914
{
    public class GetUserDatabasesResponseUnmarshaller
    {
        public static GetUserDatabasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserDatabasesResponse getUserDatabasesResponse = new GetUserDatabasesResponse();

			getUserDatabasesResponse.HttpResponse = _ctx.HttpResponse;
			getUserDatabasesResponse.RequestId = _ctx.StringValue("GetUserDatabases.RequestId");
			getUserDatabasesResponse.Success = _ctx.StringValue("GetUserDatabases.Success");
			getUserDatabasesResponse.Code = _ctx.StringValue("GetUserDatabases.Code");
			getUserDatabasesResponse.ErrorMsg = _ctx.StringValue("GetUserDatabases.ErrorMsg");
			getUserDatabasesResponse.Count = _ctx.IntegerValue("GetUserDatabases.Count");

			List<GetUserDatabasesResponse.GetUserDatabases_DbInstance> getUserDatabasesResponse_dbInstanceList = new List<GetUserDatabasesResponse.GetUserDatabases_DbInstance>();
			for (int i = 0; i < _ctx.Length("GetUserDatabases.DbInstanceList.Length"); i++) {
				GetUserDatabasesResponse.GetUserDatabases_DbInstance dbInstance = new GetUserDatabasesResponse.GetUserDatabases_DbInstance();
				dbInstance.Port = _ctx.IntegerValue("GetUserDatabases.DbInstanceList["+ i +"].Port");
				dbInstance.Host = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].Host");
				dbInstance.GatewayId = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].GatewayId");
				dbInstance.DbType = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].DbType");
				dbInstance.RegionId = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].RegionId");
				dbInstance.ConnectHost = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].ConnectHost");
				dbInstance.ConnectPort = _ctx.IntegerValue("GetUserDatabases.DbInstanceList["+ i +"].ConnectPort");
				dbInstance.ServiceType = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].ServiceType");
				dbInstance.NetworkType = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].NetworkType");
				dbInstance.NodeId = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].NodeId");
				dbInstance.InstanceStatus = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].InstanceStatus");
				dbInstance.DbDescription = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].DbDescription");
				dbInstance.InstanceId = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].InstanceId");
				dbInstance.GatewayName = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].GatewayName");
				dbInstance.GmtCreate = _ctx.LongValue("GetUserDatabases.DbInstanceList["+ i +"].GmtCreate");
				dbInstance.UserId = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].UserId");
				dbInstance.ParentId = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].ParentId");
				dbInstance.VpcId = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].VpcId");
				dbInstance.VpcInstanceId = _ctx.StringValue("GetUserDatabases.DbInstanceList["+ i +"].VpcInstanceId");

				getUserDatabasesResponse_dbInstanceList.Add(dbInstance);
			}
			getUserDatabasesResponse.DbInstanceList = getUserDatabasesResponse_dbInstanceList;
        
			return getUserDatabasesResponse;
        }
    }
}
