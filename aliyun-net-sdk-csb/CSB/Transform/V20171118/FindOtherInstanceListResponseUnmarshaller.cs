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
    public class FindOtherInstanceListResponseUnmarshaller
    {
        public static FindOtherInstanceListResponse Unmarshall(UnmarshallerContext context)
        {
			FindOtherInstanceListResponse findOtherInstanceListResponse = new FindOtherInstanceListResponse();

			findOtherInstanceListResponse.HttpResponse = context.HttpResponse;
			findOtherInstanceListResponse.Code = context.IntegerValue("FindOtherInstanceList.Code");
			findOtherInstanceListResponse.Message = context.StringValue("FindOtherInstanceList.Message");
			findOtherInstanceListResponse.RequestId = context.StringValue("FindOtherInstanceList.RequestId");

			FindOtherInstanceListResponse.FindOtherInstanceList_Data data = new FindOtherInstanceListResponse.FindOtherInstanceList_Data();
			data.CurrentPage = context.IntegerValue("FindOtherInstanceList.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindOtherInstanceList.Data.PageNumber");

			List<FindOtherInstanceListResponse.FindOtherInstanceList_Data.FindOtherInstanceList_Item> data_itemList = new List<FindOtherInstanceListResponse.FindOtherInstanceList_Data.FindOtherInstanceList_Item>();
			for (int i = 0; i < context.Length("FindOtherInstanceList.Data.ItemList.Length"); i++) {
				FindOtherInstanceListResponse.FindOtherInstanceList_Data.FindOtherInstanceList_Item item = new FindOtherInstanceListResponse.FindOtherInstanceList_Data.FindOtherInstanceList_Item();
				item.Description = context.StringValue("FindOtherInstanceList.Data.ItemList["+ i +"].Description");
				item.RunStatus = context.StringValue("FindOtherInstanceList.Data.ItemList["+ i +"].RunStatus");
				item.GmtCreate = context.LongValue("FindOtherInstanceList.Data.ItemList["+ i +"].GmtCreate");
				item.GmtModified = context.LongValue("FindOtherInstanceList.Data.ItemList["+ i +"].GmtModified");
				item.Id = context.LongValue("FindOtherInstanceList.Data.ItemList["+ i +"].Id");
				item.InstanceCategory = context.IntegerValue("FindOtherInstanceList.Data.ItemList["+ i +"].InstanceCategory");
				item.Name = context.StringValue("FindOtherInstanceList.Data.ItemList["+ i +"].Name");
				item.StatusStr = context.StringValue("FindOtherInstanceList.Data.ItemList["+ i +"].StatusStr");
				item.OwnerId = context.LongValue("FindOtherInstanceList.Data.ItemList["+ i +"].OwnerId");
				item.VpcName = context.StringValue("FindOtherInstanceList.Data.ItemList["+ i +"].VpcName");

				data_itemList.Add(item);
			}
			data.ItemList = data_itemList;
			findOtherInstanceListResponse.Data = data;
        
			return findOtherInstanceListResponse;
        }
    }
}
