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
			describeDrdsDbInstancesResponse.PageSize = _ctx.StringValue("DescribeDrdsDbInstances.PageSize");
			describeDrdsDbInstancesResponse.PageNumber = _ctx.StringValue("DescribeDrdsDbInstances.PageNumber");
			describeDrdsDbInstancesResponse.RequestId = _ctx.StringValue("DescribeDrdsDbInstances.RequestId");
			describeDrdsDbInstancesResponse.Total = _ctx.StringValue("DescribeDrdsDbInstances.Total");
			describeDrdsDbInstancesResponse.Success = _ctx.BooleanValue("DescribeDrdsDbInstances.Success");

			List<DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance> describeDrdsDbInstancesResponse_dbInstances = new List<DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsDbInstances.DbInstances.Length"); i++) {
				DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance dbInstance = new DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance();
				dbInstance.ExpireTime = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ExpireTime");
				dbInstance.PayType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].PayType");
				dbInstance.DBInstanceStatus = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].DBInstanceStatus");
				dbInstance.NetworkType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].NetworkType");
				dbInstance.Port = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].Port");
				dbInstance.EngineVersion = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].EngineVersion");
				dbInstance.DmInstanceId = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].DmInstanceId");
				dbInstance.ConnectUrl = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ConnectUrl");
				dbInstance.ReadWeight = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadWeight");
				dbInstance.RdsInstType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].RdsInstType");
				dbInstance.RemainDays = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].RemainDays");
				dbInstance.DBInstanceId = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].DBInstanceId");
				dbInstance.DbInstType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].DbInstType");
				dbInstance.Engine = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].Engine");

				List<DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance.DescribeDrdsDbInstances_ReadOnlyInstance> dbInstance_readOnlyInstances = new List<DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance.DescribeDrdsDbInstances_ReadOnlyInstance>();
				for (int j = 0; j < _ctx.Length("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances.Length"); j++) {
					DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance.DescribeDrdsDbInstances_ReadOnlyInstance readOnlyInstance = new DescribeDrdsDbInstancesResponse.DescribeDrdsDbInstances_DbInstance.DescribeDrdsDbInstances_ReadOnlyInstance();
					readOnlyInstance.ExpireTime = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].ExpireTime");
					readOnlyInstance.PayType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].PayType");
					readOnlyInstance.DBInstanceStatus = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].DBInstanceStatus");
					readOnlyInstance.NetworkType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].NetworkType");
					readOnlyInstance.Port = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].Port");
					readOnlyInstance.EngineVersion = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].EngineVersion");
					readOnlyInstance.DmInstanceId = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].DmInstanceId");
					readOnlyInstance.ConnectUrl = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].ConnectUrl");
					readOnlyInstance.ReadWeight = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].ReadWeight");
					readOnlyInstance.RdsInstType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].RdsInstType");
					readOnlyInstance.InstanceName = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].InstanceName");
					readOnlyInstance.RemainDays = _ctx.IntegerValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].RemainDays");
					readOnlyInstance.DbInstType = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].DbInstType");
					readOnlyInstance.Engine = _ctx.StringValue("DescribeDrdsDbInstances.DbInstances["+ i +"].ReadOnlyInstances["+ j +"].Engine");

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
