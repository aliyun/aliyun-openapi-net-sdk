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
using Aliyun.Acs.alikafka.Model.V20190916;

namespace Aliyun.Acs.alikafka.Transform.V20190916
{
    public class DescribeSaslUsersResponseUnmarshaller
    {
        public static DescribeSaslUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSaslUsersResponse describeSaslUsersResponse = new DescribeSaslUsersResponse();

			describeSaslUsersResponse.HttpResponse = _ctx.HttpResponse;
			describeSaslUsersResponse.Code = _ctx.IntegerValue("DescribeSaslUsers.Code");
			describeSaslUsersResponse.Message = _ctx.StringValue("DescribeSaslUsers.Message");
			describeSaslUsersResponse.RequestId = _ctx.StringValue("DescribeSaslUsers.RequestId");
			describeSaslUsersResponse.Success = _ctx.BooleanValue("DescribeSaslUsers.Success");

			List<DescribeSaslUsersResponse.DescribeSaslUsers_SaslUserVO> describeSaslUsersResponse_saslUserList = new List<DescribeSaslUsersResponse.DescribeSaslUsers_SaslUserVO>();
			for (int i = 0; i < _ctx.Length("DescribeSaslUsers.SaslUserList.Length"); i++) {
				DescribeSaslUsersResponse.DescribeSaslUsers_SaslUserVO saslUserVO = new DescribeSaslUsersResponse.DescribeSaslUsers_SaslUserVO();
				saslUserVO.Type = _ctx.StringValue("DescribeSaslUsers.SaslUserList["+ i +"].Type");
				saslUserVO.Password = _ctx.StringValue("DescribeSaslUsers.SaslUserList["+ i +"].Password");
				saslUserVO.Username = _ctx.StringValue("DescribeSaslUsers.SaslUserList["+ i +"].Username");

				describeSaslUsersResponse_saslUserList.Add(saslUserVO);
			}
			describeSaslUsersResponse.SaslUserList = describeSaslUsersResponse_saslUserList;
        
			return describeSaslUsersResponse;
        }
    }
}
