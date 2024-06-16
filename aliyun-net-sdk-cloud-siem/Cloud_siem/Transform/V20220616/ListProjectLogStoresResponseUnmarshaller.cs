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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class ListProjectLogStoresResponseUnmarshaller
    {
        public static ListProjectLogStoresResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProjectLogStoresResponse listProjectLogStoresResponse = new ListProjectLogStoresResponse();

			listProjectLogStoresResponse.HttpResponse = _ctx.HttpResponse;
			listProjectLogStoresResponse.RequestId = _ctx.StringValue("ListProjectLogStores.RequestId");

			List<ListProjectLogStoresResponse.ListProjectLogStores_DataItem> listProjectLogStoresResponse_data = new List<ListProjectLogStoresResponse.ListProjectLogStores_DataItem>();
			for (int i = 0; i < _ctx.Length("ListProjectLogStores.Data.Length"); i++) {
				ListProjectLogStoresResponse.ListProjectLogStores_DataItem dataItem = new ListProjectLogStoresResponse.ListProjectLogStores_DataItem();
				dataItem.Project = _ctx.StringValue("ListProjectLogStores.Data["+ i +"].Project");
				dataItem.LogStore = _ctx.StringValue("ListProjectLogStores.Data["+ i +"].LogStore");
				dataItem.EndPoint = _ctx.StringValue("ListProjectLogStores.Data["+ i +"].EndPoint");
				dataItem.RegionId = _ctx.StringValue("ListProjectLogStores.Data["+ i +"].RegionId");
				dataItem.LocalName = _ctx.StringValue("ListProjectLogStores.Data["+ i +"].LocalName");
				dataItem.MainUserId = _ctx.LongValue("ListProjectLogStores.Data["+ i +"].MainUserId");
				dataItem.SubUserId = _ctx.LongValue("ListProjectLogStores.Data["+ i +"].SubUserId");
				dataItem.SubUserName = _ctx.StringValue("ListProjectLogStores.Data["+ i +"].SubUserName");

				listProjectLogStoresResponse_data.Add(dataItem);
			}
			listProjectLogStoresResponse.Data = listProjectLogStoresResponse_data;
        
			return listProjectLogStoresResponse;
        }
    }
}
