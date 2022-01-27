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
    public class DescribeOssDownloadsResponseUnmarshaller
    {
        public static DescribeOssDownloadsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOssDownloadsResponse describeOssDownloadsResponse = new DescribeOssDownloadsResponse();

			describeOssDownloadsResponse.HttpResponse = _ctx.HttpResponse;
			describeOssDownloadsResponse.RequestId = _ctx.StringValue("DescribeOssDownloads.RequestId");
			describeOssDownloadsResponse.DBInstanceId = _ctx.StringValue("DescribeOssDownloads.DBInstanceId");
			describeOssDownloadsResponse.MigrateTaskId = _ctx.StringValue("DescribeOssDownloads.MigrateTaskId");

			List<DescribeOssDownloadsResponse.DescribeOssDownloads_OssDownload> describeOssDownloadsResponse_items = new List<DescribeOssDownloadsResponse.DescribeOssDownloads_OssDownload>();
			for (int i = 0; i < _ctx.Length("DescribeOssDownloads.Items.Length"); i++) {
				DescribeOssDownloadsResponse.DescribeOssDownloads_OssDownload ossDownload = new DescribeOssDownloadsResponse.DescribeOssDownloads_OssDownload();
				ossDownload.FileName = _ctx.StringValue("DescribeOssDownloads.Items["+ i +"].FileName");
				ossDownload.CreateTime = _ctx.StringValue("DescribeOssDownloads.Items["+ i +"].CreateTime");
				ossDownload.EndTime = _ctx.StringValue("DescribeOssDownloads.Items["+ i +"].EndTime");
				ossDownload.BackupMode = _ctx.StringValue("DescribeOssDownloads.Items["+ i +"].BackupMode");
				ossDownload.FileSize = _ctx.StringValue("DescribeOssDownloads.Items["+ i +"].FileSize");
				ossDownload.Status = _ctx.StringValue("DescribeOssDownloads.Items["+ i +"].Status");
				ossDownload.IsAvailable = _ctx.StringValue("DescribeOssDownloads.Items["+ i +"].IsAvailable");
				ossDownload.Description = _ctx.StringValue("DescribeOssDownloads.Items["+ i +"].Description");

				describeOssDownloadsResponse_items.Add(ossDownload);
			}
			describeOssDownloadsResponse.Items = describeOssDownloadsResponse_items;
        
			return describeOssDownloadsResponse;
        }
    }
}
