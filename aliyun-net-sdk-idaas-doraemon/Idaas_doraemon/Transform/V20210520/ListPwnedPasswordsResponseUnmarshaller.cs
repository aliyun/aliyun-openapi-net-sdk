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
using Aliyun.Acs.idaas_doraemon.Model.V20210520;

namespace Aliyun.Acs.idaas_doraemon.Transform.V20210520
{
    public class ListPwnedPasswordsResponseUnmarshaller
    {
        public static ListPwnedPasswordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPwnedPasswordsResponse listPwnedPasswordsResponse = new ListPwnedPasswordsResponse();

			listPwnedPasswordsResponse.HttpResponse = _ctx.HttpResponse;
			listPwnedPasswordsResponse.RequestId = _ctx.StringValue("ListPwnedPasswords.RequestId");
			listPwnedPasswordsResponse.PageNumber = _ctx.LongValue("ListPwnedPasswords.PageNumber");
			listPwnedPasswordsResponse.TotalCount = _ctx.LongValue("ListPwnedPasswords.TotalCount");
			listPwnedPasswordsResponse.PageSize = _ctx.LongValue("ListPwnedPasswords.PageSize");

			List<ListPwnedPasswordsResponse.ListPwnedPasswords_Items> listPwnedPasswordsResponse_pwnedPasswordInfos = new List<ListPwnedPasswordsResponse.ListPwnedPasswords_Items>();
			for (int i = 0; i < _ctx.Length("ListPwnedPasswords.PwnedPasswordInfos.Length"); i++) {
				ListPwnedPasswordsResponse.ListPwnedPasswords_Items items = new ListPwnedPasswordsResponse.ListPwnedPasswords_Items();
				items.HexPasswordSha1Hash = _ctx.StringValue("ListPwnedPasswords.PwnedPasswordInfos["+ i +"].HexPasswordSha1Hash");
				items.PwnedCount = _ctx.LongValue("ListPwnedPasswords.PwnedPasswordInfos["+ i +"].PwnedCount");

				listPwnedPasswordsResponse_pwnedPasswordInfos.Add(items);
			}
			listPwnedPasswordsResponse.PwnedPasswordInfos = listPwnedPasswordsResponse_pwnedPasswordInfos;
        
			return listPwnedPasswordsResponse;
        }
    }
}
