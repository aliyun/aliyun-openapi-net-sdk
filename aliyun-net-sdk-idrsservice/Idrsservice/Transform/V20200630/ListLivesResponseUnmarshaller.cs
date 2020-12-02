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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class ListLivesResponseUnmarshaller
    {
        public static ListLivesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLivesResponse listLivesResponse = new ListLivesResponse();

			listLivesResponse.HttpResponse = _ctx.HttpResponse;
			listLivesResponse.Code = _ctx.StringValue("ListLives.Code");
			listLivesResponse.Message = _ctx.StringValue("ListLives.Message");
			listLivesResponse.RequestId = _ctx.StringValue("ListLives.RequestId");

			ListLivesResponse.ListLives_Data data = new ListLivesResponse.ListLives_Data();
			data.TotalElements = _ctx.LongValue("ListLives.Data.TotalElements");
			data.TotalPages = _ctx.IntegerValue("ListLives.Data.TotalPages");

			List<ListLivesResponse.ListLives_Data.ListLives_ItemsItem> data_items = new List<ListLivesResponse.ListLives_Data.ListLives_ItemsItem>();
			for (int i = 0; i < _ctx.Length("ListLives.Data.Items.Length"); i++) {
				ListLivesResponse.ListLives_Data.ListLives_ItemsItem itemsItem = new ListLivesResponse.ListLives_Data.ListLives_ItemsItem();
				itemsItem.Channel = _ctx.StringValue("ListLives.Data.Items["+ i +"].Channel");
				itemsItem.CreatedAt = _ctx.StringValue("ListLives.Data.Items["+ i +"].CreatedAt");
				itemsItem.Id = _ctx.StringValue("ListLives.Data.Items["+ i +"].Id");
				itemsItem.Name = _ctx.StringValue("ListLives.Data.Items["+ i +"].Name");
				itemsItem.PublicId = _ctx.StringValue("ListLives.Data.Items["+ i +"].PublicId");
				itemsItem.Status = _ctx.StringValue("ListLives.Data.Items["+ i +"].Status");
				itemsItem.UserId = _ctx.StringValue("ListLives.Data.Items["+ i +"].UserId");

				data_items.Add(itemsItem);
			}
			data.Items = data_items;
			listLivesResponse.Data = data;
        
			return listLivesResponse;
        }
    }
}
