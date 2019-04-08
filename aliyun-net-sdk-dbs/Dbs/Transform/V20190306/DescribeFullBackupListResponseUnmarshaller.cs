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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribeFullBackupListResponseUnmarshaller
    {
        public static DescribeFullBackupListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFullBackupListResponse describeFullBackupListResponse = new DescribeFullBackupListResponse();

			describeFullBackupListResponse.HttpResponse = context.HttpResponse;
			describeFullBackupListResponse.Success = context.BooleanValue("DescribeFullBackupList.Success");
			describeFullBackupListResponse.ErrCode = context.StringValue("DescribeFullBackupList.ErrCode");
			describeFullBackupListResponse.ErrMessage = context.StringValue("DescribeFullBackupList.ErrMessage");
			describeFullBackupListResponse.HttpStatusCode = context.IntegerValue("DescribeFullBackupList.HttpStatusCode");
			describeFullBackupListResponse.RequestId = context.StringValue("DescribeFullBackupList.RequestId");
			describeFullBackupListResponse.TotalPages = context.IntegerValue("DescribeFullBackupList.TotalPages");
			describeFullBackupListResponse.PageSize = context.IntegerValue("DescribeFullBackupList.PageSize");
			describeFullBackupListResponse.PageNum = context.IntegerValue("DescribeFullBackupList.PageNum");
			describeFullBackupListResponse.TotalElements = context.IntegerValue("DescribeFullBackupList.TotalElements");

			List<DescribeFullBackupListResponse.DescribeFullBackupList_FullBackupFile> describeFullBackupListResponse_items = new List<DescribeFullBackupListResponse.DescribeFullBackupList_FullBackupFile>();
			for (int i = 0; i < context.Length("DescribeFullBackupList.Items.Length"); i++) {
				DescribeFullBackupListResponse.DescribeFullBackupList_FullBackupFile fullBackupFile = new DescribeFullBackupListResponse.DescribeFullBackupList_FullBackupFile();
				fullBackupFile.BackupSetId = context.StringValue("DescribeFullBackupList.Items["+ i +"].BackupSetId");
				fullBackupFile.SourceEndpointIpPort = context.StringValue("DescribeFullBackupList.Items["+ i +"].SourceEndpointIpPort");
				fullBackupFile.StartTime = context.LongValue("DescribeFullBackupList.Items["+ i +"].StartTime");
				fullBackupFile.EndTime = context.LongValue("DescribeFullBackupList.Items["+ i +"].EndTime");
				fullBackupFile.BackupStatus = context.StringValue("DescribeFullBackupList.Items["+ i +"].BackupStatus");
				fullBackupFile.BackupSetExpiredTime = context.LongValue("DescribeFullBackupList.Items["+ i +"].BackupSetExpiredTime");
				fullBackupFile.BackupSize = context.LongValue("DescribeFullBackupList.Items["+ i +"].BackupSize");
				fullBackupFile.StorageMethod = context.StringValue("DescribeFullBackupList.Items["+ i +"].StorageMethod");

				describeFullBackupListResponse_items.Add(fullBackupFile);
			}
			describeFullBackupListResponse.Items = describeFullBackupListResponse_items;
        
			return describeFullBackupListResponse;
        }
    }
}
