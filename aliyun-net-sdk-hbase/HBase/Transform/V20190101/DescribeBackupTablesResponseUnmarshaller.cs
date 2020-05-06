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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeBackupTablesResponseUnmarshaller
    {
        public static DescribeBackupTablesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupTablesResponse describeBackupTablesResponse = new DescribeBackupTablesResponse();

			describeBackupTablesResponse.HttpResponse = context.HttpResponse;
			describeBackupTablesResponse.RequestId = context.StringValue("DescribeBackupTables.RequestId");
			describeBackupTablesResponse.Total = context.LongValue("DescribeBackupTables.Total");
			describeBackupTablesResponse.PageSize = context.IntegerValue("DescribeBackupTables.PageSize");
			describeBackupTablesResponse.PageNumber = context.IntegerValue("DescribeBackupTables.PageNumber");

			List<string> describeBackupTablesResponse_tables = new List<string>();
			for (int i = 0; i < context.Length("DescribeBackupTables.Tables.Length"); i++) {
				describeBackupTablesResponse_tables.Add(context.StringValue("DescribeBackupTables.Tables["+ i +"]"));
			}
			describeBackupTablesResponse.Tables = describeBackupTablesResponse_tables;

			List<DescribeBackupTablesResponse.DescribeBackupTables_BackupRecord> describeBackupTablesResponse_backupRecords = new List<DescribeBackupTablesResponse.DescribeBackupTables_BackupRecord>();
			for (int i = 0; i < context.Length("DescribeBackupTables.BackupRecords.Length"); i++) {
				DescribeBackupTablesResponse.DescribeBackupTables_BackupRecord backupRecord = new DescribeBackupTablesResponse.DescribeBackupTables_BackupRecord();
				backupRecord.Table = context.StringValue("DescribeBackupTables.BackupRecords["+ i +"].Table");
				backupRecord.State = context.StringValue("DescribeBackupTables.BackupRecords["+ i +"].State");
				backupRecord.StartTime = context.StringValue("DescribeBackupTables.BackupRecords["+ i +"].StartTime");
				backupRecord.EndTime = context.StringValue("DescribeBackupTables.BackupRecords["+ i +"].EndTime");
				backupRecord.Process = context.StringValue("DescribeBackupTables.BackupRecords["+ i +"].Process");
				backupRecord.DataSize = context.StringValue("DescribeBackupTables.BackupRecords["+ i +"].DataSize");
				backupRecord.Speed = context.StringValue("DescribeBackupTables.BackupRecords["+ i +"].Speed");
				backupRecord.Message = context.StringValue("DescribeBackupTables.BackupRecords["+ i +"].Message");

				describeBackupTablesResponse_backupRecords.Add(backupRecord);
			}
			describeBackupTablesResponse.BackupRecords = describeBackupTablesResponse_backupRecords;
        
			return describeBackupTablesResponse;
        }
    }
}
