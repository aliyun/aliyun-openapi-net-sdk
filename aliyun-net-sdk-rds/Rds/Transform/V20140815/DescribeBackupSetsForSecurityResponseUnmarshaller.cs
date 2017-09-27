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
    public class DescribeBackupSetsForSecurityResponseUnmarshaller
    {
        public static DescribeBackupSetsForSecurityResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupSetsForSecurityResponse describeBackupSetsForSecurityResponse = new DescribeBackupSetsForSecurityResponse();

			describeBackupSetsForSecurityResponse.HttpResponse = context.HttpResponse;
			describeBackupSetsForSecurityResponse.RequestId = context.StringValue("DescribeBackupSetsForSecurity.RequestId");
			describeBackupSetsForSecurityResponse.TotalRecordCount = context.StringValue("DescribeBackupSetsForSecurity.TotalRecordCount");
			describeBackupSetsForSecurityResponse.PageNumber = context.StringValue("DescribeBackupSetsForSecurity.PageNumber");
			describeBackupSetsForSecurityResponse.PageRecordCount = context.StringValue("DescribeBackupSetsForSecurity.PageRecordCount");
			describeBackupSetsForSecurityResponse.TotalBackupSize = context.LongValue("DescribeBackupSetsForSecurity.TotalBackupSize");

			List<DescribeBackupSetsForSecurityResponse.DescribeBackupSetsForSecurity_Backup> describeBackupSetsForSecurityResponse_items = new List<DescribeBackupSetsForSecurityResponse.DescribeBackupSetsForSecurity_Backup>();
			for (int i = 0; i < context.Length("DescribeBackupSetsForSecurity.Items.Length"); i++) {
				DescribeBackupSetsForSecurityResponse.DescribeBackupSetsForSecurity_Backup backup = new DescribeBackupSetsForSecurityResponse.DescribeBackupSetsForSecurity_Backup();
				backup.BackupId = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupId");
				backup.DBInstanceId = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].DBInstanceId");
				backup.BackupStatus = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupStatus");
				backup.BackupStartTime = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupStartTime");
				backup.BackupEndTime = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupEndTime");
				backup.BackupType = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupType");
				backup.BackupMode = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupMode");
				backup.BackupMethod = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupMethod");
				backup.BackupDownloadURL = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupDownloadURL");
				backup.BackupIntranetDownloadURL = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupIntranetDownloadURL");
				backup.BackupLocation = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupLocation");
				backup.BackupExtractionStatus = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupExtractionStatus");
				backup.BackupScale = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupScale");
				backup.BackupDBNames = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupDBNames");
				backup.TotalBackupSize = context.LongValue("DescribeBackupSetsForSecurity.Items["+ i +"].TotalBackupSize");
				backup.BackupSize = context.LongValue("DescribeBackupSetsForSecurity.Items["+ i +"].BackupSize");
				backup.HostInstanceID = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].HostInstanceID");
				backup.StoreStatus = context.StringValue("DescribeBackupSetsForSecurity.Items["+ i +"].StoreStatus");

				describeBackupSetsForSecurityResponse_items.Add(backup);
			}
			describeBackupSetsForSecurityResponse.Items = describeBackupSetsForSecurityResponse_items;
        
			return describeBackupSetsForSecurityResponse;
        }
    }
}