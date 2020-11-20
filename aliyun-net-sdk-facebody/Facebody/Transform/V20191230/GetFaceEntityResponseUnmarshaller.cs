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
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class GetFaceEntityResponseUnmarshaller
    {
        public static GetFaceEntityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFaceEntityResponse getFaceEntityResponse = new GetFaceEntityResponse();

			getFaceEntityResponse.HttpResponse = _ctx.HttpResponse;
			getFaceEntityResponse.RequestId = _ctx.StringValue("GetFaceEntity.RequestId");

			GetFaceEntityResponse.GetFaceEntity_Data data = new GetFaceEntityResponse.GetFaceEntity_Data();
			data.DbName = _ctx.StringValue("GetFaceEntity.Data.DbName");
			data.EntityId = _ctx.StringValue("GetFaceEntity.Data.EntityId");
			data.Labels = _ctx.StringValue("GetFaceEntity.Data.Labels");

			List<GetFaceEntityResponse.GetFaceEntity_Data.GetFaceEntity_Face> data_faces = new List<GetFaceEntityResponse.GetFaceEntity_Data.GetFaceEntity_Face>();
			for (int i = 0; i < _ctx.Length("GetFaceEntity.Data.Faces.Length"); i++) {
				GetFaceEntityResponse.GetFaceEntity_Data.GetFaceEntity_Face face = new GetFaceEntityResponse.GetFaceEntity_Data.GetFaceEntity_Face();
				face.FaceId = _ctx.StringValue("GetFaceEntity.Data.Faces["+ i +"].FaceId");

				data_faces.Add(face);
			}
			data.Faces = data_faces;
			getFaceEntityResponse.Data = data;
        
			return getFaceEntityResponse;
        }
    }
}
