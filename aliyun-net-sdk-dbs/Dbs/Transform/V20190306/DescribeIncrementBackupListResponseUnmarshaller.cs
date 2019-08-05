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
    public class DescribeIncrementBackupListResponseUnmarshaller
    {
        public static DescribeIncrementBackupListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIncrementBackupListResponse describeIncrementBackupListResponse = new DescribeIncrementBackupListResponse();

			describeIncrementBackupListResponse.HttpResponse = context.HttpResponse;
			describeIncrementBackupListResponse.Success = context.BooleanValue("DescribeIncrementBackupList.Success");
			describeIncrementBackupListResponse.ErrCode = context.StringValue("DescribeIncrementBackupList.ErrCode");
			describeIncrementBackupListResponse.ErrMessage = context.StringValue("DescribeIncrementBackupList.ErrMessage");
			describeIncrementBackupListResponse.HttpStatusCode = context.IntegerValue("DescribeIncrementBackupList.HttpStatusCode");
			describeIncrementBackupListResponse.RequestId = context.StringValue("DescribeIncrementBackupList.RequestId");
			describeIncrementBackupListResponse.TotalPages = context.IntegerValue("DescribeIncrementBackupList.TotalPages");
			describeIncrementBackupListResponse.PageSize = context.IntegerValue("DescribeIncrementBackupList.PageSize");
			describeIncrementBackupListResponse.PageNum = context.IntegerValue("DescribeIncrementBackupList.PageNum");
			describeIncrementBackupListResponse.TotalElements = context.IntegerValue("DescribeIncrementBackupList.TotalElements");

			List<DescribeIncrementBackupListResponse.DescribeIncrementBackupList_IncrementBackupFile> describeIncrementBackupListResponse_items = new List<DescribeIncrementBackupListResponse.DescribeIncrementBackupList_IncrementBackupFile>();
			for (int i = 0; i < context.Length("DescribeIncrementBackupList.Items.Length"); i++) {
				DescribeIncrementBackupListResponse.DescribeIncrementBackupList_IncrementBackupFile incrementBackupFile = new DescribeIncrementBackupListResponse.DescribeIncrementBackupList_IncrementBackupFile();
				incrementBackupFile.BackupSetId = context.StringValue("DescribeIncrementBackupList.Items["+ i +"].BackupSetId");
				incrementBackupFile.SourceEndpointIpPort = context.StringValue("DescribeIncrementBackupList.Items["+ i +"].SourceEndpointIpPort");
				incrementBackupFile.StartTime = context.LongValue("DescribeIncrementBackupList.Items["+ i +"].StartTime");
				incrementBackupFile.EndTime = context.LongValue("DescribeIncrementBackupList.Items["+ i +"].EndTime");
				incrementBackupFile.BackupStatus = context.StringValue("DescribeIncrementBackupList.Items["+ i +"].BackupStatus");
				incrementBackupFile.BackupSetExpiredTime = context.LongValue("DescribeIncrementBackupList.Items["+ i +"].BackupSetExpiredTime");
				incrementBackupFile.BackupSize = context.LongValue("DescribeIncrementBackupList.Items["+ i +"].BackupSize");
				incrementBackupFile.StorageMethod = context.StringValue("DescribeIncrementBackupList.Items["+ i +"].StorageMethod");

				describeIncrementBackupListResponse_items.Add(incrementBackupFile);
			}
			describeIncrementBackupListResponse.Items = describeIncrementBackupListResponse_items;
        
			return describeIncrementBackupListResponse;
        }
    }
}
