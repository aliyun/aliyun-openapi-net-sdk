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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class CreateLiveStreamRecordIndexFilesResponseUnmarshaller
    {
        public static CreateLiveStreamRecordIndexFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateLiveStreamRecordIndexFilesResponse createLiveStreamRecordIndexFilesResponse = new CreateLiveStreamRecordIndexFilesResponse();

			createLiveStreamRecordIndexFilesResponse.HttpResponse = _ctx.HttpResponse;
			createLiveStreamRecordIndexFilesResponse.RequestId = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RequestId");

			CreateLiveStreamRecordIndexFilesResponse.CreateLiveStreamRecordIndexFiles_RecordInfo recordInfo = new CreateLiveStreamRecordIndexFilesResponse.CreateLiveStreamRecordIndexFiles_RecordInfo();
			recordInfo.RecordUrl = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.RecordUrl");
			recordInfo.StreamName = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.StreamName");
			recordInfo.CreateTime = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.CreateTime");
			recordInfo.RecordId = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.RecordId");
			recordInfo.Height = _ctx.IntegerValue("CreateLiveStreamRecordIndexFiles.RecordInfo.Height");
			recordInfo.OssBucket = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.OssBucket");
			recordInfo.DomainName = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.DomainName");
			recordInfo.OssObject = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.OssObject");
			recordInfo.EndTime = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.EndTime");
			recordInfo.AppName = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.AppName");
			recordInfo.StartTime = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.StartTime");
			recordInfo.Width = _ctx.IntegerValue("CreateLiveStreamRecordIndexFiles.RecordInfo.Width");
			recordInfo.Duration = _ctx.FloatValue("CreateLiveStreamRecordIndexFiles.RecordInfo.Duration");
			recordInfo.OssEndpoint = _ctx.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.OssEndpoint");
			createLiveStreamRecordIndexFilesResponse.RecordInfo = recordInfo;
        
			return createLiveStreamRecordIndexFilesResponse;
        }
    }
}
