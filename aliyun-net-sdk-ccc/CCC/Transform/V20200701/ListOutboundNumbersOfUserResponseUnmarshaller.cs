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
    public class ListOutboundNumbersOfUserResponseUnmarshaller
    {
        public static ListOutboundNumbersOfUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOutboundNumbersOfUserResponse listOutboundNumbersOfUserResponse = new ListOutboundNumbersOfUserResponse();

			listOutboundNumbersOfUserResponse.HttpResponse = _ctx.HttpResponse;
			listOutboundNumbersOfUserResponse.Code = _ctx.StringValue("ListOutboundNumbersOfUser.Code");
			listOutboundNumbersOfUserResponse.HttpStatusCode = _ctx.IntegerValue("ListOutboundNumbersOfUser.HttpStatusCode");
			listOutboundNumbersOfUserResponse.Message = _ctx.StringValue("ListOutboundNumbersOfUser.Message");
			listOutboundNumbersOfUserResponse.RequestId = _ctx.StringValue("ListOutboundNumbersOfUser.RequestId");

			ListOutboundNumbersOfUserResponse.ListOutboundNumbersOfUser_Data data = new ListOutboundNumbersOfUserResponse.ListOutboundNumbersOfUser_Data();
			data.PageNumber = _ctx.IntegerValue("ListOutboundNumbersOfUser.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListOutboundNumbersOfUser.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListOutboundNumbersOfUser.Data.TotalCount");

			List<ListOutboundNumbersOfUserResponse.ListOutboundNumbersOfUser_Data.ListOutboundNumbersOfUser_PhoneNumber> data_list = new List<ListOutboundNumbersOfUserResponse.ListOutboundNumbersOfUser_Data.ListOutboundNumbersOfUser_PhoneNumber>();
			for (int i = 0; i < _ctx.Length("ListOutboundNumbersOfUser.Data.List.Length"); i++) {
				ListOutboundNumbersOfUserResponse.ListOutboundNumbersOfUser_Data.ListOutboundNumbersOfUser_PhoneNumber phoneNumber = new ListOutboundNumbersOfUserResponse.ListOutboundNumbersOfUser_Data.ListOutboundNumbersOfUser_PhoneNumber();
				phoneNumber.City = _ctx.StringValue("ListOutboundNumbersOfUser.Data.List["+ i +"].City");
				phoneNumber.Number = _ctx.StringValue("ListOutboundNumbersOfUser.Data.List["+ i +"].Number");
				phoneNumber.Province = _ctx.StringValue("ListOutboundNumbersOfUser.Data.List["+ i +"].Province");

				data_list.Add(phoneNumber);
			}
			data.List = data_list;
			listOutboundNumbersOfUserResponse.Data = data;
        
			return listOutboundNumbersOfUserResponse;
        }
    }
}
