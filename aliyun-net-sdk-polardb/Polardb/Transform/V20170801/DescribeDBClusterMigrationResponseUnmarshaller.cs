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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBClusterMigrationResponseUnmarshaller
    {
        public static DescribeDBClusterMigrationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBClusterMigrationResponse describeDBClusterMigrationResponse = new DescribeDBClusterMigrationResponse();

			describeDBClusterMigrationResponse.HttpResponse = context.HttpResponse;
			describeDBClusterMigrationResponse.RequestId = context.StringValue("DescribeDBClusterMigration.RequestId");
			describeDBClusterMigrationResponse.DBClusterId = context.StringValue("DescribeDBClusterMigration.DBClusterId");
			describeDBClusterMigrationResponse.SourceRDSDBInstanceId = context.StringValue("DescribeDBClusterMigration.SourceRDSDBInstanceId");
			describeDBClusterMigrationResponse.MigrationStatus = context.StringValue("DescribeDBClusterMigration.MigrationStatus");
			describeDBClusterMigrationResponse.Topologies = context.StringValue("DescribeDBClusterMigration.Topologies");
			describeDBClusterMigrationResponse.DelayedSeconds = context.IntegerValue("DescribeDBClusterMigration.DelayedSeconds");
			describeDBClusterMigrationResponse.ExpiredTime = context.StringValue("DescribeDBClusterMigration.ExpiredTime");
			describeDBClusterMigrationResponse.RdsReadWriteMode = context.StringValue("DescribeDBClusterMigration.RdsReadWriteMode");
			describeDBClusterMigrationResponse.DBClusterReadWriteMode = context.StringValue("DescribeDBClusterMigration.DBClusterReadWriteMode");
			describeDBClusterMigrationResponse.Comment = context.StringValue("DescribeDBClusterMigration.Comment");
        
			return describeDBClusterMigrationResponse;
        }
    }
}
