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
using Aliyun.Acs.Rds.Model.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeParametersResponseUnmarshaller
    {
        public static DescribeParametersResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeParametersResponse describeParametersResponse = new DescribeParametersResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeParameters.RequestId"),
                Engine = context.StringValue("DescribeParameters.Engine"),
                EngineVersion = context.StringValue("DescribeParameters.EngineVersion")
            };
            List<DescribeParametersResponse.DBInstanceParameter> configParameters = new List<DescribeParametersResponse.DBInstanceParameter>();
			for (int i = 0; i < context.Length("DescribeParameters.ConfigParameters.Length"); i++) {
                DescribeParametersResponse.DBInstanceParameter dBInstanceParameter = new DescribeParametersResponse.DBInstanceParameter()
                {
                    ParameterName = context.StringValue($"DescribeParameters.ConfigParameters[{i}].ParameterName"),
                    ParameterValue = context.StringValue($"DescribeParameters.ConfigParameters[{i}].ParameterValue"),
                    ParameterDescription = context.StringValue($"DescribeParameters.ConfigParameters[{i}].ParameterDescription")
                };
                configParameters.Add(dBInstanceParameter);
			}
			describeParametersResponse.ConfigParameters = configParameters;

			List<DescribeParametersResponse.DBInstanceParameter> runningParameters = new List<DescribeParametersResponse.DBInstanceParameter>();
			for (int i = 0; i < context.Length("DescribeParameters.RunningParameters.Length"); i++) {
                DescribeParametersResponse.DBInstanceParameter dBInstanceParameter = new DescribeParametersResponse.DBInstanceParameter()
                {
                    ParameterName = context.StringValue($"DescribeParameters.RunningParameters[{i}].ParameterName"),
                    ParameterValue = context.StringValue($"DescribeParameters.RunningParameters[{i}].ParameterValue"),
                    ParameterDescription = context.StringValue($"DescribeParameters.RunningParameters[{i}].ParameterDescription")
                };
                runningParameters.Add(dBInstanceParameter);
			}
			describeParametersResponse.RunningParameters = runningParameters;
        
			return describeParametersResponse;
        }
    }
}