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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnDomainCnameResponseUnmarshaller
    {
        public static DescribeDcdnDomainCnameResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainCnameResponse describeDcdnDomainCnameResponse = new DescribeDcdnDomainCnameResponse();

			describeDcdnDomainCnameResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainCnameResponse.RequestId = context.StringValue("DescribeDcdnDomainCname.RequestId");

			List<DescribeDcdnDomainCnameResponse.DescribeDcdnDomainCname_Data> describeDcdnDomainCnameResponse_cnameDatas = new List<DescribeDcdnDomainCnameResponse.DescribeDcdnDomainCname_Data>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainCname.CnameDatas.Length"); i++) {
				DescribeDcdnDomainCnameResponse.DescribeDcdnDomainCname_Data data = new DescribeDcdnDomainCnameResponse.DescribeDcdnDomainCname_Data();
				data.Domain = context.StringValue("DescribeDcdnDomainCname.CnameDatas["+ i +"].Domain");
				data.Cname = context.StringValue("DescribeDcdnDomainCname.CnameDatas["+ i +"].Cname");
				data.Status = context.IntegerValue("DescribeDcdnDomainCname.CnameDatas["+ i +"].Status");

				describeDcdnDomainCnameResponse_cnameDatas.Add(data);
			}
			describeDcdnDomainCnameResponse.CnameDatas = describeDcdnDomainCnameResponse_cnameDatas;
        
			return describeDcdnDomainCnameResponse;
        }
    }
}
