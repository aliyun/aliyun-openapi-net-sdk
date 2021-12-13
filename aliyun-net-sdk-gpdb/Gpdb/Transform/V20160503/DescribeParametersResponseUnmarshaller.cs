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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeParametersResponseUnmarshaller
    {
        public static DescribeParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParametersResponse describeParametersResponse = new DescribeParametersResponse();

			describeParametersResponse.HttpResponse = _ctx.HttpResponse;
			describeParametersResponse.RequestId = _ctx.StringValue("DescribeParameters.RequestId");

			List<DescribeParametersResponse.DescribeParameters_ParametersItem> describeParametersResponse_parameters = new List<DescribeParametersResponse.DescribeParameters_ParametersItem>();
			for (int i = 0; i < _ctx.Length("DescribeParameters.Parameters.Length"); i++) {
				DescribeParametersResponse.DescribeParameters_ParametersItem parametersItem = new DescribeParametersResponse.DescribeParameters_ParametersItem();
				parametersItem.IsChangeableConfig = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].IsChangeableConfig");
				parametersItem.ForceRestartInstance = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].ForceRestartInstance");
				parametersItem.OptionalRange = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].OptionalRange");
				parametersItem.ParameterName = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].ParameterName");
				parametersItem.ParameterValue = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].ParameterValue");
				parametersItem.ParameterDescription = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].ParameterDescription");
				parametersItem.CurrentValue = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].CurrentValue");

				describeParametersResponse_parameters.Add(parametersItem);
			}
			describeParametersResponse.Parameters = describeParametersResponse_parameters;
        
			return describeParametersResponse;
        }
    }
}
