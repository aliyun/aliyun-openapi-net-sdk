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
    public class OnsConsumerTimeSpanResponseUnmarshaller
    {
        public static OnsConsumerTimeSpanResponse Unmarshall(UnmarshallerContext context)
        {
			OnsConsumerTimeSpanResponse onsConsumerTimeSpanResponse = new OnsConsumerTimeSpanResponse();

			onsConsumerTimeSpanResponse.HttpResponse = context.HttpResponse;
			onsConsumerTimeSpanResponse.RequestId = context.StringValue("OnsConsumerTimeSpan.RequestId");
			onsConsumerTimeSpanResponse.HelpUrl = context.StringValue("OnsConsumerTimeSpan.HelpUrl");

			OnsConsumerTimeSpanResponse.OnsConsumerTimeSpan_Data data = new OnsConsumerTimeSpanResponse.OnsConsumerTimeSpan_Data();
			data.Topic = context.StringValue("OnsConsumerTimeSpan.Data.Topic");
			data.MinTimeStamp = context.LongValue("OnsConsumerTimeSpan.Data.MinTimeStamp");
			data.MaxTimeStamp = context.LongValue("OnsConsumerTimeSpan.Data.MaxTimeStamp");
			data.ConsumeTimeStamp = context.LongValue("OnsConsumerTimeSpan.Data.ConsumeTimeStamp");
			data.InstanceId = context.StringValue("OnsConsumerTimeSpan.Data.InstanceId");
			onsConsumerTimeSpanResponse.Data = data;
        
			return onsConsumerTimeSpanResponse;
        }
    }
}