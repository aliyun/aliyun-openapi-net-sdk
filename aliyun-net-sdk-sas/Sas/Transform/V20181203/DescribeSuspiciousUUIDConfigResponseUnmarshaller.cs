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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeSuspiciousUUIDConfigResponseUnmarshaller
    {
        public static DescribeSuspiciousUUIDConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSuspiciousUUIDConfigResponse describeSuspiciousUUIDConfigResponse = new DescribeSuspiciousUUIDConfigResponse();

			describeSuspiciousUUIDConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeSuspiciousUUIDConfigResponse.Count = _ctx.IntegerValue("DescribeSuspiciousUUIDConfig.Count");
			describeSuspiciousUUIDConfigResponse.RequestId = _ctx.StringValue("DescribeSuspiciousUUIDConfig.RequestId");

			List<string> describeSuspiciousUUIDConfigResponse_uUIDList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSuspiciousUUIDConfig.UUIDList.Length"); i++) {
				describeSuspiciousUUIDConfigResponse_uUIDList.Add(_ctx.StringValue("DescribeSuspiciousUUIDConfig.UUIDList["+ i +"]"));
			}
			describeSuspiciousUUIDConfigResponse.UUIDList = describeSuspiciousUUIDConfigResponse_uUIDList;
        
			return describeSuspiciousUUIDConfigResponse;
        }
    }
}
