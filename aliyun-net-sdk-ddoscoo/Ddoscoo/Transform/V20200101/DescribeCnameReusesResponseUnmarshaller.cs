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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeCnameReusesResponseUnmarshaller
    {
        public static DescribeCnameReusesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCnameReusesResponse describeCnameReusesResponse = new DescribeCnameReusesResponse();

			describeCnameReusesResponse.HttpResponse = _ctx.HttpResponse;
			describeCnameReusesResponse.RequestId = _ctx.StringValue("DescribeCnameReuses.RequestId");

			List<DescribeCnameReusesResponse.DescribeCnameReuses_CnameReuse> describeCnameReusesResponse_cnameReuses = new List<DescribeCnameReusesResponse.DescribeCnameReuses_CnameReuse>();
			for (int i = 0; i < _ctx.Length("DescribeCnameReuses.CnameReuses.Length"); i++) {
				DescribeCnameReusesResponse.DescribeCnameReuses_CnameReuse cnameReuse = new DescribeCnameReusesResponse.DescribeCnameReuses_CnameReuse();
				cnameReuse.Domain = _ctx.StringValue("DescribeCnameReuses.CnameReuses["+ i +"].Domain");
				cnameReuse.Enable = _ctx.IntegerValue("DescribeCnameReuses.CnameReuses["+ i +"].Enable");
				cnameReuse.Cname = _ctx.StringValue("DescribeCnameReuses.CnameReuses["+ i +"].Cname");

				describeCnameReusesResponse_cnameReuses.Add(cnameReuse);
			}
			describeCnameReusesResponse.CnameReuses = describeCnameReusesResponse_cnameReuses;
        
			return describeCnameReusesResponse;
        }
    }
}
