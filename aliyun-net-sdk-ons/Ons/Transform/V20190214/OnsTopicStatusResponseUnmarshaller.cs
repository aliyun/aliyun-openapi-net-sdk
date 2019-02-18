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
    public class OnsTopicStatusResponseUnmarshaller
    {
        public static OnsTopicStatusResponse Unmarshall(UnmarshallerContext context)
        {
			OnsTopicStatusResponse onsTopicStatusResponse = new OnsTopicStatusResponse();

			onsTopicStatusResponse.HttpResponse = context.HttpResponse;
			onsTopicStatusResponse.RequestId = context.StringValue("OnsTopicStatus.RequestId");
			onsTopicStatusResponse.HelpUrl = context.StringValue("OnsTopicStatus.HelpUrl");

			OnsTopicStatusResponse.OnsTopicStatus_Data data = new OnsTopicStatusResponse.OnsTopicStatus_Data();
			data.TotalCount = context.LongValue("OnsTopicStatus.Data.TotalCount");
			data.LastTimeStamp = context.LongValue("OnsTopicStatus.Data.LastTimeStamp");
			onsTopicStatusResponse.Data = data;
        
			return onsTopicStatusResponse;
        }
    }
}