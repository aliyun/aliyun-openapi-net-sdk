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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeScopeUsersResponseUnmarshaller
    {
        public static DescribeScopeUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScopeUsersResponse describeScopeUsersResponse = new DescribeScopeUsersResponse();

			describeScopeUsersResponse.HttpResponse = _ctx.HttpResponse;
			describeScopeUsersResponse.Success = _ctx.BooleanValue("DescribeScopeUsers.Success");
			describeScopeUsersResponse.Code = _ctx.IntegerValue("DescribeScopeUsers.Code");
			describeScopeUsersResponse.Message = _ctx.StringValue("DescribeScopeUsers.Message");
			describeScopeUsersResponse.RequestId = _ctx.StringValue("DescribeScopeUsers.RequestId");

			List<DescribeScopeUsersResponse.DescribeScopeUsers_DataItem> describeScopeUsersResponse_data = new List<DescribeScopeUsersResponse.DescribeScopeUsers_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeScopeUsers.Data.Length"); i++) {
				DescribeScopeUsersResponse.DescribeScopeUsers_DataItem dataItem = new DescribeScopeUsersResponse.DescribeScopeUsers_DataItem();
				dataItem.AliUid = _ctx.LongValue("DescribeScopeUsers.Data["+ i +"].AliUid");
				dataItem.UserName = _ctx.StringValue("DescribeScopeUsers.Data["+ i +"].UserName");
				dataItem.UserId = _ctx.StringValue("DescribeScopeUsers.Data["+ i +"].UserId");
				dataItem.CloudCode = _ctx.StringValue("DescribeScopeUsers.Data["+ i +"].CloudCode");
				dataItem.InstanceId = _ctx.StringValue("DescribeScopeUsers.Data["+ i +"].InstanceId");

				List<string> dataItem_domains = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeScopeUsers.Data["+ i +"].Domains.Length"); j++) {
					dataItem_domains.Add(_ctx.StringValue("DescribeScopeUsers.Data["+ i +"].Domains["+ j +"]"));
				}
				dataItem.Domains = dataItem_domains;

				describeScopeUsersResponse_data.Add(dataItem);
			}
			describeScopeUsersResponse.Data = describeScopeUsersResponse_data;
        
			return describeScopeUsersResponse;
        }
    }
}
