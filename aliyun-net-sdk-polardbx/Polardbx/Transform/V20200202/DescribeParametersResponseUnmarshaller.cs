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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeParametersResponseUnmarshaller
    {
        public static DescribeParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParametersResponse describeParametersResponse = new DescribeParametersResponse();

			describeParametersResponse.HttpResponse = _ctx.HttpResponse;
			describeParametersResponse.RequestId = _ctx.StringValue("DescribeParameters.RequestId");

			DescribeParametersResponse.DescribeParameters_Data data = new DescribeParametersResponse.DescribeParameters_Data();
			data.Engine = _ctx.StringValue("DescribeParameters.Data.Engine");
			data.EngineVersion = _ctx.StringValue("DescribeParameters.Data.EngineVersion");

			List<DescribeParametersResponse.DescribeParameters_Data.DescribeParameters_DBInstanceParameter> data_configParameters = new List<DescribeParametersResponse.DescribeParameters_Data.DescribeParameters_DBInstanceParameter>();
			for (int i = 0; i < _ctx.Length("DescribeParameters.Data.ConfigParameters.Length"); i++) {
				DescribeParametersResponse.DescribeParameters_Data.DescribeParameters_DBInstanceParameter dBInstanceParameter = new DescribeParametersResponse.DescribeParameters_Data.DescribeParameters_DBInstanceParameter();
				dBInstanceParameter.ParameterDescription = _ctx.StringValue("DescribeParameters.Data.ConfigParameters["+ i +"].ParameterDescription");
				dBInstanceParameter.ParameterName = _ctx.StringValue("DescribeParameters.Data.ConfigParameters["+ i +"].ParameterName");
				dBInstanceParameter.ParameterValue = _ctx.StringValue("DescribeParameters.Data.ConfigParameters["+ i +"].ParameterValue");

				data_configParameters.Add(dBInstanceParameter);
			}
			data.ConfigParameters = data_configParameters;

			List<DescribeParametersResponse.DescribeParameters_Data.DescribeParameters_DBInstanceParameter> data_runningParameters = new List<DescribeParametersResponse.DescribeParameters_Data.DescribeParameters_DBInstanceParameter>();
			for (int i = 0; i < _ctx.Length("DescribeParameters.Data.RunningParameters.Length"); i++) {
				DescribeParametersResponse.DescribeParameters_Data.DescribeParameters_DBInstanceParameter dBInstanceParameter = new DescribeParametersResponse.DescribeParameters_Data.DescribeParameters_DBInstanceParameter();
				dBInstanceParameter.ParameterDescription = _ctx.StringValue("DescribeParameters.Data.RunningParameters["+ i +"].ParameterDescription");
				dBInstanceParameter.ParameterName = _ctx.StringValue("DescribeParameters.Data.RunningParameters["+ i +"].ParameterName");
				dBInstanceParameter.ParameterValue = _ctx.StringValue("DescribeParameters.Data.RunningParameters["+ i +"].ParameterValue");

				data_runningParameters.Add(dBInstanceParameter);
			}
			data.RunningParameters = data_runningParameters;
			describeParametersResponse.Data = data;
        
			return describeParametersResponse;
        }
    }
}
