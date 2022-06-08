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
    public class DescribeLogBackupFilesResponseUnmarshaller
    {
        public static DescribeLogBackupFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLogBackupFilesResponse describeLogBackupFilesResponse = new DescribeLogBackupFilesResponse();

			describeLogBackupFilesResponse.HttpResponse = _ctx.HttpResponse;
			describeLogBackupFilesResponse.TotalFileSize = _ctx.LongValue("DescribeLogBackupFiles.TotalFileSize");
			describeLogBackupFilesResponse.PageNumber = _ctx.IntegerValue("DescribeLogBackupFiles.PageNumber");
			describeLogBackupFilesResponse.RequestId = _ctx.StringValue("DescribeLogBackupFiles.RequestId");
			describeLogBackupFilesResponse.PageRecordCount = _ctx.IntegerValue("DescribeLogBackupFiles.PageRecordCount");
			describeLogBackupFilesResponse.TotalRecordCount = _ctx.IntegerValue("DescribeLogBackupFiles.TotalRecordCount");

			List<DescribeLogBackupFilesResponse.DescribeLogBackupFiles_BinLogFile> describeLogBackupFilesResponse_items = new List<DescribeLogBackupFilesResponse.DescribeLogBackupFiles_BinLogFile>();
			for (int i = 0; i < _ctx.Length("DescribeLogBackupFiles.Items.Length"); i++) {
				DescribeLogBackupFilesResponse.DescribeLogBackupFiles_BinLogFile binLogFile = new DescribeLogBackupFilesResponse.DescribeLogBackupFiles_BinLogFile();
				binLogFile.LogBeginTime = _ctx.StringValue("DescribeLogBackupFiles.Items["+ i +"].LogBeginTime");
				binLogFile.IntranetDownloadLink = _ctx.StringValue("DescribeLogBackupFiles.Items["+ i +"].IntranetDownloadLink");
				binLogFile.LinkExpiredTime = _ctx.StringValue("DescribeLogBackupFiles.Items["+ i +"].LinkExpiredTime");
				binLogFile.DownloadLink = _ctx.StringValue("DescribeLogBackupFiles.Items["+ i +"].DownloadLink");
				binLogFile.LogEndTime = _ctx.StringValue("DescribeLogBackupFiles.Items["+ i +"].LogEndTime");
				binLogFile.FileSize = _ctx.LongValue("DescribeLogBackupFiles.Items["+ i +"].FileSize");

				describeLogBackupFilesResponse_items.Add(binLogFile);
			}
			describeLogBackupFilesResponse.Items = describeLogBackupFilesResponse_items;
        
			return describeLogBackupFilesResponse;
        }
    }
}
