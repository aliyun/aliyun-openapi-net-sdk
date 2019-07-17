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
        public static ListInstancesOfUserResponse Unmarshall(UnmarshallerContext context)
        {
			ListInstancesOfUserResponse listInstancesOfUserResponse = new ListInstancesOfUserResponse();

			listInstancesOfUserResponse.HttpResponse = context.HttpResponse;
			listInstancesOfUserResponse.RequestId = context.StringValue("ListInstancesOfUser.RequestId");
			listInstancesOfUserResponse.Success = context.BooleanValue("ListInstancesOfUser.Success");
			listInstancesOfUserResponse.Code = context.StringValue("ListInstancesOfUser.Code");
			listInstancesOfUserResponse.Message = context.StringValue("ListInstancesOfUser.Message");
			listInstancesOfUserResponse.HttpStatusCode = context.IntegerValue("ListInstancesOfUser.HttpStatusCode");

			List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance> listInstancesOfUserResponse_instances = new List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance>();
			for (int i = 0; i < context.Length("ListInstancesOfUser.Instances.Length"); i++) {
				ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance callCenterInstance = new ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance();
				callCenterInstance.InstanceId = context.StringValue("ListInstancesOfUser.Instances["+ i +"].InstanceId");
				callCenterInstance.InstanceName = context.StringValue("ListInstancesOfUser.Instances["+ i +"].InstanceName");
				callCenterInstance.InstanceDescription = context.StringValue("ListInstancesOfUser.Instances["+ i +"].InstanceDescription");
				callCenterInstance.DomainName = context.StringValue("ListInstancesOfUser.Instances["+ i +"].DomainName");
				callCenterInstance.ConsoleUrl = context.StringValue("ListInstancesOfUser.Instances["+ i +"].ConsoleUrl");
				callCenterInstance.StorageBucket = context.StringValue("ListInstancesOfUser.Instances["+ i +"].StorageBucket");
				callCenterInstance.StorageMaxDays = context.IntegerValue("ListInstancesOfUser.Instances["+ i +"].StorageMaxDays");
				callCenterInstance.StorageMaxSize = context.IntegerValue("ListInstancesOfUser.Instances["+ i +"].StorageMaxSize");
				callCenterInstance.MaxOnlineAgents = context.IntegerValue("ListInstancesOfUser.Instances["+ i +"].MaxOnlineAgents");
				callCenterInstance.TenantId = context.StringValue("ListInstancesOfUser.Instances["+ i +"].TenantId");
				callCenterInstance.DirectoryId = context.StringValue("ListInstancesOfUser.Instances["+ i +"].DirectoryId");
				callCenterInstance.Status = context.StringValue("ListInstancesOfUser.Instances["+ i +"].Status");
				callCenterInstance.CreatedTime = context.LongValue("ListInstancesOfUser.Instances["+ i +"].CreatedTime");
				callCenterInstance.Owner = context.StringValue("ListInstancesOfUser.Instances["+ i +"].Owner");

				List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User> callCenterInstance_admin = new List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User>();
				for (int j = 0; j < context.Length("ListInstancesOfUser.Instances["+ i +"].Admin.Length"); j++) {
					ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User user = new ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User();
					user.UserId = context.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].UserId");
					user.RamId = context.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].RamId");
					user.InstanceId = context.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].InstanceId");

					ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User.ListInstancesOfUser_Detail detail = new ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_User.ListInstancesOfUser_Detail();
					detail.LoginName = context.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].Detail.LoginName");
					detail.DisplayName = context.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].Detail.DisplayName");
					detail.Phone = context.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].Detail.Phone");
					detail.Email = context.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].Detail.Email");
					detail.Department = context.StringValue("ListInstancesOfUser.Instances["+ i +"].Admin["+ j +"].Detail.Department");
					user.Detail = detail;

					callCenterInstance_admin.Add(user);
				}
				callCenterInstance.Admin = callCenterInstance_admin;

				List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber> callCenterInstance_phoneNumbers = new List<ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber>();
				for (int j = 0; j < context.Length("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers.Length"); j++) {
					ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber phoneNumber = new ListInstancesOfUserResponse.ListInstancesOfUser_CallCenterInstance.ListInstancesOfUser_PhoneNumber();
					phoneNumber.PhoneNumberId = context.StringValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].PhoneNumberId");
					phoneNumber.InstanceId = context.StringValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].InstanceId");
					phoneNumber.Number = context.StringValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].Number");
					phoneNumber.PhoneNumberDescription = context.StringValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].PhoneNumberDescription");
					phoneNumber.TestOnly = context.BooleanValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].TestOnly");
					phoneNumber.RemainingTime = context.IntegerValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].RemainingTime");
					phoneNumber.AllowOutbound = context.BooleanValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].AllowOutbound");
					phoneNumber.Usage = context.StringValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].Usage");
					phoneNumber.Trunks = context.IntegerValue("ListInstancesOfUser.Instances["+ i +"].PhoneNumbers["+ j +"].Trunks");

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
