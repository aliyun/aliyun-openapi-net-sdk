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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeElasticDailyPlanResponseUnmarshaller
    {
        public static DescribeElasticDailyPlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeElasticDailyPlanResponse describeElasticDailyPlanResponse = new DescribeElasticDailyPlanResponse();

			describeElasticDailyPlanResponse.HttpResponse = _ctx.HttpResponse;
			describeElasticDailyPlanResponse.RequestId = _ctx.StringValue("DescribeElasticDailyPlan.RequestId");

			List<DescribeElasticDailyPlanResponse.DescribeElasticDailyPlan_ElasticDailyPlanInfo> describeElasticDailyPlanResponse_elasticDailyPlanList = new List<DescribeElasticDailyPlanResponse.DescribeElasticDailyPlan_ElasticDailyPlanInfo>();
			for (int i = 0; i < _ctx.Length("DescribeElasticDailyPlan.ElasticDailyPlanList.Length"); i++) {
				DescribeElasticDailyPlanResponse.DescribeElasticDailyPlan_ElasticDailyPlanInfo elasticDailyPlanInfo = new DescribeElasticDailyPlanResponse.DescribeElasticDailyPlan_ElasticDailyPlanInfo();
				elasticDailyPlanInfo.PlanName = _ctx.StringValue("DescribeElasticDailyPlan.ElasticDailyPlanList["+ i +"].PlanName");
				elasticDailyPlanInfo.ResourcePoolName = _ctx.StringValue("DescribeElasticDailyPlan.ElasticDailyPlanList["+ i +"].ResourcePoolName");
				elasticDailyPlanInfo.ElasticNodeNum = _ctx.IntegerValue("DescribeElasticDailyPlan.ElasticDailyPlanList["+ i +"].ElasticNodeNum");
				elasticDailyPlanInfo.PlanStartTs = _ctx.StringValue("DescribeElasticDailyPlan.ElasticDailyPlanList["+ i +"].PlanStartTs");
				elasticDailyPlanInfo.PlanEndTs = _ctx.StringValue("DescribeElasticDailyPlan.ElasticDailyPlanList["+ i +"].PlanEndTs");
				elasticDailyPlanInfo.StartTs = _ctx.StringValue("DescribeElasticDailyPlan.ElasticDailyPlanList["+ i +"].StartTs");
				elasticDailyPlanInfo.EndTs = _ctx.StringValue("DescribeElasticDailyPlan.ElasticDailyPlanList["+ i +"].EndTs");
				elasticDailyPlanInfo.Day = _ctx.StringValue("DescribeElasticDailyPlan.ElasticDailyPlanList["+ i +"].Day");
				elasticDailyPlanInfo.Status = _ctx.IntegerValue("DescribeElasticDailyPlan.ElasticDailyPlanList["+ i +"].Status");

				describeElasticDailyPlanResponse_elasticDailyPlanList.Add(elasticDailyPlanInfo);
			}
			describeElasticDailyPlanResponse.ElasticDailyPlanList = describeElasticDailyPlanResponse_elasticDailyPlanList;
        
			return describeElasticDailyPlanResponse;
        }
    }
}
