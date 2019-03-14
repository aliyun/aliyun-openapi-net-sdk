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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListScalingActivityResponseUnmarshaller
    {
        public static ListScalingActivityResponse Unmarshall(UnmarshallerContext context)
        {
			ListScalingActivityResponse listScalingActivityResponse = new ListScalingActivityResponse();

			listScalingActivityResponse.HttpResponse = context.HttpResponse;
			listScalingActivityResponse.RequestId = context.StringValue("ListScalingActivity.RequestId");
			listScalingActivityResponse.PageNumber = context.IntegerValue("ListScalingActivity.PageNumber");
			listScalingActivityResponse.PageSize = context.IntegerValue("ListScalingActivity.PageSize");
			listScalingActivityResponse.Total = context.IntegerValue("ListScalingActivity.Total");

			List<ListScalingActivityResponse.ListScalingActivity_ScalingActivity> listScalingActivityResponse_scalingActivityList = new List<ListScalingActivityResponse.ListScalingActivity_ScalingActivity>();
			for (int i = 0; i < context.Length("ListScalingActivity.ScalingActivityList.Length"); i++) {
				ListScalingActivityResponse.ListScalingActivity_ScalingActivity scalingActivity = new ListScalingActivityResponse.ListScalingActivity_ScalingActivity();
				scalingActivity.BizId = context.StringValue("ListScalingActivity.ScalingActivityList["+ i +"].BizId");
				scalingActivity.StartTime = context.LongValue("ListScalingActivity.ScalingActivityList["+ i +"].StartTime");
				scalingActivity.EndTime = context.LongValue("ListScalingActivity.ScalingActivityList["+ i +"].EndTime");
				scalingActivity.InstanceIds = context.StringValue("ListScalingActivity.ScalingActivityList["+ i +"].InstanceIds");
				scalingActivity.TotalCapacity = context.IntegerValue("ListScalingActivity.ScalingActivityList["+ i +"].TotalCapacity");
				scalingActivity.Cause = context.StringValue("ListScalingActivity.ScalingActivityList["+ i +"].Cause");
				scalingActivity.Description = context.StringValue("ListScalingActivity.ScalingActivityList["+ i +"].Description");
				scalingActivity.Status = context.StringValue("ListScalingActivity.ScalingActivityList["+ i +"].Status");
				scalingActivity.Transition = context.StringValue("ListScalingActivity.ScalingActivityList["+ i +"].Transition");
				scalingActivity.ScalingRuleId = context.StringValue("ListScalingActivity.ScalingActivityList["+ i +"].ScalingRuleId");
				scalingActivity.ExpectNum = context.IntegerValue("ListScalingActivity.ScalingActivityList["+ i +"].ExpectNum");

				listScalingActivityResponse_scalingActivityList.Add(scalingActivity);
			}
			listScalingActivityResponse.ScalingActivityList = listScalingActivityResponse_scalingActivityList;
        
			return listScalingActivityResponse;
        }
    }
}
