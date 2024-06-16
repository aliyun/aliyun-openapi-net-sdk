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
    public class AddDatabaseResponseUnmarshaller
    {
        public static AddDatabaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddDatabaseResponse addDatabaseResponse = new AddDatabaseResponse();

			addDatabaseResponse.HttpResponse = _ctx.HttpResponse;
			addDatabaseResponse.Code = _ctx.StringValue("AddDatabase.Code");
			addDatabaseResponse.ErrorMsg = _ctx.StringValue("AddDatabase.ErrorMsg");
			addDatabaseResponse.RequestId = _ctx.StringValue("AddDatabase.RequestId");
			addDatabaseResponse.Success = _ctx.BooleanValue("AddDatabase.Success");

			AddDatabaseResponse.AddDatabase_DbInstance dbInstance = new AddDatabaseResponse.AddDatabase_DbInstance();
			dbInstance.Port = _ctx.IntegerValue("AddDatabase.DbInstance.Port");
			dbInstance.Host = _ctx.StringValue("AddDatabase.DbInstance.Host");
			dbInstance.GatewayId = _ctx.StringValue("AddDatabase.DbInstance.GatewayId");
			dbInstance.DbType = _ctx.StringValue("AddDatabase.DbInstance.DbType");
			dbInstance.RegionId = _ctx.StringValue("AddDatabase.DbInstance.RegionId");
			dbInstance.ConnectHost = _ctx.StringValue("AddDatabase.DbInstance.ConnectHost");
			dbInstance.ConnectPort = _ctx.IntegerValue("AddDatabase.DbInstance.ConnectPort");
			dbInstance.ServiceType = _ctx.StringValue("AddDatabase.DbInstance.ServiceType");
			dbInstance.NetworkType = _ctx.StringValue("AddDatabase.DbInstance.NetworkType");
			dbInstance.NodeId = _ctx.StringValue("AddDatabase.DbInstance.NodeId");
			dbInstance.InstanceStatus = _ctx.StringValue("AddDatabase.DbInstance.InstanceStatus");
			dbInstance.DbDescription = _ctx.StringValue("AddDatabase.DbInstance.DbDescription");
			dbInstance.InstanceId = _ctx.StringValue("AddDatabase.DbInstance.InstanceId");
			dbInstance.GatewayName = _ctx.StringValue("AddDatabase.DbInstance.GatewayName");
			dbInstance.UserId = _ctx.StringValue("AddDatabase.DbInstance.UserId");
			dbInstance.ParentId = _ctx.StringValue("AddDatabase.DbInstance.ParentId");
			dbInstance.VpcId = _ctx.StringValue("AddDatabase.DbInstance.VpcId");
			dbInstance.VpcInstanceId = _ctx.StringValue("AddDatabase.DbInstance.VpcInstanceId");
			addDatabaseResponse.DbInstance = dbInstance;
        
			return addDatabaseResponse;
        }
    }
}
