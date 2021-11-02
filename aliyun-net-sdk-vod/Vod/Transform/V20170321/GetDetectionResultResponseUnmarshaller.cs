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
    public class GetDetectionResultResponseUnmarshaller
    {
        public static GetDetectionResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDetectionResultResponse getDetectionResultResponse = new GetDetectionResultResponse();

			getDetectionResultResponse.HttpResponse = _ctx.HttpResponse;
			getDetectionResultResponse.RequestId = _ctx.StringValue("GetDetectionResult.RequestId");

			List<GetDetectionResultResponse.GetDetectionResult_DetectionResult> getDetectionResultResponse_detectionResultList = new List<GetDetectionResultResponse.GetDetectionResult_DetectionResult>();
			for (int i = 0; i < _ctx.Length("GetDetectionResult.DetectionResultList.Length"); i++) {
				GetDetectionResultResponse.GetDetectionResult_DetectionResult detectionResult = new GetDetectionResultResponse.GetDetectionResult_DetectionResult();
				detectionResult.Status = _ctx.StringValue("GetDetectionResult.DetectionResultList["+ i +"].Status");
				detectionResult.Platform = _ctx.StringValue("GetDetectionResult.DetectionResultList["+ i +"].Platform");
				detectionResult.ContentType = _ctx.StringValue("GetDetectionResult.DetectionResultList["+ i +"].ContentType");
				detectionResult.CollectionTitle = _ctx.StringValue("GetDetectionResult.DetectionResultList["+ i +"].CollectionTitle");
				detectionResult.CollectionUrl = _ctx.StringValue("GetDetectionResult.DetectionResultList["+ i +"].CollectionUrl");
				detectionResult.CreateTime = _ctx.StringValue("GetDetectionResult.DetectionResultList["+ i +"].CreateTime");
				detectionResult.Uploader = _ctx.StringValue("GetDetectionResult.DetectionResultList["+ i +"].Uploader");
				detectionResult.ModifyTime = _ctx.StringValue("GetDetectionResult.DetectionResultList["+ i +"].ModifyTime");

				getDetectionResultResponse_detectionResultList.Add(detectionResult);
			}
			getDetectionResultResponse.DetectionResultList = getDetectionResultResponse_detectionResultList;
        
			return getDetectionResultResponse;
        }
    }
}
