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
using Aliyun.Acs.Actiontrail.Model.V20200706;

namespace Aliyun.Acs.Actiontrail.Transform.V20200706
{
    public class GetDeliveryHistoryJobResponseUnmarshaller
    {
        public static GetDeliveryHistoryJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDeliveryHistoryJobResponse getDeliveryHistoryJobResponse = new GetDeliveryHistoryJobResponse();

			getDeliveryHistoryJobResponse.HttpResponse = _ctx.HttpResponse;
			getDeliveryHistoryJobResponse.JobStatus = _ctx.IntegerValue("GetDeliveryHistoryJob.JobStatus");
			getDeliveryHistoryJobResponse.CreatedTime = _ctx.StringValue("GetDeliveryHistoryJob.CreatedTime");
			getDeliveryHistoryJobResponse.EndTime = _ctx.StringValue("GetDeliveryHistoryJob.EndTime");
			getDeliveryHistoryJobResponse.RequestId = _ctx.StringValue("GetDeliveryHistoryJob.RequestId");
			getDeliveryHistoryJobResponse.StartTime = _ctx.StringValue("GetDeliveryHistoryJob.StartTime");
			getDeliveryHistoryJobResponse.TrailName = _ctx.StringValue("GetDeliveryHistoryJob.TrailName");
			getDeliveryHistoryJobResponse.UpdatedTime = _ctx.StringValue("GetDeliveryHistoryJob.UpdatedTime");
			getDeliveryHistoryJobResponse.JobId = _ctx.LongValue("GetDeliveryHistoryJob.JobId");
			getDeliveryHistoryJobResponse.HomeRegion = _ctx.StringValue("GetDeliveryHistoryJob.HomeRegion");

			List<GetDeliveryHistoryJobResponse.GetDeliveryHistoryJob_StatusItem> getDeliveryHistoryJobResponse_status = new List<GetDeliveryHistoryJobResponse.GetDeliveryHistoryJob_StatusItem>();
			for (int i = 0; i < _ctx.Length("GetDeliveryHistoryJob.Status.Length"); i++) {
				GetDeliveryHistoryJobResponse.GetDeliveryHistoryJob_StatusItem statusItem = new GetDeliveryHistoryJobResponse.GetDeliveryHistoryJob_StatusItem();
				statusItem.Status = _ctx.IntegerValue("GetDeliveryHistoryJob.Status["+ i +"].Status");
				statusItem.Region = _ctx.StringValue("GetDeliveryHistoryJob.Status["+ i +"].Region");

				getDeliveryHistoryJobResponse_status.Add(statusItem);
			}
			getDeliveryHistoryJobResponse.Status = getDeliveryHistoryJobResponse_status;
        
			return getDeliveryHistoryJobResponse;
        }
    }
}
