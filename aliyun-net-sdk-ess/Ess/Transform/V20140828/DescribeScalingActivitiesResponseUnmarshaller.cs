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
using Aliyun.Acs.Ess.Model.V20140828;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeScalingActivitiesResponseUnmarshaller
    {
        public static DescribeScalingActivitiesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScalingActivitiesResponse describeScalingActivitiesResponse = new DescribeScalingActivitiesResponse();

			describeScalingActivitiesResponse.HttpResponse = context.HttpResponse;
			describeScalingActivitiesResponse.TotalCount = context.IntegerValue("DescribeScalingActivities.TotalCount");
			describeScalingActivitiesResponse.PageNumber = context.IntegerValue("DescribeScalingActivities.PageNumber");
			describeScalingActivitiesResponse.PageSize = context.IntegerValue("DescribeScalingActivities.PageSize");
			describeScalingActivitiesResponse.RequestId = context.StringValue("DescribeScalingActivities.RequestId");

			List<DescribeScalingActivitiesResponse.DescribeScalingActivities_ScalingActivity> describeScalingActivitiesResponse_scalingActivities = new List<DescribeScalingActivitiesResponse.DescribeScalingActivities_ScalingActivity>();
			for (int i = 0; i < context.Length("DescribeScalingActivities.ScalingActivities.Length"); i++) {
				DescribeScalingActivitiesResponse.DescribeScalingActivities_ScalingActivity scalingActivity = new DescribeScalingActivitiesResponse.DescribeScalingActivities_ScalingActivity();
				scalingActivity.ScalingActivityId = context.StringValue("DescribeScalingActivities.ScalingActivities["+ i +"].ScalingActivityId");
				scalingActivity.ScalingGroupId = context.StringValue("DescribeScalingActivities.ScalingActivities["+ i +"].ScalingGroupId");
				scalingActivity.Description = context.StringValue("DescribeScalingActivities.ScalingActivities["+ i +"].Description");
				scalingActivity.Cause = context.StringValue("DescribeScalingActivities.ScalingActivities["+ i +"].Cause");
				scalingActivity.StartTime = context.StringValue("DescribeScalingActivities.ScalingActivities["+ i +"].StartTime");
				scalingActivity.EndTime = context.StringValue("DescribeScalingActivities.ScalingActivities["+ i +"].EndTime");
				scalingActivity.Progress = context.IntegerValue("DescribeScalingActivities.ScalingActivities["+ i +"].Progress");
				scalingActivity.StatusCode = context.StringValue("DescribeScalingActivities.ScalingActivities["+ i +"].StatusCode");
				scalingActivity.StatusMessage = context.StringValue("DescribeScalingActivities.ScalingActivities["+ i +"].StatusMessage");
				scalingActivity.TotalCapacity = context.StringValue("DescribeScalingActivities.ScalingActivities["+ i +"].TotalCapacity");
				scalingActivity.AttachedCapacity = context.StringValue("DescribeScalingActivities.ScalingActivities["+ i +"].AttachedCapacity");
				scalingActivity.AutoCreatedCapacity = context.StringValue("DescribeScalingActivities.ScalingActivities["+ i +"].AutoCreatedCapacity");
				scalingActivity.ScalingInstanceNumber = context.IntegerValue("DescribeScalingActivities.ScalingActivities["+ i +"].ScalingInstanceNumber");

				describeScalingActivitiesResponse_scalingActivities.Add(scalingActivity);
			}
			describeScalingActivitiesResponse.ScalingActivities = describeScalingActivitiesResponse_scalingActivities;
        
			return describeScalingActivitiesResponse;
        }
    }
}
