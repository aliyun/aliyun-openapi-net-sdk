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
    public class ListUsersByProdResponseUnmarshaller
    {
        public static ListUsersByProdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUsersByProdResponse listUsersByProdResponse = new ListUsersByProdResponse();

			listUsersByProdResponse.HttpResponse = _ctx.HttpResponse;
			listUsersByProdResponse.RequestId = _ctx.StringValue("ListUsersByProd.RequestId");

			List<ListUsersByProdResponse.ListUsersByProd_DataItem> listUsersByProdResponse_data = new List<ListUsersByProdResponse.ListUsersByProd_DataItem>();
			for (int i = 0; i < _ctx.Length("ListUsersByProd.Data.Length"); i++) {
				ListUsersByProdResponse.ListUsersByProd_DataItem dataItem = new ListUsersByProdResponse.ListUsersByProd_DataItem();
				dataItem.SourceProdCode = _ctx.StringValue("ListUsersByProd.Data["+ i +"].SourceProdCode");
				dataItem.SourceLogCode = _ctx.StringValue("ListUsersByProd.Data["+ i +"].SourceLogCode");
				dataItem.SourceLogName = _ctx.StringValue("ListUsersByProd.Data["+ i +"].SourceLogName");
				dataItem.CloudCode = _ctx.StringValue("ListUsersByProd.Data["+ i +"].CloudCode");
				dataItem.Imported = _ctx.BooleanValue("ListUsersByProd.Data["+ i +"].Imported");
				dataItem.LogMdsCode = _ctx.StringValue("ListUsersByProd.Data["+ i +"].LogMdsCode");
				dataItem.MainUserId = _ctx.LongValue("ListUsersByProd.Data["+ i +"].MainUserId");
				dataItem.SubUserId = _ctx.LongValue("ListUsersByProd.Data["+ i +"].SubUserId");
				dataItem.SubUserName = _ctx.StringValue("ListUsersByProd.Data["+ i +"].SubUserName");

				listUsersByProdResponse_data.Add(dataItem);
			}
			listUsersByProdResponse.Data = listUsersByProdResponse_data;
        
			return listUsersByProdResponse;
        }
    }
}
