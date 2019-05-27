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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeCloudDatabasesResponseUnmarshaller
    {
        public static DescribeCloudDatabasesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCloudDatabasesResponse describeCloudDatabasesResponse = new DescribeCloudDatabasesResponse();

			describeCloudDatabasesResponse.HttpResponse = context.HttpResponse;
			describeCloudDatabasesResponse.RequestId = context.StringValue("DescribeCloudDatabases.RequestId");

			List<DescribeCloudDatabasesResponse.DescribeCloudDatabases_CloudDatabase> describeCloudDatabasesResponse_cloudDatabaseList = new List<DescribeCloudDatabasesResponse.DescribeCloudDatabases_CloudDatabase>();
			for (int i = 0; i < context.Length("DescribeCloudDatabases.CloudDatabaseList.Length"); i++) {
				DescribeCloudDatabasesResponse.DescribeCloudDatabases_CloudDatabase cloudDatabase = new DescribeCloudDatabasesResponse.DescribeCloudDatabases_CloudDatabase();
				cloudDatabase.Engine = context.StringValue("DescribeCloudDatabases.CloudDatabaseList["+ i +"].Engine");
				cloudDatabase.Name = context.StringValue("DescribeCloudDatabases.CloudDatabaseList["+ i +"].Name");
				cloudDatabase.InstanceId = context.StringValue("DescribeCloudDatabases.CloudDatabaseList["+ i +"].InstanceId");

				describeCloudDatabasesResponse_cloudDatabaseList.Add(cloudDatabase);
			}
			describeCloudDatabasesResponse.CloudDatabaseList = describeCloudDatabasesResponse_cloudDatabaseList;
        
			return describeCloudDatabasesResponse;
        }
    }
}
