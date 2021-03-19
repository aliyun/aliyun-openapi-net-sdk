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
using Aliyun.Acs.Ons.Model.V20190214;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsMessageTraceResponseUnmarshaller
    {
        public static OnsMessageTraceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsMessageTraceResponse onsMessageTraceResponse = new OnsMessageTraceResponse();

			onsMessageTraceResponse.HttpResponse = _ctx.HttpResponse;
			onsMessageTraceResponse.RequestId = _ctx.StringValue("OnsMessageTrace.RequestId");
			onsMessageTraceResponse.HelpUrl = _ctx.StringValue("OnsMessageTrace.HelpUrl");

			List<OnsMessageTraceResponse.OnsMessageTrace_MessageTrack> onsMessageTraceResponse_data = new List<OnsMessageTraceResponse.OnsMessageTrace_MessageTrack>();
			for (int i = 0; i < _ctx.Length("OnsMessageTrace.Data.Length"); i++) {
				OnsMessageTraceResponse.OnsMessageTrace_MessageTrack messageTrack = new OnsMessageTraceResponse.OnsMessageTrace_MessageTrack();
				messageTrack.ConsumerGroup = _ctx.StringValue("OnsMessageTrace.Data["+ i +"].ConsumerGroup");
				messageTrack.TrackType = _ctx.StringValue("OnsMessageTrace.Data["+ i +"].TrackType");
				messageTrack.ExceptionDesc = _ctx.StringValue("OnsMessageTrace.Data["+ i +"].ExceptionDesc");
				messageTrack.InstanceId = _ctx.StringValue("OnsMessageTrace.Data["+ i +"].InstanceId");

				onsMessageTraceResponse_data.Add(messageTrack);
			}
			onsMessageTraceResponse.Data = onsMessageTraceResponse_data;
        
			return onsMessageTraceResponse;
        }
    }
}
