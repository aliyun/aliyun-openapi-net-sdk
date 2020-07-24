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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListFaceGroupsResponseUnmarshaller
    {
        public static ListFaceGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceGroupsResponse listFaceGroupsResponse = new ListFaceGroupsResponse();

			listFaceGroupsResponse.HttpResponse = context.HttpResponse;
			listFaceGroupsResponse.RequestId = context.StringValue("ListFaceGroups.RequestId");
			listFaceGroupsResponse.NextMarker = context.StringValue("ListFaceGroups.NextMarker");

			List<ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem> listFaceGroupsResponse_faceGroups = new List<ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem>();
			for (int i = 0; i < context.Length("ListFaceGroups.FaceGroups.Length"); i++) {
				ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem faceGroupsItem = new ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem();
				faceGroupsItem.GroupId = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupId");
				faceGroupsItem.GroupName = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupName");
				faceGroupsItem.FaceCount = context.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].FaceCount");
				faceGroupsItem.CreateTime = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].CreateTime");
				faceGroupsItem.ModifyTime = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].ModifyTime");
				faceGroupsItem.RemarksA = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksA");
				faceGroupsItem.RemarksB = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksB");
				faceGroupsItem.RemarksC = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksC");
				faceGroupsItem.RemarksD = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksD");
				faceGroupsItem.RemarksArrayA = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksArrayA");
				faceGroupsItem.RemarksArrayB = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].RemarksArrayB");
				faceGroupsItem.ExternalId = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].ExternalId");
				faceGroupsItem.ImageCount = context.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].ImageCount");

				ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace groupCoverFace = new ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace();
				groupCoverFace.FaceId = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceId");
				groupCoverFace.ImageUri = context.StringValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.ImageUri");

				ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace.ListFaceGroups_FaceBoundary faceBoundary = new ListFaceGroupsResponse.ListFaceGroups_FaceGroupsItem.ListFaceGroups_GroupCoverFace.ListFaceGroups_FaceBoundary();
				faceBoundary.Left = context.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Left");
				faceBoundary.Top = context.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Top");
				faceBoundary.Width = context.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Width");
				faceBoundary.Height = context.IntegerValue("ListFaceGroups.FaceGroups["+ i +"].GroupCoverFace.FaceBoundary.Height");
				groupCoverFace.FaceBoundary = faceBoundary;
				faceGroupsItem.GroupCoverFace = groupCoverFace;

				listFaceGroupsResponse_faceGroups.Add(faceGroupsItem);
			}
			listFaceGroupsResponse.FaceGroups = listFaceGroupsResponse_faceGroups;
        
			return listFaceGroupsResponse;
        }
    }
}
