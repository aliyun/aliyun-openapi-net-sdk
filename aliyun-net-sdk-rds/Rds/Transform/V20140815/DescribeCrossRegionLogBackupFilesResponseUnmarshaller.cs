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
        public static DescribeCrossRegionLogBackupFilesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCrossRegionLogBackupFilesResponse describeCrossRegionLogBackupFilesResponse = new DescribeCrossRegionLogBackupFilesResponse();

			describeCrossRegionLogBackupFilesResponse.HttpResponse = context.HttpResponse;
			describeCrossRegionLogBackupFilesResponse.RequestId = context.StringValue("DescribeCrossRegionLogBackupFiles.RequestId");
			describeCrossRegionLogBackupFilesResponse.RegionId = context.StringValue("DescribeCrossRegionLogBackupFiles.RegionId");
			describeCrossRegionLogBackupFilesResponse.DBInstanceId = context.StringValue("DescribeCrossRegionLogBackupFiles.DBInstanceId");
			describeCrossRegionLogBackupFilesResponse.StartTime = context.StringValue("DescribeCrossRegionLogBackupFiles.StartTime");
			describeCrossRegionLogBackupFilesResponse.EndTime = context.StringValue("DescribeCrossRegionLogBackupFiles.EndTime");
			describeCrossRegionLogBackupFilesResponse.TotalRecordCount = context.IntegerValue("DescribeCrossRegionLogBackupFiles.TotalRecordCount");
			describeCrossRegionLogBackupFilesResponse.PageRecordCount = context.IntegerValue("DescribeCrossRegionLogBackupFiles.PageRecordCount");
			describeCrossRegionLogBackupFilesResponse.PageNumber = context.IntegerValue("DescribeCrossRegionLogBackupFiles.PageNumber");

			List<DescribeCrossRegionLogBackupFilesResponse.DescribeCrossRegionLogBackupFiles_Item> describeCrossRegionLogBackupFilesResponse_items = new List<DescribeCrossRegionLogBackupFilesResponse.DescribeCrossRegionLogBackupFiles_Item>();
			for (int i = 0; i < context.Length("DescribeCrossRegionLogBackupFiles.Items.Length"); i++) {
				DescribeCrossRegionLogBackupFilesResponse.DescribeCrossRegionLogBackupFiles_Item item = new DescribeCrossRegionLogBackupFilesResponse.DescribeCrossRegionLogBackupFiles_Item();
				item.CrossLogBackupId = context.IntegerValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].CrossLogBackupId");
				item.CrossBackupRegion = context.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].CrossBackupRegion");
				item.CrossLogBackupSize = context.LongValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].CrossLogBackupSize");
				item.LogBeginTime = context.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].LogBeginTime");
				item.LogEndTime = context.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].LogEndTime");
				item.CrossDownloadLink = context.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].CrossDownloadLink");
				item.CrossIntranetDownloadLink = context.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].CrossIntranetDownloadLink");
				item.LinkExpiredTime = context.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].LinkExpiredTime");
				item.LogFileName = context.StringValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].LogFileName");
				item.InstanceId = context.IntegerValue("DescribeCrossRegionLogBackupFiles.Items["+ i +"].InstanceId");

				describeCrossRegionLogBackupFilesResponse_items.Add(item);
			}
			describeCrossRegionLogBackupFilesResponse.Items = describeCrossRegionLogBackupFilesResponse_items;
        
			return describeCrossRegionLogBackupFilesResponse;
        }
    }
}
