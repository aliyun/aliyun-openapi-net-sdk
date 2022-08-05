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
        public static DescribeFullBackupListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFullBackupListResponse describeFullBackupListResponse = new DescribeFullBackupListResponse();

			describeFullBackupListResponse.HttpResponse = _ctx.HttpResponse;
			describeFullBackupListResponse.HttpStatusCode = _ctx.IntegerValue("DescribeFullBackupList.HttpStatusCode");
			describeFullBackupListResponse.PageNum = _ctx.IntegerValue("DescribeFullBackupList.PageNum");
			describeFullBackupListResponse.RequestId = _ctx.StringValue("DescribeFullBackupList.RequestId");
			describeFullBackupListResponse.ErrCode = _ctx.StringValue("DescribeFullBackupList.ErrCode");
			describeFullBackupListResponse.Success = _ctx.BooleanValue("DescribeFullBackupList.Success");
			describeFullBackupListResponse.ErrMessage = _ctx.StringValue("DescribeFullBackupList.ErrMessage");
			describeFullBackupListResponse.TotalPages = _ctx.IntegerValue("DescribeFullBackupList.TotalPages");
			describeFullBackupListResponse.TotalElements = _ctx.IntegerValue("DescribeFullBackupList.TotalElements");
			describeFullBackupListResponse.PageSize = _ctx.IntegerValue("DescribeFullBackupList.PageSize");

			List<DescribeFullBackupListResponse.DescribeFullBackupList_FullBackupFile> describeFullBackupListResponse_items = new List<DescribeFullBackupListResponse.DescribeFullBackupList_FullBackupFile>();
			for (int i = 0; i < _ctx.Length("DescribeFullBackupList.Items.Length"); i++) {
				DescribeFullBackupListResponse.DescribeFullBackupList_FullBackupFile fullBackupFile = new DescribeFullBackupListResponse.DescribeFullBackupList_FullBackupFile();
				fullBackupFile.FinishTime = _ctx.LongValue("DescribeFullBackupList.Items["+ i +"].FinishTime");
				fullBackupFile.BackupStatus = _ctx.StringValue("DescribeFullBackupList.Items["+ i +"].BackupStatus");
				fullBackupFile.SourceEndpointIpPort = _ctx.StringValue("DescribeFullBackupList.Items["+ i +"].SourceEndpointIpPort");
				fullBackupFile.CreateTime = _ctx.LongValue("DescribeFullBackupList.Items["+ i +"].CreateTime");
				fullBackupFile.ErrMessage = _ctx.StringValue("DescribeFullBackupList.Items["+ i +"].ErrMessage");
				fullBackupFile.BackupObjects = _ctx.StringValue("DescribeFullBackupList.Items["+ i +"].BackupObjects");
				fullBackupFile.EndTime = _ctx.LongValue("DescribeFullBackupList.Items["+ i +"].EndTime");
				fullBackupFile.StartTime = _ctx.LongValue("DescribeFullBackupList.Items["+ i +"].StartTime");
				fullBackupFile.BackupSetExpiredTime = _ctx.LongValue("DescribeFullBackupList.Items["+ i +"].BackupSetExpiredTime");
				fullBackupFile.StorageMethod = _ctx.StringValue("DescribeFullBackupList.Items["+ i +"].StorageMethod");
				fullBackupFile.BackupSetId = _ctx.StringValue("DescribeFullBackupList.Items["+ i +"].BackupSetId");
				fullBackupFile.BackupSize = _ctx.LongValue("DescribeFullBackupList.Items["+ i +"].BackupSize");

				describeFullBackupListResponse_items.Add(fullBackupFile);
			}
			describeFullBackupListResponse.Items = describeFullBackupListResponse_items;
        
			return describeFullBackupListResponse;
        }
    }
}
