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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class DescribeCustomerFlowByLocationResponseUnmarshaller
    {
        public static DescribeCustomerFlowByLocationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCustomerFlowByLocationResponse describeCustomerFlowByLocationResponse = new DescribeCustomerFlowByLocationResponse();

			describeCustomerFlowByLocationResponse.HttpResponse = context.HttpResponse;
			describeCustomerFlowByLocationResponse.LocationId = context.LongValue("DescribeCustomerFlowByLocation.LocationId");
			describeCustomerFlowByLocationResponse.ParentLocationIds = context.StringValue("DescribeCustomerFlowByLocation.ParentLocationIds");
			describeCustomerFlowByLocationResponse.RequestId = context.StringValue("DescribeCustomerFlowByLocation.RequestId");
			describeCustomerFlowByLocationResponse.Success = context.BooleanValue("DescribeCustomerFlowByLocation.Success");
			describeCustomerFlowByLocationResponse.ErrorCode = context.StringValue("DescribeCustomerFlowByLocation.ErrorCode");
			describeCustomerFlowByLocationResponse.ErrorMessage = context.StringValue("DescribeCustomerFlowByLocation.ErrorMessage");
			describeCustomerFlowByLocationResponse.LocationName = context.StringValue("DescribeCustomerFlowByLocation.LocationName");
			describeCustomerFlowByLocationResponse.Percent = context.FloatValue("DescribeCustomerFlowByLocation.Percent");
			describeCustomerFlowByLocationResponse.StoreId = context.LongValue("DescribeCustomerFlowByLocation.StoreId");
			describeCustomerFlowByLocationResponse.Count = context.LongValue("DescribeCustomerFlowByLocation.Count");

			List<DescribeCustomerFlowByLocationResponse.DescribeCustomerFlowByLocation_CustomerFlowItem> describeCustomerFlowByLocationResponse_customerFlowItems = new List<DescribeCustomerFlowByLocationResponse.DescribeCustomerFlowByLocation_CustomerFlowItem>();
			for (int i = 0; i < context.Length("DescribeCustomerFlowByLocation.CustomerFlowItems.Length"); i++) {
				DescribeCustomerFlowByLocationResponse.DescribeCustomerFlowByLocation_CustomerFlowItem customerFlowItem = new DescribeCustomerFlowByLocationResponse.DescribeCustomerFlowByLocation_CustomerFlowItem();
				customerFlowItem.Count = context.LongValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].Count");
				customerFlowItem.StoreId = context.LongValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].StoreId");
				customerFlowItem.Percent = context.FloatValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].Percent");
				customerFlowItem.LocationName = context.StringValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].LocationName");
				customerFlowItem.ParentLocationIds = context.StringValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].ParentLocationIds");
				customerFlowItem.LocationId = context.LongValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].LocationId");

				describeCustomerFlowByLocationResponse_customerFlowItems.Add(customerFlowItem);
			}
			describeCustomerFlowByLocationResponse.CustomerFlowItems = describeCustomerFlowByLocationResponse_customerFlowItems;
        
			return describeCustomerFlowByLocationResponse;
        }
    }
}
