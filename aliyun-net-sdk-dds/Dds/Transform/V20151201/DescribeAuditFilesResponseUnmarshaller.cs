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
    public class DescribeAuditFilesResponseUnmarshaller
    {
        public static DescribeAuditFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAuditFilesResponse describeAuditFilesResponse = new DescribeAuditFilesResponse();

			describeAuditFilesResponse.HttpResponse = _ctx.HttpResponse;
			describeAuditFilesResponse.RequestId = _ctx.StringValue("DescribeAuditFiles.RequestId");
			describeAuditFilesResponse.TotalRecordCount = _ctx.IntegerValue("DescribeAuditFiles.TotalRecordCount");
			describeAuditFilesResponse.PageNumber = _ctx.IntegerValue("DescribeAuditFiles.PageNumber");
			describeAuditFilesResponse.PageRecordCount = _ctx.IntegerValue("DescribeAuditFiles.PageRecordCount");
			describeAuditFilesResponse.DBInstanceId = _ctx.StringValue("DescribeAuditFiles.DBInstanceId");

			List<DescribeAuditFilesResponse.DescribeAuditFiles_LogFile> describeAuditFilesResponse_items = new List<DescribeAuditFilesResponse.DescribeAuditFiles_LogFile>();
			for (int i = 0; i < _ctx.Length("DescribeAuditFiles.Items.Length"); i++) {
				DescribeAuditFilesResponse.DescribeAuditFiles_LogFile logFile = new DescribeAuditFilesResponse.DescribeAuditFiles_LogFile();
				logFile.FileID = _ctx.IntegerValue("DescribeAuditFiles.Items["+ i +"].FileID");
				logFile.LogStatus = _ctx.StringValue("DescribeAuditFiles.Items["+ i +"].LogStatus");
				logFile.LogStartTime = _ctx.StringValue("DescribeAuditFiles.Items["+ i +"].LogStartTime");
				logFile.LogEndTime = _ctx.StringValue("DescribeAuditFiles.Items["+ i +"].LogEndTime");
				logFile.LogDownloadURL = _ctx.StringValue("DescribeAuditFiles.Items["+ i +"].LogDownloadURL");
				logFile.LogSize = _ctx.LongValue("DescribeAuditFiles.Items["+ i +"].LogSize");

				describeAuditFilesResponse_items.Add(logFile);
			}
			describeAuditFilesResponse.Items = describeAuditFilesResponse_items;
        
			return describeAuditFilesResponse;
        }
    }
}
