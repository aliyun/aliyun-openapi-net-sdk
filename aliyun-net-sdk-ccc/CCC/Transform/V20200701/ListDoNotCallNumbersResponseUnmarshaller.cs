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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListDoNotCallNumbersResponseUnmarshaller
    {
        public static ListDoNotCallNumbersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDoNotCallNumbersResponse listDoNotCallNumbersResponse = new ListDoNotCallNumbersResponse();

			listDoNotCallNumbersResponse.HttpResponse = _ctx.HttpResponse;
			listDoNotCallNumbersResponse.Code = _ctx.StringValue("ListDoNotCallNumbers.Code");
			listDoNotCallNumbersResponse.HttpStatusCode = _ctx.IntegerValue("ListDoNotCallNumbers.HttpStatusCode");
			listDoNotCallNumbersResponse.Message = _ctx.StringValue("ListDoNotCallNumbers.Message");
			listDoNotCallNumbersResponse.RequestId = _ctx.StringValue("ListDoNotCallNumbers.RequestId");

			List<string> listDoNotCallNumbersResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ListDoNotCallNumbers.Params.Length"); i++) {
				listDoNotCallNumbersResponse_params.Add(_ctx.StringValue("ListDoNotCallNumbers.Params["+ i +"]"));
			}
			listDoNotCallNumbersResponse._Params = listDoNotCallNumbersResponse_params;

			ListDoNotCallNumbersResponse.ListDoNotCallNumbers_Data data = new ListDoNotCallNumbersResponse.ListDoNotCallNumbers_Data();
			data.PageNumber = _ctx.IntegerValue("ListDoNotCallNumbers.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListDoNotCallNumbers.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListDoNotCallNumbers.Data.TotalCount");

			List<ListDoNotCallNumbersResponse.ListDoNotCallNumbers_Data.ListDoNotCallNumbers_BlockedNumber> data_list = new List<ListDoNotCallNumbersResponse.ListDoNotCallNumbers_Data.ListDoNotCallNumbers_BlockedNumber>();
			for (int i = 0; i < _ctx.Length("ListDoNotCallNumbers.Data.List.Length"); i++) {
				ListDoNotCallNumbersResponse.ListDoNotCallNumbers_Data.ListDoNotCallNumbers_BlockedNumber blockedNumber = new ListDoNotCallNumbersResponse.ListDoNotCallNumbers_Data.ListDoNotCallNumbers_BlockedNumber();
				blockedNumber.Number = _ctx.StringValue("ListDoNotCallNumbers.Data.List["+ i +"].Number");
				blockedNumber.Scope = _ctx.StringValue("ListDoNotCallNumbers.Data.List["+ i +"].Scope");
				blockedNumber.Remark = _ctx.StringValue("ListDoNotCallNumbers.Data.List["+ i +"].Remark");
				blockedNumber.CreateTime = _ctx.LongValue("ListDoNotCallNumbers.Data.List["+ i +"].CreateTime");
				blockedNumber.Creator = _ctx.StringValue("ListDoNotCallNumbers.Data.List["+ i +"].Creator");

				data_list.Add(blockedNumber);
			}
			data.List = data_list;
			listDoNotCallNumbersResponse.Data = data;
        
			return listDoNotCallNumbersResponse;
        }
    }
}
