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
    public class CreateInstanceResponseUnmarshaller
    {
        public static CreateInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			CreateInstanceResponse createInstanceResponse = new CreateInstanceResponse();

			createInstanceResponse.HttpResponse = context.HttpResponse;
			createInstanceResponse.RequestId = context.StringValue("CreateInstance.RequestId");
			createInstanceResponse.Success = context.BooleanValue("CreateInstance.Success");
			createInstanceResponse.Code = context.StringValue("CreateInstance.Code");
			createInstanceResponse.Message = context.StringValue("CreateInstance.Message");
			createInstanceResponse.HttpStatusCode = context.IntegerValue("CreateInstance.HttpStatusCode");

			CreateInstanceResponse.CreateInstance_Instance instance = new CreateInstanceResponse.CreateInstance_Instance();
			instance.InstanceId = context.StringValue("CreateInstance.Instance.InstanceId");
			instance.InstanceName = context.StringValue("CreateInstance.Instance.InstanceName");
			instance.InstanceDescription = context.StringValue("CreateInstance.Instance.InstanceDescription");
			instance.DomainName = context.StringValue("CreateInstance.Instance.DomainName");
			instance.ConsoleUrl = context.StringValue("CreateInstance.Instance.ConsoleUrl");
			instance.StorageBucket = context.StringValue("CreateInstance.Instance.StorageBucket");
			instance.StorageMaxDays = context.IntegerValue("CreateInstance.Instance.StorageMaxDays");
			instance.StorageMaxSize = context.IntegerValue("CreateInstance.Instance.StorageMaxSize");
			instance.MaxOnlineAgents = context.IntegerValue("CreateInstance.Instance.MaxOnlineAgents");
			instance.TenantId = context.StringValue("CreateInstance.Instance.TenantId");
			instance.Status = context.StringValue("CreateInstance.Instance.Status");
			instance.DirectoryId = context.StringValue("CreateInstance.Instance.DirectoryId");
			instance.CreatedTime = context.LongValue("CreateInstance.Instance.CreatedTime");
			instance.Owner = context.StringValue("CreateInstance.Instance.Owner");

			List<string> instance_successPhoneNumbers = new List<string>();
			for (int i = 0; i < context.Length("CreateInstance.Instance.SuccessPhoneNumbers.Length"); i++) {
				instance_successPhoneNumbers.Add(context.StringValue("CreateInstance.Instance.SuccessPhoneNumbers["+ i +"]"));
			}
			instance.SuccessPhoneNumbers = instance_successPhoneNumbers;

			List<string> instance_failPhoneNumbers = new List<string>();
			for (int i = 0; i < context.Length("CreateInstance.Instance.FailPhoneNumbers.Length"); i++) {
				instance_failPhoneNumbers.Add(context.StringValue("CreateInstance.Instance.FailPhoneNumbers["+ i +"]"));
			}
			instance.FailPhoneNumbers = instance_failPhoneNumbers;

			List<string> instance_successLoginNames = new List<string>();
			for (int i = 0; i < context.Length("CreateInstance.Instance.SuccessLoginNames.Length"); i++) {
				instance_successLoginNames.Add(context.StringValue("CreateInstance.Instance.SuccessLoginNames["+ i +"]"));
			}
			instance.SuccessLoginNames = instance_successLoginNames;

			List<string> instance_failLoginNames = new List<string>();
			for (int i = 0; i < context.Length("CreateInstance.Instance.FailLoginNames.Length"); i++) {
				instance_failLoginNames.Add(context.StringValue("CreateInstance.Instance.FailLoginNames["+ i +"]"));
			}
			instance.FailLoginNames = instance_failLoginNames;

			List<CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User> instance_admin = new List<CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User>();
			for (int i = 0; i < context.Length("CreateInstance.Instance.Admin.Length"); i++) {
				CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User user = new CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User();
				user.UserId = context.StringValue("CreateInstance.Instance.Admin["+ i +"].UserId");
				user.RamId = context.StringValue("CreateInstance.Instance.Admin["+ i +"].RamId");
				user.InstanceId = context.StringValue("CreateInstance.Instance.Admin["+ i +"].InstanceId");

				CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User.CreateInstance_Detail detail = new CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User.CreateInstance_Detail();
				detail.LoginName = context.StringValue("CreateInstance.Instance.Admin["+ i +"].Detail.LoginName");
				detail.DisplayName = context.StringValue("CreateInstance.Instance.Admin["+ i +"].Detail.DisplayName");
				detail.Phone = context.StringValue("CreateInstance.Instance.Admin["+ i +"].Detail.Phone");
				detail.Email = context.StringValue("CreateInstance.Instance.Admin["+ i +"].Detail.Email");
				detail.Department = context.StringValue("CreateInstance.Instance.Admin["+ i +"].Detail.Department");
				user.Detail = detail;

				instance_admin.Add(user);
			}
			instance.Admin = instance_admin;

			List<CreateInstanceResponse.CreateInstance_Instance.CreateInstance_PhoneNumber> instance_phoneNumbers = new List<CreateInstanceResponse.CreateInstance_Instance.CreateInstance_PhoneNumber>();
			for (int i = 0; i < context.Length("CreateInstance.Instance.PhoneNumbers.Length"); i++) {
				CreateInstanceResponse.CreateInstance_Instance.CreateInstance_PhoneNumber phoneNumber = new CreateInstanceResponse.CreateInstance_Instance.CreateInstance_PhoneNumber();
				phoneNumber.PhoneNumberId = context.StringValue("CreateInstance.Instance.PhoneNumbers["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = context.StringValue("CreateInstance.Instance.PhoneNumbers["+ i +"].InstanceId");
				phoneNumber.Number = context.StringValue("CreateInstance.Instance.PhoneNumbers["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = context.StringValue("CreateInstance.Instance.PhoneNumbers["+ i +"].PhoneNumberDescription");
				phoneNumber.TestOnly = context.BooleanValue("CreateInstance.Instance.PhoneNumbers["+ i +"].TestOnly");
				phoneNumber.RemainingTime = context.IntegerValue("CreateInstance.Instance.PhoneNumbers["+ i +"].RemainingTime");
				phoneNumber.AllowOutbound = context.BooleanValue("CreateInstance.Instance.PhoneNumbers["+ i +"].AllowOutbound");
				phoneNumber.Usage = context.StringValue("CreateInstance.Instance.PhoneNumbers["+ i +"].Usage");
				phoneNumber.Trunks = context.IntegerValue("CreateInstance.Instance.PhoneNumbers["+ i +"].Trunks");

				instance_phoneNumbers.Add(phoneNumber);
			}
			instance.PhoneNumbers = instance_phoneNumbers;
			createInstanceResponse.Instance = instance;
        
			return createInstanceResponse;
        }
    }
}
