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
    public class DescribeBinlogFilesResponseUnmarshaller
    {
        public static DescribeBinlogFilesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBinlogFilesResponse describeBinlogFilesResponse = new DescribeBinlogFilesResponse();

			describeBinlogFilesResponse.HttpResponse = context.HttpResponse;
			describeBinlogFilesResponse.RequestId = context.StringValue("DescribeBinlogFiles.RequestId");
			describeBinlogFilesResponse.TotalRecordCount = context.IntegerValue("DescribeBinlogFiles.TotalRecordCount");
			describeBinlogFilesResponse.PageNumber = context.IntegerValue("DescribeBinlogFiles.PageNumber");
			describeBinlogFilesResponse.PageRecordCount = context.IntegerValue("DescribeBinlogFiles.PageRecordCount");
			describeBinlogFilesResponse.TotalFileSize = context.LongValue("DescribeBinlogFiles.TotalFileSize");

			List<DescribeBinlogFilesResponse.BinLogFile> items = new List<DescribeBinlogFilesResponse.BinLogFile>();
			for (int i = 0; i < context.Length("DescribeBinlogFiles.Items.Length"); i++) {
				DescribeBinlogFilesResponse.BinLogFile binLogFile = new DescribeBinlogFilesResponse.BinLogFile();
				binLogFile.FileSize = context.LongValue("DescribeBinlogFiles.Items["+ i +"].FileSize");
				binLogFile.LogBeginTime = context.StringValue("DescribeBinlogFiles.Items["+ i +"].LogBeginTime");
				binLogFile.LogEndTime = context.StringValue("DescribeBinlogFiles.Items["+ i +"].LogEndTime");
				binLogFile.DownloadLink = context.StringValue("DescribeBinlogFiles.Items["+ i +"].DownloadLink");
				binLogFile.IntranetDownloadLink = context.StringValue("DescribeBinlogFiles.Items["+ i +"].IntranetDownloadLink");
				binLogFile.LinkExpiredTime = context.StringValue("DescribeBinlogFiles.Items["+ i +"].LinkExpiredTime");
				binLogFile.Checksum = context.StringValue("DescribeBinlogFiles.Items["+ i +"].Checksum");
				binLogFile.HostInstanceID = context.StringValue("DescribeBinlogFiles.Items["+ i +"].HostInstanceID");

				items.Add(binLogFile);
			}
			describeBinlogFilesResponse.Items = items;
        
			return describeBinlogFilesResponse;
        }
    }
}