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
using Aliyun.Acs.Live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Live.Transform.V20161101
{
    public class CreateLiveStreamRecordIndexFilesResponseUnmarshaller
    {
        public static CreateLiveStreamRecordIndexFilesResponse Unmarshall(UnmarshallerContext context)
        {
			CreateLiveStreamRecordIndexFilesResponse createLiveStreamRecordIndexFilesResponse = new CreateLiveStreamRecordIndexFilesResponse();

			createLiveStreamRecordIndexFilesResponse.HttpResponse = context.HttpResponse;
			createLiveStreamRecordIndexFilesResponse.RequestId = context.StringValue("CreateLiveStreamRecordIndexFiles.RequestId");

			CreateLiveStreamRecordIndexFilesResponse.RecordInfo_ recordInfo = new CreateLiveStreamRecordIndexFilesResponse.RecordInfo_();
			recordInfo.RecordId = context.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.RecordId");
			recordInfo.RecordUrl = context.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.RecordUrl");
			recordInfo.DomainName = context.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.DomainName");
			recordInfo.AppName = context.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.AppName");
			recordInfo.StreamName = context.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.StreamName");
			recordInfo.OssBucket = context.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.OssBucket");
			recordInfo.OssEndpoint = context.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.OssEndpoint");
			recordInfo.OssObject = context.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.OssObject");
			recordInfo.StartTime = context.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.StartTime");
			recordInfo.EndTime = context.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.EndTime");
			recordInfo.Duration = context.FloatValue("CreateLiveStreamRecordIndexFiles.RecordInfo.Duration");
			recordInfo.Height = context.IntegerValue("CreateLiveStreamRecordIndexFiles.RecordInfo.Height");
			recordInfo.Width = context.IntegerValue("CreateLiveStreamRecordIndexFiles.RecordInfo.Width");
			recordInfo.CreateTime = context.StringValue("CreateLiveStreamRecordIndexFiles.RecordInfo.CreateTime");
			createLiveStreamRecordIndexFilesResponse.RecordInfo = recordInfo;
        
			return createLiveStreamRecordIndexFilesResponse;
        }
    }
}