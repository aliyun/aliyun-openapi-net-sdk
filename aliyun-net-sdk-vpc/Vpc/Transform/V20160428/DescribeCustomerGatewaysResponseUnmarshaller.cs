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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeCustomerGatewaysResponseUnmarshaller
    {
        public static DescribeCustomerGatewaysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCustomerGatewaysResponse describeCustomerGatewaysResponse = new DescribeCustomerGatewaysResponse();

			describeCustomerGatewaysResponse.HttpResponse = _ctx.HttpResponse;
			describeCustomerGatewaysResponse.RequestId = _ctx.StringValue("DescribeCustomerGateways.RequestId");
			describeCustomerGatewaysResponse.TotalCount = _ctx.IntegerValue("DescribeCustomerGateways.TotalCount");
			describeCustomerGatewaysResponse.PageNumber = _ctx.IntegerValue("DescribeCustomerGateways.PageNumber");
			describeCustomerGatewaysResponse.PageSize = _ctx.IntegerValue("DescribeCustomerGateways.PageSize");

			List<DescribeCustomerGatewaysResponse.DescribeCustomerGateways_CustomerGateway> describeCustomerGatewaysResponse_customerGateways = new List<DescribeCustomerGatewaysResponse.DescribeCustomerGateways_CustomerGateway>();
			for (int i = 0; i < _ctx.Length("DescribeCustomerGateways.CustomerGateways.Length"); i++) {
				DescribeCustomerGatewaysResponse.DescribeCustomerGateways_CustomerGateway customerGateway = new DescribeCustomerGatewaysResponse.DescribeCustomerGateways_CustomerGateway();
				customerGateway.CustomerGatewayId = _ctx.StringValue("DescribeCustomerGateways.CustomerGateways["+ i +"].CustomerGatewayId");
				customerGateway.Name = _ctx.StringValue("DescribeCustomerGateways.CustomerGateways["+ i +"].Name");
				customerGateway.IpAddress = _ctx.StringValue("DescribeCustomerGateways.CustomerGateways["+ i +"].IpAddress");
				customerGateway.Description = _ctx.StringValue("DescribeCustomerGateways.CustomerGateways["+ i +"].Description");
				customerGateway.CreateTime = _ctx.LongValue("DescribeCustomerGateways.CustomerGateways["+ i +"].CreateTime");
				customerGateway.Asn = _ctx.IntegerValue("DescribeCustomerGateways.CustomerGateways["+ i +"].Asn");

				describeCustomerGatewaysResponse_customerGateways.Add(customerGateway);
			}
			describeCustomerGatewaysResponse.CustomerGateways = describeCustomerGatewaysResponse_customerGateways;
        
			return describeCustomerGatewaysResponse;
        }
    }
}
