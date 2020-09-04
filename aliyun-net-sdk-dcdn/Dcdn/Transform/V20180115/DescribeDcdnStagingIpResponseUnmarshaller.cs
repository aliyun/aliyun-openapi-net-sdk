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
    public class DescribeDcdnStagingIpResponseUnmarshaller
    {
        public static DescribeDcdnStagingIpResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnStagingIpResponse describeDcdnStagingIpResponse = new DescribeDcdnStagingIpResponse();

			describeDcdnStagingIpResponse.HttpResponse = context.HttpResponse;
			describeDcdnStagingIpResponse.RequestId = context.StringValue("DescribeDcdnStagingIp.RequestId");

			List<string> describeDcdnStagingIpResponse_iPV4s = new List<string>();
			for (int i = 0; i < context.Length("DescribeDcdnStagingIp.IPV4s.Length"); i++) {
				describeDcdnStagingIpResponse_iPV4s.Add(context.StringValue("DescribeDcdnStagingIp.IPV4s["+ i +"]"));
			}
			describeDcdnStagingIpResponse.IPV4s = describeDcdnStagingIpResponse_iPV4s;
        
			return describeDcdnStagingIpResponse;
        }
    }
}
