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
    public class ListUnassignedNumbersResponseUnmarshaller
    {
        public static ListUnassignedNumbersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUnassignedNumbersResponse listUnassignedNumbersResponse = new ListUnassignedNumbersResponse();

			listUnassignedNumbersResponse.HttpResponse = _ctx.HttpResponse;
			listUnassignedNumbersResponse.Code = _ctx.StringValue("ListUnassignedNumbers.Code");
			listUnassignedNumbersResponse.HttpStatusCode = _ctx.IntegerValue("ListUnassignedNumbers.HttpStatusCode");
			listUnassignedNumbersResponse.Message = _ctx.StringValue("ListUnassignedNumbers.Message");
			listUnassignedNumbersResponse.RequestId = _ctx.StringValue("ListUnassignedNumbers.RequestId");

			ListUnassignedNumbersResponse.ListUnassignedNumbers_Data data = new ListUnassignedNumbersResponse.ListUnassignedNumbers_Data();
			data.PageNumber = _ctx.IntegerValue("ListUnassignedNumbers.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListUnassignedNumbers.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListUnassignedNumbers.Data.TotalCount");

			List<ListUnassignedNumbersResponse.ListUnassignedNumbers_Data.ListUnassignedNumbers_PhoneNumber> data_list = new List<ListUnassignedNumbersResponse.ListUnassignedNumbers_Data.ListUnassignedNumbers_PhoneNumber>();
			for (int i = 0; i < _ctx.Length("ListUnassignedNumbers.Data.List.Length"); i++) {
				ListUnassignedNumbersResponse.ListUnassignedNumbers_Data.ListUnassignedNumbers_PhoneNumber phoneNumber = new ListUnassignedNumbersResponse.ListUnassignedNumbers_Data.ListUnassignedNumbers_PhoneNumber();
				phoneNumber.Number = _ctx.StringValue("ListUnassignedNumbers.Data.List["+ i +"].Number");
				phoneNumber.Active = _ctx.BooleanValue("ListUnassignedNumbers.Data.List["+ i +"].Active");
				phoneNumber.City = _ctx.StringValue("ListUnassignedNumbers.Data.List["+ i +"].City");
				phoneNumber.Usage = _ctx.BooleanValue("ListUnassignedNumbers.Data.List["+ i +"].Usage");
				phoneNumber.Province = _ctx.StringValue("ListUnassignedNumbers.Data.List["+ i +"].Province");

				data_list.Add(phoneNumber);
			}
			data.List = data_list;
			listUnassignedNumbersResponse.Data = data;
        
			return listUnassignedNumbersResponse;
        }
    }
}
