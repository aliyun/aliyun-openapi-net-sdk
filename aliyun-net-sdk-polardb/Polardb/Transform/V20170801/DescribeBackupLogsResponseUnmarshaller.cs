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
    public class DescribeBackupLogsResponseUnmarshaller
    {
        public static DescribeBackupLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupLogsResponse describeBackupLogsResponse = new DescribeBackupLogsResponse();

			describeBackupLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupLogsResponse.RequestId = _ctx.StringValue("DescribeBackupLogs.RequestId");
			describeBackupLogsResponse.TotalRecordCount = _ctx.StringValue("DescribeBackupLogs.TotalRecordCount");
			describeBackupLogsResponse.PageNumber = _ctx.StringValue("DescribeBackupLogs.PageNumber");
			describeBackupLogsResponse.PageRecordCount = _ctx.StringValue("DescribeBackupLogs.PageRecordCount");

			List<DescribeBackupLogsResponse.DescribeBackupLogs_BackupLog> describeBackupLogsResponse_items = new List<DescribeBackupLogsResponse.DescribeBackupLogs_BackupLog>();
			for (int i = 0; i < _ctx.Length("DescribeBackupLogs.Items.Length"); i++) {
				DescribeBackupLogsResponse.DescribeBackupLogs_BackupLog backupLog = new DescribeBackupLogsResponse.DescribeBackupLogs_BackupLog();
				backupLog.BackupLogId = _ctx.StringValue("DescribeBackupLogs.Items["+ i +"].BackupLogId");
				backupLog.BackupLogName = _ctx.StringValue("DescribeBackupLogs.Items["+ i +"].BackupLogName");
				backupLog.BackupLogStartTime = _ctx.StringValue("DescribeBackupLogs.Items["+ i +"].BackupLogStartTime");
				backupLog.BackupLogEndTime = _ctx.StringValue("DescribeBackupLogs.Items["+ i +"].BackupLogEndTime");
				backupLog.BackupLogSize = _ctx.StringValue("DescribeBackupLogs.Items["+ i +"].BackupLogSize");
				backupLog.DownloadLink = _ctx.StringValue("DescribeBackupLogs.Items["+ i +"].DownloadLink");
				backupLog.IntranetDownloadLink = _ctx.StringValue("DescribeBackupLogs.Items["+ i +"].IntranetDownloadLink");
				backupLog.LinkExpiredTime = _ctx.StringValue("DescribeBackupLogs.Items["+ i +"].LinkExpiredTime");

				describeBackupLogsResponse_items.Add(backupLog);
			}
			describeBackupLogsResponse.Items = describeBackupLogsResponse_items;
        
			return describeBackupLogsResponse;
        }
    }
}
