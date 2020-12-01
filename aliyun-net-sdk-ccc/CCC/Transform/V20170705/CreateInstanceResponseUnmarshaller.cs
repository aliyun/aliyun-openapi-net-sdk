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
        public static CreateInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateInstanceResponse createInstanceResponse = new CreateInstanceResponse();

			createInstanceResponse.HttpResponse = _ctx.HttpResponse;
			createInstanceResponse.RequestId = _ctx.StringValue("CreateInstance.RequestId");
			createInstanceResponse.Success = _ctx.BooleanValue("CreateInstance.Success");
			createInstanceResponse.Code = _ctx.StringValue("CreateInstance.Code");
			createInstanceResponse.Message = _ctx.StringValue("CreateInstance.Message");
			createInstanceResponse.HttpStatusCode = _ctx.IntegerValue("CreateInstance.HttpStatusCode");

			CreateInstanceResponse.CreateInstance_Instance instance = new CreateInstanceResponse.CreateInstance_Instance();
			instance.InstanceId = _ctx.StringValue("CreateInstance.Instance.InstanceId");
			instance.InstanceName = _ctx.StringValue("CreateInstance.Instance.InstanceName");
			instance.InstanceDescription = _ctx.StringValue("CreateInstance.Instance.InstanceDescription");
			instance.DomainName = _ctx.StringValue("CreateInstance.Instance.DomainName");
			instance.ConsoleUrl = _ctx.StringValue("CreateInstance.Instance.ConsoleUrl");
			instance.StorageBucket = _ctx.StringValue("CreateInstance.Instance.StorageBucket");
			instance.StorageMaxDays = _ctx.IntegerValue("CreateInstance.Instance.StorageMaxDays");
			instance.StorageMaxSize = _ctx.IntegerValue("CreateInstance.Instance.StorageMaxSize");
			instance.MaxOnlineAgents = _ctx.IntegerValue("CreateInstance.Instance.MaxOnlineAgents");
			instance.TenantId = _ctx.StringValue("CreateInstance.Instance.TenantId");
			instance.Status = _ctx.StringValue("CreateInstance.Instance.Status");
			instance.DirectoryId = _ctx.StringValue("CreateInstance.Instance.DirectoryId");
			instance.CreatedTime = _ctx.LongValue("CreateInstance.Instance.CreatedTime");
			instance.Owner = _ctx.StringValue("CreateInstance.Instance.Owner");

			List<string> instance_successPhoneNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateInstance.Instance.SuccessPhoneNumbers.Length"); i++) {
				instance_successPhoneNumbers.Add(_ctx.StringValue("CreateInstance.Instance.SuccessPhoneNumbers["+ i +"]"));
			}
			instance.SuccessPhoneNumbers = instance_successPhoneNumbers;

			List<string> instance_failPhoneNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateInstance.Instance.FailPhoneNumbers.Length"); i++) {
				instance_failPhoneNumbers.Add(_ctx.StringValue("CreateInstance.Instance.FailPhoneNumbers["+ i +"]"));
			}
			instance.FailPhoneNumbers = instance_failPhoneNumbers;

			List<string> instance_successLoginNames = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateInstance.Instance.SuccessLoginNames.Length"); i++) {
				instance_successLoginNames.Add(_ctx.StringValue("CreateInstance.Instance.SuccessLoginNames["+ i +"]"));
			}
			instance.SuccessLoginNames = instance_successLoginNames;

			List<string> instance_failLoginNames = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateInstance.Instance.FailLoginNames.Length"); i++) {
				instance_failLoginNames.Add(_ctx.StringValue("CreateInstance.Instance.FailLoginNames["+ i +"]"));
			}
			instance.FailLoginNames = instance_failLoginNames;

			List<CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User> instance_admin = new List<CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User>();
			for (int i = 0; i < _ctx.Length("CreateInstance.Instance.Admin.Length"); i++) {
				CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User user = new CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User();
				user.UserId = _ctx.StringValue("CreateInstance.Instance.Admin["+ i +"].UserId");
				user.RamId = _ctx.StringValue("CreateInstance.Instance.Admin["+ i +"].RamId");
				user.InstanceId = _ctx.StringValue("CreateInstance.Instance.Admin["+ i +"].InstanceId");

				CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User.CreateInstance_Detail detail = new CreateInstanceResponse.CreateInstance_Instance.CreateInstance_User.CreateInstance_Detail();
				detail.LoginName = _ctx.StringValue("CreateInstance.Instance.Admin["+ i +"].Detail.LoginName");
				detail.DisplayName = _ctx.StringValue("CreateInstance.Instance.Admin["+ i +"].Detail.DisplayName");
				detail.Phone = _ctx.StringValue("CreateInstance.Instance.Admin["+ i +"].Detail.Phone");
				detail.Email = _ctx.StringValue("CreateInstance.Instance.Admin["+ i +"].Detail.Email");
				detail.Department = _ctx.StringValue("CreateInstance.Instance.Admin["+ i +"].Detail.Department");
				user.Detail = detail;

				instance_admin.Add(user);
			}
			instance.Admin = instance_admin;

			List<CreateInstanceResponse.CreateInstance_Instance.CreateInstance_PhoneNumber> instance_phoneNumbers = new List<CreateInstanceResponse.CreateInstance_Instance.CreateInstance_PhoneNumber>();
			for (int i = 0; i < _ctx.Length("CreateInstance.Instance.PhoneNumbers.Length"); i++) {
				CreateInstanceResponse.CreateInstance_Instance.CreateInstance_PhoneNumber phoneNumber = new CreateInstanceResponse.CreateInstance_Instance.CreateInstance_PhoneNumber();
				phoneNumber.PhoneNumberId = _ctx.StringValue("CreateInstance.Instance.PhoneNumbers["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = _ctx.StringValue("CreateInstance.Instance.PhoneNumbers["+ i +"].InstanceId");
				phoneNumber.Number = _ctx.StringValue("CreateInstance.Instance.PhoneNumbers["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = _ctx.StringValue("CreateInstance.Instance.PhoneNumbers["+ i +"].PhoneNumberDescription");
				phoneNumber.TestOnly = _ctx.BooleanValue("CreateInstance.Instance.PhoneNumbers["+ i +"].TestOnly");
				phoneNumber.RemainingTime = _ctx.IntegerValue("CreateInstance.Instance.PhoneNumbers["+ i +"].RemainingTime");
				phoneNumber.AllowOutbound = _ctx.BooleanValue("CreateInstance.Instance.PhoneNumbers["+ i +"].AllowOutbound");
				phoneNumber.Usage = _ctx.StringValue("CreateInstance.Instance.PhoneNumbers["+ i +"].Usage");
				phoneNumber.Trunks = _ctx.IntegerValue("CreateInstance.Instance.PhoneNumbers["+ i +"].Trunks");

				instance_phoneNumbers.Add(phoneNumber);
			}
			instance.PhoneNumbers = instance_phoneNumbers;
			createInstanceResponse.Instance = instance;
        
			return createInstanceResponse;
        }
    }
}
