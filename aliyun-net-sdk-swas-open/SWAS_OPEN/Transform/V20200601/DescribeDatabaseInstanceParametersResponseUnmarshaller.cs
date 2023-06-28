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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class DescribeDatabaseInstanceParametersResponseUnmarshaller
    {
        public static DescribeDatabaseInstanceParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDatabaseInstanceParametersResponse describeDatabaseInstanceParametersResponse = new DescribeDatabaseInstanceParametersResponse();

			describeDatabaseInstanceParametersResponse.HttpResponse = _ctx.HttpResponse;
			describeDatabaseInstanceParametersResponse.RequestId = _ctx.StringValue("DescribeDatabaseInstanceParameters.RequestId");
			describeDatabaseInstanceParametersResponse.Engine = _ctx.StringValue("DescribeDatabaseInstanceParameters.Engine");
			describeDatabaseInstanceParametersResponse.EngineVersion = _ctx.StringValue("DescribeDatabaseInstanceParameters.EngineVersion");

			List<DescribeDatabaseInstanceParametersResponse.DescribeDatabaseInstanceParameters_ConfigParameter> describeDatabaseInstanceParametersResponse_configParameters = new List<DescribeDatabaseInstanceParametersResponse.DescribeDatabaseInstanceParameters_ConfigParameter>();
			for (int i = 0; i < _ctx.Length("DescribeDatabaseInstanceParameters.ConfigParameters.Length"); i++) {
				DescribeDatabaseInstanceParametersResponse.DescribeDatabaseInstanceParameters_ConfigParameter configParameter = new DescribeDatabaseInstanceParametersResponse.DescribeDatabaseInstanceParameters_ConfigParameter();
				configParameter.ParameterDescription = _ctx.StringValue("DescribeDatabaseInstanceParameters.ConfigParameters["+ i +"].ParameterDescription");
				configParameter.ParameterName = _ctx.StringValue("DescribeDatabaseInstanceParameters.ConfigParameters["+ i +"].ParameterName");
				configParameter.ParameterValue = _ctx.StringValue("DescribeDatabaseInstanceParameters.ConfigParameters["+ i +"].ParameterValue");
				configParameter.ForceModify = _ctx.StringValue("DescribeDatabaseInstanceParameters.ConfigParameters["+ i +"].ForceModify");
				configParameter.ForceRestart = _ctx.StringValue("DescribeDatabaseInstanceParameters.ConfigParameters["+ i +"].ForceRestart");
				configParameter.CheckingCode = _ctx.StringValue("DescribeDatabaseInstanceParameters.ConfigParameters["+ i +"].CheckingCode");

				describeDatabaseInstanceParametersResponse_configParameters.Add(configParameter);
			}
			describeDatabaseInstanceParametersResponse.ConfigParameters = describeDatabaseInstanceParametersResponse_configParameters;

			List<DescribeDatabaseInstanceParametersResponse.DescribeDatabaseInstanceParameters_RunningParameter> describeDatabaseInstanceParametersResponse_runningParameters = new List<DescribeDatabaseInstanceParametersResponse.DescribeDatabaseInstanceParameters_RunningParameter>();
			for (int i = 0; i < _ctx.Length("DescribeDatabaseInstanceParameters.RunningParameters.Length"); i++) {
				DescribeDatabaseInstanceParametersResponse.DescribeDatabaseInstanceParameters_RunningParameter runningParameter = new DescribeDatabaseInstanceParametersResponse.DescribeDatabaseInstanceParameters_RunningParameter();
				runningParameter.ParameterDescription = _ctx.StringValue("DescribeDatabaseInstanceParameters.RunningParameters["+ i +"].ParameterDescription");
				runningParameter.ParameterName = _ctx.StringValue("DescribeDatabaseInstanceParameters.RunningParameters["+ i +"].ParameterName");
				runningParameter.ParameterValue = _ctx.StringValue("DescribeDatabaseInstanceParameters.RunningParameters["+ i +"].ParameterValue");
				runningParameter.ForceModify = _ctx.StringValue("DescribeDatabaseInstanceParameters.RunningParameters["+ i +"].ForceModify");
				runningParameter.ForceRestart = _ctx.StringValue("DescribeDatabaseInstanceParameters.RunningParameters["+ i +"].ForceRestart");
				runningParameter.CheckingCode = _ctx.StringValue("DescribeDatabaseInstanceParameters.RunningParameters["+ i +"].CheckingCode");

				describeDatabaseInstanceParametersResponse_runningParameters.Add(runningParameter);
			}
			describeDatabaseInstanceParametersResponse.RunningParameters = describeDatabaseInstanceParametersResponse_runningParameters;
        
			return describeDatabaseInstanceParametersResponse;
        }
    }
}
