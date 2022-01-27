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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeDrdsDbInstanceResponseUnmarshaller
    {
        public static DescribeDrdsDbInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsDbInstanceResponse describeDrdsDbInstanceResponse = new DescribeDrdsDbInstanceResponse();

			describeDrdsDbInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsDbInstanceResponse.RequestId = _ctx.StringValue("DescribeDrdsDbInstance.RequestId");
			describeDrdsDbInstanceResponse.Success = _ctx.BooleanValue("DescribeDrdsDbInstance.Success");

			DescribeDrdsDbInstanceResponse.DescribeDrdsDbInstance_DbInstance dbInstance = new DescribeDrdsDbInstanceResponse.DescribeDrdsDbInstance_DbInstance();
			dbInstance.DBInstanceId = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.DBInstanceId");
			dbInstance.DmInstanceId = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.DmInstanceId");
			dbInstance.ConnectUrl = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ConnectUrl");
			dbInstance.Port = _ctx.IntegerValue("DescribeDrdsDbInstance.DbInstance.Port");
			dbInstance.DBInstanceStatus = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.DBInstanceStatus");
			dbInstance.DbInstType = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.DbInstType");
			dbInstance.ReadWeight = _ctx.IntegerValue("DescribeDrdsDbInstance.DbInstance.ReadWeight");
			dbInstance.Engine = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.Engine");
			dbInstance.EngineVersion = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.EngineVersion");
			dbInstance.RdsInstType = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.RdsInstType");
			dbInstance.PayType = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.PayType");
			dbInstance.ExpireTime = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ExpireTime");
			dbInstance.RemainDays = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.RemainDays");
			dbInstance.NetworkType = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.NetworkType");

			List<DescribeDrdsDbInstanceResponse.DescribeDrdsDbInstance_DbInstance.DescribeDrdsDbInstance_ReadOnlyInstance> dbInstance_readOnlyInstances = new List<DescribeDrdsDbInstanceResponse.DescribeDrdsDbInstance_DbInstance.DescribeDrdsDbInstance_ReadOnlyInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances.Length"); i++) {
				DescribeDrdsDbInstanceResponse.DescribeDrdsDbInstance_DbInstance.DescribeDrdsDbInstance_ReadOnlyInstance readOnlyInstance = new DescribeDrdsDbInstanceResponse.DescribeDrdsDbInstance_DbInstance.DescribeDrdsDbInstance_ReadOnlyInstance();
				readOnlyInstance.DBInstanceId = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].DBInstanceId");
				readOnlyInstance.DmInstanceId = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].DmInstanceId");
				readOnlyInstance.ConnectUrl = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].ConnectUrl");
				readOnlyInstance.Port = _ctx.IntegerValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].Port");
				readOnlyInstance.DBInstanceStatus = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].DBInstanceStatus");
				readOnlyInstance.DbInstType = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].DbInstType");
				readOnlyInstance.ReadWeight = _ctx.IntegerValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].ReadWeight");
				readOnlyInstance.Engine = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].Engine");
				readOnlyInstance.EngineVersion = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].EngineVersion");
				readOnlyInstance.RdsInstType = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].RdsInstType");
				readOnlyInstance.PayType = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].PayType");
				readOnlyInstance.ExpireTime = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].ExpireTime");
				readOnlyInstance.RemainDays = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].RemainDays");
				readOnlyInstance.NetworkType = _ctx.StringValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].NetworkType");
				readOnlyInstance.VersionAction = _ctx.IntegerValue("DescribeDrdsDbInstance.DbInstance.ReadOnlyInstances["+ i +"].VersionAction");

				dbInstance_readOnlyInstances.Add(readOnlyInstance);
			}
			dbInstance.ReadOnlyInstances = dbInstance_readOnlyInstances;
			describeDrdsDbInstanceResponse.DbInstance = dbInstance;
        
			return describeDrdsDbInstanceResponse;
        }
    }
}
