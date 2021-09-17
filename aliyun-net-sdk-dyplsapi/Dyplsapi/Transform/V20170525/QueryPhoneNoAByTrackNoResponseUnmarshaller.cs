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
using Aliyun.Acs.Dyplsapi.Model.V20170525;

namespace Aliyun.Acs.Dyplsapi.Transform.V20170525
{
    public class QueryPhoneNoAByTrackNoResponseUnmarshaller
    {
        public static QueryPhoneNoAByTrackNoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPhoneNoAByTrackNoResponse queryPhoneNoAByTrackNoResponse = new QueryPhoneNoAByTrackNoResponse();

			queryPhoneNoAByTrackNoResponse.HttpResponse = _ctx.HttpResponse;
			queryPhoneNoAByTrackNoResponse.Code = _ctx.StringValue("QueryPhoneNoAByTrackNo.Code");
			queryPhoneNoAByTrackNoResponse.Message = _ctx.StringValue("QueryPhoneNoAByTrackNo.Message");
			queryPhoneNoAByTrackNoResponse.RequestId = _ctx.StringValue("QueryPhoneNoAByTrackNo.RequestId");

			List<QueryPhoneNoAByTrackNoResponse.QueryPhoneNoAByTrackNo_PhoneNoAInfo> queryPhoneNoAByTrackNoResponse_module = new List<QueryPhoneNoAByTrackNoResponse.QueryPhoneNoAByTrackNo_PhoneNoAInfo>();
			for (int i = 0; i < _ctx.Length("QueryPhoneNoAByTrackNo.Module.Length"); i++) {
				QueryPhoneNoAByTrackNoResponse.QueryPhoneNoAByTrackNo_PhoneNoAInfo phoneNoAInfo = new QueryPhoneNoAByTrackNoResponse.QueryPhoneNoAByTrackNo_PhoneNoAInfo();
				phoneNoAInfo.Extension = _ctx.StringValue("QueryPhoneNoAByTrackNo.Module["+ i +"].Extension");
				phoneNoAInfo.PhoneNoX = _ctx.StringValue("QueryPhoneNoAByTrackNo.Module["+ i +"].PhoneNoX");
				phoneNoAInfo.PhoneNoA = _ctx.StringValue("QueryPhoneNoAByTrackNo.Module["+ i +"].PhoneNoA");

				queryPhoneNoAByTrackNoResponse_module.Add(phoneNoAInfo);
			}
			queryPhoneNoAByTrackNoResponse.Module = queryPhoneNoAByTrackNoResponse_module;
        
			return queryPhoneNoAByTrackNoResponse;
        }
    }
}
