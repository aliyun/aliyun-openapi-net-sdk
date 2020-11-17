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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDetachedBackupsResponseUnmarshaller
    {
        public static DescribeDetachedBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDetachedBackupsResponse describeDetachedBackupsResponse = new DescribeDetachedBackupsResponse();

			describeDetachedBackupsResponse.HttpResponse = _ctx.HttpResponse;
			describeDetachedBackupsResponse.RequestId = _ctx.StringValue("DescribeDetachedBackups.RequestId");
			describeDetachedBackupsResponse.TotalRecordCount = _ctx.StringValue("DescribeDetachedBackups.TotalRecordCount");
			describeDetachedBackupsResponse.PageNumber = _ctx.StringValue("DescribeDetachedBackups.PageNumber");
			describeDetachedBackupsResponse.PageRecordCount = _ctx.StringValue("DescribeDetachedBackups.PageRecordCount");

			List<DescribeDetachedBackupsResponse.DescribeDetachedBackups_Backup> describeDetachedBackupsResponse_items = new List<DescribeDetachedBackupsResponse.DescribeDetachedBackups_Backup>();
			for (int i = 0; i < _ctx.Length("DescribeDetachedBackups.Items.Length"); i++) {
				DescribeDetachedBackupsResponse.DescribeDetachedBackups_Backup backup = new DescribeDetachedBackupsResponse.DescribeDetachedBackups_Backup();
				backup.BackupId = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupId");
				backup.DBClusterId = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].DBClusterId");
				backup.BackupStatus = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupStatus");
				backup.BackupStartTime = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupStartTime");
				backup.BackupEndTime = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupEndTime");
				backup.BackupType = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupType");
				backup.BackupMode = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupMode");
				backup.BackupMethod = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupMethod");
				backup.StoreStatus = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].StoreStatus");
				backup.BackupSetSize = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupSetSize");
				backup.ConsistentTime = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].ConsistentTime");
				backup.BackupsLevel = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].BackupsLevel");
				backup.IsAvail = _ctx.StringValue("DescribeDetachedBackups.Items["+ i +"].IsAvail");

				describeDetachedBackupsResponse_items.Add(backup);
			}
			describeDetachedBackupsResponse.Items = describeDetachedBackupsResponse_items;
        
			return describeDetachedBackupsResponse;
        }
    }
}
