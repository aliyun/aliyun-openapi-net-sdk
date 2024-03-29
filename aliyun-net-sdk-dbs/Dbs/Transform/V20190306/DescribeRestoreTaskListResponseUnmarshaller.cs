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
        public static DescribeRestoreTaskListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRestoreTaskListResponse describeRestoreTaskListResponse = new DescribeRestoreTaskListResponse();

			describeRestoreTaskListResponse.HttpResponse = _ctx.HttpResponse;
			describeRestoreTaskListResponse.HttpStatusCode = _ctx.IntegerValue("DescribeRestoreTaskList.HttpStatusCode");
			describeRestoreTaskListResponse.PageNum = _ctx.IntegerValue("DescribeRestoreTaskList.PageNum");
			describeRestoreTaskListResponse.RequestId = _ctx.StringValue("DescribeRestoreTaskList.RequestId");
			describeRestoreTaskListResponse.ErrCode = _ctx.StringValue("DescribeRestoreTaskList.ErrCode");
			describeRestoreTaskListResponse.Success = _ctx.BooleanValue("DescribeRestoreTaskList.Success");
			describeRestoreTaskListResponse.ErrMessage = _ctx.StringValue("DescribeRestoreTaskList.ErrMessage");
			describeRestoreTaskListResponse.TotalPages = _ctx.IntegerValue("DescribeRestoreTaskList.TotalPages");
			describeRestoreTaskListResponse.TotalElements = _ctx.IntegerValue("DescribeRestoreTaskList.TotalElements");
			describeRestoreTaskListResponse.PageSize = _ctx.IntegerValue("DescribeRestoreTaskList.PageSize");

			List<DescribeRestoreTaskListResponse.DescribeRestoreTaskList_RestoreTaskDetail> describeRestoreTaskListResponse_items = new List<DescribeRestoreTaskListResponse.DescribeRestoreTaskList_RestoreTaskDetail>();
			for (int i = 0; i < _ctx.Length("DescribeRestoreTaskList.Items.Length"); i++) {
				DescribeRestoreTaskListResponse.DescribeRestoreTaskList_RestoreTaskDetail restoreTaskDetail = new DescribeRestoreTaskListResponse.DescribeRestoreTaskList_RestoreTaskDetail();
				restoreTaskDetail.RestoreStatus = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].RestoreStatus");
				restoreTaskDetail.FullStruAfterRestoreProgress = _ctx.IntegerValue("DescribeRestoreTaskList.Items["+ i +"].FullStruAfterRestoreProgress");
				restoreTaskDetail.CrossRoleName = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].CrossRoleName");
				restoreTaskDetail.RestoreDir = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].RestoreDir");
				restoreTaskDetail.CrossAliyunId = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].CrossAliyunId");
				restoreTaskDetail.RestoreObjects = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].RestoreObjects");
				restoreTaskDetail.BackupPlanId = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].BackupPlanId");
				restoreTaskDetail.DestinationEndpointRegion = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointRegion");
				restoreTaskDetail.RestoreTaskCreateTime = _ctx.LongValue("DescribeRestoreTaskList.Items["+ i +"].RestoreTaskCreateTime");
				restoreTaskDetail.DestinationEndpointUserName = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointUserName");
				restoreTaskDetail.RestoreTaskFinishTime = _ctx.LongValue("DescribeRestoreTaskList.Items["+ i +"].RestoreTaskFinishTime");
				restoreTaskDetail.DestinationEndpointIpPort = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointIpPort");
				restoreTaskDetail.DestinationEndpointDatabaseName = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointDatabaseName");
				restoreTaskDetail.DestinationEndpointInstanceType = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointInstanceType");
				restoreTaskDetail.DestinationEndpointOracleSID = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointOracleSID");
				restoreTaskDetail.FullStruforeRestoreProgress = _ctx.IntegerValue("DescribeRestoreTaskList.Items["+ i +"].FullStruforeRestoreProgress");
				restoreTaskDetail.ErrMessage = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].ErrMessage");
				restoreTaskDetail.RestoreTaskId = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].RestoreTaskId");
				restoreTaskDetail.FullDataRestoreProgress = _ctx.IntegerValue("DescribeRestoreTaskList.Items["+ i +"].FullDataRestoreProgress");
				restoreTaskDetail.ContinuousRestoreProgress = _ctx.IntegerValue("DescribeRestoreTaskList.Items["+ i +"].ContinuousRestoreProgress");
				restoreTaskDetail.DestinationEndpointInstanceID = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].DestinationEndpointInstanceID");
				restoreTaskDetail.BackupSetId = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].BackupSetId");
				restoreTaskDetail.BackupGatewayId = _ctx.LongValue("DescribeRestoreTaskList.Items["+ i +"].BackupGatewayId");
				restoreTaskDetail.RestoreTaskName = _ctx.StringValue("DescribeRestoreTaskList.Items["+ i +"].RestoreTaskName");
				restoreTaskDetail.RestoreTime = _ctx.LongValue("DescribeRestoreTaskList.Items["+ i +"].RestoreTime");

				describeRestoreTaskListResponse_items.Add(restoreTaskDetail);
			}
			describeRestoreTaskListResponse.Items = describeRestoreTaskListResponse_items;
        
			return describeRestoreTaskListResponse;
        }
    }
}
