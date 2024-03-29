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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDetachedBackupsResponseUnmarshaller
    {
        public static DescribeDetachedBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDetachedBackupsResponse describeDetachedBackupsResponse = new DescribeDetachedBackupsResponse();

			describeDetachedBackupsResponse.HttpResponse = _ctx.HttpResponse;
			describeDetachedBackupsResponse.TotalBackupSize = _ctx.LongValue("DescribeDetachedBackups.TotalBackupSize");
			describeDetachedBackupsResponse.PageNumber = _ctx.StringValue("DescribeDetachedBackups.PageNumber");
			describeDetachedBackupsResponse.RequestId = _ctx.StringValue("DescribeDetachedBackups.RequestId");
			describeDetachedBackupsResponse.PageRecordCount = _ctx.StringValue("DescribeDetachedBackups.PageRecordCount");
			describeDetachedBackupsResponse.TotalRecordCount = _ctx.StringValue("DescribeDetachedBackups.TotalRecordCount");

			List<DescribeDetachedBackupsResponse.DescribeDetachedBackups_Backup> describeDetachedBackupsResponse_items = new List<DescribeDetachedBackupsResponse.DescribeDetachedBackups_Backup>();
			for (int i = 0; i < _ctx.Length("DescribeDetachedBackups.Items.Length"); i++) {
				DescribeDetachedBackupsResponse.DescribeDetachedBackups_Backup backup = new DescribeDetachedBackupsResponse.DescribeDetachedBackups_Backup();
				backup.SlaveStatus = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].SlaveStatus");
				backup.ConsistentTime = _ctx.LongValue("DescribeDetachedBackups.Items["+ i +"].ConsistentTime");
				backup.StoreStatus = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].StoreStatus");
				backup.BackupStatus = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupStatus");
				backup.BackupLocation = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupLocation");
				backup.BackupType = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupType");
				backup.BackupStartTime = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupStartTime");
				backup.TotalBackupSize = _ctx.LongValue("DescribeDetachedBackups.Items["+ i +"].TotalBackupSize");
				backup.BackupDownloadURL = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupDownloadURL");
				backup.IsAvail = _ctx.IntegerValue("DescribeDetachedBackups.Items["+ i +"].IsAvail");
				backup.MetaStatus = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].MetaStatus");
				backup.BackupEndTime = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupEndTime");
				backup.BackupDBNames = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupDBNames");
				backup.BackupScale = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupScale");
				backup.BackupId = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupId");
				backup.HostInstanceID = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].HostInstanceID");
				backup.BackupIntranetDownloadURL = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupIntranetDownloadURL");
				backup.BackupSize = _ctx.LongValue("DescribeDetachedBackups.Items["+ i +"].BackupSize");
				backup.BackupMode = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupMode");
				backup.DBInstanceId = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].DBInstanceId");
				backup.DBInstanceComment = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].DBInstanceComment");
				backup.BackupExtractionStatus = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupExtractionStatus");
				backup.BackupMethod = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupMethod");

				describeDetachedBackupsResponse_items.Add(backup);
			}
			describeDetachedBackupsResponse.Items = describeDetachedBackupsResponse_items;
        
			return describeDetachedBackupsResponse;
        }
    }
}
