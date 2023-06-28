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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class DescribeDatabaseInstancesResponseUnmarshaller
    {
        public static DescribeDatabaseInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDatabaseInstancesResponse describeDatabaseInstancesResponse = new DescribeDatabaseInstancesResponse();

			describeDatabaseInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDatabaseInstancesResponse.RequestId = _ctx.StringValue("DescribeDatabaseInstances.RequestId");
			describeDatabaseInstancesResponse.PageSize = _ctx.IntegerValue("DescribeDatabaseInstances.PageSize");
			describeDatabaseInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeDatabaseInstances.PageNumber");
			describeDatabaseInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeDatabaseInstances.TotalCount");

			List<DescribeDatabaseInstancesResponse.DescribeDatabaseInstances_DatabaseInstance> describeDatabaseInstancesResponse_databaseInstances = new List<DescribeDatabaseInstancesResponse.DescribeDatabaseInstances_DatabaseInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDatabaseInstances.DatabaseInstances.Length"); i++) {
				DescribeDatabaseInstancesResponse.DescribeDatabaseInstances_DatabaseInstance databaseInstance = new DescribeDatabaseInstancesResponse.DescribeDatabaseInstances_DatabaseInstance();
				databaseInstance.RegionId = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].RegionId");
				databaseInstance.DatabaseInstanceId = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].DatabaseInstanceId");
				databaseInstance.DatabaseInstanceName = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].DatabaseInstanceName");
				databaseInstance.DatabaseInstanceEdition = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].DatabaseInstanceEdition");
				databaseInstance.DatabaseVersion = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].DatabaseVersion");
				databaseInstance.Cpu = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].Cpu");
				databaseInstance.Memory = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].Memory");
				databaseInstance.Storage = _ctx.IntegerValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].Storage");
				databaseInstance.PrivateConnection = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].PrivateConnection");
				databaseInstance.PublicConnection = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].PublicConnection");
				databaseInstance.DatabaseInstanceStatus = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].DatabaseInstanceStatus");
				databaseInstance.BusinessStatus = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].BusinessStatus");
				databaseInstance.CreationTime = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].CreationTime");
				databaseInstance.ExpiredTime = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].ExpiredTime");
				databaseInstance.ChargeType = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].ChargeType");
				databaseInstance.SuperAccountName = _ctx.StringValue("DescribeDatabaseInstances.DatabaseInstances["+ i +"].SuperAccountName");

				describeDatabaseInstancesResponse_databaseInstances.Add(databaseInstance);
			}
			describeDatabaseInstancesResponse.DatabaseInstances = describeDatabaseInstancesResponse_databaseInstances;
        
			return describeDatabaseInstancesResponse;
        }
    }
}
