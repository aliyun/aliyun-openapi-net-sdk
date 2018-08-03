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
    public class FaceSearchResponseUnmarshaller
    {
        public static FaceSearchResponse Unmarshall(UnmarshallerContext context)
        {
			FaceSearchResponse faceSearchResponse = new FaceSearchResponse();

			faceSearchResponse.HttpResponse = context.HttpResponse;
			faceSearchResponse.RequestId = context.StringValue("FaceSearch.RequestId");
			faceSearchResponse.ImageUrl = context.StringValue("FaceSearch.ImageUrl");
			faceSearchResponse.GroupName = context.StringValue("FaceSearch.GroupName");
			faceSearchResponse.Glasses = context.IntegerValue("FaceSearch.Glasses");
			faceSearchResponse.Hat = context.IntegerValue("FaceSearch.Hat");
			faceSearchResponse.Score = context.FloatValue("FaceSearch.Score");
			faceSearchResponse.Hat1 = context.IntegerValue("FaceSearch.Hat");

			List<string> faceSearchResponse_axis = new List<string>();
			for (int i = 0; i < context.Length("FaceSearch.Axis.Length"); i++) {
				faceSearchResponse_axis.Add(context.StringValue("FaceSearch.Axis["+ i +"]"));
			}
			faceSearchResponse.Axis = faceSearchResponse_axis;

			List<FaceSearchResponse.FaceSearch_ResultFacesItem> faceSearchResponse_resultFaces = new List<FaceSearchResponse.FaceSearch_ResultFacesItem>();
			for (int i = 0; i < context.Length("FaceSearch.ResultFaces.Length"); i++) {
				FaceSearchResponse.FaceSearch_ResultFacesItem resultFacesItem = new FaceSearchResponse.FaceSearch_ResultFacesItem();
				resultFacesItem.GroupId = context.StringValue("FaceSearch.ResultFaces["+ i +"].GroupId");
				resultFacesItem.User = context.StringValue("FaceSearch.ResultFaces["+ i +"].User");
				resultFacesItem.ImageId = context.StringValue("FaceSearch.ResultFaces["+ i +"].ImageId");
				resultFacesItem.Score = context.FloatValue("FaceSearch.ResultFaces["+ i +"].Score");
				resultFacesItem.ImageUrl = context.StringValue("FaceSearch.ResultFaces["+ i +"].ImageUrl");
				resultFacesItem.Glasses = context.IntegerValue("FaceSearch.ResultFaces["+ i +"].Glasses");
				resultFacesItem.Hat = context.IntegerValue("FaceSearch.ResultFaces["+ i +"].Hat");

				List<string> resultFacesItem_axis2 = new List<string>();
				for (int j = 0; j < context.Length("FaceSearch.ResultFaces["+ i +"].Axis.Length"); j++) {
					resultFacesItem_axis2.Add(context.StringValue("FaceSearch.ResultFaces["+ i +"].Axis["+ j +"]"));
				}
				resultFacesItem.Axis2 = resultFacesItem_axis2;

				faceSearchResponse_resultFaces.Add(resultFacesItem);
			}
			faceSearchResponse.ResultFaces = faceSearchResponse_resultFaces;
        
			return faceSearchResponse;
        }
    }
}