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
    public class DescribeBackupSetDownloadTaskListResponseUnmarshaller
    {
        public static DescribeBackupSetDownloadTaskListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupSetDownloadTaskListResponse describeBackupSetDownloadTaskListResponse = new DescribeBackupSetDownloadTaskListResponse();

			describeBackupSetDownloadTaskListResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupSetDownloadTaskListResponse.Success = _ctx.BooleanValue("DescribeBackupSetDownloadTaskList.Success");
			describeBackupSetDownloadTaskListResponse.ErrCode = _ctx.StringValue("DescribeBackupSetDownloadTaskList.ErrCode");
			describeBackupSetDownloadTaskListResponse.ErrMessage = _ctx.StringValue("DescribeBackupSetDownloadTaskList.ErrMessage");
			describeBackupSetDownloadTaskListResponse.HttpStatusCode = _ctx.IntegerValue("DescribeBackupSetDownloadTaskList.HttpStatusCode");
			describeBackupSetDownloadTaskListResponse.RequestId = _ctx.StringValue("DescribeBackupSetDownloadTaskList.RequestId");
			describeBackupSetDownloadTaskListResponse.TotalPages = _ctx.IntegerValue("DescribeBackupSetDownloadTaskList.TotalPages");
			describeBackupSetDownloadTaskListResponse.PageSize = _ctx.IntegerValue("DescribeBackupSetDownloadTaskList.PageSize");
			describeBackupSetDownloadTaskListResponse.PageNum = _ctx.IntegerValue("DescribeBackupSetDownloadTaskList.PageNum");
			describeBackupSetDownloadTaskListResponse.TotalElements = _ctx.IntegerValue("DescribeBackupSetDownloadTaskList.TotalElements");

			List<DescribeBackupSetDownloadTaskListResponse.DescribeBackupSetDownloadTaskList_BackupSetDownloadTaskDetail> describeBackupSetDownloadTaskListResponse_items = new List<DescribeBackupSetDownloadTaskListResponse.DescribeBackupSetDownloadTaskList_BackupSetDownloadTaskDetail>();
			for (int i = 0; i < _ctx.Length("DescribeBackupSetDownloadTaskList.Items.Length"); i++) {
				DescribeBackupSetDownloadTaskListResponse.DescribeBackupSetDownloadTaskList_BackupSetDownloadTaskDetail backupSetDownloadTaskDetail = new DescribeBackupSetDownloadTaskListResponse.DescribeBackupSetDownloadTaskList_BackupSetDownloadTaskDetail();
				backupSetDownloadTaskDetail.BackupPlanId = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupPlanId");
				backupSetDownloadTaskDetail.BackupSetDownloadTaskId = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadTaskId");
				backupSetDownloadTaskDetail.BackupSetDownloadTaskName = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadTaskName");
				backupSetDownloadTaskDetail.BackupSetDownloadStatus = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadStatus");
				backupSetDownloadTaskDetail.BackupSetDownloadCreateTime = _ctx.LongValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadCreateTime");
				backupSetDownloadTaskDetail.BackupSetDownloadFinishTime = _ctx.LongValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadFinishTime");
				backupSetDownloadTaskDetail.BackupSetId = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetId");
				backupSetDownloadTaskDetail.BackupSetCode = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetCode");
				backupSetDownloadTaskDetail.BackupSetJobType = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetJobType");
				backupSetDownloadTaskDetail.BackupSetDataSize = _ctx.LongValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDataSize");
				backupSetDownloadTaskDetail.BackupSetDataFormat = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDataFormat");
				backupSetDownloadTaskDetail.BackupSetDbType = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDbType");
				backupSetDownloadTaskDetail.BackupSetDownloadWay = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadWay");
				backupSetDownloadTaskDetail.BackupSetDownloadDir = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadDir");
				backupSetDownloadTaskDetail.BackupSetDownloadTargetType = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadTargetType");
				backupSetDownloadTaskDetail.BackupGatewayId = _ctx.LongValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupGatewayId");
				backupSetDownloadTaskDetail.BackupSetDownloadIntranetUrl = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadIntranetUrl");
				backupSetDownloadTaskDetail.BackupSetDownloadInternetUrl = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadInternetUrl");
				backupSetDownloadTaskDetail.ErrMessage = _ctx.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].ErrMessage");

				describeBackupSetDownloadTaskListResponse_items.Add(backupSetDownloadTaskDetail);
			}
			describeBackupSetDownloadTaskListResponse.Items = describeBackupSetDownloadTaskListResponse_items;
        
			return describeBackupSetDownloadTaskListResponse;
        }
    }
}
