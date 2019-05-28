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
    public class DescribeOssDownloadsForSQLServerResponseUnmarshaller
    {
        public static DescribeOssDownloadsForSQLServerResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOssDownloadsForSQLServerResponse describeOssDownloadsForSQLServerResponse = new DescribeOssDownloadsForSQLServerResponse();

			describeOssDownloadsForSQLServerResponse.HttpResponse = context.HttpResponse;
			describeOssDownloadsForSQLServerResponse.RequestId = context.StringValue("DescribeOssDownloadsForSQLServer.RequestId");
			describeOssDownloadsForSQLServerResponse.DBInstanceName = context.StringValue("DescribeOssDownloadsForSQLServer.DBInstanceName");
			describeOssDownloadsForSQLServerResponse.MigrateIaskId = context.StringValue("DescribeOssDownloadsForSQLServer.MigrateIaskId");

			List<DescribeOssDownloadsForSQLServerResponse.DescribeOssDownloadsForSQLServer_OssDownload> describeOssDownloadsForSQLServerResponse_items = new List<DescribeOssDownloadsForSQLServerResponse.DescribeOssDownloadsForSQLServer_OssDownload>();
			for (int i = 0; i < context.Length("DescribeOssDownloadsForSQLServer.Items.Length"); i++) {
				DescribeOssDownloadsForSQLServerResponse.DescribeOssDownloadsForSQLServer_OssDownload ossDownload = new DescribeOssDownloadsForSQLServerResponse.DescribeOssDownloadsForSQLServer_OssDownload();
				ossDownload.FileName = context.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].FileName");
				ossDownload.CreateTime = context.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].CreateTime");
				ossDownload.CreateTime1 = context.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].CreateTime");
				ossDownload.BakType = context.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].BakType");
				ossDownload.FileSize = context.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].FileSize");
				ossDownload.Status = context.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].Status");
				ossDownload.IsAvail = context.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].IsAvail");
				ossDownload.Desc = context.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].Desc");

				describeOssDownloadsForSQLServerResponse_items.Add(ossDownload);
			}
			describeOssDownloadsForSQLServerResponse.Items = describeOssDownloadsForSQLServerResponse_items;
        
			return describeOssDownloadsForSQLServerResponse;
        }
    }
}
