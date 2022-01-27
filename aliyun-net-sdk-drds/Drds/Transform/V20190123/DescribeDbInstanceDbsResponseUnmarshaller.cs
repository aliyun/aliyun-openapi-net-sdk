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
    public class DescribeDbInstanceDbsResponseUnmarshaller
    {
        public static DescribeDbInstanceDbsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDbInstanceDbsResponse describeDbInstanceDbsResponse = new DescribeDbInstanceDbsResponse();

			describeDbInstanceDbsResponse.HttpResponse = _ctx.HttpResponse;
			describeDbInstanceDbsResponse.RequestId = _ctx.StringValue("DescribeDbInstanceDbs.RequestId");
			describeDbInstanceDbsResponse.Success = _ctx.BooleanValue("DescribeDbInstanceDbs.Success");
			describeDbInstanceDbsResponse.Total = _ctx.StringValue("DescribeDbInstanceDbs.Total");

			List<DescribeDbInstanceDbsResponse.DescribeDbInstanceDbs_Database> describeDbInstanceDbsResponse_databases = new List<DescribeDbInstanceDbsResponse.DescribeDbInstanceDbs_Database>();
			for (int i = 0; i < _ctx.Length("DescribeDbInstanceDbs.Databases.Length"); i++) {
				DescribeDbInstanceDbsResponse.DescribeDbInstanceDbs_Database database = new DescribeDbInstanceDbsResponse.DescribeDbInstanceDbs_Database();
				database.DbName = _ctx.StringValue("DescribeDbInstanceDbs.Databases["+ i +"].DbName");
				database.Status = _ctx.IntegerValue("DescribeDbInstanceDbs.Databases["+ i +"].Status");
				database.Description = _ctx.StringValue("DescribeDbInstanceDbs.Databases["+ i +"].Description");

				describeDbInstanceDbsResponse_databases.Add(database);
			}
			describeDbInstanceDbsResponse.Databases = describeDbInstanceDbsResponse_databases;
        
			return describeDbInstanceDbsResponse;
        }
    }
}
