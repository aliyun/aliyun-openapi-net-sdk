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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryProductListResponseUnmarshaller
    {
        public static QueryProductListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryProductListResponse queryProductListResponse = new QueryProductListResponse();

			queryProductListResponse.HttpResponse = _ctx.HttpResponse;
			queryProductListResponse.RequestId = _ctx.StringValue("QueryProductList.RequestId");
			queryProductListResponse.Success = _ctx.BooleanValue("QueryProductList.Success");
			queryProductListResponse.Code = _ctx.StringValue("QueryProductList.Code");
			queryProductListResponse.ErrorMessage = _ctx.StringValue("QueryProductList.ErrorMessage");

			QueryProductListResponse.QueryProductList_Data data = new QueryProductListResponse.QueryProductList_Data();
			data.CurrentPage = _ctx.IntegerValue("QueryProductList.Data.CurrentPage");
			data.PageCount = _ctx.IntegerValue("QueryProductList.Data.PageCount");
			data.PageSize = _ctx.IntegerValue("QueryProductList.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryProductList.Data.Total");

			List<QueryProductListResponse.QueryProductList_Data.QueryProductList_ProductInfo> data_list = new List<QueryProductListResponse.QueryProductList_Data.QueryProductList_ProductInfo>();
			for (int i = 0; i < _ctx.Length("QueryProductList.Data.List.Length"); i++) {
				QueryProductListResponse.QueryProductList_Data.QueryProductList_ProductInfo productInfo = new QueryProductListResponse.QueryProductList_Data.QueryProductList_ProductInfo();
				productInfo.GmtCreate = _ctx.LongValue("QueryProductList.Data.List["+ i +"].GmtCreate");
				productInfo.DataFormat = _ctx.IntegerValue("QueryProductList.Data.List["+ i +"].DataFormat");
				productInfo.Description = _ctx.StringValue("QueryProductList.Data.List["+ i +"].Description");
				productInfo.DeviceCount = _ctx.IntegerValue("QueryProductList.Data.List["+ i +"].DeviceCount");
				productInfo.NodeType = _ctx.IntegerValue("QueryProductList.Data.List["+ i +"].NodeType");
				productInfo.ProductKey = _ctx.StringValue("QueryProductList.Data.List["+ i +"].ProductKey");
				productInfo.ProductName = _ctx.StringValue("QueryProductList.Data.List["+ i +"].ProductName");
				productInfo.AuthType = _ctx.StringValue("QueryProductList.Data.List["+ i +"].AuthType");

				data_list.Add(productInfo);
			}
			data.List = data_list;
			queryProductListResponse.Data = data;
        
			return queryProductListResponse;
        }
    }
}
