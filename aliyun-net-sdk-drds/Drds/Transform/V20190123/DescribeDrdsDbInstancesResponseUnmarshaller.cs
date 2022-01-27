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
    public class DescribeDrdsDbInstancesResponseUnmarshaller
    {
        public static DescribeDrdsDbInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsDbInstancesResponse describeDrdsDbInstancesResponse = new DescribeDrdsDbInstancesResponse();

			describeDrdsDbInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsDbInstancesResponse.RequestId = _ctx.StringValue("DescribeDrdsDbInstances.RequestId");
			describeDrdsDbInstancesResponse.Success = _ctx.BooleanValue("DescribeDrdsDbInstances.Success");
			describeDrdsDbInstancesResponse.PageNumber = _ctx.StringValue("DescribeDrdsDbInstances.PageNumber");
			describeDrdsDbInstancesResponse.PageSize = _ctx.StringValue("DescribeDrdsDbInstances.PageSize");
			describeDrdsDbInstancesResponse.Total = _ctx.StringValue("DescribeDrdsDbInstances.Total");

			List<DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance> describeDrdsDbInstancesResponse_dbInstances = new List<DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsDbInstances.DbInstances.Length"); i++) {
				DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance dbInstance = new DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance();
				dbInstance.DBInstanceId = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].DBInstanceId");
				dbInstance.DmInstanceId = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].DmInstanceId");
				dbInstance.ConnectUrl = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ConnectUrl");
				dbInstance.Port = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].Port");
				dbInstance.DBInstanceStatus = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].DBInstanceStatus");
				dbInstance.DbInstType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].DbInstType");
				dbInstance.ReadWeight = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadWeight");
				dbInstance.NetworkType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].NetworkType");
				dbInstance.Engine = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].Engine");
				dbInstance.EngineVersion = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].EngineVersion");
				dbInstance.RdsInstType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].RdsInstType");
				dbInstance.PayType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].PayType");
				dbInstance.ExpireTime = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ExpireTime");
				dbInstance.RemainDays = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].RemainDays");

				List<DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance.DescribeDrdsDbInstances_ReadOnlyInstance> dbInstance_readOnlyInstances = new List<DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance.DescribeDrdsDbInstances_ReadOnlyInstance>();
				for (int j = 0; j < _ctx.Length("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances.Length"); j++) {
					DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance.DescribeDrdsDbInstances_ReadOnlyInstance readOnlyInstance = new DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance.DescribeDrdsDbInstances_ReadOnlyInstance();
					readOnlyInstance.InstanceName = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].InstanceName");
					readOnlyInstance.DmInstanceId = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].DmInstanceId");
					readOnlyInstance.ConnectUrl = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].ConnectUrl");
					readOnlyInstance.Port = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].Port");
					readOnlyInstance.DBInstanceStatus = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].DBInstanceStatus");
					readOnlyInstance.DbInstType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].DbInstType");
					readOnlyInstance.ReadWeight = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].ReadWeight");
					readOnlyInstance.NetworkType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].NetworkType");
					readOnlyInstance.Engine = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].Engine");
					readOnlyInstance.EngineVersion = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].EngineVersion");
					readOnlyInstance.RdsInstType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].RdsInstType");
					readOnlyInstance.PayType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].PayType");
					readOnlyInstance.ExpireTime = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].ExpireTime");
					readOnlyInstance.RemainDays = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].RemainDays");

					dbInstance_readOnlyInstances.Add(readOnlyInstance);
				}
				dbInstance.ReadOnlyInstances = dbInstance_readOnlyInstances;

				describeDrdsDbInstancesResponse_dbInstances.Add(dbInstance);
			}
			describeDrdsDbInstancesResponse.DbInstances = describeDrdsDbInstancesResponse_dbInstances;
        
			return describeDrdsDbInstancesResponse;
        }
    }
}
