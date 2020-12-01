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
        public static GetInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceResponse.RequestId = _ctx.StringValue("GetInstance.RequestId");
			getInstanceResponse.Success = _ctx.BooleanValue("GetInstance.Success");
			getInstanceResponse.Code = _ctx.StringValue("GetInstance.Code");
			getInstanceResponse.Message = _ctx.StringValue("GetInstance.Message");
			getInstanceResponse.HttpStatusCode = _ctx.IntegerValue("GetInstance.HttpStatusCode");

			GetInstanceResponse.GetInstance_Instance instance = new GetInstanceResponse.GetInstance_Instance();
			instance.InstanceId = _ctx.StringValue("GetInstance.Instance.InstanceId");
			instance.InstanceName = _ctx.StringValue("GetInstance.Instance.InstanceName");
			instance.InstanceDescription = _ctx.StringValue("GetInstance.Instance.InstanceDescription");
			instance.DomainName = _ctx.StringValue("GetInstance.Instance.DomainName");
			instance.ConsoleUrl = _ctx.StringValue("GetInstance.Instance.ConsoleUrl");
			instance.StorageBucket = _ctx.StringValue("GetInstance.Instance.StorageBucket");
			instance.StorageMaxDays = _ctx.IntegerValue("GetInstance.Instance.StorageMaxDays");
			instance.StorageMaxSize = _ctx.IntegerValue("GetInstance.Instance.StorageMaxSize");
			instance.MaxOnlineAgents = _ctx.IntegerValue("GetInstance.Instance.MaxOnlineAgents");
			instance.TenantId = _ctx.StringValue("GetInstance.Instance.TenantId");
			instance.DirectoryId = _ctx.StringValue("GetInstance.Instance.DirectoryId");
			instance.Status = _ctx.StringValue("GetInstance.Instance.Status");
			instance.CreatedTime = _ctx.LongValue("GetInstance.Instance.CreatedTime");
			instance.Owner = _ctx.StringValue("GetInstance.Instance.Owner");

			List<GetInstanceResponse.GetInstance_Instance.GetInstance_User> instance_admin = new List<GetInstanceResponse.GetInstance_Instance.GetInstance_User>();
			for (int i = 0; i < _ctx.Length("GetInstance.Instance.Admin.Length"); i++) {
				GetInstanceResponse.GetInstance_Instance.GetInstance_User user = new GetInstanceResponse.GetInstance_Instance.GetInstance_User();
				user.UserId = _ctx.StringValue("GetInstance.Instance.Admin["+ i +"].UserId");
				user.RamId = _ctx.StringValue("GetInstance.Instance.Admin["+ i +"].RamId");
				user.InstanceId = _ctx.StringValue("GetInstance.Instance.Admin["+ i +"].InstanceId");

				GetInstanceResponse.GetInstance_Instance.GetInstance_User.GetInstance_Detail detail = new GetInstanceResponse.GetInstance_Instance.GetInstance_User.GetInstance_Detail();
				detail.LoginName = _ctx.StringValue("GetInstance.Instance.Admin["+ i +"].Detail.LoginName");
				detail.DisplayName = _ctx.StringValue("GetInstance.Instance.Admin["+ i +"].Detail.DisplayName");
				detail.Phone = _ctx.StringValue("GetInstance.Instance.Admin["+ i +"].Detail.Phone");
				detail.Email = _ctx.StringValue("GetInstance.Instance.Admin["+ i +"].Detail.Email");
				detail.Department = _ctx.StringValue("GetInstance.Instance.Admin["+ i +"].Detail.Department");
				user.Detail = detail;

				instance_admin.Add(user);
			}
			instance.Admin = instance_admin;

			List<GetInstanceResponse.GetInstance_Instance.GetInstance_PhoneNumber> instance_phoneNumbers = new List<GetInstanceResponse.GetInstance_Instance.GetInstance_PhoneNumber>();
			for (int i = 0; i < _ctx.Length("GetInstance.Instance.PhoneNumbers.Length"); i++) {
				GetInstanceResponse.GetInstance_Instance.GetInstance_PhoneNumber phoneNumber = new GetInstanceResponse.GetInstance_Instance.GetInstance_PhoneNumber();
				phoneNumber.PhoneNumberId = _ctx.StringValue("GetInstance.Instance.PhoneNumbers["+ i +"].PhoneNumberId");
				phoneNumber.InstanceId = _ctx.StringValue("GetInstance.Instance.PhoneNumbers["+ i +"].InstanceId");
				phoneNumber.Number = _ctx.StringValue("GetInstance.Instance.PhoneNumbers["+ i +"].Number");
				phoneNumber.PhoneNumberDescription = _ctx.StringValue("GetInstance.Instance.PhoneNumbers["+ i +"].PhoneNumberDescription");
				phoneNumber.TestOnly = _ctx.BooleanValue("GetInstance.Instance.PhoneNumbers["+ i +"].TestOnly");
				phoneNumber.RemainingTime = _ctx.IntegerValue("GetInstance.Instance.PhoneNumbers["+ i +"].RemainingTime");
				phoneNumber.AllowOutbound = _ctx.BooleanValue("GetInstance.Instance.PhoneNumbers["+ i +"].AllowOutbound");
				phoneNumber.Usage = _ctx.StringValue("GetInstance.Instance.PhoneNumbers["+ i +"].Usage");
				phoneNumber.Trunks = _ctx.IntegerValue("GetInstance.Instance.PhoneNumbers["+ i +"].Trunks");

				instance_phoneNumbers.Add(phoneNumber);
			}
			instance.PhoneNumbers = instance_phoneNumbers;
			getInstanceResponse.Instance = instance;
        
			return getInstanceResponse;
        }
    }
}
