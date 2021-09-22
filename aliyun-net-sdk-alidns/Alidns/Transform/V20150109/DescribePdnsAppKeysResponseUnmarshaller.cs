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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribePdnsAppKeysResponseUnmarshaller
    {
        public static DescribePdnsAppKeysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePdnsAppKeysResponse describePdnsAppKeysResponse = new DescribePdnsAppKeysResponse();

			describePdnsAppKeysResponse.HttpResponse = _ctx.HttpResponse;
			describePdnsAppKeysResponse.RequestId = _ctx.StringValue("DescribePdnsAppKeys.RequestId");

			List<DescribePdnsAppKeysResponse.DescribePdnsAppKeys_AppKey> describePdnsAppKeysResponse_appKeys = new List<DescribePdnsAppKeysResponse.DescribePdnsAppKeys_AppKey>();
			for (int i = 0; i < _ctx.Length("DescribePdnsAppKeys.AppKeys.Length"); i++) {
				DescribePdnsAppKeysResponse.DescribePdnsAppKeys_AppKey appKey = new DescribePdnsAppKeysResponse.DescribePdnsAppKeys_AppKey();
				appKey.State = _ctx.StringValue("DescribePdnsAppKeys.AppKeys["+ i +"].State");
				appKey.AppKeyId = _ctx.StringValue("DescribePdnsAppKeys.AppKeys["+ i +"].AppKeyId");
				appKey.CreateDate = _ctx.StringValue("DescribePdnsAppKeys.AppKeys["+ i +"].CreateDate");

				describePdnsAppKeysResponse_appKeys.Add(appKey);
			}
			describePdnsAppKeysResponse.AppKeys = describePdnsAppKeysResponse_appKeys;
        
			return describePdnsAppKeysResponse;
        }
    }
}
