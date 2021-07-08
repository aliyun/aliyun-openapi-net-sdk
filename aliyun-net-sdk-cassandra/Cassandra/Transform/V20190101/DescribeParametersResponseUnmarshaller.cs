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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeParametersResponseUnmarshaller
    {
        public static DescribeParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParametersResponse describeParametersResponse = new DescribeParametersResponse();

			describeParametersResponse.HttpResponse = _ctx.HttpResponse;
			describeParametersResponse.RequestId = _ctx.StringValue("DescribeParameters.RequestId");
			describeParametersResponse.PageNumber = _ctx.IntegerValue("DescribeParameters.PageNumber");
			describeParametersResponse.PageSize = _ctx.IntegerValue("DescribeParameters.PageSize");
			describeParametersResponse.TotalCount = _ctx.LongValue("DescribeParameters.TotalCount");

			List<DescribeParametersResponse.DescribeParameters_Parameter> describeParametersResponse_parameters = new List<DescribeParametersResponse.DescribeParameters_Parameter>();
			for (int i = 0; i < _ctx.Length("DescribeParameters.Parameters.Length"); i++) {
				DescribeParametersResponse.DescribeParameters_Parameter parameter = new DescribeParametersResponse.DescribeParameters_Parameter();
				parameter.Name = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].Name");
				parameter._Value = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].Value");
				parameter.DefaultValue = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].DefaultValue");
				parameter.DataType = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].DataType");
				parameter.AllowedValues = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].AllowedValues");
				parameter.Description = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].Description");

				describeParametersResponse_parameters.Add(parameter);
			}
			describeParametersResponse.Parameters = describeParametersResponse_parameters;
        
			return describeParametersResponse;
        }
    }
}
