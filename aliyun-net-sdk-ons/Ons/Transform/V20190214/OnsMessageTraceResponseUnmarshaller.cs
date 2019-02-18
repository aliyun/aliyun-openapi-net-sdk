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
using Aliyun.Acs.Ons.Model.V20190214;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsMessageTraceResponseUnmarshaller
    {
        public static OnsMessageTraceResponse Unmarshall(UnmarshallerContext context)
        {
			OnsMessageTraceResponse onsMessageTraceResponse = new OnsMessageTraceResponse();

			onsMessageTraceResponse.HttpResponse = context.HttpResponse;
			onsMessageTraceResponse.RequestId = context.StringValue("OnsMessageTrace.RequestId");
			onsMessageTraceResponse.HelpUrl = context.StringValue("OnsMessageTrace.HelpUrl");

			List<OnsMessageTraceResponse.OnsMessageTrace_MessageTrack> onsMessageTraceResponse_data = new List<OnsMessageTraceResponse.OnsMessageTrace_MessageTrack>();
			for (int i = 0; i < context.Length("OnsMessageTrace.Data.Length"); i++) {
				OnsMessageTraceResponse.OnsMessageTrace_MessageTrack messageTrack = new OnsMessageTraceResponse.OnsMessageTrace_MessageTrack();
				messageTrack.ConsumerGroup = context.StringValue("OnsMessageTrace.Data["+ i +"].ConsumerGroup");
				messageTrack.TrackType = context.StringValue("OnsMessageTrace.Data["+ i +"].TrackType");
				messageTrack.ExceptionDesc = context.StringValue("OnsMessageTrace.Data["+ i +"].ExceptionDesc");
				messageTrack.InstanceId = context.StringValue("OnsMessageTrace.Data["+ i +"].InstanceId");

				onsMessageTraceResponse_data.Add(messageTrack);
			}
			onsMessageTraceResponse.Data = onsMessageTraceResponse_data;
        
			return onsMessageTraceResponse;
        }
    }
}