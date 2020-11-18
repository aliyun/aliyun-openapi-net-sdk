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
        public static DescribeBackupPlanConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPlanConfigResponse describeBackupPlanConfigResponse = new DescribeBackupPlanConfigResponse();

			describeBackupPlanConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPlanConfigResponse.RequestId = _ctx.StringValue("DescribeBackupPlanConfig.RequestId");
			describeBackupPlanConfigResponse.FullBackupCycle = _ctx.IntegerValue("DescribeBackupPlanConfig.FullBackupCycle");
			describeBackupPlanConfigResponse.MinHFileBackupCount = _ctx.IntegerValue("DescribeBackupPlanConfig.MinHFileBackupCount");
			describeBackupPlanConfigResponse.NextFullBackupDate = _ctx.StringValue("DescribeBackupPlanConfig.NextFullBackupDate");

			List<string> describeBackupPlanConfigResponse_tables = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeBackupPlanConfig.Tables.Length"); i++) {
				describeBackupPlanConfigResponse_tables.Add(_ctx.StringValue("DescribeBackupPlanConfig.Tables["+ i +"]"));
			}
			describeBackupPlanConfigResponse.Tables = describeBackupPlanConfigResponse_tables;
        
			return describeBackupPlanConfigResponse;
        }
    }
}
