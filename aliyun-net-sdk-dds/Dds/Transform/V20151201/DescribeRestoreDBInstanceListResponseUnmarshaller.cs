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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeRestoreDBInstanceListResponseUnmarshaller
    {
        public static DescribeRestoreDBInstanceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRestoreDBInstanceListResponse describeRestoreDBInstanceListResponse = new DescribeRestoreDBInstanceListResponse();

			describeRestoreDBInstanceListResponse.HttpResponse = _ctx.HttpResponse;
			describeRestoreDBInstanceListResponse.TotalCount = _ctx.IntegerValue("DescribeRestoreDBInstanceList.TotalCount");
			describeRestoreDBInstanceListResponse.RequestId = _ctx.StringValue("DescribeRestoreDBInstanceList.RequestId");
			describeRestoreDBInstanceListResponse.PageSize = _ctx.IntegerValue("DescribeRestoreDBInstanceList.PageSize");
			describeRestoreDBInstanceListResponse.PageNumber = _ctx.IntegerValue("DescribeRestoreDBInstanceList.PageNumber");

			List<DescribeRestoreDBInstanceListResponse.DescribeRestoreDBInstanceList_DBInstance> describeRestoreDBInstanceListResponse_dBInstances = new List<DescribeRestoreDBInstanceListResponse.DescribeRestoreDBInstanceList_DBInstance>();
			for (int i = 0; i < _ctx.Length("DescribeRestoreDBInstanceList.DBInstances.Length"); i++) {
				DescribeRestoreDBInstanceListResponse.DescribeRestoreDBInstanceList_DBInstance dBInstance = new DescribeRestoreDBInstanceListResponse.DescribeRestoreDBInstanceList_DBInstance();
				dBInstance.CreationTime = _ctx.StringValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].CreationTime");
				dBInstance.LockMode = _ctx.StringValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].LockMode");
				dBInstance.EngineVersion = _ctx.StringValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].EngineVersion");
				dBInstance.DBInstanceDescription = _ctx.StringValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].DBInstanceDescription");
				dBInstance.DBInstanceType = _ctx.StringValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].DBInstanceType");
				dBInstance.DBInstanceStatus = _ctx.StringValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].DBInstanceStatus");
				dBInstance.RegionId = _ctx.StringValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].RegionId");
				dBInstance.ZoneId = _ctx.StringValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].ZoneId");
				dBInstance.DBInstanceId = _ctx.StringValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].DBInstanceId");
				dBInstance.SecondaryZoneId = _ctx.StringValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].SecondaryZoneId");
				dBInstance.HiddenZoneId = _ctx.StringValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].HiddenZoneId");
				dBInstance.IsDeleted = _ctx.IntegerValue("DescribeRestoreDBInstanceList.DBInstances["+ i +"].IsDeleted");

				describeRestoreDBInstanceListResponse_dBInstances.Add(dBInstance);
			}
			describeRestoreDBInstanceListResponse.DBInstances = describeRestoreDBInstanceListResponse_dBInstances;
        
			return describeRestoreDBInstanceListResponse;
        }
    }
}
