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
using Aliyun.Acs.Netana.Model.V20181018;

namespace Aliyun.Acs.Netana.Transform.V20181018
{
    public class DescribeDiagnosticConfigResponseUnmarshaller
    {
        public static DescribeDiagnosticConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDiagnosticConfigResponse describeDiagnosticConfigResponse = new DescribeDiagnosticConfigResponse();

			describeDiagnosticConfigResponse.HttpResponse = context.HttpResponse;
			describeDiagnosticConfigResponse.RequestId = context.StringValue("DescribeDiagnosticConfig.RequestId");

			List<string> describeDiagnosticConfigResponse_apiList = new List<string>();
			for (int i = 0; i < context.Length("DescribeDiagnosticConfig.ApiList.Length"); i++) {
				describeDiagnosticConfigResponse_apiList.Add(context.StringValue("DescribeDiagnosticConfig.ApiList["+ i +"]"));
			}
			describeDiagnosticConfigResponse.ApiList = describeDiagnosticConfigResponse_apiList;
        
			return describeDiagnosticConfigResponse;
        }
    }
}
