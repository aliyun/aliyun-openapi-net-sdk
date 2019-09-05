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
using Aliyun.Acs.CloudAPI.Model.V20160714;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeSystemParametersResponseUnmarshaller
    {
        public static DescribeSystemParametersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSystemParametersResponse describeSystemParametersResponse = new DescribeSystemParametersResponse();

			describeSystemParametersResponse.HttpResponse = context.HttpResponse;
			describeSystemParametersResponse.RequestId = context.StringValue("DescribeSystemParameters.RequestId");

			List<DescribeSystemParametersResponse.DescribeSystemParameters_SystemParamItem> describeSystemParametersResponse_systemParams = new List<DescribeSystemParametersResponse.DescribeSystemParameters_SystemParamItem>();
			for (int i = 0; i < context.Length("DescribeSystemParameters.SystemParams.Length"); i++) {
				DescribeSystemParametersResponse.DescribeSystemParameters_SystemParamItem systemParamItem = new DescribeSystemParametersResponse.DescribeSystemParameters_SystemParamItem();
				systemParamItem.ParamName = context.StringValue("DescribeSystemParameters.SystemParams["+ i +"].ParamName");
				systemParamItem.ParamType = context.StringValue("DescribeSystemParameters.SystemParams["+ i +"].ParamType");
				systemParamItem.DemoValue = context.StringValue("DescribeSystemParameters.SystemParams["+ i +"].DemoValue");
				systemParamItem.Description = context.StringValue("DescribeSystemParameters.SystemParams["+ i +"].Description");

				describeSystemParametersResponse_systemParams.Add(systemParamItem);
			}
			describeSystemParametersResponse.SystemParams = describeSystemParametersResponse_systemParams;
        
			return describeSystemParametersResponse;
        }
    }
}
