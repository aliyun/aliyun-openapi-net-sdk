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
        public static GetURLUploadInfosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetURLUploadInfosResponse getURLUploadInfosResponse = new GetURLUploadInfosResponse();

			getURLUploadInfosResponse.HttpResponse = _ctx.HttpResponse;
			getURLUploadInfosResponse.RequestId = _ctx.StringValue("GetURLUploadInfos.RequestId");

			List<string> getURLUploadInfosResponse_nonExists = new List<string>();
			for (int i = 0; i < _ctx.Length("GetURLUploadInfos.NonExists.Length"); i++) {
				getURLUploadInfosResponse_nonExists.Add(_ctx.StringValue("GetURLUploadInfos.NonExists["+ i +"]"));
			}
			getURLUploadInfosResponse.NonExists = getURLUploadInfosResponse_nonExists;

			List<GetURLUploadInfosResponse.GetURLUploadInfos_UrlUploadJobInfoDTO> getURLUploadInfosResponse_uRLUploadInfoList = new List<GetURLUploadInfosResponse.GetURLUploadInfos_UrlUploadJobInfoDTO>();
			for (int i = 0; i < _ctx.Length("GetURLUploadInfos.URLUploadInfoList.Length"); i++) {
				GetURLUploadInfosResponse.GetURLUploadInfos_UrlUploadJobInfoDTO urlUploadJobInfoDTO = new GetURLUploadInfosResponse.GetURLUploadInfos_UrlUploadJobInfoDTO();
				urlUploadJobInfoDTO.JobId = _ctx.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].JobId");
				urlUploadJobInfoDTO.UploadURL = _ctx.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].UploadURL");
				urlUploadJobInfoDTO.MediaId = _ctx.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].MediaId");
				urlUploadJobInfoDTO.FileSize = _ctx.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].FileSize");
				urlUploadJobInfoDTO.Status = _ctx.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].Status");
				urlUploadJobInfoDTO.UserData = _ctx.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].UserData");
				urlUploadJobInfoDTO.ErrorCode = _ctx.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].ErrorCode");
				urlUploadJobInfoDTO.ErrorMessage = _ctx.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].ErrorMessage");
				urlUploadJobInfoDTO.CreationTime = _ctx.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].CreationTime");
				urlUploadJobInfoDTO.CompleteTime = _ctx.StringValue("GetURLUploadInfos.URLUploadInfoList["+ i +"].CompleteTime");

				getURLUploadInfosResponse_uRLUploadInfoList.Add(urlUploadJobInfoDTO);
			}
			getURLUploadInfosResponse.URLUploadInfoList = getURLUploadInfosResponse_uRLUploadInfoList;
        
			return getURLUploadInfosResponse;
        }
    }
}
