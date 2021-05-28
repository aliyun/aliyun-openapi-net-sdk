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
    public class DescribeGatewayTypesResponseUnmarshaller
    {
        public static DescribeGatewayTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayTypesResponse describeGatewayTypesResponse = new DescribeGatewayTypesResponse();

			describeGatewayTypesResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayTypesResponse.RequestId = _ctx.StringValue("DescribeGatewayTypes.RequestId");
			describeGatewayTypesResponse.Success = _ctx.BooleanValue("DescribeGatewayTypes.Success");
			describeGatewayTypesResponse.Code = _ctx.StringValue("DescribeGatewayTypes.Code");
			describeGatewayTypesResponse.Message = _ctx.StringValue("DescribeGatewayTypes.Message");
			describeGatewayTypesResponse.Types = _ctx.StringValue("DescribeGatewayTypes.Types");
        
			return describeGatewayTypesResponse;
        }
    }
}
