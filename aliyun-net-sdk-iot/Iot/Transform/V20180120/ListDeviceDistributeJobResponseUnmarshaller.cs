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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListDeviceDistributeJobResponseUnmarshaller
    {
        public static ListDeviceDistributeJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeviceDistributeJobResponse listDeviceDistributeJobResponse = new ListDeviceDistributeJobResponse();

			listDeviceDistributeJobResponse.HttpResponse = _ctx.HttpResponse;
			listDeviceDistributeJobResponse.RequestId = _ctx.StringValue("ListDeviceDistributeJob.RequestId");
			listDeviceDistributeJobResponse.Success = _ctx.BooleanValue("ListDeviceDistributeJob.Success");
			listDeviceDistributeJobResponse.Code = _ctx.StringValue("ListDeviceDistributeJob.Code");
			listDeviceDistributeJobResponse.ErrorMessage = _ctx.StringValue("ListDeviceDistributeJob.ErrorMessage");

			ListDeviceDistributeJobResponse.ListDeviceDistributeJob_Data data = new ListDeviceDistributeJobResponse.ListDeviceDistributeJob_Data();
			data.Total = _ctx.IntegerValue("ListDeviceDistributeJob.Data.Total");
			data.NextToken = _ctx.StringValue("ListDeviceDistributeJob.Data.NextToken");

			List<ListDeviceDistributeJobResponse.ListDeviceDistributeJob_Data.ListDeviceDistributeJob_Items> data_jobInfo = new List<ListDeviceDistributeJobResponse.ListDeviceDistributeJob_Data.ListDeviceDistributeJob_Items>();
			for (int i = 0; i < _ctx.Length("ListDeviceDistributeJob.Data.JobInfo.Length"); i++) {
				ListDeviceDistributeJobResponse.ListDeviceDistributeJob_Data.ListDeviceDistributeJob_Items items = new ListDeviceDistributeJobResponse.ListDeviceDistributeJob_Data.ListDeviceDistributeJob_Items();
				items.GmtCreate = _ctx.LongValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].GmtCreate");
				items.SourceUid = _ctx.StringValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].SourceUid");
				items.TargetUid = _ctx.StringValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].TargetUid");
				items.JobId = _ctx.StringValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].JobId");
				items.SourceInstanceId = _ctx.StringValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].SourceInstanceId");
				items.ProductKey = _ctx.StringValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].ProductKey");
				items.Total = _ctx.IntegerValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].Total");
				items.Status = _ctx.IntegerValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].Status");
				items.Strategy = _ctx.IntegerValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].Strategy");
				items.SourceRegion = _ctx.StringValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].SourceRegion");
				items.SourceInstanceName = _ctx.StringValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].SourceInstanceName");

				List<ListDeviceDistributeJobResponse.ListDeviceDistributeJob_Data.ListDeviceDistributeJob_Items.ListDeviceDistributeJob_TargetInstanceConfigsItem> items_targetInstanceConfigs = new List<ListDeviceDistributeJobResponse.ListDeviceDistributeJob_Data.ListDeviceDistributeJob_Items.ListDeviceDistributeJob_TargetInstanceConfigsItem>();
				for (int j = 0; j < _ctx.Length("ListDeviceDistributeJob.Data.JobInfo["+ i +"].TargetInstanceConfigs.Length"); j++) {
					ListDeviceDistributeJobResponse.ListDeviceDistributeJob_Data.ListDeviceDistributeJob_Items.ListDeviceDistributeJob_TargetInstanceConfigsItem targetInstanceConfigsItem = new ListDeviceDistributeJobResponse.ListDeviceDistributeJob_Data.ListDeviceDistributeJob_Items.ListDeviceDistributeJob_TargetInstanceConfigsItem();
					targetInstanceConfigsItem.TargetInstanceId = _ctx.StringValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].TargetInstanceConfigs["+ j +"].TargetInstanceId");
					targetInstanceConfigsItem.TargetRegion = _ctx.StringValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].TargetInstanceConfigs["+ j +"].TargetRegion");
					targetInstanceConfigsItem.TargetInstanceName = _ctx.StringValue("ListDeviceDistributeJob.Data.JobInfo["+ i +"].TargetInstanceConfigs["+ j +"].TargetInstanceName");

					items_targetInstanceConfigs.Add(targetInstanceConfigsItem);
				}
				items.TargetInstanceConfigs = items_targetInstanceConfigs;

				data_jobInfo.Add(items);
			}
			data.JobInfo = data_jobInfo;
			listDeviceDistributeJobResponse.Data = data;
        
			return listDeviceDistributeJobResponse;
        }
    }
}
