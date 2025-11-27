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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeInstanceForIsvResponseUnmarshaller
    {
        public static DescribeInstanceForIsvResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceForIsvResponse describeInstanceForIsvResponse = new DescribeInstanceForIsvResponse();

			describeInstanceForIsvResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceForIsvResponse.Status = _ctx.StringValue("DescribeInstanceForIsv.Status");
			describeInstanceForIsvResponse.ProductName = _ctx.StringValue("DescribeInstanceForIsv.ProductName");
			describeInstanceForIsvResponse.InstanceId = _ctx.LongValue("DescribeInstanceForIsv.InstanceId");
			describeInstanceForIsvResponse.ExtendJson = _ctx.StringValue("DescribeInstanceForIsv.ExtendJson");
			describeInstanceForIsvResponse.IsTrial = _ctx.BooleanValue("DescribeInstanceForIsv.IsTrial");
			describeInstanceForIsvResponse.BeganOn = _ctx.LongValue("DescribeInstanceForIsv.BeganOn");
			describeInstanceForIsvResponse.ComponentJson = _ctx.StringValue("DescribeInstanceForIsv.ComponentJson");
			describeInstanceForIsvResponse.ProductType = _ctx.StringValue("DescribeInstanceForIsv.ProductType");
			describeInstanceForIsvResponse.ProductSkuCode = _ctx.StringValue("DescribeInstanceForIsv.ProductSkuCode");
			describeInstanceForIsvResponse.CreatedOn = _ctx.LongValue("DescribeInstanceForIsv.CreatedOn");
			describeInstanceForIsvResponse.EndOn = _ctx.LongValue("DescribeInstanceForIsv.EndOn");
			describeInstanceForIsvResponse.OrderId = _ctx.LongValue("DescribeInstanceForIsv.OrderId");
			describeInstanceForIsvResponse.ProductCode = _ctx.StringValue("DescribeInstanceForIsv.ProductCode");
			describeInstanceForIsvResponse.SupplierName = _ctx.StringValue("DescribeInstanceForIsv.SupplierName");
			describeInstanceForIsvResponse.RequestId = _ctx.StringValue("DescribeInstanceForIsv.RequestId");

			DescribeInstanceForIsvResponse.DescribeInstanceForIsv_RelationalData relationalData = new DescribeInstanceForIsvResponse.DescribeInstanceForIsv_RelationalData();
			relationalData.ServiceStatus = _ctx.StringValue("DescribeInstanceForIsv.RelationalData.ServiceStatus");
			describeInstanceForIsvResponse.RelationalData = relationalData;
        
			return describeInstanceForIsvResponse;
        }
    }
}
