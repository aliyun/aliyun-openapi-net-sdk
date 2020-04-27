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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeBackupPlanConfigResponseUnmarshaller
    {
        public static DescribeBackupPlanConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupPlanConfigResponse describeBackupPlanConfigResponse = new DescribeBackupPlanConfigResponse();

			describeBackupPlanConfigResponse.HttpResponse = context.HttpResponse;
			describeBackupPlanConfigResponse.RequestId = context.StringValue("DescribeBackupPlanConfig.RequestId");
			describeBackupPlanConfigResponse.FullBackupCycle = context.IntegerValue("DescribeBackupPlanConfig.FullBackupCycle");
			describeBackupPlanConfigResponse.MinHFileBackupCount = context.IntegerValue("DescribeBackupPlanConfig.MinHFileBackupCount");
			describeBackupPlanConfigResponse.NextFullBackupDate = context.StringValue("DescribeBackupPlanConfig.NextFullBackupDate");

			List<string> describeBackupPlanConfigResponse_tables = new List<string>();
			for (int i = 0; i < context.Length("DescribeBackupPlanConfig.Tables.Length"); i++) {
				describeBackupPlanConfigResponse_tables.Add(context.StringValue("DescribeBackupPlanConfig.Tables["+ i +"]"));
			}
			describeBackupPlanConfigResponse.Tables = describeBackupPlanConfigResponse_tables;
        
			return describeBackupPlanConfigResponse;
        }
    }
}
