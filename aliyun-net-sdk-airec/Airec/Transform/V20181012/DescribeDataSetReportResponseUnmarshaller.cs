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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class DescribeDataSetReportResponseUnmarshaller
    {
        public static DescribeDataSetReportResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataSetReportResponse describeDataSetReportResponse = new DescribeDataSetReportResponse();

			describeDataSetReportResponse.HttpResponse = context.HttpResponse;
			describeDataSetReportResponse.RequestId = context.StringValue("DescribeDataSetReport.RequestId");
			describeDataSetReportResponse.Code = context.StringValue("DescribeDataSetReport.Code");
			describeDataSetReportResponse.Message = context.StringValue("DescribeDataSetReport.Message");

			DescribeDataSetReportResponse.DescribeDataSetReport_Result result = new DescribeDataSetReportResponse.DescribeDataSetReport_Result();

			DescribeDataSetReportResponse.DescribeDataSetReport_Result.DescribeDataSetReport_Overall overall = new DescribeDataSetReportResponse.DescribeDataSetReport_Result.DescribeDataSetReport_Overall();
			overall.BhvCount = context.IntegerValue("DescribeDataSetReport.Result.Overall.BhvCount");
			overall.ItemItemCount = context.IntegerValue("DescribeDataSetReport.Result.Overall.ItemItemCount");
			overall.UserUserCount = context.IntegerValue("DescribeDataSetReport.Result.Overall.UserUserCount");
			overall.ItemRepetitiveRate = context.FloatValue("DescribeDataSetReport.Result.Overall.ItemRepetitiveRate");
			overall.UserRepetitiveRate = context.FloatValue("DescribeDataSetReport.Result.Overall.UserRepetitiveRate");
			overall.UserLegalRate = context.FloatValue("DescribeDataSetReport.Result.Overall.UserLegalRate");
			overall.ItemLegalRate = context.FloatValue("DescribeDataSetReport.Result.Overall.ItemLegalRate");
			overall.BhvLegalRate = context.FloatValue("DescribeDataSetReport.Result.Overall.BhvLegalRate");
			overall.UserCompleteRate = context.FloatValue("DescribeDataSetReport.Result.Overall.UserCompleteRate");
			overall.ItemCompleteRate = context.FloatValue("DescribeDataSetReport.Result.Overall.ItemCompleteRate");
			overall.UserLoginRate = context.FloatValue("DescribeDataSetReport.Result.Overall.UserLoginRate");
			overall.ItemLoginRate = context.FloatValue("DescribeDataSetReport.Result.Overall.ItemLoginRate");
			result.Overall = overall;

			List<DescribeDataSetReportResponse.DescribeDataSetReport_Result.DescribeDataSetReport_DetailItem> result_detail = new List<DescribeDataSetReportResponse.DescribeDataSetReport_Result.DescribeDataSetReport_DetailItem>();
			for (int i = 0; i < context.Length("DescribeDataSetReport.Result.Detail.Length"); i++) {
				DescribeDataSetReportResponse.DescribeDataSetReport_Result.DescribeDataSetReport_DetailItem detailItem = new DescribeDataSetReportResponse.DescribeDataSetReport_Result.DescribeDataSetReport_DetailItem();
				detailItem.BizDate = context.LongValue("DescribeDataSetReport.Result.Detail["+ i +"].BizDate");
				detailItem.Pv = context.LongValue("DescribeDataSetReport.Result.Detail["+ i +"].Pv");
				detailItem.Uv = context.LongValue("DescribeDataSetReport.Result.Detail["+ i +"].Uv");
				detailItem.Click = context.LongValue("DescribeDataSetReport.Result.Detail["+ i +"].Click");
				detailItem.Ctr = context.FloatValue("DescribeDataSetReport.Result.Detail["+ i +"].Ctr");
				detailItem.UvCtr = context.FloatValue("DescribeDataSetReport.Result.Detail["+ i +"].UvCtr");
				detailItem.PerUvBhv = context.FloatValue("DescribeDataSetReport.Result.Detail["+ i +"].PerUvBhv");
				detailItem.PerUvClick = context.FloatValue("DescribeDataSetReport.Result.Detail["+ i +"].PerUvClick");
				detailItem.ClickUser = context.LongValue("DescribeDataSetReport.Result.Detail["+ i +"].ClickUser");
				detailItem.ActiveItem = context.LongValue("DescribeDataSetReport.Result.Detail["+ i +"].ActiveItem");

				result_detail.Add(detailItem);
			}
			result.Detail = result_detail;
			describeDataSetReportResponse.Result = result;
        
			return describeDataSetReportResponse;
        }
    }
}
