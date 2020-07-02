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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetMetaDBTableListResponseUnmarshaller
    {
        public static GetMetaDBTableListResponse Unmarshall(UnmarshallerContext context)
        {
			GetMetaDBTableListResponse getMetaDBTableListResponse = new GetMetaDBTableListResponse();

			getMetaDBTableListResponse.HttpResponse = context.HttpResponse;
			getMetaDBTableListResponse.RequestId = context.StringValue("GetMetaDBTableList.RequestId");
			getMetaDBTableListResponse.ErrorCode = context.StringValue("GetMetaDBTableList.ErrorCode");
			getMetaDBTableListResponse.ErrorMessage = context.StringValue("GetMetaDBTableList.ErrorMessage");
			getMetaDBTableListResponse.HttpStatusCode = context.IntegerValue("GetMetaDBTableList.HttpStatusCode");
			getMetaDBTableListResponse.Success = context.BooleanValue("GetMetaDBTableList.Success");

			GetMetaDBTableListResponse.GetMetaDBTableList_Data data = new GetMetaDBTableListResponse.GetMetaDBTableList_Data();
			data.PageNumber = context.IntegerValue("GetMetaDBTableList.Data.PageNumber");
			data.PageSize = context.IntegerValue("GetMetaDBTableList.Data.PageSize");
			data.TotalCount = context.LongValue("GetMetaDBTableList.Data.TotalCount");

			List<GetMetaDBTableListResponse.GetMetaDBTableList_Data.GetMetaDBTableList_TableEntityListItem> data_tableEntityList = new List<GetMetaDBTableListResponse.GetMetaDBTableList_Data.GetMetaDBTableList_TableEntityListItem>();
			for (int i = 0; i < context.Length("GetMetaDBTableList.Data.TableEntityList.Length"); i++) {
				GetMetaDBTableListResponse.GetMetaDBTableList_Data.GetMetaDBTableList_TableEntityListItem tableEntityListItem = new GetMetaDBTableListResponse.GetMetaDBTableList_Data.GetMetaDBTableList_TableEntityListItem();
				tableEntityListItem.TableName = context.StringValue("GetMetaDBTableList.Data.TableEntityList["+ i +"].TableName");
				tableEntityListItem.TableGuid = context.StringValue("GetMetaDBTableList.Data.TableEntityList["+ i +"].TableGuid");

				data_tableEntityList.Add(tableEntityListItem);
			}
			data.TableEntityList = data_tableEntityList;
			getMetaDBTableListResponse.Data = data;
        
			return getMetaDBTableListResponse;
        }
    }
}
