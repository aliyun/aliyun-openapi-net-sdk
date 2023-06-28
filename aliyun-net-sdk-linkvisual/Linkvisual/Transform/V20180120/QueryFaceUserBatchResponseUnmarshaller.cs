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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryFaceUserBatchResponseUnmarshaller
    {
        public static QueryFaceUserBatchResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceUserBatchResponse queryFaceUserBatchResponse = new QueryFaceUserBatchResponse();

			queryFaceUserBatchResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceUserBatchResponse.Code = _ctx.StringValue("QueryFaceUserBatch.Code");
			queryFaceUserBatchResponse.RequestId = _ctx.StringValue("QueryFaceUserBatch.RequestId");
			queryFaceUserBatchResponse.ErrorMessage = _ctx.StringValue("QueryFaceUserBatch.ErrorMessage");
			queryFaceUserBatchResponse.Success = _ctx.BooleanValue("QueryFaceUserBatch.Success");

			List<QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem> queryFaceUserBatchResponse_data = new List<QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryFaceUserBatch.Data.Length"); i++) {
				QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem dataItem = new QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem();
				dataItem._Params = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].Params");
				dataItem.CustomUserId = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].CustomUserId");
				dataItem.CreateTime = _ctx.LongValue("QueryFaceUserBatch.Data["+ i +"].CreateTime");
				dataItem.UserId = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].UserId");
				dataItem.Name = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].Name");
				dataItem.ModifyTime = _ctx.LongValue("QueryFaceUserBatch.Data["+ i +"].ModifyTime");

				List<QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem.QueryFaceUserBatch_FacePicListItem> dataItem_facePicList = new List<QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem.QueryFaceUserBatch_FacePicListItem>();
				for (int j = 0; j < _ctx.Length("QueryFaceUserBatch.Data["+ i +"].FacePicList.Length"); j++) {
					QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem.QueryFaceUserBatch_FacePicListItem facePicListItem = new QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem.QueryFaceUserBatch_FacePicListItem();
					facePicListItem.FaceUrl = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].FacePicList["+ j +"].FaceUrl");
					facePicListItem.FaceMd5 = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].FacePicList["+ j +"].FaceMd5");

					List<QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem.QueryFaceUserBatch_FacePicListItem.QueryFaceUserBatch_FeatureDTO> facePicListItem_featureDTOList = new List<QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem.QueryFaceUserBatch_FacePicListItem.QueryFaceUserBatch_FeatureDTO>();
					for (int k = 0; k < _ctx.Length("QueryFaceUserBatch.Data["+ i +"].FacePicList["+ j +"].FeatureDTOList.Length"); k++) {
						QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem.QueryFaceUserBatch_FacePicListItem.QueryFaceUserBatch_FeatureDTO featureDTO = new QueryFaceUserBatchResponse.QueryFaceUserBatch_DataItem.QueryFaceUserBatch_FacePicListItem.QueryFaceUserBatch_FeatureDTO();
						featureDTO.AlgorithmName = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].AlgorithmName");
						featureDTO.AlgorithmVersion = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].AlgorithmVersion");
						featureDTO.AlgorithmProvider = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].AlgorithmProvider");
						featureDTO.ErrorMessage = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].ErrorMessage");
						featureDTO.ErrorCode = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].ErrorCode");
						featureDTO.FaceMd5 = _ctx.StringValue("QueryFaceUserBatch.Data["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].FaceMd5");

						facePicListItem_featureDTOList.Add(featureDTO);
					}
					facePicListItem.FeatureDTOList = facePicListItem_featureDTOList;

					dataItem_facePicList.Add(facePicListItem);
				}
				dataItem.FacePicList = dataItem_facePicList;

				queryFaceUserBatchResponse_data.Add(dataItem);
			}
			queryFaceUserBatchResponse.Data = queryFaceUserBatchResponse_data;
        
			return queryFaceUserBatchResponse;
        }
    }
}
