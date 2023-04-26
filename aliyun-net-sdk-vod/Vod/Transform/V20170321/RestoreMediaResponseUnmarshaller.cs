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
    public class RestoreMediaResponseUnmarshaller
    {
        public static RestoreMediaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RestoreMediaResponse restoreMediaResponse = new RestoreMediaResponse();

			restoreMediaResponse.HttpResponse = _ctx.HttpResponse;
			restoreMediaResponse.RequestId = _ctx.StringValue("RestoreMedia.RequestId");
			restoreMediaResponse.Success = _ctx.BooleanValue("RestoreMedia.Success");

			List<string> restoreMediaResponse_ignoredList = new List<string>();
			for (int i = 0; i < _ctx.Length("RestoreMedia.IgnoredList.Length"); i++) {
				restoreMediaResponse_ignoredList.Add(_ctx.StringValue("RestoreMedia.IgnoredList["+ i +"]"));
			}
			restoreMediaResponse.IgnoredList = restoreMediaResponse_ignoredList;

			List<RestoreMediaResponse.RestoreMedia_MediaForbiddenReasonDTO> restoreMediaResponse_forbiddenList = new List<RestoreMediaResponse.RestoreMedia_MediaForbiddenReasonDTO>();
			for (int i = 0; i < _ctx.Length("RestoreMedia.ForbiddenList.Length"); i++) {
				RestoreMediaResponse.RestoreMedia_MediaForbiddenReasonDTO mediaForbiddenReasonDTO = new RestoreMediaResponse.RestoreMedia_MediaForbiddenReasonDTO();
				mediaForbiddenReasonDTO.MediaId = _ctx.StringValue("RestoreMedia.ForbiddenList["+ i +"].MediaId");
				mediaForbiddenReasonDTO.Reason = _ctx.StringValue("RestoreMedia.ForbiddenList["+ i +"].Reason");

				restoreMediaResponse_forbiddenList.Add(mediaForbiddenReasonDTO);
			}
			restoreMediaResponse.ForbiddenList = restoreMediaResponse_forbiddenList;
        
			return restoreMediaResponse;
        }
    }
}
