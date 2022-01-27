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
    public class DescribeAutoProvisioningGroupHistoryResponseUnmarshaller
    {
        public static DescribeAutoProvisioningGroupHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutoProvisioningGroupHistoryResponse describeAutoProvisioningGroupHistoryResponse = new DescribeAutoProvisioningGroupHistoryResponse();

			describeAutoProvisioningGroupHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeAutoProvisioningGroupHistoryResponse.PageSize = _ctx.IntegerValue("DescribeAutoProvisioningGroupHistory.PageSize");
			describeAutoProvisioningGroupHistoryResponse.RequestId = _ctx.StringValue("DescribeAutoProvisioningGroupHistory.RequestId");
			describeAutoProvisioningGroupHistoryResponse.PageNumber = _ctx.IntegerValue("DescribeAutoProvisioningGroupHistory.PageNumber");
			describeAutoProvisioningGroupHistoryResponse.TotalCount = _ctx.IntegerValue("DescribeAutoProvisioningGroupHistory.TotalCount");

			List<DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory> describeAutoProvisioningGroupHistoryResponse_autoProvisioningGroupHistories = new List<DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory>();
			for (int i = 0; i < _ctx.Length("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories.Length"); i++) {
				DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory autoProvisioningGroupHistory = new DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory();
				autoProvisioningGroupHistory.Status = _ctx.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].Status");
				autoProvisioningGroupHistory.StartTime = _ctx.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].StartTime");
				autoProvisioningGroupHistory.TaskId = _ctx.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].TaskId");
				autoProvisioningGroupHistory.LastEventTime = _ctx.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].LastEventTime");

				List<DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory.DescribeAutoProvisioningGroupHistory_ActivityDetail> autoProvisioningGroupHistory_activityDetails = new List<DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory.DescribeAutoProvisioningGroupHistory_ActivityDetail>();
				for (int j = 0; j < _ctx.Length("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].ActivityDetails.Length"); j++) {
					DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory.DescribeAutoProvisioningGroupHistory_ActivityDetail activityDetail = new DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory.DescribeAutoProvisioningGroupHistory_ActivityDetail();
					activityDetail.Status = _ctx.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].ActivityDetails["+ j +"].Status");
					activityDetail.Detail = _ctx.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].ActivityDetails["+ j +"].Detail");

					autoProvisioningGroupHistory_activityDetails.Add(activityDetail);
				}
				autoProvisioningGroupHistory.ActivityDetails = autoProvisioningGroupHistory_activityDetails;

				describeAutoProvisioningGroupHistoryResponse_autoProvisioningGroupHistories.Add(autoProvisioningGroupHistory);
			}
			describeAutoProvisioningGroupHistoryResponse.AutoProvisioningGroupHistories = describeAutoProvisioningGroupHistoryResponse_autoProvisioningGroupHistories;
        
			return describeAutoProvisioningGroupHistoryResponse;
        }
    }
}
