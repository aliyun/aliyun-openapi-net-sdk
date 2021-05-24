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
    public class ListPersonalNumbersOfUserResponseUnmarshaller
    {
        public static ListPersonalNumbersOfUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPersonalNumbersOfUserResponse listPersonalNumbersOfUserResponse = new ListPersonalNumbersOfUserResponse();

			listPersonalNumbersOfUserResponse.HttpResponse = _ctx.HttpResponse;
			listPersonalNumbersOfUserResponse.Code = _ctx.StringValue("ListPersonalNumbersOfUser.Code");
			listPersonalNumbersOfUserResponse.HttpStatusCode = _ctx.IntegerValue("ListPersonalNumbersOfUser.HttpStatusCode");
			listPersonalNumbersOfUserResponse.Message = _ctx.StringValue("ListPersonalNumbersOfUser.Message");
			listPersonalNumbersOfUserResponse.RequestId = _ctx.StringValue("ListPersonalNumbersOfUser.RequestId");

			ListPersonalNumbersOfUserResponse.ListPersonalNumbersOfUser_Data data = new ListPersonalNumbersOfUserResponse.ListPersonalNumbersOfUser_Data();
			data.PageNumber = _ctx.IntegerValue("ListPersonalNumbersOfUser.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListPersonalNumbersOfUser.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListPersonalNumbersOfUser.Data.TotalCount");

			List<ListPersonalNumbersOfUserResponse.ListPersonalNumbersOfUser_Data.ListPersonalNumbersOfUser_PhoneNumber> data_list = new List<ListPersonalNumbersOfUserResponse.ListPersonalNumbersOfUser_Data.ListPersonalNumbersOfUser_PhoneNumber>();
			for (int i = 0; i < _ctx.Length("ListPersonalNumbersOfUser.Data.List.Length"); i++) {
				ListPersonalNumbersOfUserResponse.ListPersonalNumbersOfUser_Data.ListPersonalNumbersOfUser_PhoneNumber phoneNumber = new ListPersonalNumbersOfUserResponse.ListPersonalNumbersOfUser_Data.ListPersonalNumbersOfUser_PhoneNumber();
				phoneNumber.Active = _ctx.BooleanValue("ListPersonalNumbersOfUser.Data.List["+ i +"].Active");
				phoneNumber.City = _ctx.StringValue("ListPersonalNumbersOfUser.Data.List["+ i +"].City");
				phoneNumber.ContactFlowId = _ctx.StringValue("ListPersonalNumbersOfUser.Data.List["+ i +"].ContactFlowId");
				phoneNumber.Number = _ctx.StringValue("ListPersonalNumbersOfUser.Data.List["+ i +"].Number");
				phoneNumber.Province = _ctx.StringValue("ListPersonalNumbersOfUser.Data.List["+ i +"].Province");
				phoneNumber.InstanceId = _ctx.StringValue("ListPersonalNumbersOfUser.Data.List["+ i +"].InstanceId");

				data_list.Add(phoneNumber);
			}
			data.List = data_list;
			listPersonalNumbersOfUserResponse.Data = data;
        
			return listPersonalNumbersOfUserResponse;
        }
    }
}
