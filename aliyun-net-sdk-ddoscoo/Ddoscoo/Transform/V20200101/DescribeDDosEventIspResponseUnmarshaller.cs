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
    public class DescribeDDosEventIspResponseUnmarshaller
    {
        public static DescribeDDosEventIspResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDDosEventIspResponse describeDDosEventIspResponse = new DescribeDDosEventIspResponse();

			describeDDosEventIspResponse.HttpResponse = _ctx.HttpResponse;
			describeDDosEventIspResponse.RequestId = _ctx.StringValue("DescribeDDosEventIsp.RequestId");

			List<DescribeDDosEventIspResponse.DescribeDDosEventIsp_EventIsp> describeDDosEventIspResponse_isps = new List<DescribeDDosEventIspResponse.DescribeDDosEventIsp_EventIsp>();
			for (int i = 0; i < _ctx.Length("DescribeDDosEventIsp.Isps.Length"); i++) {
				DescribeDDosEventIspResponse.DescribeDDosEventIsp_EventIsp eventIsp = new DescribeDDosEventIspResponse.DescribeDDosEventIsp_EventIsp();
				eventIsp.Isp = _ctx.StringValue("DescribeDDosEventIsp.Isps["+ i +"].Isp");
				eventIsp.InPkts = _ctx.LongValue("DescribeDDosEventIsp.Isps["+ i +"].InPkts");

				describeDDosEventIspResponse_isps.Add(eventIsp);
			}
			describeDDosEventIspResponse.Isps = describeDDosEventIspResponse_isps;
        
			return describeDDosEventIspResponse;
        }
    }
}
