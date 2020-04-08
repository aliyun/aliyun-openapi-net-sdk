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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeBackupsResponseUnmarshaller
    {
        public static DescribeBackupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupsResponse describeBackupsResponse = new DescribeBackupsResponse();

			describeBackupsResponse.HttpResponse = context.HttpResponse;
			describeBackupsResponse.RequestId = context.StringValue("DescribeBackups.RequestId");

			List<DescribeBackupsResponse.DescribeBackups_Backup> describeBackupsResponse_backups = new List<DescribeBackupsResponse.DescribeBackups_Backup>();
			for (int i = 0; i < context.Length("DescribeBackups.Backups.Length"); i++) {
				DescribeBackupsResponse.DescribeBackups_Backup backup = new DescribeBackupsResponse.DescribeBackups_Backup();
				backup.ClusterId = context.StringValue("DescribeBackups.Backups["+ i +"].ClusterId");
				backup.DataCenterId = context.StringValue("DescribeBackups.Backups["+ i +"].DataCenterId");
				backup.BackupId = context.StringValue("DescribeBackups.Backups["+ i +"].BackupId");
				backup.BackupType = context.StringValue("DescribeBackups.Backups["+ i +"].BackupType");
				backup.Status = context.StringValue("DescribeBackups.Backups["+ i +"].Status");
				backup.StartTime = context.StringValue("DescribeBackups.Backups["+ i +"].StartTime");
				backup.EndTime = context.StringValue("DescribeBackups.Backups["+ i +"].EndTime");
				backup.Size = context.LongValue("DescribeBackups.Backups["+ i +"].Size");

				describeBackupsResponse_backups.Add(backup);
			}
			describeBackupsResponse.Backups = describeBackupsResponse_backups;
        
			return describeBackupsResponse;
        }
    }
}
