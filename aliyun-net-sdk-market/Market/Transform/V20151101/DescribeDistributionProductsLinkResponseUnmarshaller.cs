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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeDistributionProductsLinkResponseUnmarshaller
    {
        public static DescribeDistributionProductsLinkResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDistributionProductsLinkResponse describeDistributionProductsLinkResponse = new DescribeDistributionProductsLinkResponse();

			describeDistributionProductsLinkResponse.HttpResponse = _ctx.HttpResponse;
			describeDistributionProductsLinkResponse.RequestId = _ctx.StringValue("DescribeDistributionProductsLink.RequestId");
			describeDistributionProductsLinkResponse.TotalCount = _ctx.LongValue("DescribeDistributionProductsLink.TotalCount");
			describeDistributionProductsLinkResponse.Success = _ctx.BooleanValue("DescribeDistributionProductsLink.Success");

			List<DescribeDistributionProductsLinkResponse.DescribeDistributionProductsLink_Item> describeDistributionProductsLinkResponse_result = new List<DescribeDistributionProductsLinkResponse.DescribeDistributionProductsLink_Item>();
			for (int i = 0; i < _ctx.Length("DescribeDistributionProductsLink.Result.Length"); i++) {
				DescribeDistributionProductsLinkResponse.DescribeDistributionProductsLink_Item item = new DescribeDistributionProductsLinkResponse.DescribeDistributionProductsLink_Item();
				item.Url = _ctx.StringValue("DescribeDistributionProductsLink.Result["+ i +"].url");
				item.Code = _ctx.StringValue("DescribeDistributionProductsLink.Result["+ i +"].code");
				item.Name = _ctx.StringValue("DescribeDistributionProductsLink.Result["+ i +"].name");

				describeDistributionProductsLinkResponse_result.Add(item);
			}
			describeDistributionProductsLinkResponse.Result = describeDistributionProductsLinkResponse_result;
        
			return describeDistributionProductsLinkResponse;
        }
    }
}
