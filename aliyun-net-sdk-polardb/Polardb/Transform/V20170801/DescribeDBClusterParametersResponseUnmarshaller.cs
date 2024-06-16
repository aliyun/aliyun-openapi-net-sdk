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
    public class DescribeDBClusterParametersResponseUnmarshaller
    {
        public static DescribeDBClusterParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterParametersResponse describeDBClusterParametersResponse = new DescribeDBClusterParametersResponse();

			describeDBClusterParametersResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterParametersResponse.DBVersion = _ctx.StringValue("DescribeDBClusterParameters.DBVersion");
			describeDBClusterParametersResponse.RequestId = _ctx.StringValue("DescribeDBClusterParameters.RequestId");
			describeDBClusterParametersResponse.DBType = _ctx.StringValue("DescribeDBClusterParameters.DBType");
			describeDBClusterParametersResponse.Engine = _ctx.StringValue("DescribeDBClusterParameters.Engine");
			describeDBClusterParametersResponse.DBClusterId = _ctx.StringValue("DescribeDBClusterParameters.DBClusterId");
			describeDBClusterParametersResponse.ParameterNumbers = _ctx.StringValue("DescribeDBClusterParameters.ParameterNumbers");

			List<DescribeDBClusterParametersResponse.DescribeDBClusterParameters_Parameter> describeDBClusterParametersResponse_runningParameters = new List<DescribeDBClusterParametersResponse.DescribeDBClusterParameters_Parameter>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterParameters.RunningParameters.Length"); i++) {
				DescribeDBClusterParametersResponse.DescribeDBClusterParameters_Parameter parameter = new DescribeDBClusterParametersResponse.DescribeDBClusterParameters_Parameter();
				parameter.CheckingCode = _ctx.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].CheckingCode");
				parameter.DataType = _ctx.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].DataType");
				parameter.ParameterName = _ctx.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].ParameterName");
				parameter.ParameterValue = _ctx.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].ParameterValue");
				parameter.ForceRestart = _ctx.BooleanValue("DescribeDBClusterParameters.RunningParameters["+ i +"].ForceRestart");
				parameter.ParameterDescription = _ctx.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].ParameterDescription");
				parameter.ParameterStatus = _ctx.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].ParameterStatus");
				parameter.DefaultParameterValue = _ctx.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].DefaultParameterValue");
				parameter.IsModifiable = _ctx.BooleanValue("DescribeDBClusterParameters.RunningParameters["+ i +"].IsModifiable");
				parameter.IsNodeAvailable = _ctx.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].IsNodeAvailable");
				parameter.ParamRelyRule = _ctx.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].ParamRelyRule");
				parameter.Factor = _ctx.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].Factor");

				describeDBClusterParametersResponse_runningParameters.Add(parameter);
			}
			describeDBClusterParametersResponse.RunningParameters = describeDBClusterParametersResponse_runningParameters;

			List<DescribeDBClusterParametersResponse.DescribeDBClusterParameters_ParametersItem> describeDBClusterParametersResponse_parameters = new List<DescribeDBClusterParametersResponse.DescribeDBClusterParameters_ParametersItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterParameters.Parameters.Length"); i++) {
				DescribeDBClusterParametersResponse.DescribeDBClusterParameters_ParametersItem parametersItem = new DescribeDBClusterParametersResponse.DescribeDBClusterParameters_ParametersItem();
				parametersItem.RdsParameterName = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].rdsParameterName");
				parametersItem.RdsParameterValue = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].rdsParameterValue");
				parametersItem.RdsParameterOptional = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].rdsParameterOptional");
				parametersItem.DistParameterName = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].distParameterName");
				parametersItem.DistParameterValue = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].distParameterValue");
				parametersItem.DistParameterOptional = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].distParameterOptional");
				parametersItem.IsEqual = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].IsEqual");
				parametersItem.DistParameterDescription = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].distParameterDescription");
				parametersItem.RdsParameterDescription = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].rdsParameterDescription");
				parametersItem.IsRdsKey = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].IsRdsKey");
				parametersItem.IsPolarDBKey = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].IsPolarDBKey");
				parametersItem.IsInstancePolarDBKey = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].IsInstancePolarDBKey");
				parametersItem.IsInstanceRdsKey = _ctx.StringValue("DescribeDBClusterParameters.Parameters["+ i +"].IsInstanceRdsKey");

				describeDBClusterParametersResponse_parameters.Add(parametersItem);
			}
			describeDBClusterParametersResponse.Parameters = describeDBClusterParametersResponse_parameters;
        
			return describeDBClusterParametersResponse;
        }
    }
}
