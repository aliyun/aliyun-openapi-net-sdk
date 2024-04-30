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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeAccountMaskingPrivilegeResponseUnmarshaller
    {
        public static DescribeAccountMaskingPrivilegeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccountMaskingPrivilegeResponse describeAccountMaskingPrivilegeResponse = new DescribeAccountMaskingPrivilegeResponse();

			describeAccountMaskingPrivilegeResponse.HttpResponse = _ctx.HttpResponse;
			describeAccountMaskingPrivilegeResponse.RequestId = _ctx.StringValue("DescribeAccountMaskingPrivilege.RequestId");

			DescribeAccountMaskingPrivilegeResponse.DescribeAccountMaskingPrivilege_Data data = new DescribeAccountMaskingPrivilegeResponse.DescribeAccountMaskingPrivilege_Data();

			List<DescribeAccountMaskingPrivilegeResponse.DescribeAccountMaskingPrivilege_Data.DescribeAccountMaskingPrivilege_UserPrivilegeItem> data_userPrivilege = new List<DescribeAccountMaskingPrivilegeResponse.DescribeAccountMaskingPrivilege_Data.DescribeAccountMaskingPrivilege_UserPrivilegeItem>();
			for (int i = 0; i < _ctx.Length("DescribeAccountMaskingPrivilege.Data.UserPrivilege.Length"); i++) {
				DescribeAccountMaskingPrivilegeResponse.DescribeAccountMaskingPrivilege_Data.DescribeAccountMaskingPrivilege_UserPrivilegeItem userPrivilegeItem = new DescribeAccountMaskingPrivilegeResponse.DescribeAccountMaskingPrivilege_Data.DescribeAccountMaskingPrivilege_UserPrivilegeItem();
				userPrivilegeItem.ExpireTime = _ctx.StringValue("DescribeAccountMaskingPrivilege.Data.UserPrivilege["+ i +"].ExpireTime");
				userPrivilegeItem.Privilege = _ctx.StringValue("DescribeAccountMaskingPrivilege.Data.UserPrivilege["+ i +"].Privilege");
				userPrivilegeItem.UserName = _ctx.StringValue("DescribeAccountMaskingPrivilege.Data.UserPrivilege["+ i +"].UserName");

				data_userPrivilege.Add(userPrivilegeItem);
			}
			data.UserPrivilege = data_userPrivilege;
			describeAccountMaskingPrivilegeResponse.Data = data;
        
			return describeAccountMaskingPrivilegeResponse;
        }
    }
}
