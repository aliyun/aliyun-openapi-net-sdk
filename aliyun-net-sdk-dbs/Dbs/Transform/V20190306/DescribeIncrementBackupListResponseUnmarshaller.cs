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
        public static DescribeIncrementBackupListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIncrementBackupListResponse describeIncrementBackupListResponse = new DescribeIncrementBackupListResponse();

			describeIncrementBackupListResponse.HttpResponse = _ctx.HttpResponse;
			describeIncrementBackupListResponse.Success = _ctx.BooleanValue("DescribeIncrementBackupList.Success");
			describeIncrementBackupListResponse.ErrCode = _ctx.StringValue("DescribeIncrementBackupList.ErrCode");
			describeIncrementBackupListResponse.ErrMessage = _ctx.StringValue("DescribeIncrementBackupList.ErrMessage");
			describeIncrementBackupListResponse.HttpStatusCode = _ctx.IntegerValue("DescribeIncrementBackupList.HttpStatusCode");
			describeIncrementBackupListResponse.RequestId = _ctx.StringValue("DescribeIncrementBackupList.RequestId");
			describeIncrementBackupListResponse.TotalPages = _ctx.IntegerValue("DescribeIncrementBackupList.TotalPages");
			describeIncrementBackupListResponse.PageSize = _ctx.IntegerValue("DescribeIncrementBackupList.PageSize");
			describeIncrementBackupListResponse.PageNum = _ctx.IntegerValue("DescribeIncrementBackupList.PageNum");
			describeIncrementBackupListResponse.TotalElements = _ctx.IntegerValue("DescribeIncrementBackupList.TotalElements");

			List<DescribeIncrementBackupListResponse.DescribeIncrementBackupList_IncrementBackupFile> describeIncrementBackupListResponse_items = new List<DescribeIncrementBackupListResponse.DescribeIncrementBackupList_IncrementBackupFile>();
			for (int i = 0; i < _ctx.Length("DescribeIncrementBackupList.Items.Length"); i++) {
				DescribeIncrementBackupListResponse.DescribeIncrementBackupList_IncrementBackupFile incrementBackupFile = new DescribeIncrementBackupListResponse.DescribeIncrementBackupList_IncrementBackupFile();
				incrementBackupFile.BackupSetId = _ctx.StringValue("DescribeIncrementBackupList.Items["+ i +"].BackupSetId");
				incrementBackupFile.BackupSetJobId = _ctx.StringValue("DescribeIncrementBackupList.Items["+ i +"].BackupSetJobId");
				incrementBackupFile.SourceEndpointIpPort = _ctx.StringValue("DescribeIncrementBackupList.Items["+ i +"].SourceEndpointIpPort");
				incrementBackupFile.StartTime = _ctx.LongValue("DescribeIncrementBackupList.Items["+ i +"].StartTime");
				incrementBackupFile.EndTime = _ctx.LongValue("DescribeIncrementBackupList.Items["+ i +"].EndTime");
				incrementBackupFile.BackupStatus = _ctx.StringValue("DescribeIncrementBackupList.Items["+ i +"].BackupStatus");
				incrementBackupFile.BackupSetExpiredTime = _ctx.LongValue("DescribeIncrementBackupList.Items["+ i +"].BackupSetExpiredTime");
				incrementBackupFile.BackupSize = _ctx.LongValue("DescribeIncrementBackupList.Items["+ i +"].BackupSize");
				incrementBackupFile.StorageMethod = _ctx.StringValue("DescribeIncrementBackupList.Items["+ i +"].StorageMethod");

				describeIncrementBackupListResponse_items.Add(incrementBackupFile);
			}
			describeIncrementBackupListResponse.Items = describeIncrementBackupListResponse_items;
        
			return describeIncrementBackupListResponse;
        }
    }
}
