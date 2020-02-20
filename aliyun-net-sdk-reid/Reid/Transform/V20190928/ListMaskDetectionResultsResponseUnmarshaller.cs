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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class ListMaskDetectionResultsResponseUnmarshaller
    {
        public static ListMaskDetectionResultsResponse Unmarshall(UnmarshallerContext context)
        {
			ListMaskDetectionResultsResponse listMaskDetectionResultsResponse = new ListMaskDetectionResultsResponse();

			listMaskDetectionResultsResponse.HttpResponse = context.HttpResponse;
			listMaskDetectionResultsResponse.ErrorCode = context.StringValue("ListMaskDetectionResults.ErrorCode");
			listMaskDetectionResultsResponse.ErrorMessage = context.StringValue("ListMaskDetectionResults.ErrorMessage");
			listMaskDetectionResultsResponse.PageNumber = context.IntegerValue("ListMaskDetectionResults.PageNumber");
			listMaskDetectionResultsResponse.Message = context.StringValue("ListMaskDetectionResults.Message");
			listMaskDetectionResultsResponse.Code = context.StringValue("ListMaskDetectionResults.Code");
			listMaskDetectionResultsResponse.TotalCount = context.LongValue("ListMaskDetectionResults.TotalCount");
			listMaskDetectionResultsResponse.DynamicCode = context.StringValue("ListMaskDetectionResults.DynamicCode");
			listMaskDetectionResultsResponse.PageSize = context.IntegerValue("ListMaskDetectionResults.PageSize");
			listMaskDetectionResultsResponse.RequestId = context.StringValue("ListMaskDetectionResults.RequestId");
			listMaskDetectionResultsResponse.Success = context.BooleanValue("ListMaskDetectionResults.Success");
			listMaskDetectionResultsResponse.DynamicMessage = context.StringValue("ListMaskDetectionResults.DynamicMessage");

			List<ListMaskDetectionResultsResponse.ListMaskDetectionResults_DetectionResult> listMaskDetectionResultsResponse_maskDetectionResults = new List<ListMaskDetectionResultsResponse.ListMaskDetectionResults_DetectionResult>();
			for (int i = 0; i < context.Length("ListMaskDetectionResults.MaskDetectionResults.Length"); i++) {
				ListMaskDetectionResultsResponse.ListMaskDetectionResults_DetectionResult detectionResult = new ListMaskDetectionResultsResponse.ListMaskDetectionResults_DetectionResult();
				detectionResult.PkId = context.StringValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].PkId");
				detectionResult.Score = context.StringValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].Score");
				detectionResult.LocationId = context.LongValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].LocationId");
				detectionResult.ImageKey = context.StringValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].ImageKey");
				detectionResult.Id = context.LongValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].Id");
				detectionResult.IpcId = context.StringValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].IpcId");
				detectionResult.MaskResult = context.StringValue("ListMaskDetectionResults.MaskDetectionResults["+ i +"].MaskResult");

				listMaskDetectionResultsResponse_maskDetectionResults.Add(detectionResult);
			}
			listMaskDetectionResultsResponse.MaskDetectionResults = listMaskDetectionResultsResponse_maskDetectionResults;
        
			return listMaskDetectionResultsResponse;
        }
    }
}
