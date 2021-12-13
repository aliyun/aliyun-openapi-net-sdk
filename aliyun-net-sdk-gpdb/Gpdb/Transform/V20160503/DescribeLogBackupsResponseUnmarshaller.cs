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
    public class DescribeLogBackupsResponseUnmarshaller
    {
        public static DescribeLogBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLogBackupsResponse describeLogBackupsResponse = new DescribeLogBackupsResponse();

			describeLogBackupsResponse.HttpResponse = _ctx.HttpResponse;
			describeLogBackupsResponse.TotalLogSize = _ctx.LongValue("DescribeLogBackups.TotalLogSize");
			describeLogBackupsResponse.PageSize = _ctx.IntegerValue("DescribeLogBackups.PageSize");
			describeLogBackupsResponse.PageNumber = _ctx.IntegerValue("DescribeLogBackups.PageNumber");
			describeLogBackupsResponse.RequestId = _ctx.StringValue("DescribeLogBackups.RequestId");
			describeLogBackupsResponse.TotalCount = _ctx.IntegerValue("DescribeLogBackups.TotalCount");

			List<DescribeLogBackupsResponse.DescribeLogBackups_Backup> describeLogBackupsResponse_items = new List<DescribeLogBackupsResponse.DescribeLogBackups_Backup>();
			for (int i = 0; i < _ctx.Length("DescribeLogBackups.Items.Length"); i++) {
				DescribeLogBackupsResponse.DescribeLogBackups_Backup backup = new DescribeLogBackupsResponse.DescribeLogBackups_Backup();
				backup.LogFileSize = _ctx.LongValue("DescribeLogBackups.Items["+ i +"].LogFileSize");
				backup.LogTime = _ctx.StringValue("DescribeLogBackups.Items["+ i +"].LogTime");
				backup.SegmentName = _ctx.StringValue("DescribeLogBackups.Items["+ i +"].SegmentName");
				backup.LogFileName = _ctx.StringValue("DescribeLogBackups.Items["+ i +"].LogFileName");
				backup.DBInstanceId = _ctx.StringValue("DescribeLogBackups.Items["+ i +"].DBInstanceId");
				backup.BackupId = _ctx.StringValue("DescribeLogBackups.Items["+ i +"].BackupId");

				describeLogBackupsResponse_items.Add(backup);
			}
			describeLogBackupsResponse.Items = describeLogBackupsResponse_items;
        
			return describeLogBackupsResponse;
        }
    }
}
