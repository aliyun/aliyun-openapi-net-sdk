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
        public static DescribeBackupSetDownloadTaskListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupSetDownloadTaskListResponse describeBackupSetDownloadTaskListResponse = new DescribeBackupSetDownloadTaskListResponse();

			describeBackupSetDownloadTaskListResponse.HttpResponse = context.HttpResponse;
			describeBackupSetDownloadTaskListResponse.Success = context.BooleanValue("DescribeBackupSetDownloadTaskList.Success");
			describeBackupSetDownloadTaskListResponse.ErrCode = context.StringValue("DescribeBackupSetDownloadTaskList.ErrCode");
			describeBackupSetDownloadTaskListResponse.ErrMessage = context.StringValue("DescribeBackupSetDownloadTaskList.ErrMessage");
			describeBackupSetDownloadTaskListResponse.HttpStatusCode = context.IntegerValue("DescribeBackupSetDownloadTaskList.HttpStatusCode");
			describeBackupSetDownloadTaskListResponse.RequestId = context.StringValue("DescribeBackupSetDownloadTaskList.RequestId");
			describeBackupSetDownloadTaskListResponse.TotalPages = context.IntegerValue("DescribeBackupSetDownloadTaskList.TotalPages");
			describeBackupSetDownloadTaskListResponse.PageSize = context.IntegerValue("DescribeBackupSetDownloadTaskList.PageSize");
			describeBackupSetDownloadTaskListResponse.PageNum = context.IntegerValue("DescribeBackupSetDownloadTaskList.PageNum");
			describeBackupSetDownloadTaskListResponse.TotalElements = context.IntegerValue("DescribeBackupSetDownloadTaskList.TotalElements");

			List<DescribeBackupSetDownloadTaskListResponse.DescribeBackupSetDownloadTaskList_BackupSetDownloadTaskDetail> describeBackupSetDownloadTaskListResponse_items = new List<DescribeBackupSetDownloadTaskListResponse.DescribeBackupSetDownloadTaskList_BackupSetDownloadTaskDetail>();
			for (int i = 0; i < context.Length("DescribeBackupSetDownloadTaskList.Items.Length"); i++) {
				DescribeBackupSetDownloadTaskListResponse.DescribeBackupSetDownloadTaskList_BackupSetDownloadTaskDetail backupSetDownloadTaskDetail = new DescribeBackupSetDownloadTaskListResponse.DescribeBackupSetDownloadTaskList_BackupSetDownloadTaskDetail();
				backupSetDownloadTaskDetail.BackupPlanId = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupPlanId");
				backupSetDownloadTaskDetail.BackupSetDownloadTaskId = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadTaskId");
				backupSetDownloadTaskDetail.BackupSetDownloadTaskName = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadTaskName");
				backupSetDownloadTaskDetail.BackupSetDownloadStatus = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadStatus");
				backupSetDownloadTaskDetail.BackupSetDownloadCreateTime = context.LongValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadCreateTime");
				backupSetDownloadTaskDetail.BackupSetDownloadFinishTime = context.LongValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadFinishTime");
				backupSetDownloadTaskDetail.BackupSetId = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetId");
				backupSetDownloadTaskDetail.BackupSetCode = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetCode");
				backupSetDownloadTaskDetail.BackupSetJobType = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetJobType");
				backupSetDownloadTaskDetail.BackupSetDataSize = context.LongValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDataSize");
				backupSetDownloadTaskDetail.BackupSetDataFormat = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDataFormat");
				backupSetDownloadTaskDetail.BackupSetDbType = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDbType");
				backupSetDownloadTaskDetail.BackupSetDownloadWay = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadWay");
				backupSetDownloadTaskDetail.BackupSetDownloadDir = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadDir");
				backupSetDownloadTaskDetail.BackupSetDownloadTargetType = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadTargetType");
				backupSetDownloadTaskDetail.BackupGatewayId = context.LongValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupGatewayId");
				backupSetDownloadTaskDetail.BackupSetDownloadIntranetUrl = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadIntranetUrl");
				backupSetDownloadTaskDetail.BackupSetDownloadInternetUrl = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].BackupSetDownloadInternetUrl");
				backupSetDownloadTaskDetail.ErrMessage = context.StringValue("DescribeBackupSetDownloadTaskList.Items["+ i +"].ErrMessage");

				describeBackupSetDownloadTaskListResponse_items.Add(backupSetDownloadTaskDetail);
			}
			describeBackupSetDownloadTaskListResponse.Items = describeBackupSetDownloadTaskListResponse_items;
        
			return describeBackupSetDownloadTaskListResponse;
        }
    }
}
