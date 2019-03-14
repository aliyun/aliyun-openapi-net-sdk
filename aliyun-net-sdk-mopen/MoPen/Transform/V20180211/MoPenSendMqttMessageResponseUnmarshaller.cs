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
using Aliyun.Acs.MoPen.Model.V20180211;

namespace Aliyun.Acs.MoPen.Transform.V20180211
{
    public class MoPenSendMqttMessageResponseUnmarshaller
    {
        public static MoPenSendMqttMessageResponse Unmarshall(UnmarshallerContext context)
        {
			MoPenSendMqttMessageResponse moPenSendMqttMessageResponse = new MoPenSendMqttMessageResponse();

			moPenSendMqttMessageResponse.HttpResponse = context.HttpResponse;
			moPenSendMqttMessageResponse.RequestId = context.StringValue("MoPenSendMqttMessage.RequestId");
			moPenSendMqttMessageResponse.Code = context.StringValue("MoPenSendMqttMessage.Code");
			moPenSendMqttMessageResponse.Message = context.StringValue("MoPenSendMqttMessage.Message");
			moPenSendMqttMessageResponse.Success = context.BooleanValue("MoPenSendMqttMessage.Success");
			moPenSendMqttMessageResponse.Description = context.StringValue("MoPenSendMqttMessage.Description");
        
			return moPenSendMqttMessageResponse;
        }
    }
}
