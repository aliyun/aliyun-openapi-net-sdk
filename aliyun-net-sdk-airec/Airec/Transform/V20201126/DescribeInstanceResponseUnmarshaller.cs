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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class DescribeInstanceResponseUnmarshaller
    {
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceResponse.Code = _ctx.StringValue("DescribeInstance.code");
			describeInstanceResponse.Message = _ctx.StringValue("DescribeInstance.message");
			describeInstanceResponse.RequestId = _ctx.StringValue("DescribeInstance.requestId");

			DescribeInstanceResponse.DescribeInstance_Result result = new DescribeInstanceResponse.DescribeInstance_Result();
			result.ChargeType = _ctx.StringValue("DescribeInstance.Result.chargeType");
			result.CommodityCode = _ctx.StringValue("DescribeInstance.Result.commodityCode");
			result.DataSetVersion = _ctx.StringValue("DescribeInstance.Result.dataSetVersion");
			result.ExpiredTime = _ctx.StringValue("DescribeInstance.Result.expiredTime");
			result.GmtCreate = _ctx.StringValue("DescribeInstance.Result.gmtCreate");
			result.GmtModified = _ctx.StringValue("DescribeInstance.Result.gmtModified");
			result.Industry = _ctx.StringValue("DescribeInstance.Result.industry");
			result.InstanceId = _ctx.StringValue("DescribeInstance.Result.instanceId");
			result.LockMode = _ctx.StringValue("DescribeInstance.Result.lockMode");
			result.Name = _ctx.StringValue("DescribeInstance.Result.name");
			result.RegionId = _ctx.StringValue("DescribeInstance.Result.regionId");
			result.Scene = _ctx.StringValue("DescribeInstance.Result.scene");
			result.Status = _ctx.StringValue("DescribeInstance.Result.status");
			result.Type = _ctx.StringValue("DescribeInstance.Result.type");
			describeInstanceResponse.Result = result;
        
			return describeInstanceResponse;
        }
    }
}
