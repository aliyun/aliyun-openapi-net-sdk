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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.rtc.Model.V20180111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class CreateConferenceResponseUnmarshaller
    {
        public static CreateConferenceResponse Unmarshall(UnmarshallerContext context)
        {
			CreateConferenceResponse createConferenceResponse = new CreateConferenceResponse();

			createConferenceResponse.HttpResponse = context.HttpResponse;
			createConferenceResponse.RequestId = context.StringValue("CreateConference.RequestId");
			createConferenceResponse.ConferenceId = context.StringValue("CreateConference.ConferenceId");

			CreateConferenceResponse.CreateConference_AuthInfo authInfo = new CreateConferenceResponse.CreateConference_AuthInfo();
			authInfo.Key = context.StringValue("CreateConference.AuthInfo.Key");
			authInfo.Nonce = context.StringValue("CreateConference.AuthInfo.Nonce");
			authInfo.Timestamp = context.IntegerValue("CreateConference.AuthInfo.Timestamp");
			createConferenceResponse.AuthInfo = authInfo;
        
			return createConferenceResponse;
        }
    }
}