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
        public static DescribeAutoProvisioningGroupHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAutoProvisioningGroupHistoryResponse describeAutoProvisioningGroupHistoryResponse = new DescribeAutoProvisioningGroupHistoryResponse();

			describeAutoProvisioningGroupHistoryResponse.HttpResponse = context.HttpResponse;
			describeAutoProvisioningGroupHistoryResponse.RequestId = context.StringValue("DescribeAutoProvisioningGroupHistory.RequestId");
			describeAutoProvisioningGroupHistoryResponse.TotalCount = context.IntegerValue("DescribeAutoProvisioningGroupHistory.TotalCount");
			describeAutoProvisioningGroupHistoryResponse.PageNumber = context.IntegerValue("DescribeAutoProvisioningGroupHistory.PageNumber");
			describeAutoProvisioningGroupHistoryResponse.PageSize = context.IntegerValue("DescribeAutoProvisioningGroupHistory.PageSize");

			List<DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory> describeAutoProvisioningGroupHistoryResponse_autoProvisioningGroupHistories = new List<DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory>();
			for (int i = 0; i < context.Length("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories.Length"); i++) {
				DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory autoProvisioningGroupHistory = new DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory();
				autoProvisioningGroupHistory.TaskId = context.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].TaskId");
				autoProvisioningGroupHistory.Status = context.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].Status");
				autoProvisioningGroupHistory.LastEventTime = context.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].LastEventTime");
				autoProvisioningGroupHistory.StartTime = context.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].StartTime");

				List<DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory.DescribeAutoProvisioningGroupHistory_ActivityDetail> autoProvisioningGroupHistory_activityDetails = new List<DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory.DescribeAutoProvisioningGroupHistory_ActivityDetail>();
				for (int j = 0; j < context.Length("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].ActivityDetails.Length"); j++) {
					DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory.DescribeAutoProvisioningGroupHistory_ActivityDetail activityDetail = new DescribeAutoProvisioningGroupHistoryResponse.DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory.DescribeAutoProvisioningGroupHistory_ActivityDetail();
					activityDetail.Detail = context.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].ActivityDetails["+ j +"].Detail");
					activityDetail.Status = context.StringValue("DescribeAutoProvisioningGroupHistory.AutoProvisioningGroupHistories["+ i +"].ActivityDetails["+ j +"].Status");

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
