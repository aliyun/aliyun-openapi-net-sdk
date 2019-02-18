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
    public class OnsInstanceCreateResponseUnmarshaller
    {
        public static OnsInstanceCreateResponse Unmarshall(UnmarshallerContext context)
        {
			OnsInstanceCreateResponse onsInstanceCreateResponse = new OnsInstanceCreateResponse();

			onsInstanceCreateResponse.HttpResponse = context.HttpResponse;
			onsInstanceCreateResponse.RequestId = context.StringValue("OnsInstanceCreate.RequestId");
			onsInstanceCreateResponse.HelpUrl = context.StringValue("OnsInstanceCreate.HelpUrl");

			OnsInstanceCreateResponse.OnsInstanceCreate_Data data = new OnsInstanceCreateResponse.OnsInstanceCreate_Data();
			data.InstanceId = context.StringValue("OnsInstanceCreate.Data.InstanceId");
			data.InstanceType = context.IntegerValue("OnsInstanceCreate.Data.InstanceType");
			onsInstanceCreateResponse.Data = data;
        
			return onsInstanceCreateResponse;
        }
    }
}