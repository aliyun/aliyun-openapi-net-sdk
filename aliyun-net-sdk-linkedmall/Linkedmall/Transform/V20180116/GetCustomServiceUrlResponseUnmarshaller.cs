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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class GetCustomServiceUrlResponseUnmarshaller
    {
        public static GetCustomServiceUrlResponse Unmarshall(UnmarshallerContext context)
        {
			GetCustomServiceUrlResponse getCustomServiceUrlResponse = new GetCustomServiceUrlResponse();

			getCustomServiceUrlResponse.HttpResponse = context.HttpResponse;
			getCustomServiceUrlResponse.RequestId = context.StringValue("GetCustomServiceUrl.RequestId");
			getCustomServiceUrlResponse.Code = context.StringValue("GetCustomServiceUrl.Code");
			getCustomServiceUrlResponse.Message = context.StringValue("GetCustomServiceUrl.Message");

			GetCustomServiceUrlResponse.GetCustomServiceUrl_UrlData urlData = new GetCustomServiceUrlResponse.GetCustomServiceUrl_UrlData();
			urlData.ReturnUrl = context.StringValue("GetCustomServiceUrl.UrlData.ReturnUrl");
			getCustomServiceUrlResponse.UrlData = urlData;
        
			return getCustomServiceUrlResponse;
        }
    }
}
