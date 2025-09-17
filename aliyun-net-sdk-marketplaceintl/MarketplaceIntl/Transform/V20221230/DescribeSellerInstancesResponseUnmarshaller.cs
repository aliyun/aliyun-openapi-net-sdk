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
using Aliyun.Acs.marketplaceIntl.Model.V20221230;

namespace Aliyun.Acs.marketplaceIntl.Transform.V20221230
{
    public class DescribeSellerInstancesResponseUnmarshaller
    {
        public static DescribeSellerInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSellerInstancesResponse describeSellerInstancesResponse = new DescribeSellerInstancesResponse();

			describeSellerInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeSellerInstancesResponse.RequestId = _ctx.StringValue("DescribeSellerInstances.RequestId");
			describeSellerInstancesResponse.PageSize = _ctx.LongValue("DescribeSellerInstances.PageSize");
			describeSellerInstancesResponse.Message = _ctx.StringValue("DescribeSellerInstances.Message");
			describeSellerInstancesResponse.PageNumber = _ctx.LongValue("DescribeSellerInstances.PageNumber");
			describeSellerInstancesResponse.Version = _ctx.StringValue("DescribeSellerInstances.Version");
			describeSellerInstancesResponse.Count = _ctx.LongValue("DescribeSellerInstances.Count");
			describeSellerInstancesResponse.Fatal = _ctx.BooleanValue("DescribeSellerInstances.Fatal");
			describeSellerInstancesResponse.Code = _ctx.StringValue("DescribeSellerInstances.Code");
			describeSellerInstancesResponse.Success = _ctx.BooleanValue("DescribeSellerInstances.Success");

			List<DescribeSellerInstancesResponse.DescribeSellerInstances_ResultItem> describeSellerInstancesResponse_result = new List<DescribeSellerInstancesResponse.DescribeSellerInstances_ResultItem>();
			for (int i = 0; i < _ctx.Length("DescribeSellerInstances.Result.Length"); i++) {
				DescribeSellerInstancesResponse.DescribeSellerInstances_ResultItem resultItem = new DescribeSellerInstancesResponse.DescribeSellerInstances_ResultItem();
				resultItem.AppInfo = _ctx.StringValue("DescribeSellerInstances.Result["+ i +"].AppInfo");
				resultItem.CommodityCode = _ctx.StringValue("DescribeSellerInstances.Result["+ i +"].CommodityCode");
				resultItem.CreatedOn = _ctx.LongValue("DescribeSellerInstances.Result["+ i +"].CreatedOn");
				resultItem.InstanceId = _ctx.LongValue("DescribeSellerInstances.Result["+ i +"].InstanceId");
				resultItem.InstanceStatus = _ctx.StringValue("DescribeSellerInstances.Result["+ i +"].InstanceStatus");
				resultItem.UserId = _ctx.LongValue("DescribeSellerInstances.Result["+ i +"].UserId");
				resultItem.HostInfo = _ctx.StringValue("DescribeSellerInstances.Result["+ i +"].HostInfo");
				resultItem.Info = _ctx.StringValue("DescribeSellerInstances.Result["+ i +"].Info");
				resultItem.ChargeType = _ctx.IntegerValue("DescribeSellerInstances.Result["+ i +"].ChargeType");

				describeSellerInstancesResponse_result.Add(resultItem);
			}
			describeSellerInstancesResponse.Result = describeSellerInstancesResponse_result;
        
			return describeSellerInstancesResponse;
        }
    }
}
