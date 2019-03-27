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
    public class GetInstanceResponseUnmarshaller
    {
        public static GetInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = context.HttpResponse;
			getInstanceResponse.RequestId = context.StringValue("GetInstance.RequestId");
			getInstanceResponse.Success = context.BooleanValue("GetInstance.Success");
			getInstanceResponse.Code = context.StringValue("GetInstance.Code");
			getInstanceResponse.Message = context.StringValue("GetInstance.Message");
			getInstanceResponse.HttpStatusCode = context.IntegerValue("GetInstance.HttpStatusCode");

			GetInstanceResponse.GetInstance_Instance instance = new GetInstanceResponse.GetInstance_Instance();
			instance.InstanceId = context.StringValue("GetInstance.Instance.InstanceId");
			instance.InstanceName = context.StringValue("GetInstance.Instance.InstanceName");
			instance.InstanceDescription = context.StringValue("GetInstance.Instance.InstanceDescription");
			instance.DomainName = context.StringValue("GetInstance.Instance.DomainName");
			instance.ConsoleUrl = context.StringValue("GetInstance.Instance.ConsoleUrl");
			instance.StorageBucket = context.StringValue("GetInstance.Instance.StorageBucket");
			instance.StorageMaxDays = context.IntegerValue("GetInstance.Instance.StorageMaxDays");
			instance.StorageMaxSize = context.IntegerValue("GetInstance.Instance.StorageMaxSize");
			instance.MaxOnlineAgents = context.IntegerValue("GetInstance.Instance.MaxOnlineAgents");
			instance.TenantId = context.StringValue("GetInstance.Instance.TenantId");
			instance.DirectoryId = context.StringValue("GetInstance.Instance.DirectoryId");
			instance.Status = context.StringValue("GetInstance.Instance.Status");
			instance.CreatedTime = context.LongValue("GetInstance.Instance.CreatedTime");
			instance.Owner = context.StringValue("GetInstance.Instance.Owner");

			List<GetInstanceResponse.GetInstance_Instance.GetInstance_User> instance_admin = new List<GetInstanceResponse.GetInstance_Instance.GetInstance_User>();
			for (int i = 0; i < context.Length("GetInstance.Instance.Admin.Length"); i++) {
				GetInstanceResponse.GetInstance_Instance.GetInstance_User user = new GetInstanceResponse.GetInstance_Instance.GetInstance_User();
				user.UserId = context.StringValue("GetInstance.Instance.Admin["+ i +"].UserId");
				user.RamId = context.StringValue("GetInstance.Instance.Admin["+ i +"].RamId");
				user.InstanceId = context.StringValue("GetInstance.Instance.Admin["+ i +"].InstanceId");

				GetInstanceResponse.GetInstance_Instance.GetInstance_User.GetInstance_Detail detail = new GetInstanceResponse.GetInstance_Instance.GetInstance_User.GetInstance_Detail();
				detail.LoginName = context.StringValue("GetInstance.Instance.Admin["+ i +"].Detail.LoginName");
				detail.DisplayName = context.StringValue("GetInstance.Instance.Admin["+ i +"].Detail.DisplayName");
				detail.Phone = context.StringValue("GetInstance.Instance.Admin["+ i +"].Detail.Phone");
				detail.Email = context.StringValue("GetInstance.Instance.Admin["+ i +"].Detail.Email");
				detail.Department = context.StringValue("GetInstance.Instance.Admin["+ i +"].Detail.Department");
				user.Detail = detail;

				instance_admin.Add(user);
			}
			instance.Admin = instance_admin;

			List<GetInstanceResponse.GetInstance_Instance.GetInstance_PhoneNumber> instance_phoneNumbers = new List<GetInstanceResponse.GetInstance_Instance.GetInstance_PhoneNumber>();
			for (int i = 0; i < context.Length("GetInstance.Instance.PhoneNumbers.Length"); i++) {
				GetInstanceResponse.GetInstance_Instance.GetInstance_PhoneNumber phoneNumber = new GetInstanceResponse.GetInstance_Instance.GetInstance_PhoneNumber();
				phoneNumber.PhoneNumberId = context.StringValue("GetInstance.Instance.PhoneNumbers["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = context.StringValue("GetInstance.Instance.PhoneNumbers["+ i +"].InstanceId");
				phoneNumber.Number = context.StringValue("GetInstance.Instance.PhoneNumbers["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = context.StringValue("GetInstance.Instance.PhoneNumbers["+ i +"].PhoneNumberDescription");
				phoneNumber.TestOnly = context.BooleanValue("GetInstance.Instance.PhoneNumbers["+ i +"].TestOnly");
				phoneNumber.RemainingTime = context.IntegerValue("GetInstance.Instance.PhoneNumbers["+ i +"].RemainingTime");
				phoneNumber.AllowOutbound = context.BooleanValue("GetInstance.Instance.PhoneNumbers["+ i +"].AllowOutbound");
				phoneNumber.Usage = context.StringValue("GetInstance.Instance.PhoneNumbers["+ i +"].Usage");
				phoneNumber.Trunks = context.IntegerValue("GetInstance.Instance.PhoneNumbers["+ i +"].Trunks");

				instance_phoneNumbers.Add(phoneNumber);
			}
			instance.PhoneNumbers = instance_phoneNumbers;
			getInstanceResponse.Instance = instance;
        
			return getInstanceResponse;
        }
    }
}
