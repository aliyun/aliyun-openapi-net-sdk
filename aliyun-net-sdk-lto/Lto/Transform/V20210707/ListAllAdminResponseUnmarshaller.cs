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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListAllAdminResponseUnmarshaller
    {
        public static ListAllAdminResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAllAdminResponse listAllAdminResponse = new ListAllAdminResponse();

			listAllAdminResponse.HttpResponse = _ctx.HttpResponse;
			listAllAdminResponse.Code = _ctx.StringValue("ListAllAdmin.Code");
			listAllAdminResponse.HttpStatusCode = _ctx.IntegerValue("ListAllAdmin.HttpStatusCode");
			listAllAdminResponse.Message = _ctx.StringValue("ListAllAdmin.Message");
			listAllAdminResponse.RequestId = _ctx.StringValue("ListAllAdmin.RequestId");
			listAllAdminResponse.Success = _ctx.BooleanValue("ListAllAdmin.Success");

			List<ListAllAdminResponse.ListAllAdmin_AdminInfo> listAllAdminResponse_data = new List<ListAllAdminResponse.ListAllAdmin_AdminInfo>();
			for (int i = 0; i < _ctx.Length("ListAllAdmin.Data.Length"); i++) {
				ListAllAdminResponse.ListAllAdmin_AdminInfo adminInfo = new ListAllAdminResponse.ListAllAdmin_AdminInfo();
				adminInfo.Name = _ctx.StringValue("ListAllAdmin.Data["+ i +"].Name");
				adminInfo.AdminId = _ctx.StringValue("ListAllAdmin.Data["+ i +"].AdminId");

				listAllAdminResponse_data.Add(adminInfo);
			}
			listAllAdminResponse.Data = listAllAdminResponse_data;
        
			return listAllAdminResponse;
        }
    }
}
