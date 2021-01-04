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
        public static DescribeGtmRecoveryPlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGtmRecoveryPlanResponse describeGtmRecoveryPlanResponse = new DescribeGtmRecoveryPlanResponse();

			describeGtmRecoveryPlanResponse.HttpResponse = _ctx.HttpResponse;
			describeGtmRecoveryPlanResponse.RequestId = _ctx.StringValue("DescribeGtmRecoveryPlan.RequestId");
			describeGtmRecoveryPlanResponse.RecoveryPlanId = _ctx.LongValue("DescribeGtmRecoveryPlan.RecoveryPlanId");
			describeGtmRecoveryPlanResponse.Name = _ctx.StringValue("DescribeGtmRecoveryPlan.Name");
			describeGtmRecoveryPlanResponse.Remark = _ctx.StringValue("DescribeGtmRecoveryPlan.Remark");
			describeGtmRecoveryPlanResponse.FaultAddrPoolNum = _ctx.IntegerValue("DescribeGtmRecoveryPlan.FaultAddrPoolNum");
			describeGtmRecoveryPlanResponse.Status = _ctx.StringValue("DescribeGtmRecoveryPlan.Status");
			describeGtmRecoveryPlanResponse.LastExecuteTime = _ctx.StringValue("DescribeGtmRecoveryPlan.LastExecuteTime");
			describeGtmRecoveryPlanResponse.LastExecuteTimestamp = _ctx.LongValue("DescribeGtmRecoveryPlan.LastExecuteTimestamp");
			describeGtmRecoveryPlanResponse.LastRollbackTime = _ctx.StringValue("DescribeGtmRecoveryPlan.LastRollbackTime");
			describeGtmRecoveryPlanResponse.LastRollbackTimestamp = _ctx.LongValue("DescribeGtmRecoveryPlan.LastRollbackTimestamp");
			describeGtmRecoveryPlanResponse.CreateTime = _ctx.StringValue("DescribeGtmRecoveryPlan.CreateTime");
			describeGtmRecoveryPlanResponse.CreateTimestamp = _ctx.LongValue("DescribeGtmRecoveryPlan.CreateTimestamp");
			describeGtmRecoveryPlanResponse.UpdateTime = _ctx.StringValue("DescribeGtmRecoveryPlan.UpdateTime");
			describeGtmRecoveryPlanResponse.UpdateTimestamp = _ctx.LongValue("DescribeGtmRecoveryPlan.UpdateTimestamp");

			List<DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool> describeGtmRecoveryPlanResponse_faultAddrPools = new List<DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool>();
			for (int i = 0; i < _ctx.Length("DescribeGtmRecoveryPlan.FaultAddrPools.Length"); i++) {
				DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool faultAddrPool = new DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool();
				faultAddrPool.AddrPoolId = _ctx.StringValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].AddrPoolId");
				faultAddrPool.AddrPoolName = _ctx.StringValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].AddrPoolName");
				faultAddrPool.InstanceId = _ctx.StringValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].InstanceId");

				List<DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool.DescribeGtmRecoveryPlan_Addr> faultAddrPool_addrs = new List<DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool.DescribeGtmRecoveryPlan_Addr>();
				for (int j = 0; j < _ctx.Length("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].Addrs.Length"); j++) {
					DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool.DescribeGtmRecoveryPlan_Addr addr = new DescribeGtmRecoveryPlanResponse.DescribeGtmRecoveryPlan_FaultAddrPool.DescribeGtmRecoveryPlan_Addr();
					addr.Id = _ctx.LongValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].Addrs["+ j +"].Id");
					addr.Mode = _ctx.StringValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].Addrs["+ j +"].Mode");
					addr._Value = _ctx.StringValue("DescribeGtmRecoveryPlan.FaultAddrPools["+ i +"].Addrs["+ j +"].Value");

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
