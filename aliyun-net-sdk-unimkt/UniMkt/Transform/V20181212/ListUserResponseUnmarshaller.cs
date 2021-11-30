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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class ListUserResponseUnmarshaller
    {
        public static ListUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserResponse listUserResponse = new ListUserResponse();

			listUserResponse.HttpResponse = _ctx.HttpResponse;
			listUserResponse.Code = _ctx.StringValue("ListUser.Code");
			listUserResponse.Success = _ctx.BooleanValue("ListUser.Success");
			listUserResponse.Message = _ctx.StringValue("ListUser.Message");
			listUserResponse.RequestId = _ctx.StringValue("ListUser.RequestId");
			listUserResponse.Total = _ctx.LongValue("ListUser.Total");
			listUserResponse.PageNumber = _ctx.IntegerValue("ListUser.PageNumber");
			listUserResponse.PageSize = _ctx.IntegerValue("ListUser.PageSize");

			List<ListUserResponse.ListUser_SspUserDTOModel> listUserResponse_model = new List<ListUserResponse.ListUser_SspUserDTOModel>();
			for (int i = 0; i < _ctx.Length("ListUser.Model.Length"); i++) {
				ListUserResponse.ListUser_SspUserDTOModel sspUserDTOModel = new ListUserResponse.ListUser_SspUserDTOModel();
				sspUserDTOModel.SspUserId = _ctx.StringValue("ListUser.Model["+ i +"].SspUserId");
				sspUserDTOModel.GmtCreateTime = _ctx.LongValue("ListUser.Model["+ i +"].GmtCreateTime");
				sspUserDTOModel.GmtModifiedTime = _ctx.LongValue("ListUser.Model["+ i +"].GmtModifiedTime");
				sspUserDTOModel.IsDeleteTag = _ctx.StringValue("ListUser.Model["+ i +"].IsDeleteTag");
				sspUserDTOModel.UserName = _ctx.StringValue("ListUser.Model["+ i +"].UserName");
				sspUserDTOModel.YunUid = _ctx.StringValue("ListUser.Model["+ i +"].YunUid");
				sspUserDTOModel.YunPersonsId = _ctx.StringValue("ListUser.Model["+ i +"].YunPersonsId");
				sspUserDTOModel.MobilePhone = _ctx.StringValue("ListUser.Model["+ i +"].MobilePhone");
				sspUserDTOModel.Email = _ctx.StringValue("ListUser.Model["+ i +"].Email");
				sspUserDTOModel.Status = _ctx.StringValue("ListUser.Model["+ i +"].Status");
				sspUserDTOModel.TenantId = _ctx.StringValue("ListUser.Model["+ i +"].TenantId");
				sspUserDTOModel.TenantUserId = _ctx.StringValue("ListUser.Model["+ i +"].TenantUserId");
				sspUserDTOModel.RoleCode = _ctx.StringValue("ListUser.Model["+ i +"].RoleCode");

				listUserResponse_model.Add(sspUserDTOModel);
			}
			listUserResponse.Model = listUserResponse_model;
        
			return listUserResponse;
        }
    }
}
