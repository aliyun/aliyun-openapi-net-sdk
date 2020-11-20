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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class CreateLiveStreamRecordIndexFilesResponseUnmarshaller
    {
        public static CreateLiveStreamRecordIndexFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateLiveStreamRecordIndexFilesResponse createLiveStreamRecordIndexFilesResponse = new CreateLiveStreamRecordIndexFilesResponse();

			createLiveStreamRecordIndexFilesResponse.HttpResponse = _ctx.HttpResponse;
			createLiveStreamRecordIndexFilesResponse.RequestId = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RequestId");

			CreateLiveStreamRecordIndexFilesResponse.CreateLiveStreamRecordIndexFiles_RecordInfo recordInfo = new CreateLiveStreamRecordIndexFilesResponse.CreateLiveStreamRecordIndexFiles_RecordInfo();
			recordInfo.RecordId = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.RecordId");
			recordInfo.RecordUrl = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.RecordUrl");
			recordInfo.Duration = _ctx.FloatValue("CreateLiveStreamRecordIndexFiles.RecordInfo.Duration");
			recordInfo.Height = _ctx.IntegerValue("CreateLiveStreamRecordIndexFiles.RecordInfo.Height");
			recordInfo.Width = _ctx.IntegerValue("CreateLiveStreamRecordIndexFiles.RecordInfo.Width");
			recordInfo.CreateTime = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.CreateTime");
			createLiveStreamRecordIndexFilesResponse.RecordInfo = recordInfo;
        
			return createLiveStreamRecordIndexFilesResponse;
        }
    }
}
