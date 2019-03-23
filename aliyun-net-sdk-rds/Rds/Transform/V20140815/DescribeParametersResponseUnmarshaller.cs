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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeParametersResponseUnmarshaller
    {
        public static DescribeParametersResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeParametersResponse describeParametersResponse = new DescribeParametersResponse();

            describeParametersResponse.HttpResponse = context.HttpResponse;
            describeParametersResponse.RequestId = context.StringValue("DescribeParameters.RequestId");
            describeParametersResponse.Engine = context.StringValue("DescribeParameters.Engine");
            describeParametersResponse.EngineVersion = context.StringValue("DescribeParameters.EngineVersion");

            List<DescribeParametersResponse.DescribeParameters_DBInstanceParameter> describeParametersResponse_configParameters = new List<DescribeParametersResponse.DescribeParameters_DBInstanceParameter>();
            for (int i = 0; i < context.Length("DescribeParameters.ConfigParameters.Length"); i++)
            {
                DescribeParametersResponse.DescribeParameters_DBInstanceParameter dBInstanceParameter = new DescribeParametersResponse.DescribeParameters_DBInstanceParameter();
                dBInstanceParameter.ParameterName = context.StringValue("DescribeParameters.ConfigParameters[" + i + "].ParameterName");
                dBInstanceParameter.ParameterValue = context.StringValue("DescribeParameters.ConfigParameters[" + i + "].ParameterValue");
                dBInstanceParameter.ParameterDescription = context.StringValue("DescribeParameters.ConfigParameters[" + i + "].ParameterDescription");

                describeParametersResponse_configParameters.Add(dBInstanceParameter);
            }
            describeParametersResponse.ConfigParameters = describeParametersResponse_configParameters;

            List<DescribeParametersResponse.DescribeParameters_DBInstanceParameter> describeParametersResponse_runningParameters = new List<DescribeParametersResponse.DescribeParameters_DBInstanceParameter>();
            for (int i = 0; i < context.Length("DescribeParameters.RunningParameters.Length"); i++)
            {
                DescribeParametersResponse.DescribeParameters_DBInstanceParameter dBInstanceParameter = new DescribeParametersResponse.DescribeParameters_DBInstanceParameter();
                dBInstanceParameter.ParameterName = context.StringValue("DescribeParameters.RunningParameters[" + i + "].ParameterName");
                dBInstanceParameter.ParameterValue = context.StringValue("DescribeParameters.RunningParameters[" + i + "].ParameterValue");
                dBInstanceParameter.ParameterDescription = context.StringValue("DescribeParameters.RunningParameters[" + i + "].ParameterDescription");

                describeParametersResponse_runningParameters.Add(dBInstanceParameter);
            }
            describeParametersResponse.RunningParameters = describeParametersResponse_runningParameters;

            return describeParametersResponse;
        }
    }
}