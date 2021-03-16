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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class ListMaskDetectionResultsResponseUnmarshaller
    {
        public static ListMaskDetectionResultsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMaskDetectionResultsResponse listMaskDetectionResultsResponse = new ListMaskDetectionResultsResponse();

			listMaskDetectionResultsResponse.HttpResponse = _ctx.HttpResponse;
			listMaskDetectionResultsResponse.ErrorCode = _ctx.StringValue("ListMaskDetectionResults.ErrorCode");
			listMaskDetectionResultsResponse.ErrorMessage = _ctx.StringValue("ListMaskDetectionResults.ErrorMessage");
			listMaskDetectionResultsResponse.PageNumber = _ctx.IntegerValue("ListMaskDetectionResults.PageNumber");
			listMaskDetectionResultsResponse.Message = _ctx.StringValue("ListMaskDetectionResults.Message");
			listMaskDetectionResultsResponse.Code = _ctx.StringValue("ListMaskDetectionResults.Code");
			listMaskDetectionResultsResponse.TotalCount = _ctx.LongValue("ListMaskDetectionResults.TotalCount");
			listMaskDetectionResultsResponse.DynamicCode = _ctx.StringValue("ListMaskDetectionResults.DynamicCode");
			listMaskDetectionResultsResponse.PageSize = _ctx.IntegerValue("ListMaskDetectionResults.PageSize");
			listMaskDetectionResultsResponse.RequestId = _ctx.StringValue("ListMaskDetectionResults.RequestId");
			listMaskDetectionResultsResponse.Success = _ctx.BooleanValue("ListMaskDetectionResults.Success");
			listMaskDetectionResultsResponse.DynamicMessage = _ctx.StringValue("ListMaskDetectionResults.DynamicMessage");

			List<ListMaskDetectionResultsResponse.ListMaskDetectionResults_DetectionResult> listMaskDetectionResultsResponse_maskDetectionResults = new List<ListMaskDetectionResultsResponse.ListMaskDetectionResults_DetectionResult>();
			for (int i = 0; i < _ctx.Length("ListMaskDetectionResults.MaskDetectionResults.Length"); i++) {
				ListMaskDetectionResultsResponse.ListMaskDetectionResults_DetectionResult detectionResult = new ListMaskDetectionResultsResponse.ListMaskDetectionResults_DetectionResult();
				detectionResult.PkId = _ctx.StringValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].PkId");
				detectionResult.Score = _ctx.StringValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].Score");
				detectionResult.LocationId = _ctx.LongValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].LocationId");
				detectionResult.ImageKey = _ctx.StringValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].ImageKey");
				detectionResult.Id = _ctx.LongValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].Id");
				detectionResult.IpcId = _ctx.StringValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].IpcId");
				detectionResult.MaskResult = _ctx.StringValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].MaskResult");

				listMaskDetectionResultsResponse_maskDetectionResults.Add(detectionResult);
			}
			listMaskDetectionResultsResponse.MaskDetectionResults = listMaskDetectionResultsResponse_maskDetectionResults;
        
			return listMaskDetectionResultsResponse;
        }
    }
}
