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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeOasSQLPlansResponseUnmarshaller
    {
        public static DescribeOasSQLPlansResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOasSQLPlansResponse describeOasSQLPlansResponse = new DescribeOasSQLPlansResponse();

			describeOasSQLPlansResponse.HttpResponse = _ctx.HttpResponse;
			describeOasSQLPlansResponse.RequestId = _ctx.StringValue("DescribeOasSQLPlans.RequestId");

			List<DescribeOasSQLPlansResponse.DescribeOasSQLPlans_DataItem> describeOasSQLPlansResponse_data = new List<DescribeOasSQLPlansResponse.DescribeOasSQLPlans_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeOasSQLPlans.Data.Length"); i++) {
				DescribeOasSQLPlansResponse.DescribeOasSQLPlans_DataItem dataItem = new DescribeOasSQLPlansResponse.DescribeOasSQLPlans_DataItem();
				dataItem.PlanHash = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].PlanHash");
				dataItem.MergedVersion = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].MergedVersion");
				dataItem.FirstLoadTime = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].FirstLoadTime");
				dataItem.PlanType = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].PlanType");
				dataItem.HitDiagnosis = _ctx.BooleanValue("DescribeOasSQLPlans.Data["+ i +"].HitDiagnosis");
				dataItem.HitPercentage = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].HitPercentage");
				dataItem.AvgCpuTime = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].AvgCpuTime");
				dataItem.Executions = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Executions");
				dataItem.PlanUnionHash = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].PlanUnionHash");
				dataItem.QuerySql = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].QuerySql");
				dataItem.Bounded = _ctx.BooleanValue("DescribeOasSQLPlans.Data["+ i +"].Bounded");

				DescribeOasSQLPlansResponse.DescribeOasSQLPlans_DataItem.DescribeOasSQLPlans_PlanExplain planExplain = new DescribeOasSQLPlansResponse.DescribeOasSQLPlans_DataItem.DescribeOasSQLPlans_PlanExplain();
				planExplain.PlanJsonString = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].PlanExplain.PlanJsonString");
				dataItem.PlanExplain = planExplain;

				List<DescribeOasSQLPlansResponse.DescribeOasSQLPlans_DataItem.DescribeOasSQLPlans_PlansItem> dataItem_plans = new List<DescribeOasSQLPlansResponse.DescribeOasSQLPlans_DataItem.DescribeOasSQLPlans_PlansItem>();
				for (int j = 0; j < _ctx.Length("DescribeOasSQLPlans.Data["+ i +"].Plans.Length"); j++) {
					DescribeOasSQLPlansResponse.DescribeOasSQLPlans_DataItem.DescribeOasSQLPlans_PlansItem plansItem = new DescribeOasSQLPlansResponse.DescribeOasSQLPlans_DataItem.DescribeOasSQLPlans_PlansItem();
					plansItem.Uid = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].Uid");
					plansItem.PlanId = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].PlanId");
					plansItem.FirstLoadTime = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].FirstLoadTime");
					plansItem.PlanType = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].PlanType");
					plansItem.PlanHash = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].PlanHash");
					plansItem.PlanSize = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].PlanSize");
					plansItem.SchemaVersion = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].SchemaVersion");
					plansItem.MergedVersion = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].MergedVersion");
					plansItem.ObServerId = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].ObServerId");
					plansItem.ObDbId = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].ObDbId");
					plansItem.ServerId = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].ServerId");
					plansItem.FirstLoadTimeUs = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].FirstLoadTimeUs");
					plansItem.HitDiagnosis = _ctx.BooleanValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].HitDiagnosis");
					plansItem.OutlineData = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].OutlineData");
					plansItem.OutlineId = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].OutlineId");
					plansItem.CollectTimeUs = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].CollectTimeUs");
					plansItem.Server = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].Server");
					plansItem.HitPercentage = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].HitPercentage");
					plansItem.Executions = _ctx.LongValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].Executions");
					plansItem.ExecPs = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].ExecPs");
					plansItem.AvgDiskReads = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].AvgDiskReads");
					plansItem.AvgDiskWrites = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].AvgDiskWrites");
					plansItem.AvgBufferGets = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].AvgBufferGets");
					plansItem.AvgApplicationWaitTime = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].AvgApplicationWaitTime");
					plansItem.AvgConcurrencyWaitTime = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].AvgConcurrencyWaitTime");
					plansItem.AvgUserIoWaitTime = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].AvgUserIoWaitTime");
					plansItem.AvgRowProcessed = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].AvgRowProcessed");
					plansItem.AvgElapsedTime = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].AvgElapsedTime");
					plansItem.AvgCpuTime = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].AvgCpuTime");
					plansItem.LargeQueryPercentage = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].LargeQueryPercentage");
					plansItem.DelayedLargeQueryPercentage = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].DelayedLargeQueryPercentage");
					plansItem.TimeoutPercentage = _ctx.DoubleValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].TimeoutPercentage");
					plansItem.TableScan = _ctx.BooleanValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].TableScan");
					plansItem.PlanUnionHash = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].PlanUnionHash");
					plansItem.SqlId = _ctx.StringValue("DescribeOasSQLPlans.Data["+ i +"].Plans["+ j +"].SqlId");

					dataItem_plans.Add(plansItem);
				}
				dataItem.Plans = dataItem_plans;

				describeOasSQLPlansResponse_data.Add(dataItem);
			}
			describeOasSQLPlansResponse.Data = describeOasSQLPlansResponse_data;
        
			return describeOasSQLPlansResponse;
        }
    }
}
