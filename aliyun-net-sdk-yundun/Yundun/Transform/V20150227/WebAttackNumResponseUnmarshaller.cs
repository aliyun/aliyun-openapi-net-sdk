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
using Aliyun.Acs.Yundun.Model.V20150227;

namespace Aliyun.Acs.Yundun.Transform.V20150227
{
    public class WebAttackNumResponseUnmarshaller
    {
        public static WebAttackNumResponse Unmarshall(UnmarshallerContext context)
        {
			WebAttackNumResponse webAttackNumResponse = new WebAttackNumResponse();

			webAttackNumResponse.HttpResponse = context.HttpResponse;
			webAttackNumResponse.RequestId = context.StringValue("WebAttackNum.RequestId");
			webAttackNumResponse.WebAttackNum = context.LongValue("WebAttackNum.WebAttackNum");
        
			return webAttackNumResponse;
        }
    }
}
