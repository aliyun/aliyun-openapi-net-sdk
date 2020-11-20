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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeStagingIpResponseUnmarshaller
    {
        public static DescribeStagingIpResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStagingIpResponse describeStagingIpResponse = new DescribeStagingIpResponse();

			describeStagingIpResponse.HttpResponse = _ctx.HttpResponse;
			describeStagingIpResponse.RequestId = _ctx.StringValue("DescribeStagingIp.RequestId");

			List<string> describeStagingIpResponse_iPV4s = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeStagingIp.IPV4s.Length"); i++) {
				describeStagingIpResponse_iPV4s.Add(_ctx.StringValue("DescribeStagingIp.IPV4s["+ i +"]"));
			}
			describeStagingIpResponse.IPV4s = describeStagingIpResponse_iPV4s;
        
			return describeStagingIpResponse;
        }
    }
}
