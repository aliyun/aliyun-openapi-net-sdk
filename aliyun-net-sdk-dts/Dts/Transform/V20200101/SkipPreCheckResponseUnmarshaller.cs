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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class SkipPreCheckResponseUnmarshaller
    {
        public static SkipPreCheckResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SkipPreCheckResponse skipPreCheckResponse = new SkipPreCheckResponse();

			skipPreCheckResponse.HttpResponse = _ctx.HttpResponse;
			skipPreCheckResponse.Code = _ctx.StringValue("SkipPreCheck.Code");
			skipPreCheckResponse.DynamicMessage = _ctx.StringValue("SkipPreCheck.DynamicMessage");
			skipPreCheckResponse.ErrCode = _ctx.StringValue("SkipPreCheck.ErrCode");
			skipPreCheckResponse.ErrMessage = _ctx.StringValue("SkipPreCheck.ErrMessage");
			skipPreCheckResponse.HttpStatusCode = _ctx.IntegerValue("SkipPreCheck.HttpStatusCode");
			skipPreCheckResponse.RequestId = _ctx.StringValue("SkipPreCheck.RequestId");
			skipPreCheckResponse.Success = _ctx.BooleanValue("SkipPreCheck.Success");
			skipPreCheckResponse.MigrationJobId = _ctx.StringValue("SkipPreCheck.MigrationJobId");
			skipPreCheckResponse.ScheduleJobId = _ctx.StringValue("SkipPreCheck.ScheduleJobId");
			skipPreCheckResponse.SkipItems = _ctx.StringValue("SkipPreCheck.SkipItems");
			skipPreCheckResponse.SkipNames = _ctx.StringValue("SkipPreCheck.SkipNames");
        
			return skipPreCheckResponse;
        }
    }
}
