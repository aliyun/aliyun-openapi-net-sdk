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
    public class GetSparkConfigLogPathResponseUnmarshaller
    {
        public static GetSparkConfigLogPathResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSparkConfigLogPathResponse getSparkConfigLogPathResponse = new GetSparkConfigLogPathResponse();

			getSparkConfigLogPathResponse.HttpResponse = _ctx.HttpResponse;
			getSparkConfigLogPathResponse.RequestId = _ctx.StringValue("GetSparkConfigLogPath.RequestId");

			GetSparkConfigLogPathResponse.GetSparkConfigLogPath_Data data = new GetSparkConfigLogPathResponse.GetSparkConfigLogPath_Data();
			data.IsLogPathExists = _ctx.BooleanValue("GetSparkConfigLogPath.Data.IsLogPathExists");
			data.RecordedLogPath = _ctx.StringValue("GetSparkConfigLogPath.Data.RecordedLogPath");
			data.ModifiedUid = _ctx.StringValue("GetSparkConfigLogPath.Data.ModifiedUid");
			data.ModifiedTimestamp = _ctx.StringValue("GetSparkConfigLogPath.Data.ModifiedTimestamp");
			data.DefaultLogPath = _ctx.StringValue("GetSparkConfigLogPath.Data.DefaultLogPath");
			getSparkConfigLogPathResponse.Data = data;
        
			return getSparkConfigLogPathResponse;
        }
    }
}
