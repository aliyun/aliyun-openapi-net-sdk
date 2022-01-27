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
        public static DescribeOssDownloadsForSQLServerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOssDownloadsForSQLServerResponse describeOssDownloadsForSQLServerResponse = new DescribeOssDownloadsForSQLServerResponse();

			describeOssDownloadsForSQLServerResponse.HttpResponse = _ctx.HttpResponse;
			describeOssDownloadsForSQLServerResponse.RequestId = _ctx.StringValue("DescribeOssDownloadsForSQLServer.RequestId");
			describeOssDownloadsForSQLServerResponse.DBInstanceName = _ctx.StringValue("DescribeOssDownloadsForSQLServer.DBInstanceName");
			describeOssDownloadsForSQLServerResponse.MigrateIaskId = _ctx.StringValue("DescribeOssDownloadsForSQLServer.MigrateIaskId");

			List<DescribeOssDownloadsForSQLServerResponse.DescribeOssDownloadsForSQLServer_OssDownload> describeOssDownloadsForSQLServerResponse_items = new List<DescribeOssDownloadsForSQLServerResponse.DescribeOssDownloadsForSQLServer_OssDownload>();
			for (int i = 0; i < _ctx.Length("DescribeOssDownloadsForSQLServer.Items.Length"); i++) {
				DescribeOssDownloadsForSQLServerResponse.DescribeOssDownloadsForSQLServer_OssDownload ossDownload = new DescribeOssDownloadsForSQLServerResponse.DescribeOssDownloadsForSQLServer_OssDownload();
				ossDownload.FileName = _ctx.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].FileName");
				ossDownload.CreateTime = _ctx.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].CreateTime");
				ossDownload.CreateTime1 = _ctx.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].CreateTime");
				ossDownload.BakType = _ctx.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].BakType");
				ossDownload.FileSize = _ctx.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].FileSize");
				ossDownload.Status = _ctx.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].Status");
				ossDownload.IsAvail = _ctx.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].IsAvail");
				ossDownload.Desc = _ctx.StringValue("DescribeOssDownloadsForSQLServer.Items["+ i +"].Desc");

				describeOssDownloadsForSQLServerResponse_items.Add(ossDownload);
			}
			describeOssDownloadsForSQLServerResponse.Items = describeOssDownloadsForSQLServerResponse_items;
        
			return describeOssDownloadsForSQLServerResponse;
        }
    }
}
