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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeBindableSmartAccessGatewaysResponseUnmarshaller
    {
        public static DescribeBindableSmartAccessGatewaysResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBindableSmartAccessGatewaysResponse describeBindableSmartAccessGatewaysResponse = new DescribeBindableSmartAccessGatewaysResponse();

			describeBindableSmartAccessGatewaysResponse.HttpResponse = context.HttpResponse;
			describeBindableSmartAccessGatewaysResponse.RequestId = context.StringValue("DescribeBindableSmartAccessGateways.RequestId");
			describeBindableSmartAccessGatewaysResponse.TotalCount = context.IntegerValue("DescribeBindableSmartAccessGateways.TotalCount");
			describeBindableSmartAccessGatewaysResponse.PageNumber = context.IntegerValue("DescribeBindableSmartAccessGateways.PageNumber");
			describeBindableSmartAccessGatewaysResponse.PageSize = context.IntegerValue("DescribeBindableSmartAccessGateways.PageSize");

			List<DescribeBindableSmartAccessGatewaysResponse.DescribeBindableSmartAccessGateways_SmartAccessGateway> describeBindableSmartAccessGatewaysResponse_smartAccessGateways = new List<DescribeBindableSmartAccessGatewaysResponse.DescribeBindableSmartAccessGateways_SmartAccessGateway>();
			for (int i = 0; i < context.Length("DescribeBindableSmartAccessGateways.SmartAccessGateways.Length"); i++) {
				DescribeBindableSmartAccessGatewaysResponse.DescribeBindableSmartAccessGateways_SmartAccessGateway smartAccessGateway = new DescribeBindableSmartAccessGatewaysResponse.DescribeBindableSmartAccessGateways_SmartAccessGateway();
				smartAccessGateway.SmartAGId = context.StringValue("DescribeBindableSmartAccessGateways.SmartAccessGateways["+ i +"].SmartAGId");
				smartAccessGateway.Name = context.StringValue("DescribeBindableSmartAccessGateways.SmartAccessGateways["+ i +"].Name");
				smartAccessGateway.SmartAGUid = context.LongValue("DescribeBindableSmartAccessGateways.SmartAccessGateways["+ i +"].SmartAGUid");

				describeBindableSmartAccessGatewaysResponse_smartAccessGateways.Add(smartAccessGateway);
			}
			describeBindableSmartAccessGatewaysResponse.SmartAccessGateways = describeBindableSmartAccessGatewaysResponse_smartAccessGateways;
        
			return describeBindableSmartAccessGatewaysResponse;
        }
    }
}
