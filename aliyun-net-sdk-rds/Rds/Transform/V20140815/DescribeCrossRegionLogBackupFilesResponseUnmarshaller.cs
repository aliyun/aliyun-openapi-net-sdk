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
    public class DescribeCrossRegionLogBackupFilesResponseUnmarshaller
    {
        public static DescribeCrossRegionLogBackupFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCrossRegionLogBackupFilesResponse describeCrossRegionLogBackupFilesResponse = new DescribeCrossRegionLogBackupFilesResponse();

			describeCrossRegionLogBackupFilesResponse.HttpResponse = _ctx.HttpResponse;
			describeCrossRegionLogBackupFilesResponse.EndTime = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.EndTime");
			describeCrossRegionLogBackupFilesResponse.StartTime = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.StartTime");
			describeCrossRegionLogBackupFilesResponse.RequestId = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.RequestId");
			describeCrossRegionLogBackupFilesResponse.PageRecordCount = _ctx.IntegerValue("DescribeCrossRegionLogBackupFiles.PageRecordCount");
			describeCrossRegionLogBackupFilesResponse.TotalRecordCount = _ctx.IntegerValue("DescribeCrossRegionLogBackupFiles.TotalRecordCount");
			describeCrossRegionLogBackupFilesResponse.DBInstanceId = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.DBInstanceId");
			describeCrossRegionLogBackupFilesResponse.PageNumber = _ctx.IntegerValue("DescribeCrossRegionLogBackupFiles.PageNumber");
			describeCrossRegionLogBackupFilesResponse.RegionId = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.RegionId");

			List<DescribeCrossRegionLogBackupFilesResponse.DescribeCrossRegionLogBackupFiles_Item> describeCrossRegionLogBackupFilesResponse_items = new List<DescribeCrossRegionLogBackupFilesResponse.DescribeCrossRegionLogBackupFiles_Item>();
			for (int i = 0; i < _ctx.Length("DescribeCrossRegionLogBackupFiles.Items.Length"); i++) {
				DescribeCrossRegionLogBackupFilesResponse.DescribeCrossRegionLogBackupFiles_Item item = new DescribeCrossRegionLogBackupFilesResponse.DescribeCrossRegionLogBackupFiles_Item();
				item.LogBeginTime = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].LogBeginTime");
				item.LinkExpiredTime = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].LinkExpiredTime");
				item.CrossIntranetDownloadLink = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].CrossIntranetDownloadLink");
				item.LogFileName = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].LogFileName");
				item.CrossBackupRegion = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].CrossBackupRegion");
				item.CrossDownloadLink = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].CrossDownloadLink");
				item.CrossLogBackupSize = _ctx.LongValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].CrossLogBackupSize");
				item.InstanceId = _ctx.IntegerValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].InstanceId");
				item.CrossLogBackupId = _ctx.IntegerValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].CrossLogBackupId");
				item.LogEndTime = _ctx.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].LogEndTime");

				describeCrossRegionLogBackupFilesResponse_items.Add(item);
			}
			describeCrossRegionLogBackupFilesResponse.Items = describeCrossRegionLogBackupFilesResponse_items;
        
			return describeCrossRegionLogBackupFilesResponse;
        }
    }
}
