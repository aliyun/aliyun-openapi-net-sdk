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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeFCTriggerResponseUnmarshaller
    {
        public static DescribeFCTriggerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFCTriggerResponse describeFCTriggerResponse = new DescribeFCTriggerResponse();

			describeFCTriggerResponse.HttpResponse = _ctx.HttpResponse;
			describeFCTriggerResponse.RequestId = _ctx.StringValue("DescribeFCTrigger.RequestId");

			DescribeFCTriggerResponse.DescribeFCTrigger_FCTrigger fCTrigger = new DescribeFCTriggerResponse.DescribeFCTrigger_FCTrigger();
			fCTrigger.EventMetaName = _ctx.StringValue("DescribeFCTrigger.FCTrigger.EventMetaName");
			fCTrigger.EventMetaVersion = _ctx.StringValue("DescribeFCTrigger.FCTrigger.EventMetaVersion");
			fCTrigger.TriggerARN = _ctx.StringValue("DescribeFCTrigger.FCTrigger.TriggerARN");
			fCTrigger.RoleARN = _ctx.StringValue("DescribeFCTrigger.FCTrigger.RoleARN");
			fCTrigger.SourceArn = _ctx.StringValue("DescribeFCTrigger.FCTrigger.SourceArn");
			fCTrigger.Notes = _ctx.StringValue("DescribeFCTrigger.FCTrigger.Notes");
			describeFCTriggerResponse.FCTrigger = fCTrigger;
        
			return describeFCTriggerResponse;
        }
    }
}
