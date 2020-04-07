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
        public static ListBookkeepingsResponse Unmarshall(UnmarshallerContext context)
        {
			ListBookkeepingsResponse listBookkeepingsResponse = new ListBookkeepingsResponse();

			listBookkeepingsResponse.HttpResponse = context.HttpResponse;
			listBookkeepingsResponse.RequestId = context.StringValue("ListBookkeepings.RequestId");
			listBookkeepingsResponse.TotalItemNumber = context.IntegerValue("ListBookkeepings.TotalItemNumber");
			listBookkeepingsResponse.CurrentPageNumber = context.IntegerValue("ListBookkeepings.CurrentPageNumber");
			listBookkeepingsResponse.PageSize = context.IntegerValue("ListBookkeepings.PageSize");
			listBookkeepingsResponse.TotalPageNumber = context.IntegerValue("ListBookkeepings.TotalPageNumber");

			List<ListBookkeepingsResponse.ListBookkeepings_Bookkeeping> listBookkeepingsResponse_bookkeepings = new List<ListBookkeepingsResponse.ListBookkeepings_Bookkeeping>();
			for (int i = 0; i < context.Length("ListBookkeepings.Bookkeepings.Length"); i++) {
				ListBookkeepingsResponse.ListBookkeepings_Bookkeeping bookkeeping = new ListBookkeepingsResponse.ListBookkeepings_Bookkeeping();
				bookkeeping.BizId = context.StringValue("ListBookkeepings.Bookkeepings["+ i +"].BizId");
				bookkeeping.CompanyName = context.StringValue("ListBookkeepings.Bookkeepings["+ i +"].CompanyName");
				bookkeeping.OrderId = context.StringValue("ListBookkeepings.Bookkeepings["+ i +"].OrderId");
				bookkeeping.Status = context.IntegerValue("ListBookkeepings.Bookkeepings["+ i +"].Status");
				bookkeeping.Renew = context.BooleanValue("ListBookkeepings.Bookkeepings["+ i +"].Renew");
				bookkeeping.Note = context.StringValue("ListBookkeepings.Bookkeepings["+ i +"].Note");

				listBookkeepingsResponse_bookkeepings.Add(bookkeeping);
			}
			listBookkeepingsResponse.Bookkeepings = listBookkeepingsResponse_bookkeepings;
        
			return listBookkeepingsResponse;
        }
    }
}
