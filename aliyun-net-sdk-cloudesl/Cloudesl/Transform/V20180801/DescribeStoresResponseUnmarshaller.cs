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
using Aliyun.Acs.cloudesl.Model.V20180801;

namespace Aliyun.Acs.cloudesl.Transform.V20180801
{
    public class DescribeStoresResponseUnmarshaller
    {
        public static DescribeStoresResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStoresResponse describeStoresResponse = new DescribeStoresResponse();

			describeStoresResponse.HttpResponse = context.HttpResponse;
			describeStoresResponse.RequestId = context.StringValue("DescribeStores.RequestId");
			describeStoresResponse.Success = context.BooleanValue("DescribeStores.Success");
			describeStoresResponse.Message = context.StringValue("DescribeStores.Message");
			describeStoresResponse.ErrorCode = context.StringValue("DescribeStores.ErrorCode");
			describeStoresResponse.TotalCount = context.IntegerValue("DescribeStores.TotalCount");
			describeStoresResponse.PageNumber = context.IntegerValue("DescribeStores.PageNumber");
			describeStoresResponse.PageSize = context.IntegerValue("DescribeStores.PageSize");

			List<DescribeStoresResponse.DescribeStores_StoreInfo> describeStoresResponse_stores = new List<DescribeStoresResponse.DescribeStores_StoreInfo>();
			for (int i = 0; i < context.Length("DescribeStores.Stores.Length"); i++) {
				DescribeStoresResponse.DescribeStores_StoreInfo storeInfo = new DescribeStoresResponse.DescribeStores_StoreInfo();
				storeInfo.CompanyId = context.StringValue("DescribeStores.Stores["+ i +"].CompanyId");
				storeInfo.StoreId = context.StringValue("DescribeStores.Stores["+ i +"].StoreId");
				storeInfo.StoreName = context.StringValue("DescribeStores.Stores["+ i +"].StoreName");
				storeInfo.Brand = context.StringValue("DescribeStores.Stores["+ i +"].Brand");
				storeInfo.OutId = context.StringValue("DescribeStores.Stores["+ i +"].OutId");
				storeInfo.Phone = context.StringValue("DescribeStores.Stores["+ i +"].Phone");
				storeInfo.Level = context.StringValue("DescribeStores.Stores["+ i +"].Level");
				storeInfo.Groups = context.StringValue("DescribeStores.Stores["+ i +"].Groups");
				storeInfo.Comments = context.StringValue("DescribeStores.Stores["+ i +"].Comments");
				storeInfo.ParentId = context.StringValue("DescribeStores.Stores["+ i +"].ParentId");
				storeInfo.GmtCreate = context.StringValue("DescribeStores.Stores["+ i +"].GmtCreate");
				storeInfo.GmtModified = context.StringValue("DescribeStores.Stores["+ i +"].GmtModified");

				describeStoresResponse_stores.Add(storeInfo);
			}
			describeStoresResponse.Stores = describeStoresResponse_stores;
        
			return describeStoresResponse;
        }
    }
}
