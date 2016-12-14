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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeSystemParametersResponseUnmarshaller
    {
        public static DescribeSystemParametersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSystemParametersResponse describeSystemParametersResponse = new DescribeSystemParametersResponse();

			describeSystemParametersResponse.HttpResponse = context.HttpResponse;
			describeSystemParametersResponse.RequestId = context.StringValue("DescribeSystemParameters.RequestId");

			List<DescribeSystemParametersResponse.SystemParamItem> systemParams = new List<DescribeSystemParametersResponse.SystemParamItem>();
			for (int i = 0; i < context.Length("DescribeSystemParameters.SystemParams.Length"); i++) {
				DescribeSystemParametersResponse.SystemParamItem systemParamItem = new DescribeSystemParametersResponse.SystemParamItem();
				systemParamItem.ParamName = context.StringValue("DescribeSystemParameters.SystemParams["+ i +"].ParamName");
				systemParamItem.ParamType = context.StringValue("DescribeSystemParameters.SystemParams["+ i +"].ParamType");
				systemParamItem.DemoValue = context.StringValue("DescribeSystemParameters.SystemParams["+ i +"].DemoValue");
				systemParamItem.Description = context.StringValue("DescribeSystemParameters.SystemParams["+ i +"].Description");

				systemParams.Add(systemParamItem);
			}
			describeSystemParametersResponse.SystemParams = systemParams;
        
			return describeSystemParametersResponse;
        }
    }
}