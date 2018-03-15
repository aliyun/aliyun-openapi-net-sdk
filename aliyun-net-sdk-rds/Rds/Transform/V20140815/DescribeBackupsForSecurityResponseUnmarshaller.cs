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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeBackupsForSecurityResponseUnmarshaller
    {
        public static DescribeBackupsForSecurityResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupsForSecurityResponse describeBackupsForSecurityResponse = new DescribeBackupsForSecurityResponse();

			describeBackupsForSecurityResponse.HttpResponse = context.HttpResponse;
			describeBackupsForSecurityResponse.RequestId = context.StringValue("DescribeBackupsForSecurity.RequestId");
			describeBackupsForSecurityResponse.TotalRecordCount = context.StringValue("DescribeBackupsForSecurity.TotalRecordCount");
			describeBackupsForSecurityResponse.PageNumber = context.StringValue("DescribeBackupsForSecurity.PageNumber");
			describeBackupsForSecurityResponse.PageRecordCount = context.StringValue("DescribeBackupsForSecurity.PageRecordCount");
			describeBackupsForSecurityResponse.TotalBackupSize = context.LongValue("DescribeBackupsForSecurity.TotalBackupSize");

			List<DescribeBackupsForSecurityResponse.DescribeBackupsForSecurity_Backup> describeBackupsForSecurityResponse_items = new List<DescribeBackupsForSecurityResponse.DescribeBackupsForSecurity_Backup>();
			for (int i = 0; i < context.Length("DescribeBackupsForSecurity.Items.Length"); i++) {
				DescribeBackupsForSecurityResponse.DescribeBackupsForSecurity_Backup backup = new DescribeBackupsForSecurityResponse.DescribeBackupsForSecurity_Backup();
				backup.BackupId = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupId");
				backup.DBInstanceId = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].DBInstanceId");
				backup.BackupStatus = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupStatus");
				backup.BackupStartTime = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupStartTime");
				backup.BackupEndTime = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupEndTime");
				backup.BackupType = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupType");
				backup.BackupMode = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupMode");
				backup.BackupMethod = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupMethod");
				backup.BackupDownloadURL = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupDownloadURL");
				backup.BackupIntranetDownloadURL = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupIntranetDownloadURL");
				backup.BackupLocation = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupLocation");
				backup.BackupExtractionStatus = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupExtractionStatus");
				backup.BackupScale = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupScale");
				backup.BackupDBNames = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].BackupDBNames");
				backup.TotalBackupSize = context.LongValue("DescribeBackupsForSecurity.Items["+ i +"].TotalBackupSize");
				backup.BackupSize = context.LongValue("DescribeBackupsForSecurity.Items["+ i +"].BackupSize");
				backup.HostInstanceID = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].HostInstanceID");
				backup.StoreStatus = context.StringValue("DescribeBackupsForSecurity.Items["+ i +"].StoreStatus");

				describeBackupsForSecurityResponse_items.Add(backup);
			}
			describeBackupsForSecurityResponse.Items = describeBackupsForSecurityResponse_items;
        
			return describeBackupsForSecurityResponse;
        }
    }
}