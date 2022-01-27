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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class GetUserResponseUnmarshaller
    {
        public static GetUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = _ctx.HttpResponse;
			getUserResponse.Code = _ctx.StringValue("GetUser.Code");
			getUserResponse.Message = _ctx.StringValue("GetUser.Message");
			getUserResponse.RequestId = _ctx.StringValue("GetUser.RequestId");

			GetUserResponse.GetUser_Data data = new GetUserResponse.GetUser_Data();
			data.CreatedAt = _ctx.StringValue("GetUser.Data.CreatedAt");
			data.Email = _ctx.StringValue("GetUser.Data.Email");
			data.Id = _ctx.StringValue("GetUser.Data.Id");
			data.Name = _ctx.StringValue("GetUser.Data.Name");
			data.PhoneNumber = _ctx.StringValue("GetUser.Data.PhoneNumber");
			data.Role = _ctx.StringValue("GetUser.Data.Role");
			data.Source = _ctx.StringValue("GetUser.Data.Source");
			data.UpdatedAt = _ctx.StringValue("GetUser.Data.UpdatedAt");
			data.Username = _ctx.StringValue("GetUser.Data.Username");

			List<GetUserResponse.GetUser_Data.GetUser_DepartmentsItem> data_departments = new List<GetUserResponse.GetUser_Data.GetUser_DepartmentsItem>();
			for (int i = 0; i < _ctx.Length("GetUser.Data.Departments.Length"); i++) {
				GetUserResponse.GetUser_Data.GetUser_DepartmentsItem departmentsItem = new GetUserResponse.GetUser_Data.GetUser_DepartmentsItem();
				departmentsItem.Description = _ctx.StringValue("GetUser.Data.Departments["+ i +"].Description");
				departmentsItem.GmtCreate = _ctx.StringValue("GetUser.Data.Departments["+ i +"].GmtCreate");
				departmentsItem.GmtModified = _ctx.StringValue("GetUser.Data.Departments["+ i +"].GmtModified");
				departmentsItem.Id = _ctx.StringValue("GetUser.Data.Departments["+ i +"].Id");
				departmentsItem.Name = _ctx.StringValue("GetUser.Data.Departments["+ i +"].Name");

				data_departments.Add(departmentsItem);
			}
			data.Departments = data_departments;
			getUserResponse.Data = data;
        
			return getUserResponse;
        }
    }
}
