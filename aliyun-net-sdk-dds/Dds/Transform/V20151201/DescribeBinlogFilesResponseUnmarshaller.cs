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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeBinlogFilesResponseUnmarshaller
    {
        public static DescribeBinlogFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBinlogFilesResponse describeBinlogFilesResponse = new DescribeBinlogFilesResponse();

			describeBinlogFilesResponse.HttpResponse = _ctx.HttpResponse;
			describeBinlogFilesResponse.RequestId = _ctx.StringValue("DescribeBinlogFiles.RequestId");
			describeBinlogFilesResponse.PageNumber = _ctx.IntegerValue("DescribeBinlogFiles.PageNumber");
			describeBinlogFilesResponse.MaxRecordsPerPage = _ctx.IntegerValue("DescribeBinlogFiles.MaxRecordsPerPage");
			describeBinlogFilesResponse.TotalRecordCount = _ctx.IntegerValue("DescribeBinlogFiles.TotalRecordCount");

			List<DescribeBinlogFilesResponse.DescribeBinlogFiles_LogFile> describeBinlogFilesResponse_items = new List<DescribeBinlogFilesResponse.DescribeBinlogFiles_LogFile>();
			for (int i = 0; i < _ctx.Length("DescribeBinlogFiles.Items.Length"); i++) {
				DescribeBinlogFilesResponse.DescribeBinlogFiles_LogFile logFile = new DescribeBinlogFilesResponse.DescribeBinlogFiles_LogFile();
				logFile.LogFileName = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].LogFileName");
				logFile.DumpDownloadURL = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].DumpDownloadURL");
				logFile.LogBeginTime = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].LogBeginTime");
				logFile.DumpBucket = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].DumpBucket");
				logFile.LinkExpiredTime = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].LinkExpiredTime");
				logFile.DownloadLink = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].DownloadLink");
				logFile.OSSEndpoint = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].OSSEndpoint");
				logFile.LogEndTime = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].LogEndTime");
				logFile.DumpState = _ctx.IntegerValue("DescribeBinlogFiles.Items["+ i +"].DumpState");
				logFile.FileSize = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].FileSize");
				logFile.FileId = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].FileId");
				logFile.BinLogId = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].BinLogId");
				logFile.LogStatus = _ctx.StringValue("DescribeBinlogFiles.Items["+ i +"].LogStatus");

				describeBinlogFilesResponse_items.Add(logFile);
			}
			describeBinlogFilesResponse.Items = describeBinlogFilesResponse_items;
        
			return describeBinlogFilesResponse;
        }
    }
}
