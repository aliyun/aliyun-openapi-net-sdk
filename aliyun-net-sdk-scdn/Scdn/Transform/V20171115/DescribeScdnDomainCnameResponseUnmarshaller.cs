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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainCnameResponseUnmarshaller
    {
        public static DescribeScdnDomainCnameResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDomainCnameResponse describeScdnDomainCnameResponse = new DescribeScdnDomainCnameResponse();

			describeScdnDomainCnameResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDomainCnameResponse.RequestId = _ctx.StringValue("DescribeScdnDomainCname.RequestId");

			List<DescribeScdnDomainCnameResponse.DescribeScdnDomainCname_Data> describeScdnDomainCnameResponse_cnameDatas = new List<DescribeScdnDomainCnameResponse.DescribeScdnDomainCname_Data>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDomainCname.CnameDatas.Length"); i++) {
				DescribeScdnDomainCnameResponse.DescribeScdnDomainCname_Data data = new DescribeScdnDomainCnameResponse.DescribeScdnDomainCname_Data();
				data.Status = _ctx.IntegerValue("DescribeScdnDomainCname.CnameDatas["+ i +"].Status");
				data.Domain = _ctx.StringValue("DescribeScdnDomainCname.CnameDatas["+ i +"].Domain");
				data.Cname = _ctx.StringValue("DescribeScdnDomainCname.CnameDatas["+ i +"].Cname");

				describeScdnDomainCnameResponse_cnameDatas.Add(data);
			}
			describeScdnDomainCnameResponse.CnameDatas = describeScdnDomainCnameResponse_cnameDatas;
        
			return describeScdnDomainCnameResponse;
        }
    }
}
