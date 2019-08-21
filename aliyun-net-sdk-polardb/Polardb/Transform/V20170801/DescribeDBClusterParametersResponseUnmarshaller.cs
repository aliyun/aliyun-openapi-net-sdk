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
        public static DescribeDBClusterParametersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBClusterParametersResponse describeDBClusterParametersResponse = new DescribeDBClusterParametersResponse();

			describeDBClusterParametersResponse.HttpResponse = context.HttpResponse;
			describeDBClusterParametersResponse.RequestId = context.StringValue("DescribeDBClusterParameters.RequestId");
			describeDBClusterParametersResponse.Engine = context.StringValue("DescribeDBClusterParameters.Engine");
			describeDBClusterParametersResponse.DBType = context.StringValue("DescribeDBClusterParameters.DBType");
			describeDBClusterParametersResponse.DBVersion = context.StringValue("DescribeDBClusterParameters.DBVersion");

			List<DescribeDBClusterParametersResponse.DescribeDBClusterParameters_Parameter> describeDBClusterParametersResponse_runningParameters = new List<DescribeDBClusterParametersResponse.DescribeDBClusterParameters_Parameter>();
			for (int i = 0; i < context.Length("DescribeDBClusterParameters.RunningParameters.Length"); i++) {
				DescribeDBClusterParametersResponse.DescribeDBClusterParameters_Parameter parameter = new DescribeDBClusterParametersResponse.DescribeDBClusterParameters_Parameter();
				parameter.ParameterName = context.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].ParameterName");
				parameter.DataType = context.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].DataType");
				parameter.DefaultParameterValue = context.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].DefaultParameterValue");
				parameter.ParameterValue = context.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].ParameterValue");
				parameter.IsModifiable = context.BooleanValue("DescribeDBClusterParameters.RunningParameters["+ i +"].IsModifiable");
				parameter.ForceRestart = context.BooleanValue("DescribeDBClusterParameters.RunningParameters["+ i +"].ForceRestart");
				parameter.ParameterStatus = context.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].ParameterStatus");
				parameter.CheckingCode = context.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].CheckingCode");
				parameter.ParameterDescription = context.StringValue("DescribeDBClusterParameters.RunningParameters["+ i +"].ParameterDescription");

				describeDBClusterParametersResponse_runningParameters.Add(parameter);
			}
			describeDBClusterParametersResponse.RunningParameters = describeDBClusterParametersResponse_runningParameters;
        
			return describeDBClusterParametersResponse;
        }
    }
}
