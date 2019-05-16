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
        public static GetUploadDetailsResponse Unmarshall(UnmarshallerContext context)
        {
			GetUploadDetailsResponse getUploadDetailsResponse = new GetUploadDetailsResponse();

			getUploadDetailsResponse.HttpResponse = context.HttpResponse;
			getUploadDetailsResponse.RequestId = context.StringValue("GetUploadDetails.RequestId");

			List<string> getUploadDetailsResponse_nonExistMediaIds = new List<string>();
			for (int i = 0; i < context.Length("GetUploadDetails.NonExistMediaIds.Length"); i++) {
				getUploadDetailsResponse_nonExistMediaIds.Add(context.StringValue("GetUploadDetails.NonExistMediaIds["+ i +"]"));
			}
			getUploadDetailsResponse.NonExistMediaIds = getUploadDetailsResponse_nonExistMediaIds;

			List<string> getUploadDetailsResponse_forbiddenMediaIds = new List<string>();
			for (int i = 0; i < context.Length("GetUploadDetails.ForbiddenMediaIds.Length"); i++) {
				getUploadDetailsResponse_forbiddenMediaIds.Add(context.StringValue("GetUploadDetails.ForbiddenMediaIds["+ i +"]"));
			}
			getUploadDetailsResponse.ForbiddenMediaIds = getUploadDetailsResponse_forbiddenMediaIds;

			List<GetUploadDetailsResponse.GetUploadDetails_UploadDetail> getUploadDetailsResponse_uploadDetails = new List<GetUploadDetailsResponse.GetUploadDetails_UploadDetail>();
			for (int i = 0; i < context.Length("GetUploadDetails.UploadDetails.Length"); i++) {
				GetUploadDetailsResponse.GetUploadDetails_UploadDetail uploadDetail = new GetUploadDetailsResponse.GetUploadDetails_UploadDetail();
				uploadDetail.MediaId = context.StringValue("GetUploadDetails.UploadDetails["+ i +"].MediaId");
				uploadDetail.Title = context.StringValue("GetUploadDetails.UploadDetails["+ i +"].Title");
				uploadDetail.FileSize = context.LongValue("GetUploadDetails.UploadDetails["+ i +"].FileSize");
				uploadDetail.Status = context.StringValue("GetUploadDetails.UploadDetails["+ i +"].Status");
				uploadDetail.UploadStatus = context.StringValue("GetUploadDetails.UploadDetails["+ i +"].UploadStatus");
				uploadDetail.CreationTime = context.StringValue("GetUploadDetails.UploadDetails["+ i +"].CreationTime");
				uploadDetail.ModificationTime = context.StringValue("GetUploadDetails.UploadDetails["+ i +"].ModificationTime");
				uploadDetail.CompletionTime = context.StringValue("GetUploadDetails.UploadDetails["+ i +"].CompletionTime");
				uploadDetail.UploadSize = context.LongValue("GetUploadDetails.UploadDetails["+ i +"].UploadSize");
				uploadDetail.UploadRatio = context.FloatValue("GetUploadDetails.UploadDetails["+ i +"].UploadRatio");
				uploadDetail.UploadIP = context.StringValue("GetUploadDetails.UploadDetails["+ i +"].UploadIP");
				uploadDetail.UploadSource = context.StringValue("GetUploadDetails.UploadDetails["+ i +"].UploadSource");
				uploadDetail.DeviceModel = context.StringValue("GetUploadDetails.UploadDetails["+ i +"].DeviceModel");

				getUploadDetailsResponse_uploadDetails.Add(uploadDetail);
			}
			getUploadDetailsResponse.UploadDetails = getUploadDetailsResponse_uploadDetails;
        
			return getUploadDetailsResponse;
        }
    }
}
