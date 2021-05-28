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
    public class DescribeGatewayLocationsResponseUnmarshaller
    {
        public static DescribeGatewayLocationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayLocationsResponse describeGatewayLocationsResponse = new DescribeGatewayLocationsResponse();

			describeGatewayLocationsResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayLocationsResponse.RequestId = _ctx.StringValue("DescribeGatewayLocations.RequestId");
			describeGatewayLocationsResponse.Success = _ctx.BooleanValue("DescribeGatewayLocations.Success");
			describeGatewayLocationsResponse.Code = _ctx.StringValue("DescribeGatewayLocations.Code");
			describeGatewayLocationsResponse.Message = _ctx.StringValue("DescribeGatewayLocations.Message");
			describeGatewayLocationsResponse.Locations = _ctx.StringValue("DescribeGatewayLocations.Locations");
        
			return describeGatewayLocationsResponse;
        }
    }
}
