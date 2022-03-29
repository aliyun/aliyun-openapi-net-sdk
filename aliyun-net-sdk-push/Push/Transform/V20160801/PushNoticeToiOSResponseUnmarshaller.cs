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
using Aliyun.Acs.Push.Model.V20160801;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class PushNoticeToiOSResponseUnmarshaller
    {
        public static PushNoticeToiOSResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PushNoticeToiOSResponse pushNoticeToiOSResponse = new PushNoticeToiOSResponse();

			pushNoticeToiOSResponse.HttpResponse = _ctx.HttpResponse;
			pushNoticeToiOSResponse.MessageId = _ctx.StringValue("PushNoticeToiOS.MessageId");
			pushNoticeToiOSResponse.RequestId = _ctx.StringValue("PushNoticeToiOS.RequestId");
        
			return pushNoticeToiOSResponse;
        }
    }
}
