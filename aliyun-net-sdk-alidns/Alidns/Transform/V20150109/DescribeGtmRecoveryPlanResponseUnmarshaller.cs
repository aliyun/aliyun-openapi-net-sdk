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
    public class DescribeGtmRecoveryPlanResponseUnmarshaller
    {
        public static DescribeGtmRecoveryPlanResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGtmRecoveryPlanResponse describeGtmRecoveryPlanResponse = new DescribeGtmRecoveryPlanResponse();

			describeGtmRecoveryPlanResponse.HttpResponse = context.HttpResponse;
			describeGtmRecoveryPlanResponse.RequestId = context.StringValue("DescribeGtmRecoveryPlan.RequestId");
			describeGtmRecoveryPlanResponse.RecoveryPlanId = context.LongValue("DescribeGtmRecoveryPlan.RecoveryPlanId");
			describeGtmRecoveryPlanResponse.Name = context.StringValue("DescribeGtmRecoveryPlan.Name");
			describeGtmRecoveryPlanResponse.Remark = context.StringValue("DescribeGtmRecoveryPlan.Remark");
			describeGtmRecoveryPlanResponse.FaultAddrPoolNum = context.IntegerValue("DescribeGtmRecoveryPlan.FaultAddrPoolNum");
			describeGtmRecoveryPlanResponse.Status = context.StringValue("DescribeGtmRecoveryPlan.Status");
			describeGtmRecoveryPlanResponse.LastExecuteTime = context.StringValue("DescribeGtmRecoveryPlan.LastExecuteTime");
			describeGtmRecoveryPlanResponse.LastExecuteTimestamp = context.LongValue("DescribeGtmRecoveryPlan.LastExecuteTimestamp");
			describeGtmRecoveryPlanResponse.LastRollbackTime = context.StringValue("DescribeGtmRecoveryPlan.LastRollbackTime");
			describeGtmRecoveryPlanResponse.LastRollbackTimestamp = context.LongValue("DescribeGtmRecoveryPlan.LastRollbackTimestamp");
			describeGtmRecoveryPlanResponse.CreateTime = context.StringValue("DescribeGtmRecoveryPlan.CreateTime");
			describeGtmRecoveryPlanResponse.CreateTimestamp = context.LongValue("DescribeGtmRecoveryPlan.CreateTimestamp");
			describeGtmRecoveryPlanResponse.UpdateTime = context.StringValue("DescribeGtmRecoveryPlan.UpdateTime");
			describeGtmRecoveryPlanResponse.UpdateTimestamp = context.LongValue("DescribeGtmRecoveryPlan.UpdateTimestamp");

			List<DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool> describeGtmRecoveryPlanResponse_faultAddrPools = new List<DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool>();
			for (int i = 0; i < context.Length("DescribeGtmRecoveryPlan.FaultAddrPools.Length"); i++) {
				DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool faultAddrPool = new DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool();
				faultAddrPool.AddrPoolId = context.StringValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].AddrPoolId");
				faultAddrPool.AddrPoolName = context.StringValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].AddrPoolName");
				faultAddrPool.InstanceId = context.StringValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].InstanceId");

				List<DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool.DescribeGtmRecoveryPlan_Addr> faultAddrPool_addrs = new List<DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool.DescribeGtmRecoveryPlan_Addr>();
				for (int j = 0; j < context.Length("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].Addrs.Length"); j++) {
					DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool.DescribeGtmRecoveryPlan_Addr addr = new DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool.DescribeGtmRecoveryPlan_Addr();
					addr.Id = context.LongValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].Addrs["+ j +"].Id");
					addr.Mode = context.StringValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].Addrs["+ j +"].Mode");
					addr._Value = context.StringValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].Addrs["+ j +"].Value");

					faultAddrPool_addrs.Add(addr);
				}
				faultAddrPool.Addrs = faultAddrPool_addrs;

				describeGtmRecoveryPlanResponse_faultAddrPools.Add(faultAddrPool);
			}
			describeGtmRecoveryPlanResponse.FaultAddrPools = describeGtmRecoveryPlanResponse_faultAddrPools;
        
			return describeGtmRecoveryPlanResponse;
        }
    }
}
