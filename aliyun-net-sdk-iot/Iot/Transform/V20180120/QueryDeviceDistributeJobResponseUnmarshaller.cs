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
    public class QueryDeviceDistributeJobResponseUnmarshaller
    {
        public static QueryDeviceDistributeJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceDistributeJobResponse queryDeviceDistributeJobResponse = new QueryDeviceDistributeJobResponse();

			queryDeviceDistributeJobResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceDistributeJobResponse.RequestId = _ctx.StringValue("QueryDeviceDistributeJob.RequestId");
			queryDeviceDistributeJobResponse.Success = _ctx.BooleanValue("QueryDeviceDistributeJob.Success");
			queryDeviceDistributeJobResponse.Code = _ctx.StringValue("QueryDeviceDistributeJob.Code");
			queryDeviceDistributeJobResponse.ErrorMessage = _ctx.StringValue("QueryDeviceDistributeJob.ErrorMessage");

			QueryDeviceDistributeJobResponse.QueryDeviceDistributeJob_Data data = new QueryDeviceDistributeJobResponse.QueryDeviceDistributeJob_Data();
			data.SourceUid = _ctx.StringValue("QueryDeviceDistributeJob.Data.SourceUid");
			data.TargetUid = _ctx.StringValue("QueryDeviceDistributeJob.Data.TargetUid");
			data.SourceInstanceId = _ctx.StringValue("QueryDeviceDistributeJob.Data.SourceInstanceId");
			data.JobId = _ctx.StringValue("QueryDeviceDistributeJob.Data.JobId");
			data.ProductKey = _ctx.StringValue("QueryDeviceDistributeJob.Data.ProductKey");
			data.Total = _ctx.IntegerValue("QueryDeviceDistributeJob.Data.Total");
			data.Status = _ctx.IntegerValue("QueryDeviceDistributeJob.Data.Status");
			data.GmtCreate = _ctx.LongValue("QueryDeviceDistributeJob.Data.GmtCreate");
			data.Strategy = _ctx.IntegerValue("QueryDeviceDistributeJob.Data.Strategy");

			List<QueryDeviceDistributeJobResponse.QueryDeviceDistributeJob_Data.QueryDeviceDistributeJob_TargetInstanceConfigsItem> data_targetInstanceConfigs = new List<QueryDeviceDistributeJobResponse.QueryDeviceDistributeJob_Data.QueryDeviceDistributeJob_TargetInstanceConfigsItem>();
			for (int i = 0; i < _ctx.Length("QueryDeviceDistributeJob.Data.TargetInstanceConfigs.Length"); i++) {
				QueryDeviceDistributeJobResponse.QueryDeviceDistributeJob_Data.QueryDeviceDistributeJob_TargetInstanceConfigsItem targetInstanceConfigsItem = new QueryDeviceDistributeJobResponse.QueryDeviceDistributeJob_Data.QueryDeviceDistributeJob_TargetInstanceConfigsItem();
				targetInstanceConfigsItem.TargetInstanceId = _ctx.StringValue("QueryDeviceDistributeJob.Data.TargetInstanceConfigs["+ i +"].TargetInstanceId");

				data_targetInstanceConfigs.Add(targetInstanceConfigsItem);
			}
			data.TargetInstanceConfigs = data_targetInstanceConfigs;
			queryDeviceDistributeJobResponse.Data = data;
        
			return queryDeviceDistributeJobResponse;
        }
    }
}
