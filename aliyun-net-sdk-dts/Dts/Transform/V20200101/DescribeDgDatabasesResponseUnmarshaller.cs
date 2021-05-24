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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeDgDatabasesResponseUnmarshaller
    {
        public static DescribeDgDatabasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDgDatabasesResponse describeDgDatabasesResponse = new DescribeDgDatabasesResponse();

			describeDgDatabasesResponse.HttpResponse = _ctx.HttpResponse;
			describeDgDatabasesResponse.RequestId = _ctx.StringValue("DescribeDgDatabases.RequestId");
			describeDgDatabasesResponse.Success = _ctx.BooleanValue("DescribeDgDatabases.Success");
			describeDgDatabasesResponse.ErrCode = _ctx.StringValue("DescribeDgDatabases.ErrCode");
			describeDgDatabasesResponse.ErrMessage = _ctx.StringValue("DescribeDgDatabases.ErrMessage");
			describeDgDatabasesResponse.DynamicCode = _ctx.StringValue("DescribeDgDatabases.DynamicCode");
			describeDgDatabasesResponse.DynamicMessage = _ctx.StringValue("DescribeDgDatabases.DynamicMessage");
			describeDgDatabasesResponse.HttpStatusCode = _ctx.IntegerValue("DescribeDgDatabases.HttpStatusCode");

			List<DescribeDgDatabasesResponse.DescribeDgDatabases_DgDatabasesItem> describeDgDatabasesResponse_dgDatabases = new List<DescribeDgDatabasesResponse.DescribeDgDatabases_DgDatabasesItem>();
			for (int i = 0; i < _ctx.Length("DescribeDgDatabases.DgDatabases.Length"); i++) {
				DescribeDgDatabasesResponse.DescribeDgDatabases_DgDatabasesItem dgDatabasesItem = new DescribeDgDatabasesResponse.DescribeDgDatabases_DgDatabasesItem();
				dgDatabasesItem.InstanceId = _ctx.StringValue("DescribeDgDatabases.DgDatabases["+ i +"].InstanceId");
				dgDatabasesItem.InstanceName = _ctx.StringValue("DescribeDgDatabases.DgDatabases["+ i +"].InstanceName");
				dgDatabasesItem.Region = _ctx.StringValue("DescribeDgDatabases.DgDatabases["+ i +"].Region");
				dgDatabasesItem.Engine = _ctx.StringValue("DescribeDgDatabases.DgDatabases["+ i +"].Engine");
				dgDatabasesItem.VpcId = _ctx.StringValue("DescribeDgDatabases.DgDatabases["+ i +"].VpcId");
				dgDatabasesItem.VpcCloudInstanceId = _ctx.StringValue("DescribeDgDatabases.DgDatabases["+ i +"].VpcCloudInstanceId");
				dgDatabasesItem.Status = _ctx.StringValue("DescribeDgDatabases.DgDatabases["+ i +"].Status");
				dgDatabasesItem.GroupId = _ctx.StringValue("DescribeDgDatabases.DgDatabases["+ i +"].GroupId");
				dgDatabasesItem.HostPort = _ctx.StringValue("DescribeDgDatabases.DgDatabases["+ i +"].HostPort");
				dgDatabasesItem.ConnectHostPort = _ctx.StringValue("DescribeDgDatabases.DgDatabases["+ i +"].ConnectHostPort");

				describeDgDatabasesResponse_dgDatabases.Add(dgDatabasesItem);
			}
			describeDgDatabasesResponse.DgDatabases = describeDgDatabasesResponse_dgDatabases;
        
			return describeDgDatabasesResponse;
        }
    }
}
