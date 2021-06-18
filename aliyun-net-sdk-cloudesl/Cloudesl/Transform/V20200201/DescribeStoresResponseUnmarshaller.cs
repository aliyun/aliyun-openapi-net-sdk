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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeStoresResponseUnmarshaller
    {
        public static DescribeStoresResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStoresResponse describeStoresResponse = new DescribeStoresResponse();

			describeStoresResponse.HttpResponse = _ctx.HttpResponse;
			describeStoresResponse.ErrorMessage = _ctx.StringValue("DescribeStores.ErrorMessage");
			describeStoresResponse.ErrorCode = _ctx.StringValue("DescribeStores.ErrorCode");
			describeStoresResponse.TotalCount = _ctx.IntegerValue("DescribeStores.TotalCount");
			describeStoresResponse.Message = _ctx.StringValue("DescribeStores.Message");
			describeStoresResponse.PageSize = _ctx.IntegerValue("DescribeStores.PageSize");
			describeStoresResponse.DynamicCode = _ctx.StringValue("DescribeStores.DynamicCode");
			describeStoresResponse.Code = _ctx.StringValue("DescribeStores.Code");
			describeStoresResponse.PageNumber = _ctx.IntegerValue("DescribeStores.PageNumber");
			describeStoresResponse.DynamicMessage = _ctx.StringValue("DescribeStores.DynamicMessage");
			describeStoresResponse.RequestId = _ctx.StringValue("DescribeStores.RequestId");
			describeStoresResponse.Success = _ctx.BooleanValue("DescribeStores.Success");

			List<DescribeStoresResponse.DescribeStores_StoreInfo> describeStoresResponse_stores = new List<DescribeStoresResponse.DescribeStores_StoreInfo>();
			for (int i = 0; i < _ctx.Length("DescribeStores.Stores.Length"); i++) {
				DescribeStoresResponse.DescribeStores_StoreInfo storeInfo = new DescribeStoresResponse.DescribeStores_StoreInfo();
				storeInfo.StoreName = _ctx.StringValue("DescribeStores.Stores["+ i +"].StoreName");
				storeInfo.StoreId = _ctx.StringValue("DescribeStores.Stores["+ i +"].StoreId");
				storeInfo.GmtCreate = _ctx.StringValue("DescribeStores.Stores["+ i +"].GmtCreate");
				storeInfo.ParentId = _ctx.StringValue("DescribeStores.Stores["+ i +"].ParentId");
				storeInfo.UserStoreCode = _ctx.StringValue("DescribeStores.Stores["+ i +"].UserStoreCode");
				storeInfo.GmtModified = _ctx.StringValue("DescribeStores.Stores["+ i +"].GmtModified");
				storeInfo.Phone = _ctx.StringValue("DescribeStores.Stores["+ i +"].Phone");
				storeInfo.Level = _ctx.StringValue("DescribeStores.Stores["+ i +"].Level");
				storeInfo.TemplateVersion = _ctx.StringValue("DescribeStores.Stores["+ i +"].TemplateVersion");

				describeStoresResponse_stores.Add(storeInfo);
			}
			describeStoresResponse.Stores = describeStoresResponse_stores;
        
			return describeStoresResponse;
        }
    }
}
