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
    public class ListExecutionPlansResponseUnmarshaller
    {
        public static ListExecutionPlansResponse Unmarshall(UnmarshallerContext context)
        {
			ListExecutionPlansResponse listExecutionPlansResponse = new ListExecutionPlansResponse();

			listExecutionPlansResponse.HttpResponse = context.HttpResponse;
			listExecutionPlansResponse.RequestId = context.StringValue("ListExecutionPlans.RequestId");
			listExecutionPlansResponse.TotalCount = context.IntegerValue("ListExecutionPlans.TotalCount");
			listExecutionPlansResponse.PageNumber = context.IntegerValue("ListExecutionPlans.PageNumber");
			listExecutionPlansResponse.PageSize = context.IntegerValue("ListExecutionPlans.PageSize");

			List<ListExecutionPlansResponse.ListExecutionPlans_ExecutionPlanInfo> listExecutionPlansResponse_executionPlans = new List<ListExecutionPlansResponse.ListExecutionPlans_ExecutionPlanInfo>();
			for (int i = 0; i < context.Length("ListExecutionPlans.ExecutionPlans.Length"); i++) {
				ListExecutionPlansResponse.ListExecutionPlans_ExecutionPlanInfo executionPlanInfo = new ListExecutionPlansResponse.ListExecutionPlans_ExecutionPlanInfo();
				executionPlanInfo.Id = context.StringValue("ListExecutionPlans.ExecutionPlans["+ i +"].Id");
				executionPlanInfo.Name = context.StringValue("ListExecutionPlans.ExecutionPlans["+ i +"].Name");
				executionPlanInfo.CreateClusterOnDemand = context.BooleanValue("ListExecutionPlans.ExecutionPlans["+ i +"].CreateClusterOnDemand");
				executionPlanInfo.Stragety = context.StringValue("ListExecutionPlans.ExecutionPlans["+ i +"].Stragety");
				executionPlanInfo.Status = context.StringValue("ListExecutionPlans.ExecutionPlans["+ i +"].Status");
				executionPlanInfo.TimeInterval = context.IntegerValue("ListExecutionPlans.ExecutionPlans["+ i +"].TimeInterval");
				executionPlanInfo.StartTime = context.LongValue("ListExecutionPlans.ExecutionPlans["+ i +"].StartTime");
				executionPlanInfo.TimeUnit = context.StringValue("ListExecutionPlans.ExecutionPlans["+ i +"].TimeUnit");

				listExecutionPlansResponse_executionPlans.Add(executionPlanInfo);
			}
			listExecutionPlansResponse.ExecutionPlans = listExecutionPlansResponse_executionPlans;
        
			return listExecutionPlansResponse;
        }
    }
}
