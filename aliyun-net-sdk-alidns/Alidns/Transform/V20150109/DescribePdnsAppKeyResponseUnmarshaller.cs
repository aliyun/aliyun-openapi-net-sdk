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
    public class DescribePdnsAppKeyResponseUnmarshaller
    {
        public static DescribePdnsAppKeyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePdnsAppKeyResponse describePdnsAppKeyResponse = new DescribePdnsAppKeyResponse();

			describePdnsAppKeyResponse.HttpResponse = _ctx.HttpResponse;
			describePdnsAppKeyResponse.RequestId = _ctx.StringValue("DescribePdnsAppKey.RequestId");

			DescribePdnsAppKeyResponse.DescribePdnsAppKey_AppKey appKey = new DescribePdnsAppKeyResponse.DescribePdnsAppKey_AppKey();
			appKey.State = _ctx.StringValue("DescribePdnsAppKey.AppKey.State");
			appKey.AppKeyId = _ctx.StringValue("DescribePdnsAppKey.AppKey.AppKeyId");
			appKey.CreateDate = _ctx.StringValue("DescribePdnsAppKey.AppKey.CreateDate");
			appKey.AppKeySecret = _ctx.StringValue("DescribePdnsAppKey.AppKey.AppKeySecret");
			describePdnsAppKeyResponse.AppKey = appKey;
        
			return describePdnsAppKeyResponse;
        }
    }
}
