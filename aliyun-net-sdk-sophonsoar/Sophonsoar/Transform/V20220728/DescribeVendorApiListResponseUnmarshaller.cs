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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeVendorApiListResponseUnmarshaller
    {
        public static DescribeVendorApiListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVendorApiListResponse describeVendorApiListResponse = new DescribeVendorApiListResponse();

			describeVendorApiListResponse.HttpResponse = _ctx.HttpResponse;
			describeVendorApiListResponse.RequestId = _ctx.StringValue("DescribeVendorApiList.RequestId");

			DescribeVendorApiListResponse.DescribeVendorApiList_Page page = new DescribeVendorApiListResponse.DescribeVendorApiList_Page();
			page.TotalCount = _ctx.LongValue("DescribeVendorApiList.Page.TotalCount");
			page.PageNumber = _ctx.LongValue("DescribeVendorApiList.Page.PageNumber");
			page.PageSize = _ctx.IntegerValue("DescribeVendorApiList.Page.PageSize");
			describeVendorApiListResponse.Page = page;

			List<DescribeVendorApiListResponse.DescribeVendorApiList_Data> describeVendorApiListResponse_apiList = new List<DescribeVendorApiListResponse.DescribeVendorApiList_Data>();
			for (int i = 0; i < _ctx.Length("DescribeVendorApiList.ApiList.Length"); i++) {
				DescribeVendorApiListResponse.DescribeVendorApiList_Data data = new DescribeVendorApiListResponse.DescribeVendorApiList_Data();
				data.VendorCode = _ctx.StringValue("DescribeVendorApiList.ApiList["+ i +"].VendorCode");
				data.ProductCode = _ctx.StringValue("DescribeVendorApiList.ApiList["+ i +"].ProductCode");
				data.ProductName = _ctx.StringValue("DescribeVendorApiList.ApiList["+ i +"].ProductName");
				data.Parameter = _ctx.StringValue("DescribeVendorApiList.ApiList["+ i +"].Parameter");
				data.ProductDomain = _ctx.StringValue("DescribeVendorApiList.ApiList["+ i +"].ProductDomain");
				data.Protocol = _ctx.StringValue("DescribeVendorApiList.ApiList["+ i +"].Protocol");
				data.Method = _ctx.StringValue("DescribeVendorApiList.ApiList["+ i +"].Method");
				data.ApiName = _ctx.StringValue("DescribeVendorApiList.ApiList["+ i +"].ApiName");
				data.NeedPageInfo = _ctx.BooleanValue("DescribeVendorApiList.ApiList["+ i +"].NeedPageInfo");
				data.PageInfo = _ctx.StringValue("DescribeVendorApiList.ApiList["+ i +"].PageInfo");
				data.ApiVersion = _ctx.StringValue("DescribeVendorApiList.ApiList["+ i +"].ApiVersion");
				data.NeedAdvanceConfig = _ctx.BooleanValue("DescribeVendorApiList.ApiList["+ i +"].NeedAdvanceConfig");
				data.AdvanceConfig = _ctx.StringValue("DescribeVendorApiList.ApiList["+ i +"].AdvanceConfig");

				describeVendorApiListResponse_apiList.Add(data);
			}
			describeVendorApiListResponse.ApiList = describeVendorApiListResponse_apiList;
        
			return describeVendorApiListResponse;
        }
    }
}
