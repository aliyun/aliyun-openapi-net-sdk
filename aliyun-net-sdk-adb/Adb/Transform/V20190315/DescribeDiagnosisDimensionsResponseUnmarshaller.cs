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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeDiagnosisDimensionsResponseUnmarshaller
    {
        public static DescribeDiagnosisDimensionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDiagnosisDimensionsResponse describeDiagnosisDimensionsResponse = new DescribeDiagnosisDimensionsResponse();

			describeDiagnosisDimensionsResponse.HttpResponse = _ctx.HttpResponse;
			describeDiagnosisDimensionsResponse.RequestId = _ctx.StringValue("DescribeDiagnosisDimensions.RequestId");

			List<string> describeDiagnosisDimensionsResponse_clientIps = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDiagnosisDimensions.ClientIps.Length"); i++) {
				describeDiagnosisDimensionsResponse_clientIps.Add(_ctx.StringValue("DescribeDiagnosisDimensions.ClientIps["+ i +"]"));
			}
			describeDiagnosisDimensionsResponse.ClientIps = describeDiagnosisDimensionsResponse_clientIps;

			List<string> describeDiagnosisDimensionsResponse_resourceGroups = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDiagnosisDimensions.ResourceGroups.Length"); i++) {
				describeDiagnosisDimensionsResponse_resourceGroups.Add(_ctx.StringValue("DescribeDiagnosisDimensions.ResourceGroups["+ i +"]"));
			}
			describeDiagnosisDimensionsResponse.ResourceGroups = describeDiagnosisDimensionsResponse_resourceGroups;

			List<string> describeDiagnosisDimensionsResponse_userNames = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDiagnosisDimensions.UserNames.Length"); i++) {
				describeDiagnosisDimensionsResponse_userNames.Add(_ctx.StringValue("DescribeDiagnosisDimensions.UserNames["+ i +"]"));
			}
			describeDiagnosisDimensionsResponse.UserNames = describeDiagnosisDimensionsResponse_userNames;

			List<string> describeDiagnosisDimensionsResponse_databases = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDiagnosisDimensions.Databases.Length"); i++) {
				describeDiagnosisDimensionsResponse_databases.Add(_ctx.StringValue("DescribeDiagnosisDimensions.Databases["+ i +"]"));
			}
			describeDiagnosisDimensionsResponse.Databases = describeDiagnosisDimensionsResponse_databases;
        
			return describeDiagnosisDimensionsResponse;
        }
    }
}
