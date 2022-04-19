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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeImageBaselineCheckSummaryResponseUnmarshaller
    {
        public static DescribeImageBaselineCheckSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageBaselineCheckSummaryResponse describeImageBaselineCheckSummaryResponse = new DescribeImageBaselineCheckSummaryResponse();

			describeImageBaselineCheckSummaryResponse.HttpResponse = _ctx.HttpResponse;
			describeImageBaselineCheckSummaryResponse.RequestId = _ctx.StringValue("DescribeImageBaselineCheckSummary.RequestId");

			DescribeImageBaselineCheckSummaryResponse.DescribeImageBaselineCheckSummary_PageInfo pageInfo = new DescribeImageBaselineCheckSummaryResponse.DescribeImageBaselineCheckSummary_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeImageBaselineCheckSummary.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeImageBaselineCheckSummary.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeImageBaselineCheckSummary.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("DescribeImageBaselineCheckSummary.PageInfo.Count");
			describeImageBaselineCheckSummaryResponse.PageInfo = pageInfo;

			List<DescribeImageBaselineCheckSummaryResponse.DescribeImageBaselineCheckSummary_BaselineResultSummaryItem> describeImageBaselineCheckSummaryResponse_baselineResultSummary = new List<DescribeImageBaselineCheckSummaryResponse.DescribeImageBaselineCheckSummary_BaselineResultSummaryItem>();
			for (int i = 0; i < _ctx.Length("DescribeImageBaselineCheckSummary.BaselineResultSummary.Length"); i++) {
				DescribeImageBaselineCheckSummaryResponse.DescribeImageBaselineCheckSummary_BaselineResultSummaryItem baselineResultSummaryItem = new DescribeImageBaselineCheckSummaryResponse.DescribeImageBaselineCheckSummary_BaselineResultSummaryItem();
				baselineResultSummaryItem.Status = _ctx.IntegerValue("DescribeImageBaselineCheckSummary.BaselineResultSummary["+ i +"].Status");
				baselineResultSummaryItem.MiddleRiskImage = _ctx.IntegerValue("DescribeImageBaselineCheckSummary.BaselineResultSummary["+ i +"].MiddleRiskImage");
				baselineResultSummaryItem.BaselineNameLevel = _ctx.StringValue("DescribeImageBaselineCheckSummary.BaselineResultSummary["+ i +"].BaselineNameLevel");
				baselineResultSummaryItem.LastScanTime = _ctx.LongValue("DescribeImageBaselineCheckSummary.BaselineResultSummary["+ i +"].LastScanTime");
				baselineResultSummaryItem.HighRiskImage = _ctx.IntegerValue("DescribeImageBaselineCheckSummary.BaselineResultSummary["+ i +"].HighRiskImage");
				baselineResultSummaryItem.BaselineNameKey = _ctx.StringValue("DescribeImageBaselineCheckSummary.BaselineResultSummary["+ i +"].BaselineNameKey");
				baselineResultSummaryItem.BaselineClassKey = _ctx.StringValue("DescribeImageBaselineCheckSummary.BaselineResultSummary["+ i +"].BaselineClassKey");
				baselineResultSummaryItem.BaselineNameAlias = _ctx.StringValue("DescribeImageBaselineCheckSummary.BaselineResultSummary["+ i +"].BaselineNameAlias");
				baselineResultSummaryItem.BaselineClassAlias = _ctx.StringValue("DescribeImageBaselineCheckSummary.BaselineResultSummary["+ i +"].BaselineClassAlias");
				baselineResultSummaryItem.FirstScanTime = _ctx.LongValue("DescribeImageBaselineCheckSummary.BaselineResultSummary["+ i +"].FirstScanTime");
				baselineResultSummaryItem.LowRiskImage = _ctx.IntegerValue("DescribeImageBaselineCheckSummary.BaselineResultSummary["+ i +"].LowRiskImage");

				describeImageBaselineCheckSummaryResponse_baselineResultSummary.Add(baselineResultSummaryItem);
			}
			describeImageBaselineCheckSummaryResponse.BaselineResultSummary = describeImageBaselineCheckSummaryResponse_baselineResultSummary;
        
			return describeImageBaselineCheckSummaryResponse;
        }
    }
}
