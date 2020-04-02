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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class ReleaseMovieSeatResponseUnmarshaller
    {
        public static ReleaseMovieSeatResponse Unmarshall(UnmarshallerContext context)
        {
			ReleaseMovieSeatResponse releaseMovieSeatResponse = new ReleaseMovieSeatResponse();

			releaseMovieSeatResponse.HttpResponse = context.HttpResponse;
			releaseMovieSeatResponse.RequestId = context.StringValue("ReleaseMovieSeat.RequestId");
			releaseMovieSeatResponse.Code = context.StringValue("ReleaseMovieSeat.Code");
			releaseMovieSeatResponse.Message = context.StringValue("ReleaseMovieSeat.Message");
			releaseMovieSeatResponse.SubCode = context.StringValue("ReleaseMovieSeat.SubCode");
			releaseMovieSeatResponse.SubMessage = context.StringValue("ReleaseMovieSeat.SubMessage");
			releaseMovieSeatResponse.LogsId = context.StringValue("ReleaseMovieSeat.LogsId");
			releaseMovieSeatResponse.Success = context.BooleanValue("ReleaseMovieSeat.Success");

			ReleaseMovieSeatResponse.ReleaseMovieSeat_ActionResult actionResult = new ReleaseMovieSeatResponse.ReleaseMovieSeat_ActionResult();
			actionResult.ReturnCode = context.StringValue("ReleaseMovieSeat.ActionResult.ReturnCode");
			actionResult.ReturnValue = context.StringValue("ReleaseMovieSeat.ActionResult.ReturnValue");
			actionResult.ReturnMessage = context.StringValue("ReleaseMovieSeat.ActionResult.ReturnMessage");
			releaseMovieSeatResponse.ActionResult = actionResult;
        
			return releaseMovieSeatResponse;
        }
    }
}
