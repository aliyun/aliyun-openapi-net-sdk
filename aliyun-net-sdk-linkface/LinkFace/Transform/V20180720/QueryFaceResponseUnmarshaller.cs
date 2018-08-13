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
using Aliyun.Acs.LinkFace.Model.V20180720;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.LinkFace.Transform.V20180720
{
    public class QueryFaceResponseUnmarshaller
    {
        public static QueryFaceResponse Unmarshall(UnmarshallerContext context)
        {
			QueryFaceResponse queryFaceResponse = new QueryFaceResponse();

			queryFaceResponse.HttpResponse = context.HttpResponse;
			queryFaceResponse.RequestId = context.StringValue("QueryFace.RequestId");
			queryFaceResponse.Code = context.IntegerValue("QueryFace.Code");
			queryFaceResponse.Message = context.StringValue("QueryFace.Message");
			queryFaceResponse.Success = context.BooleanValue("QueryFace.Success");

			QueryFaceResponse.QueryFace_Data data = new QueryFaceResponse.QueryFace_Data();

			List<string> data_groupIds = new List<string>();
			for (int i = 0; i < context.Length("QueryFace.Data.GroupIds.Length"); i++) {
				data_groupIds.Add(context.StringValue("QueryFace.Data.GroupIds["+ i +"]"));
			}
			data.GroupIds = data_groupIds;

			List<QueryFaceResponse.QueryFace_Data.QueryFace_UserFaceMetasItem> data_userFaceMetas = new List<QueryFaceResponse.QueryFace_Data.QueryFace_UserFaceMetasItem>();
			for (int i = 0; i < context.Length("QueryFace.Data.UserFaceMetas.Length"); i++) {
				QueryFaceResponse.QueryFace_Data.QueryFace_UserFaceMetasItem userFaceMetasItem = new QueryFaceResponse.QueryFace_Data.QueryFace_UserFaceMetasItem();
				userFaceMetasItem.ClientTag = context.StringValue("QueryFace.Data.UserFaceMetas["+ i +"].ClientTag");
				userFaceMetasItem.Index = context.IntegerValue("QueryFace.Data.UserFaceMetas["+ i +"].Index");
				userFaceMetasItem.FaceUrl = context.StringValue("QueryFace.Data.UserFaceMetas["+ i +"].FaceUrl");
				userFaceMetasItem.UserInfo = context.StringValue("QueryFace.Data.UserFaceMetas["+ i +"].UserInfo");

				data_userFaceMetas.Add(userFaceMetasItem);
			}
			data.UserFaceMetas = data_userFaceMetas;
			queryFaceResponse.Data = data;
        
			return queryFaceResponse;
        }
    }
}