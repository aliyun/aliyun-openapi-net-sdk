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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class GetSparkAppWebUiAddressResponseUnmarshaller
    {
        public static GetSparkAppWebUiAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSparkAppWebUiAddressResponse getSparkAppWebUiAddressResponse = new GetSparkAppWebUiAddressResponse();

			getSparkAppWebUiAddressResponse.HttpResponse = _ctx.HttpResponse;
			getSparkAppWebUiAddressResponse.RequestId = _ctx.StringValue("GetSparkAppWebUiAddress.RequestId");

			GetSparkAppWebUiAddressResponse.GetSparkAppWebUiAddress_Data data = new GetSparkAppWebUiAddressResponse.GetSparkAppWebUiAddress_Data();
			data.AppId = _ctx.StringValue("GetSparkAppWebUiAddress.Data.AppId");
			data.ExpirationTimeInMillis = _ctx.LongValue("GetSparkAppWebUiAddress.Data.ExpirationTimeInMillis");
			data.WebUiAddress = _ctx.StringValue("GetSparkAppWebUiAddress.Data.WebUiAddress");
			data.DBClusterId = _ctx.StringValue("GetSparkAppWebUiAddress.Data.DBClusterId");
			getSparkAppWebUiAddressResponse.Data = data;
        
			return getSparkAppWebUiAddressResponse;
        }
    }
}
