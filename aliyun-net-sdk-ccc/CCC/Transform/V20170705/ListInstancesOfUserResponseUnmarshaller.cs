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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListInstancesOfUserResponseUnmarshaller
    {
        public static ListInstancesOfUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesOfUserResponse listInstancesOfUserResponse = new ListInstancesOfUserResponse();

			listInstancesOfUserResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesOfUserResponse.RequestId = _ctx.StringValue("ListInstancesOfUser.RequestId");
			listInstancesOfUserResponse.Success = _ctx.BooleanValue("ListInstancesOfUser.Success");
			listInstancesOfUserResponse.Code = _ctx.StringValue("ListInstancesOfUser.Code");
			listInstancesOfUserResponse.Message = _ctx.StringValue("ListInstancesOfUser.Message");
			listInstancesOfUserResponse.HttpStatusCode = _ctx.IntegerValue("ListInstancesOfUser.HttpStatusCode");

			List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance> listInstancesOfUserResponse_instances = new List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance>();
			for (int i = 0; i < _ctx.Length("ListInstancesOfUser.Instances.Length"); i++) {
				ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance callCenterInstance = new ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance();
				callCenterInstance.InstanceId = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].InstanceId");
				callCenterInstance.InstanceName = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].InstanceName");
				callCenterInstance.InstanceDescription = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].InstanceDescription");
				callCenterInstance.DomainName = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].DomainName");
				callCenterInstance.ConsoleUrl = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].ConsoleUrl");
				callCenterInstance.StorageBucket = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].StorageBucket");
				callCenterInstance.StorageMaxDays = _ctx.IntegerValue("ListInstancesOfUser.Instances["+ i +"].StorageMaxDays");
				callCenterInstance.StorageMaxSize = _ctx.IntegerValue("ListInstancesOfUser.Instances["+ i +"].StorageMaxSize");
				callCenterInstance.MaxOnlineAgents = _ctx.IntegerValue("ListInstancesOfUser.Instances["+ i +"].MaxOnlineAgents");
				callCenterInstance.TenantId = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].TenantId");
				callCenterInstance.DirectoryId = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].DirectoryId");
				callCenterInstance.Status = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].Status");
				callCenterInstance.CreatedTime = _ctx.LongValue("ListInstancesOfUser.Instances["+ i +"].CreatedTime");
				callCenterInstance.Owner = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].Owner");

				List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User> callCenterInstance_admin = new List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User>();
				for (int j = 0; j < _ctx.Length("ListInstancesOfUser.Instances["+ i +"].Admin.Length"); j++) {
					ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User user = new ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User();
					user.UserId = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].UserId");
					user.RamId = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].RamId");
					user.InstanceId = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].InstanceId");

					ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User.ListInstancesOfUser_Detail detail = new ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User.ListInstancesOfUser_Detail();
					detail.LoginName = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].Detail.LoginName");
					detail.DisplayName = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].Detail.DisplayName");
					detail.Phone = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].Detail.Phone");
					detail.Email = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].Detail.Email");
					detail.Department = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].Detail.Department");
					user.Detail = detail;

					callCenterInstance_admin.Add(user);
				}
				callCenterInstance.Admin = callCenterInstance_admin;

				List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber> callCenterInstance_phoneNumbers = new List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber>();
				for (int j = 0; j < _ctx.Length("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers.Length"); j++) {
					ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber phoneNumber = new ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber();
					phoneNumber.PhoneNumberId = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].PhoneNumberId");
					phoneNumber.InstanceId = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].InstanceId");
					phoneNumber.Number = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].Number");
					phoneNumber.PhoneNumberDescription = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].PhoneNumberDescription");
					phoneNumber.TestOnly = _ctx.BooleanValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].TestOnly");
					phoneNumber.RemainingTime = _ctx.IntegerValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].RemainingTime");
					phoneNumber.AllowOutbound = _ctx.BooleanValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].AllowOutbound");
					phoneNumber.Usage = _ctx.StringValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].Usage");
					phoneNumber.Trunks = _ctx.IntegerValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].Trunks");

					callCenterInstance_phoneNumbers.Add(phoneNumber);
				}
				callCenterInstance.PhoneNumbers = callCenterInstance_phoneNumbers;

				listInstancesOfUserResponse_instances.Add(callCenterInstance);
			}
			listInstancesOfUserResponse.Instances = listInstancesOfUserResponse_instances;
        
			return listInstancesOfUserResponse;
        }
    }
}
