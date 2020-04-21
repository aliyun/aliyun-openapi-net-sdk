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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class ScanCodeNotificationResponseUnmarshaller
    {
        public static ScanCodeNotificationResponse Unmarshall(UnmarshallerContext context)
        {
			ScanCodeNotificationResponse scanCodeNotificationResponse = new ScanCodeNotificationResponse();

			scanCodeNotificationResponse.HttpResponse = context.HttpResponse;
			scanCodeNotificationResponse.Status = context.BooleanValue("ScanCodeNotification.Status");
			scanCodeNotificationResponse.Msg = context.StringValue("ScanCodeNotification.Msg");
			scanCodeNotificationResponse.ErrorCode = context.StringValue("ScanCodeNotification.ErrorCode");
			scanCodeNotificationResponse.RequestId = context.StringValue("ScanCodeNotification.RequestId");
        
			return scanCodeNotificationResponse;
        }
    }
}
