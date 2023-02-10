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
using Aliyun.Acs.PTS.Model.V20201020;

namespace Aliyun.Acs.PTS.Transform.V20201020
{
    public class CreatePtsSceneBaseLineFromReportResponseUnmarshaller
    {
        public static CreatePtsSceneBaseLineFromReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreatePtsSceneBaseLineFromReportResponse createPtsSceneBaseLineFromReportResponse = new CreatePtsSceneBaseLineFromReportResponse();

			createPtsSceneBaseLineFromReportResponse.HttpResponse = _ctx.HttpResponse;
			createPtsSceneBaseLineFromReportResponse.Message = _ctx.StringValue("CreatePtsSceneBaseLineFromReport.Message");
			createPtsSceneBaseLineFromReportResponse.RequestId = _ctx.StringValue("CreatePtsSceneBaseLineFromReport.RequestId");
			createPtsSceneBaseLineFromReportResponse.HttpStatusCode = _ctx.IntegerValue("CreatePtsSceneBaseLineFromReport.HttpStatusCode");
			createPtsSceneBaseLineFromReportResponse.Code = _ctx.StringValue("CreatePtsSceneBaseLineFromReport.Code");
			createPtsSceneBaseLineFromReportResponse.Success = _ctx.BooleanValue("CreatePtsSceneBaseLineFromReport.Success");
        
			return createPtsSceneBaseLineFromReportResponse;
        }
    }
}
