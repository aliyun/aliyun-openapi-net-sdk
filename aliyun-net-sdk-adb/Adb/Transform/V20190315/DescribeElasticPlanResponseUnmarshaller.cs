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
    public class DescribeElasticPlanResponseUnmarshaller
    {
        public static DescribeElasticPlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeElasticPlanResponse describeElasticPlanResponse = new DescribeElasticPlanResponse();

			describeElasticPlanResponse.HttpResponse = _ctx.HttpResponse;
			describeElasticPlanResponse.RequestId = _ctx.StringValue("DescribeElasticPlan.RequestId");

			List<DescribeElasticPlanResponse.DescribeElasticPlan_ElasticPlanInfo> describeElasticPlanResponse_elasticPlanList = new List<DescribeElasticPlanResponse.DescribeElasticPlan_ElasticPlanInfo>();
			for (int i = 0; i < _ctx.Length("DescribeElasticPlan.ElasticPlanList.Length"); i++) {
				DescribeElasticPlanResponse.DescribeElasticPlan_ElasticPlanInfo elasticPlanInfo = new DescribeElasticPlanResponse.DescribeElasticPlan_ElasticPlanInfo();
				elasticPlanInfo.PlanName = _ctx.StringValue("DescribeElasticPlan.ElasticPlanList["+ i +"].PlanName");
				elasticPlanInfo.ResourcePoolName = _ctx.StringValue("DescribeElasticPlan.ElasticPlanList["+ i +"].ResourcePoolName");
				elasticPlanInfo.ElasticNodeNum = _ctx.IntegerValue("DescribeElasticPlan.ElasticPlanList["+ i +"].ElasticNodeNum");
				elasticPlanInfo.StartTime = _ctx.StringValue("DescribeElasticPlan.ElasticPlanList["+ i +"].StartTime");
				elasticPlanInfo.EndTime = _ctx.StringValue("DescribeElasticPlan.ElasticPlanList["+ i +"].EndTime");
				elasticPlanInfo.WeeklyRepeat = _ctx.StringValue("DescribeElasticPlan.ElasticPlanList["+ i +"].WeeklyRepeat");
				elasticPlanInfo.StartDay = _ctx.StringValue("DescribeElasticPlan.ElasticPlanList["+ i +"].StartDay");
				elasticPlanInfo.EndDay = _ctx.StringValue("DescribeElasticPlan.ElasticPlanList["+ i +"].EndDay");
				elasticPlanInfo.Enable = _ctx.BooleanValue("DescribeElasticPlan.ElasticPlanList["+ i +"].Enable");

				describeElasticPlanResponse_elasticPlanList.Add(elasticPlanInfo);
			}
			describeElasticPlanResponse.ElasticPlanList = describeElasticPlanResponse_elasticPlanList;
        
			return describeElasticPlanResponse;
        }
    }
}
