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
    public class DeleteLiveStreamRecordIndexFilesResponseUnmarshaller
    {
        public static DeleteLiveStreamRecordIndexFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteLiveStreamRecordIndexFilesResponse deleteLiveStreamRecordIndexFilesResponse = new DeleteLiveStreamRecordIndexFilesResponse();

			deleteLiveStreamRecordIndexFilesResponse.HttpResponse = _ctx.HttpResponse;
			deleteLiveStreamRecordIndexFilesResponse.RequestId = _ctx.StringValue("DeleteLiveStreamRecordIndexFiles.RequestId");
			deleteLiveStreamRecordIndexFilesResponse.Message = _ctx.StringValue("DeleteLiveStreamRecordIndexFiles.Message");
			deleteLiveStreamRecordIndexFilesResponse.Code = _ctx.StringValue("DeleteLiveStreamRecordIndexFiles.Code");

			List<DeleteLiveStreamRecordIndexFilesResponse.DeleteLiveStreamRecordIndexFiles_RecordDeleteInfo> deleteLiveStreamRecordIndexFilesResponse_recordDeleteInfoList = new List<DeleteLiveStreamRecordIndexFilesResponse.DeleteLiveStreamRecordIndexFiles_RecordDeleteInfo>();
			for (int i = 0; i < _ctx.Length("DeleteLiveStreamRecordIndexFiles.RecordDeleteInfoList.Length"); i++) {
				DeleteLiveStreamRecordIndexFilesResponse.DeleteLiveStreamRecordIndexFiles_RecordDeleteInfo recordDeleteInfo = new DeleteLiveStreamRecordIndexFilesResponse.DeleteLiveStreamRecordIndexFiles_RecordDeleteInfo();
				recordDeleteInfo.RecordId = _ctx.StringValue("DeleteLiveStreamRecordIndexFiles.RecordDeleteInfoList["+ i +"].RecordId");
				recordDeleteInfo.Message = _ctx.StringValue("DeleteLiveStreamRecordIndexFiles.RecordDeleteInfoList["+ i +"].Message");

				deleteLiveStreamRecordIndexFilesResponse_recordDeleteInfoList.Add(recordDeleteInfo);
			}
			deleteLiveStreamRecordIndexFilesResponse.RecordDeleteInfoList = deleteLiveStreamRecordIndexFilesResponse_recordDeleteInfoList;
        
			return deleteLiveStreamRecordIndexFilesResponse;
        }
    }
}
