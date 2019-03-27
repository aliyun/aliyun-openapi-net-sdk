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
using Aliyun.Acs.CSB.Model.V20171118;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class FindInstanceListResponseUnmarshaller
    {
        public static FindInstanceListResponse Unmarshall(UnmarshallerContext context)
        {
			FindInstanceListResponse findInstanceListResponse = new FindInstanceListResponse();

			findInstanceListResponse.HttpResponse = context.HttpResponse;
			findInstanceListResponse.Code = context.IntegerValue("FindInstanceList.Code");
			findInstanceListResponse.Message = context.StringValue("FindInstanceList.Message");
			findInstanceListResponse.RequestId = context.StringValue("FindInstanceList.RequestId");

			FindInstanceListResponse.FindInstanceList_Data data = new FindInstanceListResponse.FindInstanceList_Data();
			data.CurrentPage = context.IntegerValue("FindInstanceList.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindInstanceList.Data.PageNumber");

			List<FindInstanceListResponse.FindInstanceList_Data.FindInstanceList_Item> data_itemList = new List<FindInstanceListResponse.FindInstanceList_Data.FindInstanceList_Item>();
			for (int i = 0; i < context.Length("FindInstanceList.Data.ItemList.Length"); i++) {
				FindInstanceListResponse.FindInstanceList_Data.FindInstanceList_Item item = new FindInstanceListResponse.FindInstanceList_Data.FindInstanceList_Item();
				item.Description = context.StringValue("FindInstanceList.Data.ItemList["+ i +"].Description");
				item.FrontStatus = context.StringValue("FindInstanceList.Data.ItemList["+ i +"].FrontStatus");
				item.GmtCreate = context.LongValue("FindInstanceList.Data.ItemList["+ i +"].GmtCreate");
				item.GmtModified = context.LongValue("FindInstanceList.Data.ItemList["+ i +"].GmtModified");
				item.Id = context.LongValue("FindInstanceList.Data.ItemList["+ i +"].Id");
				item.InstanceCategory = context.IntegerValue("FindInstanceList.Data.ItemList["+ i +"].InstanceCategory");
				item.Name = context.StringValue("FindInstanceList.Data.ItemList["+ i +"].Name");
				item.StatusCode = context.IntegerValue("FindInstanceList.Data.ItemList["+ i +"].StatusCode");
				item.Visible = context.BooleanValue("FindInstanceList.Data.ItemList["+ i +"].Visible");
				item.VpcName = context.StringValue("FindInstanceList.Data.ItemList["+ i +"].VpcName");

				data_itemList.Add(item);
			}
			data.ItemList = data_itemList;
			findInstanceListResponse.Data = data;
        
			return findInstanceListResponse;
        }
    }
}
