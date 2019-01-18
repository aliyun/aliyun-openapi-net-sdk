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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class SearchFaceResponseUnmarshaller
    {
        public static SearchFaceResponse Unmarshall(UnmarshallerContext context)
        {
			SearchFaceResponse searchFaceResponse = new SearchFaceResponse();

			searchFaceResponse.HttpResponse = context.HttpResponse;
			searchFaceResponse.RequestId = context.StringValue("SearchFace.RequestId");
			searchFaceResponse.ImageUri = context.StringValue("SearchFace.ImageUri");
			searchFaceResponse.GroupName = context.StringValue("SearchFace.GroupName");
			searchFaceResponse.Glasses = context.IntegerValue("SearchFace.Glasses");
			searchFaceResponse.Hat = context.IntegerValue("SearchFace.Hat");
			searchFaceResponse.Score = context.FloatValue("SearchFace.Score");

			List<string> searchFaceResponse_axis = new List<string>();
			for (int i = 0; i < context.Length("SearchFace.Axis.Length"); i++) {
				searchFaceResponse_axis.Add(context.StringValue("SearchFace.Axis["+ i +"]"));
			}
			searchFaceResponse.Axis = searchFaceResponse_axis;

			List<SearchFaceResponse.SearchFace_ResultFacesItem> searchFaceResponse_resultFaces = new List<SearchFaceResponse.SearchFace_ResultFacesItem>();
			for (int i = 0; i < context.Length("SearchFace.ResultFaces.Length"); i++) {
				SearchFaceResponse.SearchFace_ResultFacesItem resultFacesItem = new SearchFaceResponse.SearchFace_ResultFacesItem();
				resultFacesItem.GroupId = context.StringValue("SearchFace.ResultFaces["+ i +"].GroupId");
				resultFacesItem.User = context.StringValue("SearchFace.ResultFaces["+ i +"].User");
				resultFacesItem.ImageId = context.StringValue("SearchFace.ResultFaces["+ i +"].ImageId");
				resultFacesItem.Score = context.FloatValue("SearchFace.ResultFaces["+ i +"].Score");
				resultFacesItem.ImageUri = context.StringValue("SearchFace.ResultFaces["+ i +"].ImageUri");
				resultFacesItem.Glasses = context.IntegerValue("SearchFace.ResultFaces["+ i +"].Glasses");
				resultFacesItem.Hat = context.IntegerValue("SearchFace.ResultFaces["+ i +"].Hat");

				List<string> resultFacesItem_axis1 = new List<string>();
				for (int j = 0; j < context.Length("SearchFace.ResultFaces["+ i +"].Axis.Length"); j++) {
					resultFacesItem_axis1.Add(context.StringValue("SearchFace.ResultFaces["+ i +"].Axis["+ j +"]"));
				}
				resultFacesItem.Axis1 = resultFacesItem_axis1;

				searchFaceResponse_resultFaces.Add(resultFacesItem);
			}
			searchFaceResponse.ResultFaces = searchFaceResponse_resultFaces;
        
			return searchFaceResponse;
        }
    }
}