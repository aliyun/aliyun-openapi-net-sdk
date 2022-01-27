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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetUploadDetailsResponseUnmarshaller
    {
        public static GetUploadDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUploadDetailsResponse getUploadDetailsResponse = new GetUploadDetailsResponse();

			getUploadDetailsResponse.HttpResponse = _ctx.HttpResponse;
			getUploadDetailsResponse.RequestId = _ctx.StringValue("GetUploadDetails.RequestId");

			List<string> getUploadDetailsResponse_nonExistMediaIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetUploadDetails.NonExistMediaIds.Length"); i++) {
				getUploadDetailsResponse_nonExistMediaIds.Add(_ctx.StringValue("GetUploadDetails.NonExistMediaIds["+ i +"]"));
			}
			getUploadDetailsResponse.NonExistMediaIds = getUploadDetailsResponse_nonExistMediaIds;

			List<string> getUploadDetailsResponse_forbiddenMediaIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetUploadDetails.ForbiddenMediaIds.Length"); i++) {
				getUploadDetailsResponse_forbiddenMediaIds.Add(_ctx.StringValue("GetUploadDetails.ForbiddenMediaIds["+ i +"]"));
			}
			getUploadDetailsResponse.ForbiddenMediaIds = getUploadDetailsResponse_forbiddenMediaIds;

			List<GetUploadDetailsResponse.GetUploadDetails_UploadDetail> getUploadDetailsResponse_uploadDetails = new List<GetUploadDetailsResponse.GetUploadDetails_UploadDetail>();
			for (int i = 0; i < _ctx.Length("GetUploadDetails.UploadDetails.Length"); i++) {
				GetUploadDetailsResponse.GetUploadDetails_UploadDetail uploadDetail = new GetUploadDetailsResponse.GetUploadDetails_UploadDetail();
				uploadDetail.MediaId = _ctx.StringValue("GetUploadDetails.UploadDetails["+ i +"].MediaId");
				uploadDetail.Title = _ctx.StringValue("GetUploadDetails.UploadDetails["+ i +"].Title");
				uploadDetail.FileSize = _ctx.LongValue("GetUploadDetails.UploadDetails["+ i +"].FileSize");
				uploadDetail.Status = _ctx.StringValue("GetUploadDetails.UploadDetails["+ i +"].Status");
				uploadDetail.UploadStatus = _ctx.StringValue("GetUploadDetails.UploadDetails["+ i +"].UploadStatus");
				uploadDetail.CreationTime = _ctx.StringValue("GetUploadDetails.UploadDetails["+ i +"].CreationTime");
				uploadDetail.ModificationTime = _ctx.StringValue("GetUploadDetails.UploadDetails["+ i +"].ModificationTime");
				uploadDetail.CompletionTime = _ctx.StringValue("GetUploadDetails.UploadDetails["+ i +"].CompletionTime");
				uploadDetail.UploadSize = _ctx.LongValue("GetUploadDetails.UploadDetails["+ i +"].UploadSize");
				uploadDetail.UploadRatio = _ctx.FloatValue("GetUploadDetails.UploadDetails["+ i +"].UploadRatio");
				uploadDetail.UploadIP = _ctx.StringValue("GetUploadDetails.UploadDetails["+ i +"].UploadIP");
				uploadDetail.UploadSource = _ctx.StringValue("GetUploadDetails.UploadDetails["+ i +"].UploadSource");
				uploadDetail.DeviceModel = _ctx.StringValue("GetUploadDetails.UploadDetails["+ i +"].DeviceModel");

				getUploadDetailsResponse_uploadDetails.Add(uploadDetail);
			}
			getUploadDetailsResponse.UploadDetails = getUploadDetailsResponse_uploadDetails;
        
			return getUploadDetailsResponse;
        }
    }
}
