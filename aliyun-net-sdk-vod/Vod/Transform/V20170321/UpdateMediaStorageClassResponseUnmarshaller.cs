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
    public class UpdateMediaStorageClassResponseUnmarshaller
    {
        public static UpdateMediaStorageClassResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateMediaStorageClassResponse updateMediaStorageClassResponse = new UpdateMediaStorageClassResponse();

			updateMediaStorageClassResponse.HttpResponse = _ctx.HttpResponse;
			updateMediaStorageClassResponse.RequestId = _ctx.StringValue("UpdateMediaStorageClass.RequestId");
			updateMediaStorageClassResponse.Status = _ctx.StringValue("UpdateMediaStorageClass.Status");

			List<string> updateMediaStorageClassResponse_ignoredList = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateMediaStorageClass.IgnoredList.Length"); i++) {
				updateMediaStorageClassResponse_ignoredList.Add(_ctx.StringValue("UpdateMediaStorageClass.IgnoredList["+ i +"]"));
			}
			updateMediaStorageClassResponse.IgnoredList = updateMediaStorageClassResponse_ignoredList;

			List<UpdateMediaStorageClassResponse.UpdateMediaStorageClass_MediaForbiddenReasonDTO> updateMediaStorageClassResponse_forbiddenList = new List<UpdateMediaStorageClassResponse.UpdateMediaStorageClass_MediaForbiddenReasonDTO>();
			for (int i = 0; i < _ctx.Length("UpdateMediaStorageClass.ForbiddenList.Length"); i++) {
				UpdateMediaStorageClassResponse.UpdateMediaStorageClass_MediaForbiddenReasonDTO mediaForbiddenReasonDTO = new UpdateMediaStorageClassResponse.UpdateMediaStorageClass_MediaForbiddenReasonDTO();
				mediaForbiddenReasonDTO.MediaId = _ctx.StringValue("UpdateMediaStorageClass.ForbiddenList["+ i +"].MediaId");
				mediaForbiddenReasonDTO.Reason = _ctx.StringValue("UpdateMediaStorageClass.ForbiddenList["+ i +"].Reason");

				updateMediaStorageClassResponse_forbiddenList.Add(mediaForbiddenReasonDTO);
			}
			updateMediaStorageClassResponse.ForbiddenList = updateMediaStorageClassResponse_forbiddenList;
        
			return updateMediaStorageClassResponse;
        }
    }
}
