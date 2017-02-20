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
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeBackupsResponseUnmarshaller
    {
        public static DescribeBackupsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeBackupsResponse describeBackupsResponse = new DescribeBackupsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeBackups.RequestId"),
                TotalRecordCount = context.StringValue("DescribeBackups.TotalRecordCount"),
                PageNumber = context.StringValue("DescribeBackups.PageNumber"),
                PageRecordCount = context.StringValue("DescribeBackups.PageRecordCount")
            };
            List<DescribeBackupsResponse.Backup> items = new List<DescribeBackupsResponse.Backup>();
			for (int i = 0; i < context.Length("DescribeBackups.Items.Length"); i++) {
                DescribeBackupsResponse.Backup backup = new DescribeBackupsResponse.Backup()
                {
                    BackupId = context.StringValue($"DescribeBackups.Items[{i}].BackupId"),
                    DBInstanceId = context.StringValue($"DescribeBackups.Items[{i}].DBInstanceId"),
                    BackupStatus = context.EnumValue<DescribeBackupsResponse.Backup.BackupStatusEnum>($"DescribeBackups.Items[{i}].BackupStatus"),
                    BackupStartTime = context.StringValue($"DescribeBackups.Items[{i}].BackupStartTime"),
                    BackupEndTime = context.StringValue($"DescribeBackups.Items[{i}].BackupEndTime"),
                    BackupType = context.EnumValue<DescribeBackupsResponse.Backup.BackupTypeEnum>($"DescribeBackups.Items[{i}].BackupType"),
                    BackupMode = context.EnumValue<DescribeBackupsResponse.Backup.BackupModeEnum>($"DescribeBackups.Items[{i}].BackupMode"),
                    BackupMethod = context.EnumValue<DescribeBackupsResponse.Backup.BackupMethodEnum>($"DescribeBackups.Items[{i}].BackupMethod"),
                    BackupDownloadURL = context.StringValue($"DescribeBackups.Items[{i}].BackupDownloadURL"),
                    BackupLocation = context.StringValue($"DescribeBackups.Items[{i}].BackupLocation"),
                    BackupExtractionStatus = context.EnumValue<DescribeBackupsResponse.Backup.BackupExtractionStatusEnum>($"DescribeBackups.Items[{i}].BackupExtractionStatus"),
                    BackupScale = context.EnumValue<DescribeBackupsResponse.Backup.BackupScaleEnum>($"DescribeBackups.Items[{i}].BackupScale"),
                    BackupDBNames = context.StringValue($"DescribeBackups.Items[{i}].BackupDBNames"),
                    BackupSize = context.LongValue($"DescribeBackups.Items[{i}].BackupSize")
                };
                items.Add(backup);
			}
			describeBackupsResponse.Items = items;
        
			return describeBackupsResponse;
        }
    }
}