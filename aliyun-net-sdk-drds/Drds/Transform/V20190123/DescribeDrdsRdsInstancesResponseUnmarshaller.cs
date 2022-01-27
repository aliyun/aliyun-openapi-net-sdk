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
    public class DescribeDrdsRdsInstancesResponseUnmarshaller
    {
        public static DescribeDrdsRdsInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsRdsInstancesResponse describeDrdsRdsInstancesResponse = new DescribeDrdsRdsInstancesResponse();

			describeDrdsRdsInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsRdsInstancesResponse.RequestId = _ctx.StringValue("DescribeDrdsRdsInstances.RequestId");
			describeDrdsRdsInstancesResponse.Success = _ctx.BooleanValue("DescribeDrdsRdsInstances.Success");
			describeDrdsRdsInstancesResponse.PageNumber = _ctx.StringValue("DescribeDrdsRdsInstances.PageNumber");
			describeDrdsRdsInstancesResponse.PageSize = _ctx.StringValue("DescribeDrdsRdsInstances.PageSize");
			describeDrdsRdsInstancesResponse.Total = _ctx.StringValue("DescribeDrdsRdsInstances.Total");

			List<DescribeDrdsRdsInstancesResponse.DescribeDrdsRdsInstances_DbInstance> describeDrdsRdsInstancesResponse_dbInstances = new List<DescribeDrdsRdsInstancesResponse.DescribeDrdsRdsInstances_DbInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsRdsInstances.DbInstances.Length"); i++) {
				DescribeDrdsRdsInstancesResponse.DescribeDrdsRdsInstances_DbInstance dbInstance = new DescribeDrdsRdsInstancesResponse.DescribeDrdsRdsInstances_DbInstance();
				dbInstance.DBInstanceId = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].DBInstanceId");
				dbInstance.DmInstanceId = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].DmInstanceId");
				dbInstance.ConnectUrl = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].ConnectUrl");
				dbInstance.Port = _ctx.IntegerValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].Port");
				dbInstance.DBInstanceStatus = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].DBInstanceStatus");
				dbInstance.DbInstType = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].DbInstType");
				dbInstance.ReadWeight = _ctx.IntegerValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].ReadWeight");
				dbInstance.NetworkType = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].NetworkType");
				dbInstance.Engine = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].Engine");
				dbInstance.EngineVersion = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].EngineVersion");
				dbInstance.RdsInstType = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].RdsInstType");
				dbInstance.PayType = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].PayType");
				dbInstance.ExpireTime = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].ExpireTime");
				dbInstance.RemainDays = _ctx.IntegerValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].RemainDays");
				dbInstance.DBInstanceClassType = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].DBInstanceClassType");
				dbInstance.DBInstanceCPU = _ctx.StringValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].DBInstanceCPU");
				dbInstance.DBInstanceMemory = _ctx.LongValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].DBInstanceMemory");
				dbInstance.DBInstanceStorage = _ctx.LongValue("DescribeDrdsRdsInstances.DbInstances["+ i +"].DBInstanceStorage");

				describeDrdsRdsInstancesResponse_dbInstances.Add(dbInstance);
			}
			describeDrdsRdsInstancesResponse.DbInstances = describeDrdsRdsInstancesResponse_dbInstances;
        
			return describeDrdsRdsInstancesResponse;
        }
    }
}
