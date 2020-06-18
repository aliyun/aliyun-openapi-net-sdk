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
    public class DescribeCrossRegionBackupsResponseUnmarshaller
    {
        public static DescribeCrossRegionBackupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCrossRegionBackupsResponse describeCrossRegionBackupsResponse = new DescribeCrossRegionBackupsResponse();

			describeCrossRegionBackupsResponse.HttpResponse = context.HttpResponse;
			describeCrossRegionBackupsResponse.RequestId = context.StringValue("DescribeCrossRegionBackups.RequestId");
			describeCrossRegionBackupsResponse.RegionId = context.StringValue("DescribeCrossRegionBackups.RegionId");
			describeCrossRegionBackupsResponse.StartTime = context.StringValue("DescribeCrossRegionBackups.StartTime");
			describeCrossRegionBackupsResponse.EndTime = context.StringValue("DescribeCrossRegionBackups.EndTime");
			describeCrossRegionBackupsResponse.TotalRecordCount = context.IntegerValue("DescribeCrossRegionBackups.TotalRecordCount");
			describeCrossRegionBackupsResponse.PageRecordCount = context.IntegerValue("DescribeCrossRegionBackups.PageRecordCount");
			describeCrossRegionBackupsResponse.PageNumber = context.IntegerValue("DescribeCrossRegionBackups.PageNumber");

			List<DescribeCrossRegionBackupsResponse.DescribeCrossRegionBackups_Item> describeCrossRegionBackupsResponse_items = new List<DescribeCrossRegionBackupsResponse.DescribeCrossRegionBackups_Item>();
			for (int i = 0; i < context.Length("DescribeCrossRegionBackups.Items.Length"); i++) {
				DescribeCrossRegionBackupsResponse.DescribeCrossRegionBackups_Item item = new DescribeCrossRegionBackupsResponse.DescribeCrossRegionBackups_Item();
				item.CrossBackupId = context.IntegerValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupId");
				item.CrossBackupRegion = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupRegion");
				item.BackupSetStatus = context.IntegerValue("DescribeCrossRegionBackups.Items["+ i +"].BackupSetStatus");
				item.BackupStartTime = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].BackupStartTime");
				item.BackupEndTime = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].BackupEndTime");
				item.BackupType = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].BackupType");
				item.BackupMethod = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].BackupMethod");
				item.CrossBackupSetSize = context.LongValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupSetSize");
				item.CrossBackupSetFile = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupSetFile");
				item.CrossBackupDownloadLink = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupDownloadLink");
				item.Engine = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].Engine");
				item.EngineVersion = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].EngineVersion");
				item.CrossBackupSetLocation = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupSetLocation");
				item.BackupSetScale = context.IntegerValue("DescribeCrossRegionBackups.Items["+ i +"].BackupSetScale");
				item.InstanceId = context.IntegerValue("DescribeCrossRegionBackups.Items["+ i +"].InstanceId");
				item.DBInstanceStorageType = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].DBInstanceStorageType");
				item.Category = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].Category");
				item.ConsistentTime = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].ConsistentTime");
				item.HasBackupTableMeta = context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].HasBackupTableMeta");

				List<string> item_restoreRegions = new List<string>();
				for (int j = 0; j < context.Length("DescribeCrossRegionBackups.Items["+ i +"].RestoreRegions.Length"); j++) {
					item_restoreRegions.Add(context.StringValue("DescribeCrossRegionBackups.Items["+ i +"].RestoreRegions["+ j +"]"));
				}
				item.RestoreRegions = item_restoreRegions;

				describeCrossRegionBackupsResponse_items.Add(item);
			}
			describeCrossRegionBackupsResponse.Items = describeCrossRegionBackupsResponse_items;
        
			return describeCrossRegionBackupsResponse;
        }
    }
}
