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
    public class DescribeRestoreTaskListResponseUnmarshaller
    {
        public static DescribeRestoreTaskListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRestoreTaskListResponse describeRestoreTaskListResponse = new DescribeRestoreTaskListResponse();

			describeRestoreTaskListResponse.HttpResponse = context.HttpResponse;
			describeRestoreTaskListResponse.Success = context.BooleanValue("DescribeRestoreTaskList.Success");
			describeRestoreTaskListResponse.ErrCode = context.StringValue("DescribeRestoreTaskList.ErrCode");
			describeRestoreTaskListResponse.ErrMessage = context.StringValue("DescribeRestoreTaskList.ErrMessage");
			describeRestoreTaskListResponse.HttpStatusCode = context.IntegerValue("DescribeRestoreTaskList.HttpStatusCode");
			describeRestoreTaskListResponse.RequestId = context.StringValue("DescribeRestoreTaskList.RequestId");
			describeRestoreTaskListResponse.TotalPages = context.IntegerValue("DescribeRestoreTaskList.TotalPages");
			describeRestoreTaskListResponse.PageSize = context.IntegerValue("DescribeRestoreTaskList.PageSize");
			describeRestoreTaskListResponse.PageNum = context.IntegerValue("DescribeRestoreTaskList.PageNum");
			describeRestoreTaskListResponse.TotalElements = context.IntegerValue("DescribeRestoreTaskList.TotalElements");

			List<DescribeRestoreTaskListResponse.DescribeRestoreTaskList_RestoreTaskDetail> describeRestoreTaskListResponse_items = new List<DescribeRestoreTaskListResponse.DescribeRestoreTaskList_RestoreTaskDetail>();
			for (int i = 0; i < context.Length("DescribeRestoreTaskList.Items.Length"); i++) {
				DescribeRestoreTaskListResponse.DescribeRestoreTaskList_RestoreTaskDetail restoreTaskDetail = new DescribeRestoreTaskListResponse.DescribeRestoreTaskList_RestoreTaskDetail();
				restoreTaskDetail.BackupPlanId = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].BackupPlanId");
				restoreTaskDetail.DestinationEndpointInstanceType = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointInstanceType");
				restoreTaskDetail.DestinationEndpointRegion = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointRegion");
				restoreTaskDetail.DestinationEndpointInstanceID = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointInstanceID");
				restoreTaskDetail.DestinationEndpointIpPort = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointIpPort");
				restoreTaskDetail.DestinationEndpointDatabaseName = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointDatabaseName");
				restoreTaskDetail.DestinationEndpointUserName = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointUserName");
				restoreTaskDetail.DestinationEndpointOracleSID = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointOracleSID");
				restoreTaskDetail.RestoreObjects = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].RestoreObjects");
				restoreTaskDetail.BackupGatewayId = context.LongValue("DescribeRestoreTaskList.Items["+ i +"].BackupGatewayId");
				restoreTaskDetail.RestoreDir = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].RestoreDir");
				restoreTaskDetail.RestoreTaskName = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].RestoreTaskName");
				restoreTaskDetail.BackupSetId = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].BackupSetId");
				restoreTaskDetail.RestoreTime = context.LongValue("DescribeRestoreTaskList.Items["+ i +"].RestoreTime");
				restoreTaskDetail.RestoreTaskCreateTime = context.LongValue("DescribeRestoreTaskList.Items["+ i +"].RestoreTaskCreateTime");
				restoreTaskDetail.RestoreTaskFinishTime = context.LongValue("DescribeRestoreTaskList.Items["+ i +"].RestoreTaskFinishTime");
				restoreTaskDetail.RestoreStatus = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].RestoreStatus");
				restoreTaskDetail.RestoreTaskId = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].RestoreTaskId");
				restoreTaskDetail.FullStruforeRestoreProgress = context.IntegerValue("DescribeRestoreTaskList.Items["+ i +"].FullStruforeRestoreProgress");
				restoreTaskDetail.FullDataRestoreProgress = context.IntegerValue("DescribeRestoreTaskList.Items["+ i +"].FullDataRestoreProgress");
				restoreTaskDetail.ContinuousRestoreProgress = context.IntegerValue("DescribeRestoreTaskList.Items["+ i +"].ContinuousRestoreProgress");
				restoreTaskDetail.FullStruAfterRestoreProgress = context.IntegerValue("DescribeRestoreTaskList.Items["+ i +"].FullStruAfterRestoreProgress");
				restoreTaskDetail.ErrMessage = context.StringValue("DescribeRestoreTaskList.Items["+ i +"].ErrMessage");

				describeRestoreTaskListResponse_items.Add(restoreTaskDetail);
			}
			describeRestoreTaskListResponse.Items = describeRestoreTaskListResponse_items;
        
			return describeRestoreTaskListResponse;
        }
    }
}
