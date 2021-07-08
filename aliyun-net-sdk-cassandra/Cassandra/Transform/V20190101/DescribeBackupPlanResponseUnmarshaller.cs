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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeBackupPlanResponseUnmarshaller
    {
        public static DescribeBackupPlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPlanResponse describeBackupPlanResponse = new DescribeBackupPlanResponse();

			describeBackupPlanResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPlanResponse.RequestId = _ctx.StringValue("DescribeBackupPlan.RequestId");

			DescribeBackupPlanResponse.DescribeBackupPlan_BackupPlan backupPlan = new DescribeBackupPlanResponse.DescribeBackupPlan_BackupPlan();
			backupPlan.ClusterId = _ctx.StringValue("DescribeBackupPlan.BackupPlan.ClusterId");
			backupPlan.DataCenterId = _ctx.StringValue("DescribeBackupPlan.BackupPlan.DataCenterId");
			backupPlan.CreatedTime = _ctx.StringValue("DescribeBackupPlan.BackupPlan.CreatedTime");
			backupPlan.BackupTime = _ctx.StringValue("DescribeBackupPlan.BackupPlan.BackupTime");
			backupPlan.BackupPeriod = _ctx.StringValue("DescribeBackupPlan.BackupPlan.BackupPeriod");
			backupPlan.RetentionPeriod = _ctx.IntegerValue("DescribeBackupPlan.BackupPlan.RetentionPeriod");
			backupPlan.Active = _ctx.BooleanValue("DescribeBackupPlan.BackupPlan.Active");
			describeBackupPlanResponse.BackupPlan = backupPlan;
        
			return describeBackupPlanResponse;
        }
    }
}
