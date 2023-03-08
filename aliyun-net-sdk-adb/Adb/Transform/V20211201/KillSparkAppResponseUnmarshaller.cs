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
    public class KillSparkAppResponseUnmarshaller
    {
        public static KillSparkAppResponse Unmarshall(UnmarshallerContext _ctx)
        {
			KillSparkAppResponse killSparkAppResponse = new KillSparkAppResponse();

			killSparkAppResponse.HttpResponse = _ctx.HttpResponse;
			killSparkAppResponse.RequestId = _ctx.StringValue("KillSparkApp.RequestId");

			KillSparkAppResponse.KillSparkApp_Data data = new KillSparkAppResponse.KillSparkApp_Data();
			data.AppId = _ctx.StringValue("KillSparkApp.Data.AppId");
			data.AppName = _ctx.StringValue("KillSparkApp.Data.AppName");
			data.Message = _ctx.StringValue("KillSparkApp.Data.Message");
			data.State = _ctx.StringValue("KillSparkApp.Data.State");
			data.DBClusterId = _ctx.StringValue("KillSparkApp.Data.DBClusterId");
			killSparkAppResponse.Data = data;
        
			return killSparkAppResponse;
        }
    }
}
