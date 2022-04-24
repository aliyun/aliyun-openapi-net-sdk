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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBNodesParametersResponseUnmarshaller
    {
        public static DescribeDBNodesParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBNodesParametersResponse describeDBNodesParametersResponse = new DescribeDBNodesParametersResponse();

			describeDBNodesParametersResponse.HttpResponse = _ctx.HttpResponse;
			describeDBNodesParametersResponse.DBVersion = _ctx.StringValue("DescribeDBNodesParameters.DBVersion");
			describeDBNodesParametersResponse.RequestId = _ctx.StringValue("DescribeDBNodesParameters.RequestId");
			describeDBNodesParametersResponse.DBType = _ctx.StringValue("DescribeDBNodesParameters.DBType");
			describeDBNodesParametersResponse.Engine = _ctx.StringValue("DescribeDBNodesParameters.Engine");

			List<DescribeDBNodesParametersResponse.DescribeDBNodesParameters_DBNodeParameter> describeDBNodesParametersResponse_dBNodeIds = new List<DescribeDBNodesParametersResponse.DescribeDBNodesParameters_DBNodeParameter>();
			for (int i = 0; i < _ctx.Length("DescribeDBNodesParameters.DBNodeIds.Length"); i++) {
				DescribeDBNodesParametersResponse.DescribeDBNodesParameters_DBNodeParameter dBNodeParameter = new DescribeDBNodesParametersResponse.DescribeDBNodesParameters_DBNodeParameter();
				dBNodeParameter.DBNodeId = _ctx.StringValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].DBNodeId");

				List<DescribeDBNodesParametersResponse.DescribeDBNodesParameters_DBNodeParameter.DescribeDBNodesParameters_Parameter> dBNodeParameter_runningParameters = new List<DescribeDBNodesParametersResponse.DescribeDBNodesParameters_DBNodeParameter.DescribeDBNodesParameters_Parameter>();
				for (int j = 0; j < _ctx.Length("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters.Length"); j++) {
					DescribeDBNodesParametersResponse.DescribeDBNodesParameters_DBNodeParameter.DescribeDBNodesParameters_Parameter parameter = new DescribeDBNodesParametersResponse.DescribeDBNodesParameters_DBNodeParameter.DescribeDBNodesParameters_Parameter();
					parameter.CheckingCode = _ctx.StringValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters["+ j +"].CheckingCode");
					parameter.DataType = _ctx.StringValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters["+ j +"].DataType");
					parameter.DefaultParameterValue = _ctx.StringValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters["+ j +"].DefaultParameterValue");
					parameter.ForceRestart = _ctx.BooleanValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters["+ j +"].ForceRestart");
					parameter.IsModifiable = _ctx.BooleanValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters["+ j +"].IsModifiable");
					parameter.ParameterDescription = _ctx.StringValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters["+ j +"].ParameterDescription");
					parameter.ParameterName = _ctx.StringValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters["+ j +"].ParameterName");
					parameter.ParameterStatus = _ctx.StringValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters["+ j +"].ParameterStatus");
					parameter.ParameterValue = _ctx.StringValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters["+ j +"].ParameterValue");
					parameter.IsNodeAvailable = _ctx.StringValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters["+ j +"].IsNodeAvailable");
					parameter.ParamRelyRule = _ctx.StringValue("DescribeDBNodesParameters.DBNodeIds["+ i +"].RunningParameters["+ j +"].ParamRelyRule");

					dBNodeParameter_runningParameters.Add(parameter);
				}
				dBNodeParameter.RunningParameters = dBNodeParameter_runningParameters;

				describeDBNodesParametersResponse_dBNodeIds.Add(dBNodeParameter);
			}
			describeDBNodesParametersResponse.DBNodeIds = describeDBNodesParametersResponse_dBNodeIds;
        
			return describeDBNodesParametersResponse;
        }
    }
}
