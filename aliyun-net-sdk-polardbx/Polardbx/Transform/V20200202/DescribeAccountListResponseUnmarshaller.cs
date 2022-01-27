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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeAccountListResponseUnmarshaller
    {
        public static DescribeAccountListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccountListResponse describeAccountListResponse = new DescribeAccountListResponse();

			describeAccountListResponse.HttpResponse = _ctx.HttpResponse;
			describeAccountListResponse.Message = _ctx.StringValue("DescribeAccountList.Message");
			describeAccountListResponse.RequestId = _ctx.StringValue("DescribeAccountList.RequestId");
			describeAccountListResponse.Success = _ctx.BooleanValue("DescribeAccountList.Success");

			List<DescribeAccountListResponse.DescribeAccountList_Account> describeAccountListResponse_data = new List<DescribeAccountListResponse.DescribeAccountList_Account>();
			for (int i = 0; i < _ctx.Length("DescribeAccountList.Data.Length"); i++) {
				DescribeAccountListResponse.DescribeAccountList_Account account = new DescribeAccountListResponse.DescribeAccountList_Account();
				account.AccountDescription = _ctx.StringValue("DescribeAccountList.Data["+ i +"].AccountDescription");
				account.AccountName = _ctx.StringValue("DescribeAccountList.Data["+ i +"].AccountName");
				account.AccountPrivilege = _ctx.StringValue("DescribeAccountList.Data["+ i +"].AccountPrivilege");
				account.AccountType = _ctx.StringValue("DescribeAccountList.Data["+ i +"].AccountType");
				account.DBInstanceName = _ctx.StringValue("DescribeAccountList.Data["+ i +"].DBInstanceName");
				account.DBName = _ctx.StringValue("DescribeAccountList.Data["+ i +"].DBName");

				describeAccountListResponse_data.Add(account);
			}
			describeAccountListResponse.Data = describeAccountListResponse_data;
        
			return describeAccountListResponse;
        }
    }
}
