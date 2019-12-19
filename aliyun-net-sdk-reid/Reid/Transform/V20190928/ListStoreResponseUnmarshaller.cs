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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class ListStoreResponseUnmarshaller
    {
        public static ListStoreResponse Unmarshall(UnmarshallerContext context)
        {
			ListStoreResponse listStoreResponse = new ListStoreResponse();

			listStoreResponse.HttpResponse = context.HttpResponse;
			listStoreResponse.ErrorCode = context.StringValue("ListStore.ErrorCode");
			listStoreResponse.ErrorMessage = context.StringValue("ListStore.ErrorMessage");
			listStoreResponse.RequestId = context.StringValue("ListStore.RequestId");
			listStoreResponse.Success = context.BooleanValue("ListStore.Success");

			List<ListStoreResponse.ListStore_OpenStore> listStoreResponse_stores = new List<ListStoreResponse.ListStore_OpenStore>();
			for (int i = 0; i < context.Length("ListStore.Stores.Length"); i++) {
				ListStoreResponse.ListStore_OpenStore openStore = new ListStoreResponse.ListStore_OpenStore();
				openStore.StoreId = context.LongValue("ListStore.Stores["+ i +"].StoreId");
				openStore.GmtCreate = context.LongValue("ListStore.Stores["+ i +"].GmtCreate");
				openStore.Sqm = context.FloatValue("ListStore.Stores["+ i +"].Sqm");
				openStore.Status = context.IntegerValue("ListStore.Stores["+ i +"].Status");
				openStore.Name = context.StringValue("ListStore.Stores["+ i +"].Name");
				openStore.OpeningEndTime = context.StringValue("ListStore.Stores["+ i +"].OpeningEndTime");
				openStore.OpeningStartTime = context.StringValue("ListStore.Stores["+ i +"].OpeningStartTime");
				openStore.StoreType = context.StringValue("ListStore.Stores["+ i +"].StoreType");
				openStore.GmtModified = context.LongValue("ListStore.Stores["+ i +"].GmtModified");
				openStore.Address = context.StringValue("ListStore.Stores["+ i +"].Address");

				listStoreResponse_stores.Add(openStore);
			}
			listStoreResponse.Stores = listStoreResponse_stores;
        
			return listStoreResponse;
        }
    }
}
