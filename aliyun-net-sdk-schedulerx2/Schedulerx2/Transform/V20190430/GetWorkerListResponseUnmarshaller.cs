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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class GetWorkerListResponseUnmarshaller
    {
        public static GetWorkerListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetWorkerListResponse getWorkerListResponse = new GetWorkerListResponse();

			getWorkerListResponse.HttpResponse = _ctx.HttpResponse;
			getWorkerListResponse.RequestId = _ctx.StringValue("GetWorkerList.RequestId");
			getWorkerListResponse.Code = _ctx.IntegerValue("GetWorkerList.Code");
			getWorkerListResponse.Message = _ctx.StringValue("GetWorkerList.Message");
			getWorkerListResponse.Success = _ctx.BooleanValue("GetWorkerList.Success");

			GetWorkerListResponse.GetWorkerList_Data data = new GetWorkerListResponse.GetWorkerList_Data();

			List<GetWorkerListResponse.GetWorkerList_Data.GetWorkerList_WorkerInfo> data_workerInfos = new List<GetWorkerListResponse.GetWorkerList_Data.GetWorkerList_WorkerInfo>();
			for (int i = 0; i < _ctx.Length("GetWorkerList.Data.WorkerInfos.Length"); i++) {
				GetWorkerListResponse.GetWorkerList_Data.GetWorkerList_WorkerInfo workerInfo = new GetWorkerListResponse.GetWorkerList_Data.GetWorkerList_WorkerInfo();
				workerInfo.Ip = _ctx.StringValue("GetWorkerList.Data.WorkerInfos["+ i +"].Ip");
				workerInfo.Port = _ctx.IntegerValue("GetWorkerList.Data.WorkerInfos["+ i +"].Port");
				workerInfo.WorkerAddress = _ctx.StringValue("GetWorkerList.Data.WorkerInfos["+ i +"].WorkerAddress");
				workerInfo.Label = _ctx.StringValue("GetWorkerList.Data.WorkerInfos["+ i +"].Label");
				workerInfo.Version = _ctx.StringValue("GetWorkerList.Data.WorkerInfos["+ i +"].Version");
				workerInfo.Starter = _ctx.StringValue("GetWorkerList.Data.WorkerInfos["+ i +"].Starter");

				data_workerInfos.Add(workerInfo);
			}
			data.WorkerInfos = data_workerInfos;
			getWorkerListResponse.Data = data;
        
			return getWorkerListResponse;
        }
    }
}
