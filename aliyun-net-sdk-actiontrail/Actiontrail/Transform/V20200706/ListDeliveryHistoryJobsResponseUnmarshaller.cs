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
    public class ListDeliveryHistoryJobsResponseUnmarshaller
    {
        public static ListDeliveryHistoryJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeliveryHistoryJobsResponse listDeliveryHistoryJobsResponse = new ListDeliveryHistoryJobsResponse();

			listDeliveryHistoryJobsResponse.HttpResponse = _ctx.HttpResponse;
			listDeliveryHistoryJobsResponse.RequestId = _ctx.StringValue("ListDeliveryHistoryJobs.RequestId");
			listDeliveryHistoryJobsResponse.TotalCount = _ctx.IntegerValue("ListDeliveryHistoryJobs.TotalCount");
			listDeliveryHistoryJobsResponse.PageNumber = _ctx.IntegerValue("ListDeliveryHistoryJobs.PageNumber");
			listDeliveryHistoryJobsResponse.PageSize = _ctx.IntegerValue("ListDeliveryHistoryJobs.PageSize");

			List<ListDeliveryHistoryJobsResponse.ListDeliveryHistoryJobs_DeliveryHistoryJob> listDeliveryHistoryJobsResponse_deliveryHistoryJobs = new List<ListDeliveryHistoryJobsResponse.ListDeliveryHistoryJobs_DeliveryHistoryJob>();
			for (int i = 0; i < _ctx.Length("ListDeliveryHistoryJobs.DeliveryHistoryJobs.Length"); i++) {
				ListDeliveryHistoryJobsResponse.ListDeliveryHistoryJobs_DeliveryHistoryJob deliveryHistoryJob = new ListDeliveryHistoryJobsResponse.ListDeliveryHistoryJobs_DeliveryHistoryJob();
				deliveryHistoryJob.TrailName = _ctx.StringValue("ListDeliveryHistoryJobs.DeliveryHistoryJobs["+ i +"].TrailName");
				deliveryHistoryJob.CreatedTime = _ctx.StringValue("ListDeliveryHistoryJobs.DeliveryHistoryJobs["+ i +"].CreatedTime");
				deliveryHistoryJob.UpdatedTime = _ctx.StringValue("ListDeliveryHistoryJobs.DeliveryHistoryJobs["+ i +"].UpdatedTime");
				deliveryHistoryJob.HomeRegion = _ctx.StringValue("ListDeliveryHistoryJobs.DeliveryHistoryJobs["+ i +"].HomeRegion");
				deliveryHistoryJob.StartTime = _ctx.StringValue("ListDeliveryHistoryJobs.DeliveryHistoryJobs["+ i +"].StartTime");
				deliveryHistoryJob.EndTime = _ctx.StringValue("ListDeliveryHistoryJobs.DeliveryHistoryJobs["+ i +"].EndTime");
				deliveryHistoryJob.JobId = _ctx.LongValue("ListDeliveryHistoryJobs.DeliveryHistoryJobs["+ i +"].JobId");
				deliveryHistoryJob.JobStatus = _ctx.IntegerValue("ListDeliveryHistoryJobs.DeliveryHistoryJobs["+ i +"].JobStatus");

				listDeliveryHistoryJobsResponse_deliveryHistoryJobs.Add(deliveryHistoryJob);
			}
			listDeliveryHistoryJobsResponse.DeliveryHistoryJobs = listDeliveryHistoryJobsResponse_deliveryHistoryJobs;
        
			return listDeliveryHistoryJobsResponse;
        }
    }
}
