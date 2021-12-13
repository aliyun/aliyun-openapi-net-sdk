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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeSQLLogFilesResponseUnmarshaller
    {
        public static DescribeSQLLogFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLLogFilesResponse describeSQLLogFilesResponse = new DescribeSQLLogFilesResponse();

			describeSQLLogFilesResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLLogFilesResponse.TotalRecordCount = _ctx.IntegerValue("DescribeSQLLogFiles.TotalRecordCount");
			describeSQLLogFilesResponse.PageRecordCount = _ctx.IntegerValue("DescribeSQLLogFiles.PageRecordCount");
			describeSQLLogFilesResponse.RequestId = _ctx.StringValue("DescribeSQLLogFiles.RequestId");
			describeSQLLogFilesResponse.PageNumber = _ctx.IntegerValue("DescribeSQLLogFiles.PageNumber");

			List<DescribeSQLLogFilesResponse.DescribeSQLLogFiles_LogFile> describeSQLLogFilesResponse_items = new List<DescribeSQLLogFilesResponse.DescribeSQLLogFiles_LogFile>();
			for (int i = 0; i < _ctx.Length("DescribeSQLLogFiles.Items.Length"); i++) {
				DescribeSQLLogFilesResponse.DescribeSQLLogFiles_LogFile logFile = new DescribeSQLLogFilesResponse.DescribeSQLLogFiles_LogFile();
				logFile.FileID = _ctx.StringValue("DescribeSQLLogFiles.Items["+ i +"].FileID");
				logFile.LogStartTime = _ctx.StringValue("DescribeSQLLogFiles.Items["+ i +"].LogStartTime");
				logFile.LogSize = _ctx.StringValue("DescribeSQLLogFiles.Items["+ i +"].LogSize");
				logFile.LogDownloadURL = _ctx.StringValue("DescribeSQLLogFiles.Items["+ i +"].LogDownloadURL");
				logFile.LogEndTime = _ctx.StringValue("DescribeSQLLogFiles.Items["+ i +"].LogEndTime");
				logFile.LogStatus = _ctx.StringValue("DescribeSQLLogFiles.Items["+ i +"].LogStatus");

				describeSQLLogFilesResponse_items.Add(logFile);
			}
			describeSQLLogFilesResponse.Items = describeSQLLogFilesResponse_items;
        
			return describeSQLLogFilesResponse;
        }
    }
}
