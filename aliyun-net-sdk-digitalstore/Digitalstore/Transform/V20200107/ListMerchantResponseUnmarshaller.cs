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
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class ListMerchantResponseUnmarshaller
    {
        public static ListMerchantResponse Unmarshall(UnmarshallerContext context)
        {
			ListMerchantResponse listMerchantResponse = new ListMerchantResponse();

			listMerchantResponse.HttpResponse = context.HttpResponse;
			listMerchantResponse.Success = context.BooleanValue("ListMerchant.Success");
			listMerchantResponse.RequestId = context.StringValue("ListMerchant.RequestId");
			listMerchantResponse.PageSize = context.StringValue("ListMerchant.PageSize");
			listMerchantResponse.PageNumber = context.StringValue("ListMerchant.PageNumber");
			listMerchantResponse.TotalCount = context.IntegerValue("ListMerchant.TotalCount");

			ListMerchantResponse.ListMerchant_Data data = new ListMerchantResponse.ListMerchant_Data();
			data.PageSize = context.IntegerValue("ListMerchant.Data.PageSize");
			data.PageNumber = context.IntegerValue("ListMerchant.Data.PageNumber");
			data.TotalCount = context.IntegerValue("ListMerchant.Data.TotalCount");

			List<ListMerchantResponse.ListMerchant_Data.ListMerchant_ListItem> data_list = new List<ListMerchantResponse.ListMerchant_Data.ListMerchant_ListItem>();
			for (int i = 0; i < context.Length("ListMerchant.Data.List.Length"); i++) {
				ListMerchantResponse.ListMerchant_Data.ListMerchant_ListItem listItem = new ListMerchantResponse.ListMerchant_Data.ListMerchant_ListItem();
				listItem.MerchantId = context.LongValue("ListMerchant.Data.List["+ i +"].MerchantId");
				listItem.Name = context.StringValue("ListMerchant.Data.List["+ i +"].Name");
				listItem.Type = context.IntegerValue("ListMerchant.Data.List["+ i +"].Type");
				listItem.Company = context.StringValue("ListMerchant.Data.List["+ i +"].Company");
				listItem.Phone = context.StringValue("ListMerchant.Data.List["+ i +"].Phone");
				listItem.Address = context.StringValue("ListMerchant.Data.List["+ i +"].Address");
				listItem.Email = context.StringValue("ListMerchant.Data.List["+ i +"].Email");
				listItem.Status = context.IntegerValue("ListMerchant.Data.List["+ i +"].Status");
				listItem.Remark = context.StringValue("ListMerchant.Data.List["+ i +"].Remark");

				data_list.Add(listItem);
			}
			data.List = data_list;
			listMerchantResponse.Data = data;
        
			return listMerchantResponse;
        }
    }
}
