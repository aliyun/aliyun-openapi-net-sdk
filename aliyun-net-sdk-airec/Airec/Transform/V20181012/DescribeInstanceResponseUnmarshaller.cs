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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class DescribeInstanceResponseUnmarshaller
    {
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = context.HttpResponse;
			describeInstanceResponse.RequestId = context.StringValue("DescribeInstance.RequestId");
			describeInstanceResponse.Code = context.StringValue("DescribeInstance.Code");
			describeInstanceResponse.Message = context.StringValue("DescribeInstance.Message");

			DescribeInstanceResponse.DescribeInstance_Result result = new DescribeInstanceResponse.DescribeInstance_Result();
			result.InstanceId = context.StringValue("DescribeInstance.Result.InstanceId");
			result.ChargeType = context.StringValue("DescribeInstance.Result.ChargeType");
			result.RegionId = context.StringValue("DescribeInstance.Result.RegionId");
			result.Name = context.StringValue("DescribeInstance.Result.Name");
			result.Type = context.StringValue("DescribeInstance.Result.Type");
			result.ExpiredTime = context.StringValue("DescribeInstance.Result.ExpiredTime");
			result.GmtCreate = context.StringValue("DescribeInstance.Result.GmtCreate");
			result.GmtModified = context.StringValue("DescribeInstance.Result.GmtModified");
			result.Status = context.StringValue("DescribeInstance.Result.Status");
			result.Industry = context.StringValue("DescribeInstance.Result.Industry");
			result.Scene = context.StringValue("DescribeInstance.Result.Scene");
			result.DataSetVersion = context.StringValue("DescribeInstance.Result.DataSetVersion");
			result.CommodityCode = context.StringValue("DescribeInstance.Result.CommodityCode");
			result.LockMode = context.StringValue("DescribeInstance.Result.LockMode");
			describeInstanceResponse.Result = result;
        
			return describeInstanceResponse;
        }
    }
}
