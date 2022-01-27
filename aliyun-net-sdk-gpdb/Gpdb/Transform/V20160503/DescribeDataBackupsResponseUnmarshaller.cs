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
    public class DescribeDataBackupsResponseUnmarshaller
    {
        public static DescribeDataBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataBackupsResponse describeDataBackupsResponse = new DescribeDataBackupsResponse();

			describeDataBackupsResponse.HttpResponse = _ctx.HttpResponse;
			describeDataBackupsResponse.PageSize = _ctx.IntegerValue("DescribeDataBackups.PageSize");
			describeDataBackupsResponse.RequestId = _ctx.StringValue("DescribeDataBackups.RequestId");
			describeDataBackupsResponse.PageNumber = _ctx.IntegerValue("DescribeDataBackups.PageNumber");
			describeDataBackupsResponse.TotalCount = _ctx.IntegerValue("DescribeDataBackups.TotalCount");

			List<DescribeDataBackupsResponse.DescribeDataBackups_Backup> describeDataBackupsResponse_items = new List<DescribeDataBackupsResponse.DescribeDataBackups_Backup>();
			for (int i = 0; i < _ctx.Length("DescribeDataBackups.Items.Length"); i++) {
				DescribeDataBackupsResponse.DescribeDataBackups_Backup backup = new DescribeDataBackupsResponse.DescribeDataBackups_Backup();
				backup.DataType = _ctx.StringValue("DescribeDataBackups.Items["+ i +"].DataType");
				backup.ConsistentTime = _ctx.LongValue("DescribeDataBackups.Items["+ i +"].ConsistentTime");
				backup.BackupStatus = _ctx.StringValue("DescribeDataBackups.Items["+ i +"].BackupStatus");
				backup.BackupStartTime = _ctx.StringValue("DescribeDataBackups.Items["+ i +"].BackupStartTime");
				backup.BackupEndTime = _ctx.StringValue("DescribeDataBackups.Items["+ i +"].BackupEndTime");
				backup.BackupEndTimeLocal = _ctx.StringValue("DescribeDataBackups.Items["+ i +"].BackupEndTimeLocal");
				backup.BackupSetId = _ctx.StringValue("DescribeDataBackups.Items["+ i +"].BackupSetId");
				backup.BaksetName = _ctx.StringValue("DescribeDataBackups.Items["+ i +"].BaksetName");
				backup.BackupSize = _ctx.LongValue("DescribeDataBackups.Items["+ i +"].BackupSize");
				backup.BackupMode = _ctx.StringValue("DescribeDataBackups.Items["+ i +"].BackupMode");
				backup.BackupStartTimeLocal = _ctx.StringValue("DescribeDataBackups.Items["+ i +"].BackupStartTimeLocal");
				backup.DBInstanceId = _ctx.StringValue("DescribeDataBackups.Items["+ i +"].DBInstanceId");

				describeDataBackupsResponse_items.Add(backup);
			}
			describeDataBackupsResponse.Items = describeDataBackupsResponse_items;
        
			return describeDataBackupsResponse;
        }
    }
}
