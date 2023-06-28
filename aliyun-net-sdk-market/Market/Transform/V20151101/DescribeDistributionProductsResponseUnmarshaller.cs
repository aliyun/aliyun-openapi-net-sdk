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
    public class DescribeDistributionProductsResponseUnmarshaller
    {
        public static DescribeDistributionProductsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDistributionProductsResponse describeDistributionProductsResponse = new DescribeDistributionProductsResponse();

			describeDistributionProductsResponse.HttpResponse = _ctx.HttpResponse;
			describeDistributionProductsResponse.RequestId = _ctx.StringValue("DescribeDistributionProducts.RequestId");
			describeDistributionProductsResponse.PageNumber = _ctx.IntegerValue("DescribeDistributionProducts.PageNumber");
			describeDistributionProductsResponse.PageSize = _ctx.IntegerValue("DescribeDistributionProducts.PageSize");
			describeDistributionProductsResponse.TotalCount = _ctx.IntegerValue("DescribeDistributionProducts.TotalCount");

			List<DescribeDistributionProductsResponse.DescribeDistributionProducts_Result> describeDistributionProductsResponse_results = new List<DescribeDistributionProductsResponse.DescribeDistributionProducts_Result>();
			for (int i = 0; i < _ctx.Length("DescribeDistributionProducts.Results.Length"); i++) {
				DescribeDistributionProductsResponse.DescribeDistributionProducts_Result result = new DescribeDistributionProductsResponse.DescribeDistributionProducts_Result();
				result.FirstCategoryName = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].FirstCategoryName");
				result.SecondCategoryName = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].SecondCategoryName");
				result.Type = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].Type");
				result.ImageUrl = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].ImageUrl");
				result.Code = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].Code");
				result.Name = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].Name");
				result.ShortDescription = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].ShortDescription");
				result.Price = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].Price");
				result.Score = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].Score");
				result.TradeCount = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].TradeCount");
				result.UserCommentCount = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].UserCommentCount");
				result.SubmissionRadio = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].SubmissionRadio");
				result.SupplierName = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].SupplierName");
				result.SupplierUId = _ctx.StringValue("DescribeDistributionProducts.Results["+ i +"].SupplierUId");

				describeDistributionProductsResponse_results.Add(result);
			}
			describeDistributionProductsResponse.Results = describeDistributionProductsResponse_results;
        
			return describeDistributionProductsResponse;
        }
    }
}
