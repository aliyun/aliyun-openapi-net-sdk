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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribePolarxDbInstancesResponseUnmarshaller
    {
        public static DescribePolarxDbInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePolarxDbInstancesResponse describePolarxDbInstancesResponse = new DescribePolarxDbInstancesResponse();

			describePolarxDbInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describePolarxDbInstancesResponse.RequestId = _ctx.StringValue("DescribePolarxDbInstances.RequestId");
			describePolarxDbInstancesResponse.Success = _ctx.BooleanValue("DescribePolarxDbInstances.Success");
			describePolarxDbInstancesResponse.PageNumber = _ctx.StringValue("DescribePolarxDbInstances.PageNumber");
			describePolarxDbInstancesResponse.PageSize = _ctx.StringValue("DescribePolarxDbInstances.PageSize");
			describePolarxDbInstancesResponse.Total = _ctx.StringValue("DescribePolarxDbInstances.Total");

			List<DescribePolarxDbInstancesResponse.DescribePolarxDbInstances_DbInstance> describePolarxDbInstancesResponse_dbInstances = new List<DescribePolarxDbInstancesResponse.DescribePolarxDbInstances_DbInstance>();
			for (int i = 0; i < _ctx.Length("DescribePolarxDbInstances.DbInstances.Length"); i++) {
				DescribePolarxDbInstancesResponse.DescribePolarxDbInstances_DbInstance dbInstance = new DescribePolarxDbInstancesResponse.DescribePolarxDbInstances_DbInstance();
				dbInstance.DBInstanceId = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].DBInstanceId");
				dbInstance.Description = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].Description");
				dbInstance.PayType = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].PayType");
				dbInstance.CreateTime = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].CreateTime");
				dbInstance.ExpireTime = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].ExpireTime");
				dbInstance.RegionId = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].RegionId");
				dbInstance.ZoneId = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].ZoneId");
				dbInstance.Network = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].Network");
				dbInstance.VPCId = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].VPCId");
				dbInstance.Engine = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].Engine");
				dbInstance.DBType = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].DBType");
				dbInstance.DBVersion = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].DBVersion");
				dbInstance.Status = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].Status");
				dbInstance.StatusDesc = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].StatusDesc");
				dbInstance.LockMode = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].LockMode");
				dbInstance.LockReason = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].lockReason");
				dbInstance.NodeCount = _ctx.IntegerValue("DescribePolarxDbInstances.DbInstances["+ i +"].NodeCount");
				dbInstance.NodeClass = _ctx.StringValue("DescribePolarxDbInstances.DbInstances["+ i +"].NodeClass");
				dbInstance.StorageUsed = _ctx.IntegerValue("DescribePolarxDbInstances.DbInstances["+ i +"].StorageUsed");

				describePolarxDbInstancesResponse_dbInstances.Add(dbInstance);
			}
			describePolarxDbInstancesResponse.DbInstances = describePolarxDbInstancesResponse_dbInstances;
        
			return describePolarxDbInstancesResponse;
        }
    }
}
