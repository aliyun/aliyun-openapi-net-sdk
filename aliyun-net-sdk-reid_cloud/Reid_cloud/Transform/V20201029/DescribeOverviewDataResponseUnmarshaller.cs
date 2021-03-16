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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class DescribeOverviewDataResponseUnmarshaller
    {
        public static DescribeOverviewDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOverviewDataResponse describeOverviewDataResponse = new DescribeOverviewDataResponse();

			describeOverviewDataResponse.HttpResponse = _ctx.HttpResponse;
			describeOverviewDataResponse.ErrorCode = _ctx.StringValue("DescribeOverviewData.ErrorCode");
			describeOverviewDataResponse.ErrorMessage = _ctx.StringValue("DescribeOverviewData.ErrorMessage");
			describeOverviewDataResponse.Message = _ctx.StringValue("DescribeOverviewData.Message");
			describeOverviewDataResponse.Code = _ctx.StringValue("DescribeOverviewData.Code");
			describeOverviewDataResponse.DynamicCode = _ctx.StringValue("DescribeOverviewData.DynamicCode");
			describeOverviewDataResponse.RequestId = _ctx.StringValue("DescribeOverviewData.RequestId");
			describeOverviewDataResponse.Success = _ctx.BooleanValue("DescribeOverviewData.Success");
			describeOverviewDataResponse.DynamicMessage = _ctx.StringValue("DescribeOverviewData.DynamicMessage");

			DescribeOverviewDataResponse.DescribeOverviewData_OverviewDetail overviewDetail = new DescribeOverviewDataResponse.DescribeOverviewData_OverviewDetail();
			overviewDetail.StayDeepAvgWOWPercent = _ctx.FloatValue("DescribeOverviewData.OverviewDetail.StayDeepAvgWOWPercent");
			overviewDetail.StayDeepAvg = _ctx.FloatValue("DescribeOverviewData.OverviewDetail.StayDeepAvg");
			overviewDetail.UvAvgWOWPercent = _ctx.FloatValue("DescribeOverviewData.OverviewDetail.UvAvgWOWPercent");
			overviewDetail.StayAvgPeriodWOWPercent = _ctx.FloatValue("DescribeOverviewData.OverviewDetail.StayAvgPeriodWOWPercent");
			overviewDetail.UvEverySqmGrowthWOWPercent = _ctx.FloatValue("DescribeOverviewData.OverviewDetail.UvEverySqmGrowthWOWPercent");
			overviewDetail.UvWOWPercent = _ctx.FloatValue("DescribeOverviewData.OverviewDetail.UvWOWPercent");
			overviewDetail.Uv = _ctx.LongValue("DescribeOverviewData.OverviewDetail.Uv");
			overviewDetail.UvEverySqm = _ctx.FloatValue("DescribeOverviewData.OverviewDetail.UvEverySqm");
			overviewDetail.UvAvg = _ctx.FloatValue("DescribeOverviewData.OverviewDetail.UvAvg");
			overviewDetail.StayAvgPeriod = _ctx.FloatValue("DescribeOverviewData.OverviewDetail.StayAvgPeriod");
			describeOverviewDataResponse.OverviewDetail = overviewDetail;

			DescribeOverviewDataResponse.DescribeOverviewData_AccurateOverviewDetail accurateOverviewDetail = new DescribeOverviewDataResponse.DescribeOverviewData_AccurateOverviewDetail();
			accurateOverviewDetail.StayDeepAvgWOWPercent = _ctx.StringValue("DescribeOverviewData.AccurateOverviewDetail.StayDeepAvgWOWPercent");
			accurateOverviewDetail.StayDeepAvg = _ctx.StringValue("DescribeOverviewData.AccurateOverviewDetail.StayDeepAvg");
			accurateOverviewDetail.UvAvgWOWPercent = _ctx.StringValue("DescribeOverviewData.AccurateOverviewDetail.UvAvgWOWPercent");
			accurateOverviewDetail.StayAvgPeriodWOWPercent = _ctx.StringValue("DescribeOverviewData.AccurateOverviewDetail.StayAvgPeriodWOWPercent");
			accurateOverviewDetail.UvWOWPercent = _ctx.StringValue("DescribeOverviewData.AccurateOverviewDetail.UvWOWPercent");
			accurateOverviewDetail.UvEverySqmGrowthWOWPercent = _ctx.StringValue("DescribeOverviewData.AccurateOverviewDetail.UvEverySqmGrowthWOWPercent");
			accurateOverviewDetail.Uv = _ctx.LongValue("DescribeOverviewData.AccurateOverviewDetail.Uv");
			accurateOverviewDetail.UvEverySqm = _ctx.StringValue("DescribeOverviewData.AccurateOverviewDetail.UvEverySqm");
			accurateOverviewDetail.UvAvg = _ctx.StringValue("DescribeOverviewData.AccurateOverviewDetail.UvAvg");
			accurateOverviewDetail.StayAvgPeriod = _ctx.StringValue("DescribeOverviewData.AccurateOverviewDetail.StayAvgPeriod");
			describeOverviewDataResponse.AccurateOverviewDetail = accurateOverviewDetail;
        
			return describeOverviewDataResponse;
        }
    }
}
