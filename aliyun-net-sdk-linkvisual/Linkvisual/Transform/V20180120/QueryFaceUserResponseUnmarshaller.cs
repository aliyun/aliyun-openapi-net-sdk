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
    public class QueryFaceUserResponseUnmarshaller
    {
        public static QueryFaceUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceUserResponse queryFaceUserResponse = new QueryFaceUserResponse();

			queryFaceUserResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceUserResponse.Code = _ctx.StringValue("QueryFaceUser.Code");
			queryFaceUserResponse.RequestId = _ctx.StringValue("QueryFaceUser.RequestId");
			queryFaceUserResponse.ErrorMessage = _ctx.StringValue("QueryFaceUser.ErrorMessage");
			queryFaceUserResponse.Success = _ctx.BooleanValue("QueryFaceUser.Success");

			QueryFaceUserResponse.QueryFaceUser_Data data = new QueryFaceUserResponse.QueryFaceUser_Data();
			data._Params = _ctx.StringValue("QueryFaceUser.Data.Params");
			data.CustomUserId = _ctx.StringValue("QueryFaceUser.Data.CustomUserId");
			data.Name = _ctx.StringValue("QueryFaceUser.Data.Name");
			data.UserId = _ctx.StringValue("QueryFaceUser.Data.UserId");

			List<QueryFaceUserResponse.QueryFaceUser_Data.QueryFaceUser_FacePicListItem> data_facePicList = new List<QueryFaceUserResponse.QueryFaceUser_Data.QueryFaceUser_FacePicListItem>();
			for (int i = 0; i < _ctx.Length("QueryFaceUser.Data.FacePicList.Length"); i++) {
				QueryFaceUserResponse.QueryFaceUser_Data.QueryFaceUser_FacePicListItem facePicListItem = new QueryFaceUserResponse.QueryFaceUser_Data.QueryFaceUser_FacePicListItem();
				facePicListItem.FaceUrl = _ctx.StringValue("QueryFaceUser.Data.FacePicList["+ i +"].FaceUrl");
				facePicListItem.FaceMd5 = _ctx.StringValue("QueryFaceUser.Data.FacePicList["+ i +"].FaceMd5");

				List<QueryFaceUserResponse.QueryFaceUser_Data.QueryFaceUser_FacePicListItem.QueryFaceUser_FeatureDTO> facePicListItem_featureDTOList = new List<QueryFaceUserResponse.QueryFaceUser_Data.QueryFaceUser_FacePicListItem.QueryFaceUser_FeatureDTO>();
				for (int j = 0; j < _ctx.Length("QueryFaceUser.Data.FacePicList["+ i +"].FeatureDTOList.Length"); j++) {
					QueryFaceUserResponse.QueryFaceUser_Data.QueryFaceUser_FacePicListItem.QueryFaceUser_FeatureDTO featureDTO = new QueryFaceUserResponse.QueryFaceUser_Data.QueryFaceUser_FacePicListItem.QueryFaceUser_FeatureDTO();
					featureDTO.AlgorithmName = _ctx.StringValue("QueryFaceUser.Data.FacePicList["+ i +"].FeatureDTOList["+ j +"].AlgorithmName");
					featureDTO.AlgorithmVersion = _ctx.StringValue("QueryFaceUser.Data.FacePicList["+ i +"].FeatureDTOList["+ j +"].AlgorithmVersion");
					featureDTO.AlgorithmProvider = _ctx.StringValue("QueryFaceUser.Data.FacePicList["+ i +"].FeatureDTOList["+ j +"].AlgorithmProvider");
					featureDTO.ErrorMessage = _ctx.StringValue("QueryFaceUser.Data.FacePicList["+ i +"].FeatureDTOList["+ j +"].ErrorMessage");
					featureDTO.ErrorCode = _ctx.StringValue("QueryFaceUser.Data.FacePicList["+ i +"].FeatureDTOList["+ j +"].ErrorCode");
					featureDTO.FaceMd5 = _ctx.StringValue("QueryFaceUser.Data.FacePicList["+ i +"].FeatureDTOList["+ j +"].FaceMd5");

					facePicListItem_featureDTOList.Add(featureDTO);
				}
				facePicListItem.FeatureDTOList = facePicListItem_featureDTOList;

				data_facePicList.Add(facePicListItem);
			}
			data.FacePicList = data_facePicList;
			queryFaceUserResponse.Data = data;
        
			return queryFaceUserResponse;
        }
    }
}
