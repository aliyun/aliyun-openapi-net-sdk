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
    public class DescribeBinlogFilesResponseUnmarshaller
    {
        public static DescribeBinlogFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBinlogFilesResponse describeBinlogFilesResponse = new DescribeBinlogFilesResponse();

			describeBinlogFilesResponse.HttpResponse = _ctx.HttpResponse;
			describeBinlogFilesResponse.TotalFileSize = _ctx.LongValue("DescribeBinlogFiles.TotalFileSize");
			describeBinlogFilesResponse.PageNumber = _ctx.IntegerValue("DescribeBinlogFiles.PageNumber");
			describeBinlogFilesResponse.RequestId = _ctx.StringValue("DescribeBinlogFiles.RequestId");
			describeBinlogFilesResponse.PageRecordCount = _ctx.IntegerValue("DescribeBinlogFiles.PageRecordCount");
			describeBinlogFilesResponse.TotalRecordCount = _ctx.IntegerValue("DescribeBinlogFiles.TotalRecordCount");

			List<DescribeBinlogFilesResponse.DescribeBinlogFiles_BinLogFile> describeBinlogFilesResponse_items = new List<DescribeBinlogFilesResponse.DescribeBinlogFiles_BinLogFile>();
			for (int i = 0; i < _ctx.Length("DescribeBinlogFiles.Items.Length"); i++) {
				DescribeBinlogFilesResponse.DescribeBinlogFiles_BinLogFile binLogFile = new DescribeBinlogFilesResponse.DescribeBinlogFiles_BinLogFile();
				binLogFile.RemoteStatus = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].RemoteStatus");
				binLogFile.IntranetDownloadLink = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].IntranetDownloadLink");
				binLogFile.LogBeginTime = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].LogBeginTime");
				binLogFile.LinkExpiredTime = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].LinkExpiredTime");
				binLogFile.DownloadLink = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].DownloadLink");
				binLogFile.LogFileName = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].LogFileName");
				binLogFile.Checksum = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].Checksum");
				binLogFile.LogEndTime = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].LogEndTime");
				binLogFile.HostInstanceID = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].HostInstanceID");
				binLogFile.FileSize = _ctx.LongValue("DescribeBinlogFiles.Items["+ i +"].FileSize");

				describeBinlogFilesResponse_items.Add(binLogFile);
			}
			describeBinlogFilesResponse.Items = describeBinlogFilesResponse_items;
        
			return describeBinlogFilesResponse;
        }
    }
}
