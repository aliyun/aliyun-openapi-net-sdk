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
    public class ListAIImageInfoResponseUnmarshaller
    {
        public static ListAIImageInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAIImageInfoResponse listAIImageInfoResponse = new ListAIImageInfoResponse();

			listAIImageInfoResponse.HttpResponse = _ctx.HttpResponse;
			listAIImageInfoResponse.RequestId = _ctx.StringValue("ListAIImageInfo.RequestId");

			List<ListAIImageInfoResponse.ListAIImageInfo_AIImageInfo> listAIImageInfoResponse_aIImageInfoList = new List<ListAIImageInfoResponse.ListAIImageInfo_AIImageInfo>();
			for (int i = 0; i < _ctx.Length("ListAIImageInfo.AIImageInfoList.Length"); i++) {
				ListAIImageInfoResponse.ListAIImageInfo_AIImageInfo aIImageInfo = new ListAIImageInfoResponse.ListAIImageInfo_AIImageInfo();
				aIImageInfo.VideoId = _ctx.StringValue("ListAIImageInfo.AIImageInfoList["+ i +"].VideoId");
				aIImageInfo.AIImageInfoId = _ctx.StringValue("ListAIImageInfo.AIImageInfoList["+ i +"].AIImageInfoId");
				aIImageInfo.JobId = _ctx.StringValue("ListAIImageInfo.AIImageInfoList["+ i +"].JobId");
				aIImageInfo.FileURL = _ctx.StringValue("ListAIImageInfo.AIImageInfoList["+ i +"].FileURL");
				aIImageInfo.Score = _ctx.StringValue("ListAIImageInfo.AIImageInfoList["+ i +"].Score");
				aIImageInfo.Time = _ctx.StringValue("ListAIImageInfo.AIImageInfoList["+ i +"].Time");
				aIImageInfo.Format = _ctx.StringValue("ListAIImageInfo.AIImageInfoList["+ i +"].Format");
				aIImageInfo.CreationTime = _ctx.StringValue("ListAIImageInfo.AIImageInfoList["+ i +"].CreationTime");
				aIImageInfo.Version = _ctx.StringValue("ListAIImageInfo.AIImageInfoList["+ i +"].Version");

				listAIImageInfoResponse_aIImageInfoList.Add(aIImageInfo);
			}
			listAIImageInfoResponse.AIImageInfoList = listAIImageInfoResponse_aIImageInfoList;
        
			return listAIImageInfoResponse;
        }
    }
}
