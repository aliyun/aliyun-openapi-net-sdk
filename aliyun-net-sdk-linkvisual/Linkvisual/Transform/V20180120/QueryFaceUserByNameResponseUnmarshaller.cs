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
    public class QueryFaceUserByNameResponseUnmarshaller
    {
        public static QueryFaceUserByNameResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceUserByNameResponse queryFaceUserByNameResponse = new QueryFaceUserByNameResponse();

			queryFaceUserByNameResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceUserByNameResponse.Code = _ctx.StringValue("QueryFaceUserByName.Code");
			queryFaceUserByNameResponse.RequestId = _ctx.StringValue("QueryFaceUserByName.RequestId");
			queryFaceUserByNameResponse.ErrorMessage = _ctx.StringValue("QueryFaceUserByName.ErrorMessage");
			queryFaceUserByNameResponse.Success = _ctx.BooleanValue("QueryFaceUserByName.Success");

			QueryFaceUserByNameResponse.QueryFaceUserByName_Data data = new QueryFaceUserByNameResponse.QueryFaceUserByName_Data();
			data.PageSize = _ctx.IntegerValue("QueryFaceUserByName.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryFaceUserByName.Data.Total");
			data.Page = _ctx.IntegerValue("QueryFaceUserByName.Data.Page");

			List<QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData> data_list = new List<QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData>();
			for (int i = 0; i < _ctx.Length("QueryFaceUserByName.Data.List.Length"); i++) {
				QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData pageData = new QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData();
				pageData._Params = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].Params");
				pageData.CustomUserId = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].CustomUserId");
				pageData.CreateTime = _ctx.LongValue("QueryFaceUserByName.Data.List["+ i +"].CreateTime");
				pageData.UserId = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].UserId");
				pageData.Name = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].Name");
				pageData.ModifyTime = _ctx.LongValue("QueryFaceUserByName.Data.List["+ i +"].ModifyTime");

				List<QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData.QueryFaceUserByName_FacePicListItem> pageData_facePicList = new List<QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData.QueryFaceUserByName_FacePicListItem>();
				for (int j = 0; j < _ctx.Length("QueryFaceUserByName.Data.List["+ i +"].FacePicList.Length"); j++) {
					QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData.QueryFaceUserByName_FacePicListItem facePicListItem = new QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData.QueryFaceUserByName_FacePicListItem();
					facePicListItem.FaceUrl = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].FacePicList["+ j +"].FaceUrl");
					facePicListItem.FaceMd5 = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].FacePicList["+ j +"].FaceMd5");

					List<QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData.QueryFaceUserByName_FacePicListItem.QueryFaceUserByName_FeatureDTO> facePicListItem_featureDTOList = new List<QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData.QueryFaceUserByName_FacePicListItem.QueryFaceUserByName_FeatureDTO>();
					for (int k = 0; k < _ctx.Length("QueryFaceUserByName.Data.List["+ i +"].FacePicList["+ j +"].FeatureDTOList.Length"); k++) {
						QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData.QueryFaceUserByName_FacePicListItem.QueryFaceUserByName_FeatureDTO featureDTO = new QueryFaceUserByNameResponse.QueryFaceUserByName_Data.QueryFaceUserByName_PageData.QueryFaceUserByName_FacePicListItem.QueryFaceUserByName_FeatureDTO();
						featureDTO.AlgorithmName = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].AlgorithmName");
						featureDTO.AlgorithmVersion = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].AlgorithmVersion");
						featureDTO.AlgorithmProvider = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].AlgorithmProvider");
						featureDTO.ErrorMessage = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].ErrorMessage");
						featureDTO.ErrorCode = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].ErrorCode");
						featureDTO.FaceMd5 = _ctx.StringValue("QueryFaceUserByName.Data.List["+ i +"].FacePicList["+ j +"].FeatureDTOList["+ k +"].FaceMd5");

						facePicListItem_featureDTOList.Add(featureDTO);
					}
					facePicListItem.FeatureDTOList = facePicListItem_featureDTOList;

					pageData_facePicList.Add(facePicListItem);
				}
				pageData.FacePicList = pageData_facePicList;

				data_list.Add(pageData);
			}
			data.List = data_list;
			queryFaceUserByNameResponse.Data = data;
        
			return queryFaceUserByNameResponse;
        }
    }
}
