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
    public class DescribeBackupsResponseUnmarshaller
    {
        public static DescribeBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupsResponse describeBackupsResponse = new DescribeBackupsResponse();

			describeBackupsResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupsResponse.RequestId = _ctx.StringValue("DescribeBackups.RequestId");
			describeBackupsResponse.TotalRecordCount = _ctx.StringValue("DescribeBackups.TotalRecordCount");
			describeBackupsResponse.PageNumber = _ctx.StringValue("DescribeBackups.PageNumber");
			describeBackupsResponse.PageRecordCount = _ctx.StringValue("DescribeBackups.PageRecordCount");

			List<DescribeBackupsResponse.DescribeBackups_Backup> describeBackupsResponse_items = new List<DescribeBackupsResponse.DescribeBackups_Backup>();
			for (int i = 0; i < _ctx.Length("DescribeBackups.Items.Length"); i++) {
				DescribeBackupsResponse.DescribeBackups_Backup backup = new DescribeBackupsResponse.DescribeBackups_Backup();
				backup.BackupId = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupId");
				backup.DBClusterId = _ctx.StringValue("DescribeBackups.Items["+ i +"].DBClusterId");
				backup.BackupStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupStatus");
				backup.BackupStartTime = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupStartTime");
				backup.BackupEndTime = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupEndTime");
				backup.BackupType = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupType");
				backup.BackupMode = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupMode");
				backup.BackupMethod = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupMethod");
				backup.StoreStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].StoreStatus");
				backup.BackupSetSize = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupSetSize");
				backup.ConsistentTime = _ctx.StringValue("DescribeBackups.Items["+ i +"].ConsistentTime");
				backup.BackupsLevel = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupsLevel");
				backup.IsAvail = _ctx.StringValue("DescribeBackups.Items["+ i +"].IsAvail");

				describeBackupsResponse_items.Add(backup);
			}
			describeBackupsResponse.Items = describeBackupsResponse_items;
        
			return describeBackupsResponse;
        }
    }
}
