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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class SubmitSparkAppResponseUnmarshaller
    {
        public static SubmitSparkAppResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitSparkAppResponse submitSparkAppResponse = new SubmitSparkAppResponse();

			submitSparkAppResponse.HttpResponse = _ctx.HttpResponse;
			submitSparkAppResponse.RequestId = _ctx.StringValue("SubmitSparkApp.RequestId");

			SubmitSparkAppResponse.SubmitSparkApp_Data data = new SubmitSparkAppResponse.SubmitSparkApp_Data();
			data.AppId = _ctx.StringValue("SubmitSparkApp.Data.AppId");
			data.AppName = _ctx.StringValue("SubmitSparkApp.Data.AppName");
			data.Message = _ctx.StringValue("SubmitSparkApp.Data.Message");
			data.State = _ctx.StringValue("SubmitSparkApp.Data.State");
			submitSparkAppResponse.Data = data;
        
			return submitSparkAppResponse;
        }
    }
}
