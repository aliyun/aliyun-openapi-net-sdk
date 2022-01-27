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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class DescribeCustomerFlowByLocationResponseUnmarshaller
    {
        public static DescribeCustomerFlowByLocationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCustomerFlowByLocationResponse describeCustomerFlowByLocationResponse = new DescribeCustomerFlowByLocationResponse();

			describeCustomerFlowByLocationResponse.HttpResponse = _ctx.HttpResponse;
			describeCustomerFlowByLocationResponse.Count = _ctx.LongValue("DescribeCustomerFlowByLocation.Count");
			describeCustomerFlowByLocationResponse.StoreId = _ctx.LongValue("DescribeCustomerFlowByLocation.StoreId");
			describeCustomerFlowByLocationResponse.Percent = _ctx.FloatValue("DescribeCustomerFlowByLocation.Percent");
			describeCustomerFlowByLocationResponse.LocationName = _ctx.StringValue("DescribeCustomerFlowByLocation.LocationName");
			describeCustomerFlowByLocationResponse.RequestId = _ctx.StringValue("DescribeCustomerFlowByLocation.RequestId");
			describeCustomerFlowByLocationResponse.Success = _ctx.BooleanValue("DescribeCustomerFlowByLocation.Success");
			describeCustomerFlowByLocationResponse.DynamicMessage = _ctx.StringValue("DescribeCustomerFlowByLocation.DynamicMessage");
			describeCustomerFlowByLocationResponse.ErrorCode = _ctx.StringValue("DescribeCustomerFlowByLocation.ErrorCode");
			describeCustomerFlowByLocationResponse.ErrorMessage = _ctx.StringValue("DescribeCustomerFlowByLocation.ErrorMessage");
			describeCustomerFlowByLocationResponse.Message = _ctx.StringValue("DescribeCustomerFlowByLocation.Message");
			describeCustomerFlowByLocationResponse.Code = _ctx.StringValue("DescribeCustomerFlowByLocation.Code");
			describeCustomerFlowByLocationResponse.DynamicCode = _ctx.StringValue("DescribeCustomerFlowByLocation.DynamicCode");
			describeCustomerFlowByLocationResponse.LocationId = _ctx.LongValue("DescribeCustomerFlowByLocation.LocationId");
			describeCustomerFlowByLocationResponse.ParentLocationIds = _ctx.StringValue("DescribeCustomerFlowByLocation.ParentLocationIds");

			List<DescribeCustomerFlowByLocationResponse.DescribeCustomerFlowByLocation_CustomerFlowItem> describeCustomerFlowByLocationResponse_customerFlowItems = new List<DescribeCustomerFlowByLocationResponse.DescribeCustomerFlowByLocation_CustomerFlowItem>();
			for (int i = 0; i < _ctx.Length("DescribeCustomerFlowByLocation.CustomerFlowItems.Length"); i++) {
				DescribeCustomerFlowByLocationResponse.DescribeCustomerFlowByLocation_CustomerFlowItem customerFlowItem = new DescribeCustomerFlowByLocationResponse.DescribeCustomerFlowByLocation_CustomerFlowItem();
				customerFlowItem.Count = _ctx.LongValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].Count");
				customerFlowItem.Percent = _ctx.FloatValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].Percent");
				customerFlowItem.StoreId = _ctx.LongValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].StoreId");
				customerFlowItem.LocationName = _ctx.StringValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].LocationName");
				customerFlowItem.ParentLocationIds = _ctx.StringValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].ParentLocationIds");
				customerFlowItem.LocationId = _ctx.LongValue("DescribeCustomerFlowByLocation.CustomerFlowItems["+ i +"].LocationId");

				describeCustomerFlowByLocationResponse_customerFlowItems.Add(customerFlowItem);
			}
			describeCustomerFlowByLocationResponse.CustomerFlowItems = describeCustomerFlowByLocationResponse_customerFlowItems;
        
			return describeCustomerFlowByLocationResponse;
        }
    }
}
