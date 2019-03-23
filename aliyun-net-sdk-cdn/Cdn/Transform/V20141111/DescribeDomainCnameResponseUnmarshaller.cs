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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainCnameResponseUnmarshaller
    {
        public static DescribeDomainCnameResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainCnameResponse describeDomainCnameResponse = new DescribeDomainCnameResponse();

            describeDomainCnameResponse.HttpResponse = context.HttpResponse;
            describeDomainCnameResponse.RequestId = context.StringValue("DescribeDomainCname.RequestId");

            List<DescribeDomainCnameResponse.DescribeDomainCname_Data> describeDomainCnameResponse_cnameDatas = new List<DescribeDomainCnameResponse.DescribeDomainCname_Data>();
            for (int i = 0; i < context.Length("DescribeDomainCname.CnameDatas.Length"); i++)
            {
                DescribeDomainCnameResponse.DescribeDomainCname_Data data = new DescribeDomainCnameResponse.DescribeDomainCname_Data();
                data.Domain = context.StringValue("DescribeDomainCname.CnameDatas[" + i + "].Domain");
                data.Cname = context.StringValue("DescribeDomainCname.CnameDatas[" + i + "].Cname");
                data.Status = context.IntegerValue("DescribeDomainCname.CnameDatas[" + i + "].Status");

                describeDomainCnameResponse_cnameDatas.Add(data);
            }
            describeDomainCnameResponse.CnameDatas = describeDomainCnameResponse_cnameDatas;

            return describeDomainCnameResponse;
        }
    }
}
