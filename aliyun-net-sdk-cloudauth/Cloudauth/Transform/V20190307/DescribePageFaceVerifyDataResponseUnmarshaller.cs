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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class DescribePageFaceVerifyDataResponseUnmarshaller
    {
        public static DescribePageFaceVerifyDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePageFaceVerifyDataResponse describePageFaceVerifyDataResponse = new DescribePageFaceVerifyDataResponse();

			describePageFaceVerifyDataResponse.HttpResponse = _ctx.HttpResponse;
			describePageFaceVerifyDataResponse.RequestId = _ctx.StringValue("DescribePageFaceVerifyData.RequestId");
			describePageFaceVerifyDataResponse.Success = _ctx.StringValue("DescribePageFaceVerifyData.Success");
			describePageFaceVerifyDataResponse.Code = _ctx.StringValue("DescribePageFaceVerifyData.Code");
			describePageFaceVerifyDataResponse.Message = _ctx.StringValue("DescribePageFaceVerifyData.Message");
			describePageFaceVerifyDataResponse.TotalCount = _ctx.StringValue("DescribePageFaceVerifyData.TotalCount");
			describePageFaceVerifyDataResponse.PageSize = _ctx.StringValue("DescribePageFaceVerifyData.PageSize");
			describePageFaceVerifyDataResponse.TotalPage = _ctx.StringValue("DescribePageFaceVerifyData.TotalPage");
			describePageFaceVerifyDataResponse.CurrentPage = _ctx.StringValue("DescribePageFaceVerifyData.CurrentPage");

			List<DescribePageFaceVerifyDataResponse.DescribePageFaceVerifyData_ItemsItem> describePageFaceVerifyDataResponse_items = new List<DescribePageFaceVerifyDataResponse.DescribePageFaceVerifyData_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribePageFaceVerifyData.Items.Length"); i++) {
				DescribePageFaceVerifyDataResponse.DescribePageFaceVerifyData_ItemsItem itemsItem = new DescribePageFaceVerifyDataResponse.DescribePageFaceVerifyData_ItemsItem();
				itemsItem.Date = _ctx.StringValue("DescribePageFaceVerifyData.Items["+ i +"].Date");
				itemsItem.TotalCount = _ctx.StringValue("DescribePageFaceVerifyData.Items["+ i +"].TotalCount");
				itemsItem.SuccessCount = _ctx.StringValue("DescribePageFaceVerifyData.Items["+ i +"].SuccessCount");
				itemsItem.SceneId = _ctx.StringValue("DescribePageFaceVerifyData.Items["+ i +"].SceneId");
				itemsItem.SceneName = _ctx.StringValue("DescribePageFaceVerifyData.Items["+ i +"].SceneName");
				itemsItem.ProductCode = _ctx.StringValue("DescribePageFaceVerifyData.Items["+ i +"].ProductCode");

				describePageFaceVerifyDataResponse_items.Add(itemsItem);
			}
			describePageFaceVerifyDataResponse.Items = describePageFaceVerifyDataResponse_items;
        
			return describePageFaceVerifyDataResponse;
        }
    }
}
