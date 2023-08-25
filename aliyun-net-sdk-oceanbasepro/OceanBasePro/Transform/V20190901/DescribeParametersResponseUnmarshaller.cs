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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeParametersResponseUnmarshaller
    {
        public static DescribeParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParametersResponse describeParametersResponse = new DescribeParametersResponse();

			describeParametersResponse.HttpResponse = _ctx.HttpResponse;
			describeParametersResponse.RequestId = _ctx.StringValue("DescribeParameters.RequestId");

			List<DescribeParametersResponse.DescribeParameters_Data> describeParametersResponse_parameters = new List<DescribeParametersResponse.DescribeParameters_Data>();
			for (int i = 0; i < _ctx.Length("DescribeParameters.Parameters.Length"); i++) {
				DescribeParametersResponse.DescribeParameters_Data data = new DescribeParametersResponse.DescribeParameters_Data();
				data.Description = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].Description");
				data.ValueType = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].ValueType");
				data.CurrentValue = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].CurrentValue");
				data.NeedReboot = _ctx.BooleanValue("DescribeParameters.Parameters["+ i +"].NeedReboot");
				data.Name = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].Name");
				data.DefaultValue = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].DefaultValue");
				data._Readonly = _ctx.BooleanValue("DescribeParameters.Parameters["+ i +"].Readonly");
				data.Unit = _ctx.StringValue("DescribeParameters.Parameters["+ i +"].Unit");

				List<string> data_rejectedValue = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeParameters.Parameters["+ i +"].RejectedValue.Length"); j++) {
					data_rejectedValue.Add(_ctx.StringValue("DescribeParameters.Parameters["+ i +"].RejectedValue["+ j +"]"));
				}
				data.RejectedValue = data_rejectedValue;

				List<string> data_acceptableValue = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeParameters.Parameters["+ i +"].AcceptableValue.Length"); j++) {
					data_acceptableValue.Add(_ctx.StringValue("DescribeParameters.Parameters["+ i +"].AcceptableValue["+ j +"]"));
				}
				data.AcceptableValue = data_acceptableValue;

				describeParametersResponse_parameters.Add(data);
			}
			describeParametersResponse.Parameters = describeParametersResponse_parameters;
        
			return describeParametersResponse;
        }
    }
}
