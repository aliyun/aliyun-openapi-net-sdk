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
    public class ListAllProdsResponseUnmarshaller
    {
        public static ListAllProdsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAllProdsResponse listAllProdsResponse = new ListAllProdsResponse();

			listAllProdsResponse.HttpResponse = _ctx.HttpResponse;
			listAllProdsResponse.RequestId = _ctx.StringValue("ListAllProds.RequestId");

			ListAllProdsResponse.ListAllProds_Data data = new ListAllProdsResponse.ListAllProds_Data();
			data.TotalCount = _ctx.IntegerValue("ListAllProds.Data.TotalCount");
			data.PageSize = _ctx.IntegerValue("ListAllProds.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("ListAllProds.Data.CurrentPage");

			List<ListAllProdsResponse.ListAllProds_Data.ListAllProds_ProdListItem> data_prodList = new List<ListAllProdsResponse.ListAllProds_Data.ListAllProds_ProdListItem>();
			for (int i = 0; i < _ctx.Length("ListAllProds.Data.ProdList.Length"); i++) {
				ListAllProdsResponse.ListAllProds_Data.ListAllProds_ProdListItem prodListItem = new ListAllProdsResponse.ListAllProds_Data.ListAllProds_ProdListItem();
				prodListItem.ProdCode = _ctx.StringValue("ListAllProds.Data.ProdList["+ i +"].ProdCode");
				prodListItem.TotalLogCount = _ctx.IntegerValue("ListAllProds.Data.ProdList["+ i +"].TotalLogCount");
				prodListItem.ImportedLogCount = _ctx.IntegerValue("ListAllProds.Data.ProdList["+ i +"].ImportedLogCount");
				prodListItem.ModifyTime = _ctx.StringValue("ListAllProds.Data.ProdList["+ i +"].ModifyTime");
				prodListItem.CloudCode = _ctx.StringValue("ListAllProds.Data.ProdList["+ i +"].CloudCode");

				data_prodList.Add(prodListItem);
			}
			data.ProdList = data_prodList;
			listAllProdsResponse.Data = data;
        
			return listAllProdsResponse;
        }
    }
}
