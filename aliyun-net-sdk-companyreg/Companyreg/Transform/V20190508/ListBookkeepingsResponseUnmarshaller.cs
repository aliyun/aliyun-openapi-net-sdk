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
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class ListBookkeepingsResponseUnmarshaller
    {
        public static ListBookkeepingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBookkeepingsResponse listBookkeepingsResponse = new ListBookkeepingsResponse();

			listBookkeepingsResponse.HttpResponse = _ctx.HttpResponse;
			listBookkeepingsResponse.RequestId = _ctx.StringValue("ListBookkeepings.RequestId");
			listBookkeepingsResponse.TotalItemNumber = _ctx.IntegerValue("ListBookkeepings.TotalItemNumber");
			listBookkeepingsResponse.CurrentPageNumber = _ctx.IntegerValue("ListBookkeepings.CurrentPageNumber");
			listBookkeepingsResponse.PageSize = _ctx.IntegerValue("ListBookkeepings.PageSize");
			listBookkeepingsResponse.TotalPageNumber = _ctx.IntegerValue("ListBookkeepings.TotalPageNumber");

			List<ListBookkeepingsResponse.ListBookkeepings_Bookkeeping> listBookkeepingsResponse_bookkeepings = new List<ListBookkeepingsResponse.ListBookkeepings_Bookkeeping>();
			for (int i = 0; i < _ctx.Length("ListBookkeepings.Bookkeepings.Length"); i++) {
				ListBookkeepingsResponse.ListBookkeepings_Bookkeeping bookkeeping = new ListBookkeepingsResponse.ListBookkeepings_Bookkeeping();
				bookkeeping.BizId = _ctx.StringValue("ListBookkeepings.Bookkeepings["+ i +"].BizId");
				bookkeeping.CompanyName = _ctx.StringValue("ListBookkeepings.Bookkeepings["+ i +"].CompanyName");
				bookkeeping.OrderId = _ctx.StringValue("ListBookkeepings.Bookkeepings["+ i +"].OrderId");
				bookkeeping.Status = _ctx.IntegerValue("ListBookkeepings.Bookkeepings["+ i +"].Status");
				bookkeeping.Renew = _ctx.BooleanValue("ListBookkeepings.Bookkeepings["+ i +"].Renew");
				bookkeeping.Note = _ctx.StringValue("ListBookkeepings.Bookkeepings["+ i +"].Note");
				bookkeeping.CommodityType = _ctx.StringValue("ListBookkeepings.Bookkeepings["+ i +"].CommodityType");

				listBookkeepingsResponse_bookkeepings.Add(bookkeeping);
			}
			listBookkeepingsResponse.Bookkeepings = listBookkeepingsResponse_bookkeepings;
        
			return listBookkeepingsResponse;
        }
    }
}
