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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeGtmRecoveryPlansResponseUnmarshaller
    {
        public static DescribeGtmRecoveryPlansResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGtmRecoveryPlansResponse describeGtmRecoveryPlansResponse = new DescribeGtmRecoveryPlansResponse();

			describeGtmRecoveryPlansResponse.HttpResponse = context.HttpResponse;
			describeGtmRecoveryPlansResponse.RequestId = context.StringValue("DescribeGtmRecoveryPlans.RequestId");
			describeGtmRecoveryPlansResponse.TotalItems = context.IntegerValue("DescribeGtmRecoveryPlans.TotalItems");
			describeGtmRecoveryPlansResponse.TotalPages = context.IntegerValue("DescribeGtmRecoveryPlans.TotalPages");
			describeGtmRecoveryPlansResponse.PageNumber = context.IntegerValue("DescribeGtmRecoveryPlans.PageNumber");
			describeGtmRecoveryPlansResponse.PageSize = context.IntegerValue("DescribeGtmRecoveryPlans.PageSize");

			List<DescribeGtmRecoveryPlansResponse.DescribeGtmRecoveryPlans_RecoveryPlan> describeGtmRecoveryPlansResponse_recoveryPlans = new List<DescribeGtmRecoveryPlansResponse.DescribeGtmRecoveryPlans_RecoveryPlan>();
			for (int i = 0; i < context.Length("DescribeGtmRecoveryPlans.RecoveryPlans.Length"); i++) {
				DescribeGtmRecoveryPlansResponse.DescribeGtmRecoveryPlans_RecoveryPlan recoveryPlan = new DescribeGtmRecoveryPlansResponse.DescribeGtmRecoveryPlans_RecoveryPlan();
				recoveryPlan.RecoveryPlanId = context.LongValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].RecoveryPlanId");
				recoveryPlan.Name = context.StringValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].Name");
				recoveryPlan.Remark = context.StringValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].Remark");
				recoveryPlan.FaultAddrPoolNum = context.IntegerValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].FaultAddrPoolNum");
				recoveryPlan.LastExecuteTime = context.StringValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].LastExecuteTime");
				recoveryPlan.LastExecuteTimestamp = context.LongValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].LastExecuteTimestamp");
				recoveryPlan.LastRollbackTime = context.StringValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].LastRollbackTime");
				recoveryPlan.LastRollbackTimestamp = context.LongValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].LastRollbackTimestamp");
				recoveryPlan.CreateTime = context.StringValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].CreateTime");
				recoveryPlan.CreateTimestamp = context.LongValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].CreateTimestamp");
				recoveryPlan.UpdateTime = context.StringValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].UpdateTime");
				recoveryPlan.UpdateTimestamp = context.LongValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].UpdateTimestamp");
				recoveryPlan.Status = context.StringValue("DescribeGtmRecoveryPlans.RecoveryPlans["+ i +"].Status");

				describeGtmRecoveryPlansResponse_recoveryPlans.Add(recoveryPlan);
			}
			describeGtmRecoveryPlansResponse.RecoveryPlans = describeGtmRecoveryPlansResponse_recoveryPlans;
        
			return describeGtmRecoveryPlansResponse;
        }
    }
}
