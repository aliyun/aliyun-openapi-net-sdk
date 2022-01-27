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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeInstanceSwitchAzoneResponseUnmarshaller
    {
        public static DescribeInstanceSwitchAzoneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceSwitchAzoneResponse describeInstanceSwitchAzoneResponse = new DescribeInstanceSwitchAzoneResponse();

			describeInstanceSwitchAzoneResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceSwitchAzoneResponse.RequestId = _ctx.StringValue("DescribeInstanceSwitchAzone.RequestId");
			describeInstanceSwitchAzoneResponse.Success = _ctx.BooleanValue("DescribeInstanceSwitchAzone.Success");

			DescribeInstanceSwitchAzoneResponse.DescribeInstanceSwitchAzone_Result result = new DescribeInstanceSwitchAzoneResponse.DescribeInstanceSwitchAzone_Result();
			result.OriginAzoneId = _ctx.StringValue("DescribeInstanceSwitchAzone.Result.OriginAzoneId");
			result.RegionId = _ctx.StringValue("DescribeInstanceSwitchAzone.Result.RegionId");
			result.SwitchAble = _ctx.BooleanValue("DescribeInstanceSwitchAzone.Result.SwitchAble");

			List<string> result_targetAzones = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceSwitchAzone.Result.TargetAzones.Length"); i++) {
				result_targetAzones.Add(_ctx.StringValue("DescribeInstanceSwitchAzone.Result.TargetAzones["+ i +"]"));
			}
			result.TargetAzones = result_targetAzones;
			describeInstanceSwitchAzoneResponse.Result = result;
        
			return describeInstanceSwitchAzoneResponse;
        }
    }
}
