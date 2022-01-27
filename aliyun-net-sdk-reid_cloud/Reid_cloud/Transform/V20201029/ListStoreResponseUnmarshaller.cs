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
    public class ListStoreResponseUnmarshaller
    {
        public static ListStoreResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStoreResponse listStoreResponse = new ListStoreResponse();

			listStoreResponse.HttpResponse = _ctx.HttpResponse;
			listStoreResponse.ErrorCode = _ctx.StringValue("ListStore.ErrorCode");
			listStoreResponse.ErrorMessage = _ctx.StringValue("ListStore.ErrorMessage");
			listStoreResponse.Message = _ctx.StringValue("ListStore.Message");
			listStoreResponse.Code = _ctx.StringValue("ListStore.Code");
			listStoreResponse.DynamicCode = _ctx.StringValue("ListStore.DynamicCode");
			listStoreResponse.RequestId = _ctx.StringValue("ListStore.RequestId");
			listStoreResponse.Success = _ctx.BooleanValue("ListStore.Success");
			listStoreResponse.DynamicMessage = _ctx.StringValue("ListStore.DynamicMessage");

			List<ListStoreResponse.ListStore_OpenStore> listStoreResponse_stores = new List<ListStoreResponse.ListStore_OpenStore>();
			for (int i = 0; i < _ctx.Length("ListStore.Stores.Length"); i++) {
				ListStoreResponse.ListStore_OpenStore openStore = new ListStoreResponse.ListStore_OpenStore();
				openStore.StoreId = _ctx.LongValue("ListStore.Stores["+ i +"].StoreId");
				openStore.GmtCreate = _ctx.LongValue("ListStore.Stores["+ i +"].GmtCreate");
				openStore.Sqm = _ctx.FloatValue("ListStore.Stores["+ i +"].Sqm");
				openStore.Status = _ctx.IntegerValue("ListStore.Stores["+ i +"].Status");
				openStore.Name = _ctx.StringValue("ListStore.Stores["+ i +"].Name");
				openStore.OpeningEndTime = _ctx.StringValue("ListStore.Stores["+ i +"].OpeningEndTime");
				openStore.OpeningStartTime = _ctx.StringValue("ListStore.Stores["+ i +"].OpeningStartTime");
				openStore.StoreType = _ctx.StringValue("ListStore.Stores["+ i +"].StoreType");
				openStore.GmtModified = _ctx.LongValue("ListStore.Stores["+ i +"].GmtModified");
				openStore.Address = _ctx.StringValue("ListStore.Stores["+ i +"].Address");

				listStoreResponse_stores.Add(openStore);
			}
			listStoreResponse.Stores = listStoreResponse_stores;
        
			return listStoreResponse;
        }
    }
}
