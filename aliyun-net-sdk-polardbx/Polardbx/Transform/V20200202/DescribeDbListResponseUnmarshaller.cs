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
    public class DescribeDbListResponseUnmarshaller
    {
        public static DescribeDbListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDbListResponse describeDbListResponse = new DescribeDbListResponse();

			describeDbListResponse.HttpResponse = _ctx.HttpResponse;
			describeDbListResponse.RequestId = _ctx.StringValue("DescribeDbList.RequestId");
			describeDbListResponse.Success = _ctx.BooleanValue("DescribeDbList.Success");
			describeDbListResponse.Message = _ctx.StringValue("DescribeDbList.Message");

			List<DescribeDbListResponse.DescribeDbList_DB> describeDbListResponse_data = new List<DescribeDbListResponse.DescribeDbList_DB>();
			for (int i = 0; i < _ctx.Length("DescribeDbList.Data.Length"); i++) {
				DescribeDbListResponse.DescribeDbList_DB dB = new DescribeDbListResponse.DescribeDbList_DB();
				dB.DBName = _ctx.StringValue("DescribeDbList.Data["+ i +"].DBName");
				dB.DBDescription = _ctx.StringValue("DescribeDbList.Data["+ i +"].DBDescription");
				dB.DBInstanceName = _ctx.StringValue("DescribeDbList.Data["+ i +"].DBInstanceName");
				dB.CharacterSetName = _ctx.StringValue("DescribeDbList.Data["+ i +"].CharacterSetName");

				List<DescribeDbListResponse.DescribeDbList_DB.DescribeDbList_Account> dB_accounts = new List<DescribeDbListResponse.DescribeDbList_DB.DescribeDbList_Account>();
				for (int j = 0; j < _ctx.Length("DescribeDbList.Data["+ i +"].Accounts.Length"); j++) {
					DescribeDbListResponse.DescribeDbList_DB.DescribeDbList_Account account = new DescribeDbListResponse.DescribeDbList_DB.DescribeDbList_Account();
					account.AccountName = _ctx.StringValue("DescribeDbList.Data["+ i +"].Accounts["+ j +"].AccountName");
					account.AccountPrivilege = _ctx.StringValue("DescribeDbList.Data["+ i +"].Accounts["+ j +"].AccountPrivilege");

					dB_accounts.Add(account);
				}
				dB.Accounts = dB_accounts;

				describeDbListResponse_data.Add(dB);
			}
			describeDbListResponse.Data = describeDbListResponse_data;
        
			return describeDbListResponse;
        }
    }
}
