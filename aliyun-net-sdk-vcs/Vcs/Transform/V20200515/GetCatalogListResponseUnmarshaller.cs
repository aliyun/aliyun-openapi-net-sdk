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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class GetCatalogListResponseUnmarshaller
    {
        public static GetCatalogListResponse Unmarshall(UnmarshallerContext context)
        {
			GetCatalogListResponse getCatalogListResponse = new GetCatalogListResponse();

			getCatalogListResponse.HttpResponse = context.HttpResponse;
			getCatalogListResponse.Code = context.StringValue("GetCatalogList.Code");
			getCatalogListResponse.Message = context.StringValue("GetCatalogList.Message");
			getCatalogListResponse.RequestId = context.StringValue("GetCatalogList.RequestId");

			List<GetCatalogListResponse.GetCatalogList_DataItem> getCatalogListResponse_data = new List<GetCatalogListResponse.GetCatalogList_DataItem>();
			for (int i = 0; i < context.Length("GetCatalogList.Data.Length"); i++) {
				GetCatalogListResponse.GetCatalogList_DataItem dataItem = new GetCatalogListResponse.GetCatalogList_DataItem();
				dataItem.IsvSubId = context.StringValue("GetCatalogList.Data["+ i +"].IsvSubId");
				dataItem.ParentCatalogId = context.LongValue("GetCatalogList.Data["+ i +"].ParentCatalogId");
				dataItem.ProfileCount = context.LongValue("GetCatalogList.Data["+ i +"].ProfileCount");
				dataItem.CatalogId = context.LongValue("GetCatalogList.Data["+ i +"].CatalogId");
				dataItem.CatalogName = context.StringValue("GetCatalogList.Data["+ i +"].CatalogName");

				getCatalogListResponse_data.Add(dataItem);
			}
			getCatalogListResponse.Data = getCatalogListResponse_data;
        
			return getCatalogListResponse;
        }
    }
}
