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
    public class ListInstancesResponseUnmarshaller
    {
        public static ListInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesResponse.Code = _ctx.StringValue("ListInstances.Code");
			listInstancesResponse.HttpStatusCode = _ctx.IntegerValue("ListInstances.HttpStatusCode");
			listInstancesResponse.Message = _ctx.StringValue("ListInstances.Message");
			listInstancesResponse.RequestId = _ctx.StringValue("ListInstances.RequestId");

			List<string> listInstancesResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ListInstances.Params.Length"); i++) {
				listInstancesResponse_params.Add(_ctx.StringValue("ListInstances.Params["+ i +"]"));
			}
			listInstancesResponse._Params = listInstancesResponse_params;

			ListInstancesResponse.ListInstances_Data data = new ListInstancesResponse.ListInstances_Data();
			data.PageNumber = _ctx.IntegerValue("ListInstances.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListInstances.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListInstances.Data.TotalCount");

			List<ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance> data_list = new List<ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance>();
			for (int i = 0; i < _ctx.Length("ListInstances.Data.List.Length"); i++) {
				ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance callCenterInstance = new ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance();
				callCenterInstance.Status = _ctx.StringValue("ListInstances.Data.List["+ i +"].Status");
				callCenterInstance.ConsoleUrl = _ctx.StringValue("ListInstances.Data.List["+ i +"].ConsoleUrl");
				callCenterInstance.Description = _ctx.StringValue("ListInstances.Data.List["+ i +"].Description");
				callCenterInstance.CreateTime = _ctx.LongValue("ListInstances.Data.List["+ i +"].CreateTime");
				callCenterInstance.AliyunUid = _ctx.StringValue("ListInstances.Data.List["+ i +"].AliyunUid");
				callCenterInstance.Name = _ctx.StringValue("ListInstances.Data.List["+ i +"].Name");
				callCenterInstance.DomainName = _ctx.StringValue("ListInstances.Data.List["+ i +"].DomainName");
				callCenterInstance.Id = _ctx.StringValue("ListInstances.Data.List["+ i +"].Id");

				List<ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance.ListInstances_User> callCenterInstance_adminList = new List<ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance.ListInstances_User>();
				for (int j = 0; j < _ctx.Length("ListInstances.Data.List["+ i +"].AdminList.Length"); j++) {
					ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance.ListInstances_User user = new ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance.ListInstances_User();
					user.DisplayName = _ctx.StringValue("ListInstances.Data.List["+ i +"].AdminList["+ j +"].DisplayName");
					user.Extension = _ctx.StringValue("ListInstances.Data.List["+ i +"].AdminList["+ j +"].Extension");
					user.LoginName = _ctx.StringValue("ListInstances.Data.List["+ i +"].AdminList["+ j +"].LoginName");
					user.Email = _ctx.StringValue("ListInstances.Data.List["+ i +"].AdminList["+ j +"].Email");
					user.WorkMode = _ctx.StringValue("ListInstances.Data.List["+ i +"].AdminList["+ j +"].WorkMode");
					user.Mobile = _ctx.StringValue("ListInstances.Data.List["+ i +"].AdminList["+ j +"].Mobile");
					user.UserId = _ctx.StringValue("ListInstances.Data.List["+ i +"].AdminList["+ j +"].UserId");
					user.RoleName = _ctx.StringValue("ListInstances.Data.List["+ i +"].AdminList["+ j +"].RoleName");
					user.InstanceId = _ctx.StringValue("ListInstances.Data.List["+ i +"].AdminList["+ j +"].InstanceId");
					user.RoleId = _ctx.StringValue("ListInstances.Data.List["+ i +"].AdminList["+ j +"].RoleId");

					callCenterInstance_adminList.Add(user);
				}
				callCenterInstance.AdminList = callCenterInstance_adminList;

				List<ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance.ListInstances_PhoneNumber> callCenterInstance_numberList = new List<ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance.ListInstances_PhoneNumber>();
				for (int j = 0; j < _ctx.Length("ListInstances.Data.List["+ i +"].NumberList.Length"); j++) {
					ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance.ListInstances_PhoneNumber phoneNumber = new ListInstancesResponse.ListInstances_Data.ListInstances_CallCenterInstance.ListInstances_PhoneNumber();
					phoneNumber.Number = _ctx.StringValue("ListInstances.Data.List["+ i +"].NumberList["+ j +"].Number");

					callCenterInstance_numberList.Add(phoneNumber);
				}
				callCenterInstance.NumberList = callCenterInstance_numberList;

				data_list.Add(callCenterInstance);
			}
			data.List = data_list;
			listInstancesResponse.Data = data;
        
			return listInstancesResponse;
        }
    }
}
