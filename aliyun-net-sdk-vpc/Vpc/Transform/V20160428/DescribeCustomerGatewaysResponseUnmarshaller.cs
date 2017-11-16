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
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeCustomerGatewaysResponseUnmarshaller
    {
        public static DescribeCustomerGatewaysResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCustomerGatewaysResponse describeCustomerGatewaysResponse = new DescribeCustomerGatewaysResponse();

			describeCustomerGatewaysResponse.HttpResponse = context.HttpResponse;
			describeCustomerGatewaysResponse.RequestId = context.StringValue("DescribeCustomerGateways.RequestId");
			describeCustomerGatewaysResponse.TotalCount = context.IntegerValue("DescribeCustomerGateways.TotalCount");
			describeCustomerGatewaysResponse.PageNumber = context.IntegerValue("DescribeCustomerGateways.PageNumber");
			describeCustomerGatewaysResponse.PageSize = context.IntegerValue("DescribeCustomerGateways.PageSize");

			List<DescribeCustomerGatewaysResponse.DescribeCustomerGateways_CustomerGateway> describeCustomerGatewaysResponse_customerGateways = new List<DescribeCustomerGatewaysResponse.DescribeCustomerGateways_CustomerGateway>();
			for (int i = 0; i < context.Length("DescribeCustomerGateways.CustomerGateways.Length"); i++) {
				DescribeCustomerGatewaysResponse.DescribeCustomerGateways_CustomerGateway customerGateway = new DescribeCustomerGatewaysResponse.DescribeCustomerGateways_CustomerGateway();
				customerGateway.CustomerGatewayId = context.StringValue("DescribeCustomerGateways.CustomerGateways["+ i +"].CustomerGatewayId");
				customerGateway.Name = context.StringValue("DescribeCustomerGateways.CustomerGateways["+ i +"].Name");
				customerGateway.IpAddress = context.StringValue("DescribeCustomerGateways.CustomerGateways["+ i +"].IpAddress");
				customerGateway.Description = context.StringValue("DescribeCustomerGateways.CustomerGateways["+ i +"].Description");
				customerGateway.CreateTime = context.LongValue("DescribeCustomerGateways.CustomerGateways["+ i +"].CreateTime");

				describeCustomerGatewaysResponse_customerGateways.Add(customerGateway);
			}
			describeCustomerGatewaysResponse.CustomerGateways = describeCustomerGatewaysResponse_customerGateways;
        
			return describeCustomerGatewaysResponse;
        }
    }
}