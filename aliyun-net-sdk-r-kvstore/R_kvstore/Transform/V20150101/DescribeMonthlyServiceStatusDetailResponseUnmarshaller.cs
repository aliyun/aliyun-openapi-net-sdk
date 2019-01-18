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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeMonthlyServiceStatusDetailResponseUnmarshaller
    {
        public static DescribeMonthlyServiceStatusDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMonthlyServiceStatusDetailResponse describeMonthlyServiceStatusDetailResponse = new DescribeMonthlyServiceStatusDetailResponse();

			describeMonthlyServiceStatusDetailResponse.HttpResponse = context.HttpResponse;
			describeMonthlyServiceStatusDetailResponse.RequestId = context.StringValue("DescribeMonthlyServiceStatusDetail.RequestId");
			describeMonthlyServiceStatusDetailResponse.InstanceId = context.StringValue("DescribeMonthlyServiceStatusDetail.InstanceId");
			describeMonthlyServiceStatusDetailResponse.UptimePct = context.FloatValue("DescribeMonthlyServiceStatusDetail.UptimePct");

			List<DescribeMonthlyServiceStatusDetailResponse.DescribeMonthlyServiceStatusDetail_AffectedInfo> describeMonthlyServiceStatusDetailResponse_affectedInfos = new List<DescribeMonthlyServiceStatusDetailResponse.DescribeMonthlyServiceStatusDetail_AffectedInfo>();
			for (int i = 0; i < context.Length("DescribeMonthlyServiceStatusDetail.AffectedInfos.Length"); i++) {
				DescribeMonthlyServiceStatusDetailResponse.DescribeMonthlyServiceStatusDetail_AffectedInfo affectedInfo = new DescribeMonthlyServiceStatusDetailResponse.DescribeMonthlyServiceStatusDetail_AffectedInfo();
				affectedInfo.StartTime = context.StringValue("DescribeMonthlyServiceStatusDetail.AffectedInfos["+ i +"].StartTime");
				affectedInfo.EndTime = context.StringValue("DescribeMonthlyServiceStatusDetail.AffectedInfos["+ i +"].EndTime");
				affectedInfo.Description = context.StringValue("DescribeMonthlyServiceStatusDetail.AffectedInfos["+ i +"].Description");

				describeMonthlyServiceStatusDetailResponse_affectedInfos.Add(affectedInfo);
			}
			describeMonthlyServiceStatusDetailResponse.AffectedInfos = describeMonthlyServiceStatusDetailResponse_affectedInfos;
        
			return describeMonthlyServiceStatusDetailResponse;
        }
    }
}