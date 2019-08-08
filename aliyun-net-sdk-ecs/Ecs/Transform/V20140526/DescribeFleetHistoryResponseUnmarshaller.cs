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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeFleetHistoryResponseUnmarshaller
    {
        public static DescribeFleetHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFleetHistoryResponse describeFleetHistoryResponse = new DescribeFleetHistoryResponse();

			describeFleetHistoryResponse.HttpResponse = context.HttpResponse;
			describeFleetHistoryResponse.RequestId = context.StringValue("DescribeFleetHistory.RequestId");
			describeFleetHistoryResponse.TotalCount = context.IntegerValue("DescribeFleetHistory.TotalCount");
			describeFleetHistoryResponse.PageNumber = context.IntegerValue("DescribeFleetHistory.PageNumber");
			describeFleetHistoryResponse.PageSize = context.IntegerValue("DescribeFleetHistory.PageSize");

			List<DescribeFleetHistoryResponse.DescribeFleetHistory_FleetHistory> describeFleetHistoryResponse_fleetHistorys = new List<DescribeFleetHistoryResponse.DescribeFleetHistory_FleetHistory>();
			for (int i = 0; i < context.Length("DescribeFleetHistory.FleetHistorys.Length"); i++) {
				DescribeFleetHistoryResponse.DescribeFleetHistory_FleetHistory fleetHistory = new DescribeFleetHistoryResponse.DescribeFleetHistory_FleetHistory();
				fleetHistory.TaskId = context.StringValue("DescribeFleetHistory.FleetHistorys["+ i +"].TaskId");
				fleetHistory.Status = context.StringValue("DescribeFleetHistory.FleetHistorys["+ i +"].Status");
				fleetHistory.LastEventTime = context.StringValue("DescribeFleetHistory.FleetHistorys["+ i +"].LastEventTime");
				fleetHistory.StartTime = context.StringValue("DescribeFleetHistory.FleetHistorys["+ i +"].StartTime");

				List<DescribeFleetHistoryResponse.DescribeFleetHistory_FleetHistory.DescribeFleetHistory_ActivityDetail> fleetHistory_activityDetails = new List<DescribeFleetHistoryResponse.DescribeFleetHistory_FleetHistory.DescribeFleetHistory_ActivityDetail>();
				for (int j = 0; j < context.Length("DescribeFleetHistory.FleetHistorys["+ i +"].ActivityDetails.Length"); j++) {
					DescribeFleetHistoryResponse.DescribeFleetHistory_FleetHistory.DescribeFleetHistory_ActivityDetail activityDetail = new DescribeFleetHistoryResponse.DescribeFleetHistory_FleetHistory.DescribeFleetHistory_ActivityDetail();
					activityDetail.Detail = context.StringValue("DescribeFleetHistory.FleetHistorys["+ i +"].ActivityDetails["+ j +"].Detail");
					activityDetail.Status = context.FloatValue("DescribeFleetHistory.FleetHistorys["+ i +"].ActivityDetails["+ j +"].Status");

					fleetHistory_activityDetails.Add(activityDetail);
				}
				fleetHistory.ActivityDetails = fleetHistory_activityDetails;

				describeFleetHistoryResponse_fleetHistorys.Add(fleetHistory);
			}
			describeFleetHistoryResponse.FleetHistorys = describeFleetHistoryResponse_fleetHistorys;
        
			return describeFleetHistoryResponse;
        }
    }
}
