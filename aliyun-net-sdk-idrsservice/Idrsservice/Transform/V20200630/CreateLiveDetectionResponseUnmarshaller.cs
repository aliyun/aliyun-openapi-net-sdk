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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class CreateLiveDetectionResponseUnmarshaller
    {
        public static CreateLiveDetectionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateLiveDetectionResponse createLiveDetectionResponse = new CreateLiveDetectionResponse();

			createLiveDetectionResponse.HttpResponse = _ctx.HttpResponse;
			createLiveDetectionResponse.Code = _ctx.StringValue("CreateLiveDetection.Code");
			createLiveDetectionResponse.Message = _ctx.StringValue("CreateLiveDetection.Message");
			createLiveDetectionResponse.RequestId = _ctx.StringValue("CreateLiveDetection.RequestId");

			CreateLiveDetectionResponse.CreateLiveDetection_Data data = new CreateLiveDetectionResponse.CreateLiveDetection_Data();
			data.Id = _ctx.StringValue("CreateLiveDetection.Data.Id");
			createLiveDetectionResponse.Data = data;
        
			return createLiveDetectionResponse;
        }
    }
}
