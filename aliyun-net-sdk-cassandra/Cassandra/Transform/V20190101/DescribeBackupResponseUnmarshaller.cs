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
    public class DescribeBackupResponseUnmarshaller
    {
        public static DescribeBackupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupResponse describeBackupResponse = new DescribeBackupResponse();

			describeBackupResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupResponse.RequestId = _ctx.StringValue("DescribeBackup.RequestId");

			DescribeBackupResponse.DescribeBackup_Backup backup = new DescribeBackupResponse.DescribeBackup_Backup();
			backup.ClusterId = _ctx.StringValue("DescribeBackup.Backup.ClusterId");
			backup.DataCenterId = _ctx.StringValue("DescribeBackup.Backup.DataCenterId");
			backup.BackupId = _ctx.StringValue("DescribeBackup.Backup.BackupId");
			backup.BackupType = _ctx.StringValue("DescribeBackup.Backup.BackupType");
			backup.Status = _ctx.StringValue("DescribeBackup.Backup.Status");
			backup.StartTime = _ctx.StringValue("DescribeBackup.Backup.StartTime");
			backup.EndTime = _ctx.StringValue("DescribeBackup.Backup.EndTime");
			backup.Size = _ctx.LongValue("DescribeBackup.Backup.Size");
			backup.Details = _ctx.StringValue("DescribeBackup.Backup.Details");
			describeBackupResponse.Backup = backup;
        
			return describeBackupResponse;
        }
    }
}
