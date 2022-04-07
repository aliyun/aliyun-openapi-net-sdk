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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeParametersResponseUnmarshaller
    {
        public static DescribeParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParametersResponse describeParametersResponse = new DescribeParametersResponse();

			describeParametersResponse.HttpResponse = _ctx.HttpResponse;
			describeParametersResponse.EngineVersion = _ctx.StringValue("DescribeParameters.EngineVersion");
			describeParametersResponse.RequestId = _ctx.StringValue("DescribeParameters.RequestId");
			describeParametersResponse.Engine = _ctx.StringValue("DescribeParameters.Engine");

			List<DescribeParametersResponse.DescribeParameters_Parameter> describeParametersResponse_runningParameters = new List<DescribeParametersResponse.DescribeParameters_Parameter>();
			for (int i = 0; i < _ctx.Length("DescribeParameters.RunningParameters.Length"); i++) {
				DescribeParametersResponse.DescribeParameters_Parameter parameter = new DescribeParametersResponse.DescribeParameters_Parameter();
				parameter.CheckingCode = _ctx.StringValue("DescribeParameters.RunningParameters["+ i +"].CheckingCode");
				parameter.ParameterName = _ctx.StringValue("DescribeParameters.RunningParameters["+ i +"].ParameterName");
				parameter.ParameterValue = _ctx.StringValue("DescribeParameters.RunningParameters["+ i +"].ParameterValue");
				parameter.ForceRestart = _ctx.StringValue("DescribeParameters.RunningParameters["+ i +"].ForceRestart");
				parameter.ParameterDescription = _ctx.StringValue("DescribeParameters.RunningParameters["+ i +"].ParameterDescription");
				parameter.ModifiableStatus = _ctx.StringValue("DescribeParameters.RunningParameters["+ i +"].ModifiableStatus");

				describeParametersResponse_runningParameters.Add(parameter);
			}
			describeParametersResponse.RunningParameters = describeParametersResponse_runningParameters;

			List<DescribeParametersResponse.DescribeParameters_Parameter> describeParametersResponse_configParameters = new List<DescribeParametersResponse.DescribeParameters_Parameter>();
			for (int i = 0; i < _ctx.Length("DescribeParameters.ConfigParameters.Length"); i++) {
				DescribeParametersResponse.DescribeParameters_Parameter parameter = new DescribeParametersResponse.DescribeParameters_Parameter();
				parameter.CheckingCode = _ctx.StringValue("DescribeParameters.ConfigParameters["+ i +"].CheckingCode");
				parameter.ParameterName = _ctx.StringValue("DescribeParameters.ConfigParameters["+ i +"].ParameterName");
				parameter.ParameterValue = _ctx.StringValue("DescribeParameters.ConfigParameters["+ i +"].ParameterValue");
				parameter.ForceRestart = _ctx.StringValue("DescribeParameters.ConfigParameters["+ i +"].ForceRestart");
				parameter.ParameterDescription = _ctx.StringValue("DescribeParameters.ConfigParameters["+ i +"].ParameterDescription");
				parameter.ModifiableStatus = _ctx.StringValue("DescribeParameters.ConfigParameters["+ i +"].ModifiableStatus");

				describeParametersResponse_configParameters.Add(parameter);
			}
			describeParametersResponse.ConfigParameters = describeParametersResponse_configParameters;
        
			return describeParametersResponse;
        }
    }
}
