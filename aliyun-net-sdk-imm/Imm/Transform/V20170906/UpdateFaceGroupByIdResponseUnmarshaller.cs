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
    public class UpdateFaceGroupByIdResponseUnmarshaller
    {
        public static UpdateFaceGroupByIdResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateFaceGroupByIdResponse updateFaceGroupByIdResponse = new UpdateFaceGroupByIdResponse();

			updateFaceGroupByIdResponse.HttpResponse = context.HttpResponse;
			updateFaceGroupByIdResponse.RequestId = context.StringValue("UpdateFaceGroupById.RequestId");
			updateFaceGroupByIdResponse.SetId = context.StringValue("UpdateFaceGroupById.SetId");

			List<UpdateFaceGroupByIdResponse.UpdateFaceGroupById_FailUpdateDetailItem> updateFaceGroupByIdResponse_failUpdateDetail = new List<UpdateFaceGroupByIdResponse.UpdateFaceGroupById_FailUpdateDetailItem>();
			for (int i = 0; i < context.Length("UpdateFaceGroupById.FailUpdateDetail.Length"); i++) {
				UpdateFaceGroupByIdResponse.UpdateFaceGroupById_FailUpdateDetailItem failUpdateDetailItem = new UpdateFaceGroupByIdResponse.UpdateFaceGroupById_FailUpdateDetailItem();
				failUpdateDetailItem.FaceId = context.StringValue("UpdateFaceGroupById.FailUpdateDetail["+ i +"].FaceId");
				failUpdateDetailItem.Reason = context.StringValue("UpdateFaceGroupById.FailUpdateDetail["+ i +"].Reason");

				updateFaceGroupByIdResponse_failUpdateDetail.Add(failUpdateDetailItem);
			}
			updateFaceGroupByIdResponse.FailUpdateDetail = updateFaceGroupByIdResponse_failUpdateDetail;

			List<UpdateFaceGroupByIdResponse.UpdateFaceGroupById_FacesItem> updateFaceGroupByIdResponse_faces = new List<UpdateFaceGroupByIdResponse.UpdateFaceGroupById_FacesItem>();
			for (int i = 0; i < context.Length("UpdateFaceGroupById.Faces.Length"); i++) {
				UpdateFaceGroupByIdResponse.UpdateFaceGroupById_FacesItem facesItem = new UpdateFaceGroupByIdResponse.UpdateFaceGroupById_FacesItem();
				facesItem.FaceId = context.StringValue("UpdateFaceGroupById.Faces["+ i +"].FaceId");
				facesItem.GroupId = context.StringValue("UpdateFaceGroupById.Faces["+ i +"].GroupId");

				updateFaceGroupByIdResponse_faces.Add(facesItem);
			}
			updateFaceGroupByIdResponse.Faces = updateFaceGroupByIdResponse_faces;
        
			return updateFaceGroupByIdResponse;
        }
    }
}