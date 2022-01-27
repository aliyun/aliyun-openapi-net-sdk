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
        public static DescribeCrossRegionBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCrossRegionBackupsResponse describeCrossRegionBackupsResponse = new DescribeCrossRegionBackupsResponse();

			describeCrossRegionBackupsResponse.HttpResponse = _ctx.HttpResponse;
			describeCrossRegionBackupsResponse.RequestId = _ctx.StringValue("DescribeCrossRegionBackups.RequestId");
			describeCrossRegionBackupsResponse.RegionId = _ctx.StringValue("DescribeCrossRegionBackups.RegionId");
			describeCrossRegionBackupsResponse.StartTime = _ctx.StringValue("DescribeCrossRegionBackups.StartTime");
			describeCrossRegionBackupsResponse.EndTime = _ctx.StringValue("DescribeCrossRegionBackups.EndTime");
			describeCrossRegionBackupsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeCrossRegionBackups.TotalRecordCount");
			describeCrossRegionBackupsResponse.PageRecordCount = _ctx.IntegerValue("DescribeCrossRegionBackups.PageRecordCount");
			describeCrossRegionBackupsResponse.PageNumber = _ctx.IntegerValue("DescribeCrossRegionBackups.PageNumber");

			List<DescribeCrossRegionBackupsResponse.DescribeCrossRegionBackups_Item> describeCrossRegionBackupsResponse_items = new List<DescribeCrossRegionBackupsResponse.DescribeCrossRegionBackups_Item>();
			for (int i = 0; i < _ctx.Length("DescribeCrossRegionBackups.Items.Length"); i++) {
				DescribeCrossRegionBackupsResponse.DescribeCrossRegionBackups_Item item = new DescribeCrossRegionBackupsResponse.DescribeCrossRegionBackups_Item();
				item.CrossBackupId = _ctx.IntegerValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupId");
				item.CrossBackupRegion = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupRegion");
				item.BackupSetStatus = _ctx.IntegerValue("DescribeCrossRegionBackups.Items["+ i +"].BackupSetStatus");
				item.BackupStartTime = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].BackupStartTime");
				item.BackupEndTime = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].BackupEndTime");
				item.BackupType = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].BackupType");
				item.BackupMethod = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].BackupMethod");
				item.CrossBackupSetSize = _ctx.LongValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupSetSize");
				item.CrossBackupSetFile = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupSetFile");
				item.CrossBackupDownloadLink = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupDownloadLink");
				item.Engine = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].Engine");
				item.EngineVersion = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].EngineVersion");
				item.CrossBackupSetLocation = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].CrossBackupSetLocation");
				item.BackupSetScale = _ctx.IntegerValue("DescribeCrossRegionBackups.Items["+ i +"].BackupSetScale");
				item.InstanceId = _ctx.IntegerValue("DescribeCrossRegionBackups.Items["+ i +"].InstanceId");
				item.DBInstanceStorageType = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].DBInstanceStorageType");
				item.Category = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].Category");
				item.ConsistentTime = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].ConsistentTime");
				item.HasBackupTableMeta = _ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].HasBackupTableMeta");

				List<string> item_restoreRegions = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCrossRegionBackups.Items["+ i +"].RestoreRegions.Length"); j++) {
					item_restoreRegions.Add(_ctx.StringValue("DescribeCrossRegionBackups.Items["+ i +"].RestoreRegions["+ j +"]"));
				}
				item.RestoreRegions = item_restoreRegions;

				describeCrossRegionBackupsResponse_items.Add(item);
			}
			describeCrossRegionBackupsResponse.Items = describeCrossRegionBackupsResponse_items;
        
			return describeCrossRegionBackupsResponse;
        }
    }
}
