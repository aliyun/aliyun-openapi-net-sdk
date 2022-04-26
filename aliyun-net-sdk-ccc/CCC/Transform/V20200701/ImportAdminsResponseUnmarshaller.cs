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
    public class ImportAdminsResponseUnmarshaller
    {
        public static ImportAdminsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ImportAdminsResponse importAdminsResponse = new ImportAdminsResponse();

			importAdminsResponse.HttpResponse = _ctx.HttpResponse;
			importAdminsResponse.HttpStatusCode = _ctx.IntegerValue("ImportAdmins.HttpStatusCode");
			importAdminsResponse.RequestId = _ctx.StringValue("ImportAdmins.RequestId");
			importAdminsResponse.Code = _ctx.StringValue("ImportAdmins.Code");
			importAdminsResponse.Message = _ctx.StringValue("ImportAdmins.Message");

			List<ImportAdminsResponse.ImportAdmins_User> importAdminsResponse_data = new List<ImportAdminsResponse.ImportAdmins_User>();
			for (int i = 0; i < _ctx.Length("ImportAdmins.Data.Length"); i++) {
				ImportAdminsResponse.ImportAdmins_User user = new ImportAdminsResponse.ImportAdmins_User();
				user.InstanceId = _ctx.StringValue("ImportAdmins.Data["+ i +"].InstanceId");
				user.UserId = _ctx.StringValue("ImportAdmins.Data["+ i +"].UserId");
				user.RoleId = _ctx.StringValue("ImportAdmins.Data["+ i +"].RoleId");
				user.Extension = _ctx.StringValue("ImportAdmins.Data["+ i +"].Extension");
				user.RamId = _ctx.StringValue("ImportAdmins.Data["+ i +"].RamId");

				importAdminsResponse_data.Add(user);
			}
			importAdminsResponse.Data = importAdminsResponse_data;
        
			return importAdminsResponse;
        }
    }
}
