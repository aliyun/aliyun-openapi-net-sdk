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
    public class GetURLUploadInfosResponseUnmarshaller
    {
        public static GetURLUploadInfosResponse Unmarshall(UnmarshallerContext context)
        {
			GetURLUploadInfosResponse getURLUploadInfosResponse = new GetURLUploadInfosResponse();

			getURLUploadInfosResponse.HttpResponse = context.HttpResponse;
			getURLUploadInfosResponse.RequestId = context.StringValue("GetURLUploadInfos.RequestId");

			List<string> getURLUploadInfosResponse_nonExists = new List<string>();
			for (int i = 0; i < context.Length("GetURLUploadInfos.NonExists.Length"); i++) {
				getURLUploadInfosResponse_nonExists.Add(context.StringValue("GetURLUploadInfos.NonExists["+ i +"]"));
			}
			getURLUploadInfosResponse.NonExists = getURLUploadInfosResponse_nonExists;

			List<GetURLUploadInfosResponse.GetURLUploadInfos_UrlUploadJobInfoDTO> getURLUploadInfosResponse_uRLUploadInfoList = new List<GetURLUploadInfosResponse.GetURLUploadInfos_UrlUploadJobInfoDTO>();
			for (int i = 0; i < context.Length("GetURLUploadInfos.URLUploadInfoList.Length"); i++) {
				GetURLUploadInfosResponse.GetURLUploadInfos_UrlUploadJobInfoDTO urlUploadJobInfoDTO = new GetURLUploadInfosResponse.GetURLUploadInfos_UrlUploadJobInfoDTO();
				urlUploadJobInfoDTO.JobId = context.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].JobId");
				urlUploadJobInfoDTO.UploadURL = context.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].UploadURL");
				urlUploadJobInfoDTO.MediaId = context.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].MediaId");
				urlUploadJobInfoDTO.FileSize = context.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].FileSize");
				urlUploadJobInfoDTO.Status = context.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].Status");
				urlUploadJobInfoDTO.UserData = context.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].UserData");
				urlUploadJobInfoDTO.ErrorCode = context.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].ErrorCode");
				urlUploadJobInfoDTO.ErrorMessage = context.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].ErrorMessage");
				urlUploadJobInfoDTO.CreationTime = context.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].CreationTime");
				urlUploadJobInfoDTO.CompleteTime = context.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].CompleteTime");

				getURLUploadInfosResponse_uRLUploadInfoList.Add(urlUploadJobInfoDTO);
			}
			getURLUploadInfosResponse.URLUploadInfoList = getURLUploadInfosResponse_uRLUploadInfoList;
        
			return getURLUploadInfosResponse;
        }
    }
}
