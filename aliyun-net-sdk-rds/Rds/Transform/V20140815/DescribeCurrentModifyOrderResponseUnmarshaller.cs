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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeCurrentModifyOrderResponseUnmarshaller
    {
        public static DescribeCurrentModifyOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCurrentModifyOrderResponse describeCurrentModifyOrderResponse = new DescribeCurrentModifyOrderResponse();

			describeCurrentModifyOrderResponse.HttpResponse = _ctx.HttpResponse;
			describeCurrentModifyOrderResponse.RequestId = _ctx.StringValue("DescribeCurrentModifyOrder.RequestId");

			List<DescribeCurrentModifyOrderResponse.DescribeCurrentModifyOrder_ModifyOrderItem> describeCurrentModifyOrderResponse_modifyOrder = new List<DescribeCurrentModifyOrderResponse.DescribeCurrentModifyOrder_ModifyOrderItem>();
			for (int i = 0; i < _ctx.Length("DescribeCurrentModifyOrder.ModifyOrder.Length"); i++) {
				DescribeCurrentModifyOrderResponse.DescribeCurrentModifyOrder_ModifyOrderItem modifyOrderItem = new DescribeCurrentModifyOrderResponse.DescribeCurrentModifyOrder_ModifyOrderItem();
				modifyOrderItem.DbInstanceId = _ctx.StringValue("DescribeCurrentModifyOrder.ModifyOrder["+ i +"].DbInstanceId");
				modifyOrderItem.TargetDBInstanceClass = _ctx.StringValue("DescribeCurrentModifyOrder.ModifyOrder["+ i +"].TargetDBInstanceClass");
				modifyOrderItem.Storage = _ctx.StringValue("DescribeCurrentModifyOrder.ModifyOrder["+ i +"].Storage");
				modifyOrderItem.MemoryClass = _ctx.StringValue("DescribeCurrentModifyOrder.ModifyOrder["+ i +"].MemoryClass");
				modifyOrderItem.Cpu = _ctx.StringValue("DescribeCurrentModifyOrder.ModifyOrder["+ i +"].Cpu");
				modifyOrderItem.ClassGroup = _ctx.StringValue("DescribeCurrentModifyOrder.ModifyOrder["+ i +"].ClassGroup");
				modifyOrderItem.EffectiveTime = _ctx.StringValue("DescribeCurrentModifyOrder.ModifyOrder["+ i +"].EffectiveTime");
				modifyOrderItem.Status = _ctx.StringValue("DescribeCurrentModifyOrder.ModifyOrder["+ i +"].Status");
				modifyOrderItem.Mark = _ctx.StringValue("DescribeCurrentModifyOrder.ModifyOrder["+ i +"].Mark");

				describeCurrentModifyOrderResponse_modifyOrder.Add(modifyOrderItem);
			}
			describeCurrentModifyOrderResponse.ModifyOrder = describeCurrentModifyOrderResponse_modifyOrder;
        
			return describeCurrentModifyOrderResponse;
        }
    }
}
