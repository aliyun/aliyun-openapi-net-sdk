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
    public class DescribeBackupPlansResponseUnmarshaller
    {
        public static DescribeBackupPlansResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPlansResponse describeBackupPlansResponse = new DescribeBackupPlansResponse();

			describeBackupPlansResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPlansResponse.RequestId = _ctx.StringValue("DescribeBackupPlans.RequestId");

			List<DescribeBackupPlansResponse.DescribeBackupPlans_BackupPlan> describeBackupPlansResponse_backupPlans = new List<DescribeBackupPlansResponse.DescribeBackupPlans_BackupPlan>();
			for (int i = 0; i < _ctx.Length("DescribeBackupPlans.BackupPlans.Length"); i++) {
				DescribeBackupPlansResponse.DescribeBackupPlans_BackupPlan backupPlan = new DescribeBackupPlansResponse.DescribeBackupPlans_BackupPlan();
				backupPlan.ClusterId = _ctx.StringValue("DescribeBackupPlans.BackupPlans["+ i +"].ClusterId");
				backupPlan.DataCenterId = _ctx.StringValue("DescribeBackupPlans.BackupPlans["+ i +"].DataCenterId");
				backupPlan.CreatedTime = _ctx.StringValue("DescribeBackupPlans.BackupPlans["+ i +"].CreatedTime");
				backupPlan.BackupTime = _ctx.StringValue("DescribeBackupPlans.BackupPlans["+ i +"].BackupTime");
				backupPlan.BackupPeriod = _ctx.StringValue("DescribeBackupPlans.BackupPlans["+ i +"].BackupPeriod");
				backupPlan.RetentionPeriod = _ctx.IntegerValue("DescribeBackupPlans.BackupPlans["+ i +"].RetentionPeriod");
				backupPlan.Active = _ctx.BooleanValue("DescribeBackupPlans.BackupPlans["+ i +"].Active");

				describeBackupPlansResponse_backupPlans.Add(backupPlan);
			}
			describeBackupPlansResponse.BackupPlans = describeBackupPlansResponse_backupPlans;
        
			return describeBackupPlansResponse;
        }
    }
}
