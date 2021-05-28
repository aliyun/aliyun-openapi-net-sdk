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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeGatewaysForCmsResponseUnmarshaller
    {
        public static DescribeGatewaysForCmsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewaysForCmsResponse describeGatewaysForCmsResponse = new DescribeGatewaysForCmsResponse();

			describeGatewaysForCmsResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewaysForCmsResponse.RequestId = _ctx.StringValue("DescribeGatewaysForCms.RequestId");
			describeGatewaysForCmsResponse.Success = _ctx.BooleanValue("DescribeGatewaysForCms.Success");
			describeGatewaysForCmsResponse.Code = _ctx.StringValue("DescribeGatewaysForCms.Code");
			describeGatewaysForCmsResponse.Message = _ctx.StringValue("DescribeGatewaysForCms.Message");
			describeGatewaysForCmsResponse.TotalCount = _ctx.IntegerValue("DescribeGatewaysForCms.TotalCount");
			describeGatewaysForCmsResponse.PageNumber = _ctx.IntegerValue("DescribeGatewaysForCms.PageNumber");
			describeGatewaysForCmsResponse.PageSize = _ctx.IntegerValue("DescribeGatewaysForCms.PageSize");

			List<DescribeGatewaysForCmsResponse.DescribeGatewaysForCms_Gateway> describeGatewaysForCmsResponse_gateways = new List<DescribeGatewaysForCmsResponse.DescribeGatewaysForCms_Gateway>();
			for (int i = 0; i < _ctx.Length("DescribeGatewaysForCms.Gateways.Length"); i++) {
				DescribeGatewaysForCmsResponse.DescribeGatewaysForCms_Gateway gateway = new DescribeGatewaysForCmsResponse.DescribeGatewaysForCms_Gateway();
				gateway.GatewayId = _ctx.StringValue("DescribeGatewaysForCms.Gateways["+ i +"].GatewayId");
				gateway.Name = _ctx.StringValue("DescribeGatewaysForCms.Gateways["+ i +"].Name");
				gateway.Description = _ctx.StringValue("DescribeGatewaysForCms.Gateways["+ i +"].Description");

				describeGatewaysForCmsResponse_gateways.Add(gateway);
			}
			describeGatewaysForCmsResponse.Gateways = describeGatewaysForCmsResponse_gateways;
        
			return describeGatewaysForCmsResponse;
        }
    }
}
